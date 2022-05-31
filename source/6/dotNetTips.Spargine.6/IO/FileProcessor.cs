// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-15-2022
// ***********************************************************************
// <copyright file="FileProcessor.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Processes files and fires events.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Security;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Diagnostics;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO
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
		/// Handles the <see cref="Processed" /> event that is thrown after each file is processed.
		/// </summary>
		/// <param name="e">The <see cref="FileProgressEventArgs" /> instance containing the event data.</param>
		protected virtual void OnProcessed(FileProgressEventArgs e) => this.Processed?.Invoke(this, e);

		/// <summary>
		/// Copies files to new location. Will not throw exceptions.
		/// </summary>
		/// <param name="files">The files.</param>
		/// <param name="destination">The destination folder.</param>
		/// <returns>System.Object.</returns>
		/// <remarks>Use the Processed event to find out if file copied succeeded or failed.</remarks>
		[SuppressMessage("Microsoft.Design", "CA1031")]
		[Information(nameof(CopyFiles), author: "David McCarter", createdOn: "8/6/2017", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public int CopyFiles([NotNull] IEnumerable<FileInfo> files, [NotNull] DirectoryInfo destination)
		{
			var list = files.ArgumentItemsExists().ToArray();

			_ = destination.CheckExists();

			var destinationPath = destination.FullName;

			var successCount = 0;

			for (var fileCount = 0; fileCount < list.Length; fileCount++)
			{
				var tempFile = list[fileCount];

				if (tempFile.Exists)
				{
					try
					{
						var newFileName = new FileInfo(fileName: tempFile.FullName.Replace(tempFile.Directory.Root.FullName, destinationPath, StringComparison.InvariantCulture));

						if (newFileName.Directory.Exists is false)
						{
							newFileName.Directory.Create();
						}

						var psw = PerformanceStopwatch.StartNew();

						_ = tempFile.CopyTo(newFileName.FullName, overwrite: true);

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
		[Information(nameof(DeleteFiles), author: "David McCarter", createdOn: "8/6/2017", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public int DeleteFiles([NotNull] IEnumerable<FileInfo> files)
		{
			if (files.Any() is false)
			{
				return 0;
			}

			var successCount = 0;
			var list = files.ToArray();

			for (var fileCount = 0; fileCount < list.Length; fileCount++)
			{
				var tempFile = list[fileCount];

				if (tempFile.Exists)
				{
					try
					{
						var psw = PerformanceStopwatch.StartNew();

						using (var task = new Task(() => tempFile.Delete()))
						{
							task.FireAndForget(); //TODO: DOCUMENT THIS EXAMPLE
						}

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
					catch (Exception ex) when (ex is IOException or SecurityException or UnauthorizedAccessException)
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
		[Information(nameof(DeleteFolders), author: "David McCarter", createdOn: "8/6/2017", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public int DeleteFolders([NotNull] IReadOnlyCollection<DirectoryInfo> folders)
		{
			if (folders.HasItems() is false)
			{
				return 0;
			}

			var successCount = 0;
			var list = folders.ToArray();

			for (var folderIndex = 0; folderIndex < list.Length; folderIndex++)
			{
				var tempFolder = list[folderIndex];

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
					catch (Exception ex) when (ex is IOException or SecurityException or UnauthorizedAccessException or System.IO.DirectoryNotFoundException)
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
	}
}
