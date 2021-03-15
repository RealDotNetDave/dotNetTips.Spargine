// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2021
// ***********************************************************************
// <copyright file="FileProcessor.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Processes files and fires events.</summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.Diagnostics;
using dotNetTips.Spargine.Properties;

namespace dotNetTips.Spargine.IO
{
	/// <summary>
	/// Process files with events.
	/// </summary>
	public class FileProcessor
	{
		/// <summary>
		/// Occurs when processor processes a file or folder.
		/// </summary>
		public event EventHandler<FileProgressEventArgs> Processed;

		/// <summary>
		/// Copies files to new location. Will not throw exceptions.
		/// </summary>
		/// <param name="files">The files.</param>
		/// <param name="destinationFolder">The destination folder.</param>
		/// <returns>System.Object.</returns>
		/// <remarks>Use the Processed event to find out if file copied succeeded or failed.</remarks>
		[Information(nameof(CopyFiles), author: "David McCarter", createdOn: "8/6/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public int CopyFiles(IEnumerable<FileInfo> files, DirectoryInfo destinationFolder)
		{
			Validate.TryValidateParam(files, nameof(files));
			Validate.TryValidateParam(destinationFolder, nameof(destinationFolder));

			var successCount = 0;

			if (destinationFolder.Exists == false)
			{
				destinationFolder.Create();
			}

			var list = files.ToArray();

			for (var i = 0; i < list.Length; i++)
			{
				var tempFile = list[i];

				if (tempFile.Exists)
				{
					try
					{
						var newFileName = new FileInfo(tempFile.FullName.Replace(tempFile.Directory.Root.FullName, destinationFolder.FullName));

						if (newFileName.Directory.Exists == false)
						{
							newFileName.Directory.Create();
						}

						var psw = PerformanceStopwatch.StartNew();

						tempFile.CopyTo(newFileName.FullName, overwrite: true);

						var perf = psw.StopReset();

						successCount += 1;

						this.OnProcessed(new FileProgressEventArgs
						{
							Name = tempFile.FullName,
							Message = tempFile.Name,
							ProgressState = FileProgressState.Copied,
							Size = tempFile.Length,
							SpeedInMilliseconds = perf.TotalMilliseconds,
						});
					}
					catch (Exception ex)
					{
						// Send error.
						this.OnProcessed(new FileProgressEventArgs
						{
							Name = tempFile.FullName,
							ProgressState = FileProgressState.Error,
							Size = tempFile.Length,
							Message = ex.Message,
						});
					}
				}
				else
				{
					this.OnProcessed(new FileProgressEventArgs
					{
						Name = tempFile.FullName,
						ProgressState = FileProgressState.Error,
						Size = tempFile.Length,
						Message = Resources.FileNotFound,
					});
				}
			}

			return successCount;
		}

		/// <summary>
		/// Deletes file list.
		/// </summary>
		/// <param name="files">The file list to delete.</param>
		/// <returns>System.Int32 with the number of files that were successfully deleted.</returns>
		/// <remarks>Use the <seealso cref="Processed">Processed</seealso> event to find out if file deletion succeeded or failed.</remarks>
		[Information(nameof(DeleteFiles), author: "David McCarter", createdOn: "8/6/2017", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public int DeleteFiles(IEnumerable<FileInfo> files)
		{
			Validate.TryValidateParam(files, nameof(files));

			var successCount = 0;
			var list = files.ToArray();

			for (var i = 0; i < list.Length; i++)
			{
				var tempFile = list[i];

				if (tempFile.Exists)
				{
					try
					{
						var psw = PerformanceStopwatch.StartNew();

						// TODO: ADD ASYNC - await Task.Run(()=> method);
						tempFile.Delete();

						var perf = psw.StopReset();

						successCount += 1;

						this.OnProcessed(new FileProgressEventArgs
						{
							Name = tempFile.FullName,
							Message = tempFile.Name,
							ProgressState = FileProgressState.Deleted,
							Size = tempFile.Length,
							SpeedInMilliseconds = perf.TotalMilliseconds,
						});
					}
					catch (Exception ex) when (ex is IOException || ex is SecurityException || ex is UnauthorizedAccessException)
					{
						this.OnProcessed(new FileProgressEventArgs
						{
							Name = tempFile.FullName,
							ProgressState = FileProgressState.Error,
							Size = tempFile.Length,
							Message = ex.Message,
						});
					}
				}
				else
				{
					this.OnProcessed(new FileProgressEventArgs
					{
						Name = tempFile.FullName,
						ProgressState = FileProgressState.Error,
						Message = Resources.FileNotFound,
					});
				}
			}

			return successCount;
		}

		/// <summary>
		/// Deletes the folders.
		/// </summary>
		/// <param name="folders">The folders.</param>
		/// <returns>System.Int32.</returns>
		[Information(nameof(DeleteFolders), author: "David McCarter", createdOn: "8/6/2017", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public int DeleteFolders(IEnumerable<DirectoryInfo> folders)
		{
			Validate.TryValidateParam(folders, nameof(folders));

			var successCount = 0;
			var list = folders.ToArray();

			for (var i = 0; i < list.Length; i++)
			{
				var tempFolder = list[i];

				if (tempFolder.Exists)
				{
					try
					{
						tempFolder.Delete(recursive: true);

						successCount += 1;

						this.OnProcessed(new FileProgressEventArgs
						{
							Name = tempFolder.FullName,
							ProgressState = FileProgressState.Deleted,
						});
					}
					catch (Exception ex) when (ex is IOException || ex is SecurityException || ex is UnauthorizedAccessException || ex is System.IO.DirectoryNotFoundException)
					{
						this.OnProcessed(new FileProgressEventArgs
						{
							Name = tempFolder.FullName,
							ProgressState = FileProgressState.Error,
							Message = ex.Message,
						});
					}
				}
				else
				{
					this.OnProcessed(new FileProgressEventArgs
					{
						Name = tempFolder.FullName,
						ProgressState = FileProgressState.Error,
						Message = Resources.FolderNotFound,
					});
				}
			}

			return successCount;
		}

		/// <summary>
		/// Handles the <see cref="E:Processed" /> event that is thrown after each file is processed.
		/// </summary>
		/// <param name="e">The <see cref="FileProgressEventArgs" /> instance containing the event data.</param>
		protected virtual void OnProcessed(FileProgressEventArgs e) => this.Processed?.Invoke(this, e);
	}
}
