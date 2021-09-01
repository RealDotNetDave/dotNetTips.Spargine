// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2021
// ***********************************************************************
// <copyright file="FileHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Helper methods for files.</summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Properties;

namespace dotNetTips.Spargine.IO
{

	/// <summary>
	/// Helper methods for files.
	/// </summary>
	[Information(nameof(FileHelper), "David McCarter", "2/11/2017", Status = Status.Available)]
	public static class FileHelper
	{
		/// <summary>
		/// The count for retries.
		/// </summary>
		private const int Retries = 10;

		/// <summary>
		/// Gets the invalid file name chars.
		/// </summary>
		/// <value>The invalid file name chars.</value>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<char> InvalidFileNameChars { get; } = Path.GetInvalidFileNameChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();

		/// <summary>
		/// Copies the file to a new directory. If the file already exists, it
		/// will be overwritten.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <param name="destinationFolder">The destination folder.</param>
		/// <returns>File length as System.Int64.</returns>
		[Information(nameof(CopyFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static long CopyFile([NotNull] FileInfo file, [NotNull] DirectoryInfo destinationFolder)
		{
			var newFileName = Path.Combine(destinationFolder.FullName, file.Name);

			using (var sourceStream = File.Open(file.FullName, FileMode.Open))
			{
				if (File.Exists(newFileName))
				{
					File.Delete(newFileName);
				}

				using var destinationStream = File.Create(newFileName);

				sourceStream.CopyTo(destinationStream);

				destinationStream.Flush();
			}

			return file.Length;
		}

		/// <summary>
		/// Copies a file to a new directory as an asynchronous operation.
		/// If the file already exists, it will be overwritten.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <param name="destinationFolder">The destination folder.</param>
		/// <returns>Task&lt;System.Int32&gt;.</returns>
		[Information(nameof(CopyFileAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://dotnettips.wordpress.com/2020/11/17/coding-faster-with-the-dotnettips-utility-november-2020-update")]
		public static async Task<long> CopyFileAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destinationFolder)
		{
			var newFileName = Path.Combine(destinationFolder.FullName, file.Name);

			using (var sourceStream = File.Open(file.FullName, FileMode.Open))
			{
				if (File.Exists(newFileName))
				{
					File.Delete(newFileName);
				}

				using var destinationStream = File.Create(newFileName);

				await sourceStream.CopyToAsync(destinationStream).ConfigureAwait(false);
				await destinationStream.FlushAsync().ConfigureAwait(false);
			}

			return file.Length;
		}

		/// <summary>
		/// Attempts to delete files and will return the file name and error message for files that
		/// could not be deleted.
		/// </summary>
		/// <param name="files">The files.</param>
		/// <returns>IEnumerable&lt;KeyValuePair&lt;System.String, System.String&gt;&gt;.</returns>
		[Information(nameof(DeleteFiles), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static IEnumerable<(string FileName, string ErrorMessage)> DeleteFiles([NotNull] this IEnumerable<string> files)
		{
			var errors = new List<(string FileName, string ErrorMessage)>();

			_ = Parallel.ForEach(source: files, body: (fileName) =>
			{
				try
				{
					File.Delete(fileName);
				}
				catch (Exception ex) when (ex is ArgumentException or
				  ArgumentNullException or
				  System.IO.DirectoryNotFoundException or
				  IOException or
				  NotSupportedException or
				  PathTooLongException or
				  UnauthorizedAccessException)
				{
					errors.Add((FileName: fileName, ErrorMessage: ex.GetAllMessages()));
				}
			});

			return errors.AsEnumerable();
		}

		/// <summary>
		/// Downloads the file from the web and stores it in the given local file path.
		/// </summary>
		/// <param name="remoteFileUrl">The remote file URL.</param>
		/// <param name="localFilePath">The local file path.</param>
		/// <param name="clientId">The client identifier.</param>
		[Information(nameof(DownloadFileFromWeb), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void DownloadFileFromWeb([NotNull] Uri remoteFileUrl, [NotNull] string localFilePath, string clientId = "NONE")
		{
			_ = Directory.CreateDirectory(Path.GetDirectoryName(localFilePath));

			using var client = new HttpClient();

			client.DefaultRequestHeaders.Add("CLIENTID", clientId);

			using var localStream = File.Create(localFilePath);

			using (var stream = client.GetStreamAsync(remoteFileUrl).Result)
			{
				stream.CopyTo(localStream);
			}

			localStream.Flush();
		}

		/// <summary>
		/// Download file from web and unzips it as an asynchronous operation.
		/// </summary>
		/// <param name="remoteFileUrl">The remote file URL.</param>
		/// <param name="localExpandedDirPath">The local expanded dir path.</param>
		/// <returns>Task.</returns>
		[Information(nameof(DownloadFileFromWebAndUnzipAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static async Task DownloadFileFromWebAndUnzipAsync([NotNull] Uri remoteFileUrl, [NotNull] string localExpandedDirPath)
		{
			var tempFileNameBase = Guid.NewGuid().ToString();
			var tempDownloadPath = Path.Combine(Path.GetTempPath(), $"{tempFileNameBase}{Path.GetExtension(remoteFileUrl.ToString())}");

			DownloadFileFromWeb(remoteFileUrl, tempDownloadPath);

			await UnZipAsync(tempDownloadPath, localExpandedDirPath, true).ConfigureAwait(false);
		}

		/// <summary>
		/// Downloads file from web URL as an asynchronous operation.
		/// </summary>
		/// <param name="remoteFileUrl">The remote file URL.</param>
		/// <param name="localFilePath">The local file path.</param>
		/// <returns>Task.</returns>
		[Information(nameof(DownloadFileFromWeb), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static async Task DownloadFileFromWebAsync([NotNull] Uri remoteFileUrl, [NotNull] string localFilePath)
		{
			_ = Directory.CreateDirectory(Path.GetDirectoryName(localFilePath));

			using var client = new HttpClient();
			using var localStream = File.Create(localFilePath);
			using (var stream = await client.GetStreamAsync(remoteFileUrl).ConfigureAwait(false))
			{
				await stream.CopyToAsync(localStream).ConfigureAwait(false);
			}

			await localStream.FlushAsync().ConfigureAwait(false);
		}

		/// <summary>
		/// Determines whether [has invalid path chars] [the specified file name].
		/// </summary>
		/// <param name="fileName">The path.</param>
		/// <returns><c>true</c> if [has invalid path chars] [the specified file name]; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool FileHasInvalidChars([NotNull] string fileName)
		{
			return fileName.IndexOfAny(InvalidFileNameChars.ToArray()) != -1;
		}

		/// <summary>
		/// Moves the file.
		/// </summary>
		/// <param name="sourceFileName">Name of the source file.</param>
		/// <param name="destinationFileName">Name of the destination file.</param>
		[Information(nameof(MoveFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
		public static void MoveFile([NotNull] string sourceFileName, [NotNull] string destinationFileName)
		{
			Validate.TryValidateParam<ArgumentInvalidException>(File.Exists(sourceFileName), nameof(sourceFileName), $"File {sourceFileName} does not exist.");

			// Create destination directory if missing
			var dir = Path.GetDirectoryName(destinationFileName);

			if (Directory.Exists(dir) == false)
			{
				_ = Directory.CreateDirectory(dir);
			}

			for (var retryCount = 0; retryCount < Retries; retryCount++)
			{
				try
				{
					File.Move(sourceFileName, destinationFileName);
					return;
				}
				catch (IOException) when (retryCount < Retries - 1)
				{
				}
				catch (UnauthorizedAccessException) when (retryCount < Retries - 1)
				{
				}

				// If something has a transient lock on the file waiting may resolve the issue
				Thread.Sleep(( retryCount + 1 ) * 10);
			}
		}

		/// <summary>
		/// Moves the file with options.
		/// </summary>
		/// <param name="sourceFileName">Name of the source file.</param>
		/// <param name="destinationFileName">Name of the destination file.</param>
		/// <param name="fileMoveOptions">The file move options.</param>
		[Information(nameof(MoveFile), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 99, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void MoveFile([NotNull] string sourceFileName, [NotNull] string destinationFileName, FileMoveOptions fileMoveOptions)
		{
			Validate.TryValidateParam<ArgumentInvalidException>(File.Exists(sourceFileName), nameof(sourceFileName), $"File {sourceFileName} does not exist.");


			for (var retryCount = 0; retryCount < Retries; retryCount++)
			{
				try
				{
					_ = NativeMethods.MoveFileEx(sourceFileName, destinationFileName, (int)fileMoveOptions);
					return;
				}
				catch (IOException) when (retryCount < Retries - 1)
				{
				}
				catch (UnauthorizedAccessException) when (retryCount < Retries - 1)
				{
				}

				// If something has a transient lock on the file waiting may resolve the issue
				Thread.Sleep(( retryCount + 1 ) * 10);
			}
		}

		/// <summary>
		/// Un-GZip's a file as an asynchronous operation.
		/// </summary>
		/// <param name="gzipPath">The gzip path.</param>
		/// <param name="expandedFilePath">The expanded file path.</param>
		/// <returns>Task.</returns>
		[Information(nameof(UnGZipAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static async Task UnGZipAsync([NotNull] string gzipPath, [NotNull] string expandedFilePath)
		{
			using var gzipStream = File.OpenRead(gzipPath);
			using var expandedStream = new GZipStream(gzipStream, CompressionMode.Decompress);
			using var targetFileStream = File.OpenWrite(expandedFilePath);

			await expandedStream.CopyToAsync(targetFileStream).ConfigureAwait(false);
		}

		/// <summary>
		/// un-gzip as an asynchronous operation.
		/// </summary>
		/// <param name="gzipPath">The gzip path.</param>
		/// <param name="expandedFilePath">The expanded file path.</param>
		/// <param name="deleteGZipFile">if set to <c>true</c> [delete g zip file].</param>
		/// <returns>Task.</returns>
		[Information(nameof(UnGZipAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static async Task UnGZipAsync([NotNull] string gzipPath, [NotNull] string expandedFilePath, bool deleteGZipFile)
		{
			Validate.TryValidateParam<ArgumentInvalidException>(File.Exists(gzipPath), nameof(gzipPath), "GZip file not found.");

			await UnGZipAsync(gzipPath, expandedFilePath).ConfigureAwait(false);

			if (deleteGZipFile)
			{
				File.Delete(gzipPath);
			}
		}

		/// <summary>
		/// Unzips a file as an asynchronous operation.
		/// </summary>
		/// <param name="zipPath">The path to the zip file.</param>
		/// <param name="expandToDirectory">The directory path where files will be unzipped.</param>
		/// <returns>Task.</returns>
		[Information(nameof(UnZipAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static async Task UnZipAsync([NotNull] string zipPath, [NotNull] string expandToDirectory)
		{
			Validate.TryValidateParam<ArgumentInvalidException>(File.Exists(zipPath), nameof(zipPath), Resources.ZipFileNotFound);

			await UnWinZipAsync(zipPath, expandToDirectory).ConfigureAwait(false);
		}

		/// <summary>
		/// Unzips a file as an asynchronous operation.
		/// </summary>
		/// <param name="zipPath">The path to the zip file.</param>
		/// <param name="expandToDirectory">The directory path where files will be unzipped.</param>
		/// <param name="deleteZipFile">if set to <c>true</c> [deletes zip file].</param>
		/// <returns>Task.</returns>
		[Information(nameof(UnZipAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static async Task UnZipAsync([NotNull] string zipPath, [NotNull] string expandToDirectory, bool deleteZipFile)
		{
			await UnZipAsync(zipPath, expandToDirectory).ConfigureAwait(false);

			if (deleteZipFile)
			{
				File.Delete(zipPath);
			}
		}

		/// <summary>
		/// Un-zips a file as an asynchronous operation.
		/// </summary>
		/// <param name="zipPath">The zip path.</param>
		/// <param name="expandedDirectoryPath">The expanded directory path.</param>
		/// <returns>Task.</returns>
		[Information(nameof(UnWinZipAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		private static async Task UnWinZipAsync(string zipPath, string expandedDirectoryPath)
		{
			using var zipFileStream = File.OpenRead(zipPath);
			using var zipArchiveStream = new ZipArchive(zipFileStream);

			for (var zipArchiveCount = 0; zipArchiveCount < zipArchiveStream.Entries.Count; zipArchiveCount++)
			{
				var zipArchiveEntry = zipArchiveStream.Entries[zipArchiveCount];

				if (zipArchiveEntry.CompressedLength == 0)
				{
					continue;
				}

				var extractedFilePath = Path.Combine(expandedDirectoryPath, zipArchiveEntry.FullName);

				_ = Directory.CreateDirectory(Path.GetDirectoryName(extractedFilePath));

				using var zipStream = zipArchiveEntry.Open();
				using var extractedFileStream = File.OpenWrite(extractedFilePath);

				await zipStream.CopyToAsync(extractedFileStream).ConfigureAwait(false);
			}
		}

	}
}
