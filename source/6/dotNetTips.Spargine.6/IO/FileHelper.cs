// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="FileHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Helper methods for files.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Compression;
using System.Security.AccessControl;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )Safe

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Helper methods for files.
/// </summary>
[Information(nameof(FileHelper), "David McCarter", "2/11/2017", Status = Status.Available)]
public static class FileHelper
{
	/// <summary>
	/// The no result
	/// </summary>
	private const int NoResult = -1;

	/// <summary>
	/// The count for retries.
	/// </summary>
	private const int Retries = 10;

	/// <summary>
	/// The HTTP client
	/// </summary>
	private static HttpClient _httpClient;

	/// <summary>
	/// Gets the HTTP client.
	/// </summary>
	/// <returns>System.Net.Http.HttpClient.</returns>
	private static HttpClient GetHttpClient()
	{
		_httpClient ??= new HttpClient();

		return _httpClient;
	}

	/// <summary>
	/// Un-zips a file as an asynchronous operation.
	/// </summary>
	/// <param name="zipPath">The zip path.</param>
	/// <param name="expandedDirectoryPath">The expanded directory path.</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnWinZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	private static async Task UnWinZipAsync(string zipPath, string expandedDirectoryPath)
	{
		using var zipFileStream = File.OpenRead(zipPath);
		using var zipArchiveStream = new ZipArchive(zipFileStream);

		for (var zipArchiveCount = 0; zipArchiveCount < zipArchiveStream.Entries.FastCount(); zipArchiveCount++)
		{
			var zipArchiveEntry = zipArchiveStream.Entries[zipArchiveCount];

			if (zipArchiveEntry.CompressedLength == 0)
			{
				continue;
			}

			var extractedFilePath = Path.Combine(expandedDirectoryPath, zipArchiveEntry.FullName);

			_ = Directory.CreateDirectory(Path.GetDirectoryName(extractedFilePath));

			using (var zipStream = zipArchiveEntry.Open())
			{
				using (var extractedFileStream = File.OpenWrite(extractedFilePath))
				{
					await zipStream.CopyToAsync(extractedFileStream, CancellationToken.None).ConfigureAwait(false);
				}
			}
		}
	}

	/// <summary>
	/// Checks the permission of a file.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <param name="permission">The requested permission.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(CheckPermission), author: "David McCarter", createdOn: "6/17/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool CheckPermission(string path, FileSystemRights permission = FileSystemRights.Read)
	{
		path = path.ArgumentNotNullOrEmpty(trim: true);

		var access = FileSystemAclExtensions.GetAccessControl(new FileInfo(path));

		if (access is null)
		{
			return false;
		}

		var rules = access.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));

		if (rules is null)
		{
			return false;
		}

		var allow = false;
		var deny = false;

		for (var index = 0; index < rules.Count; index++)
		{
			var rule = rules[index] as FileSystemAccessRule;

			if ((permission & rule.FileSystemRights) != permission)
			{
				continue;
			}

			if (rule.AccessControlType == AccessControlType.Allow)
			{
				allow = true;
			}
			else if (rule.AccessControlType == AccessControlType.Deny)
			{
				deny = true;
			}
		}

		return allow && !deny;
	}

	//#if NET7_0_OR_GREATER

	//public delegate CopyProgressResult ProgressCallback(long TotalFileSize, long TotalBytesTransferred, long StreamSize, long StreamBytesTransferred, uint dwStreamNumber, CopyProgressCallbackReason dwCallbackReason, IntPtr hSourceFile, IntPtr hDestinationFile, IntPtr lpData);

	//		public enum CopyProgressResult : uint
	//		{
	//			Continue = 0,
	//			Cancel = 1,
	//			Stop = 2,
	//			Quiet = 3
	//		}

	//		public enum CopyProgressCallbackReason : uint
	//		{
	//			ChunkFinished = 0x00000000,
	//			StreamSwitch = 0x00000001
	//		}

	//	    internal static bool CopyFileWithEvents(string oldFile, string newFile, ProgressCallback progressCallback)
	//		{
	//			int cancel = 0;
	//			return SourceGenerators.CopyFileEx(oldFile, newFile, progressCallback, IntPtr.Zero, ref cancel, CopyFileMode.Restartable | CopyFileMode.Restartable);
	//		}

	//    [Information(nameof(CopyFile), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.New, Documentation = "ADD URL")]
	//	public static bool CopyFile([NotNull] FileInfo file, [NotNull] DirectoryInfo destination, [NotNull] ProgressCallback progressCallback)
	//	{
	//		var fileName = file.ArgumentExists().FullName;

	//		if (destination.ArgumentNotNull().CheckExists(throwException: true))
	//		{
	//		    var destinationName = destination.FullName;
	//			var newFileName = Path.Combine(destinationName, fileName);
	//			return CopyFileEx(fileName, destinationName, progressCallback, IntPtr.Zero, ref cancel, CopyFileMode.Restartable | CopyFileMode.Restartable);
	//		}
	//		else
	//		{
	//		  return false;
	//		}
	//    }

	//#endif

	/// <summary>
	/// Copies the file to a new directory. If the file already exists, it
	/// will be overwritten.
	/// </summary>
	/// <param name="file">The file.</param>
	/// <param name="destination">The destination folder.</param>
	/// <returns>File length as System.Int64. If value is -1, then there is an issue creating the file.</returns>
	[Information(nameof(CopyFile), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static long CopyFile([NotNull] FileInfo file, [NotNull] DirectoryInfo destination)
	{
		var fileName = file.ArgumentExists().FullName;

		if (destination.ArgumentNotNull().CheckExists(throwException: true))
		{
			var destinationName = destination.FullName;

			var newFileName = Path.Combine(destinationName, fileName);

			using (var sourceStream = file.Open(FileMode.Open))
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
		else
		{
			return NoResult;
		}
	}

	/// <summary>
	/// Copies a file to a new directory as an asynchronous operation.
	/// If the file already exists, it will be overwritten.
	/// </summary>
	/// <param name="file">The file.</param>
	/// <param name="destination">The destination folder.</param>
	/// <returns>Task&lt;System.Int32&gt;.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(CopyFileAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://dotnettips.wordpress.com/2020/11/17/coding-faster-with-the-dotnettips-utility-november-2020-update")]
	public static async Task<long> CopyFileAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination)
	{
		var fileName = file.ArgumentExists().FullName;
		_ = destination.ArgumentNotNull().CheckExists(createDirectory: true, throwException: true, errorMessage: string.Format(CultureInfo.InvariantCulture, Resources.DirectoryDoesNotExistOrCannotBeCreated, destination.FullName));

		var destinationName = destination.FullName;

		var newFileName = Path.Combine(destinationName, fileName);

		using (var sourceStream = File.Open(fileName, FileMode.Open))
		{
			if (File.Exists(newFileName))
			{
				File.Delete(newFileName);
			}

			using (var destinationStream = File.Create(newFileName))
			{
				await sourceStream.CopyToAsync(destinationStream, CancellationToken.None).ConfigureAwait(false);
				await destinationStream.FlushAsync(CancellationToken.None).ConfigureAwait(false);
			}
		}

		return file.Length;
	}

	/// <summary>
	/// Attempts to delete files and will return the file name and error message for files that
	/// could not be deleted.
	/// </summary>
	/// <param name="files">The files.</param>
	/// <returns>IEnumerable&lt;KeyValuePair&lt;System.String, System.String&gt;&gt;.</returns>
	[Information(nameof(DeleteFiles), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IEnumerable<(string FileName, string ErrorMessage)> DeleteFiles([NotNull] this IEnumerable<string> files)
	{
		files = files.ArgumentNotNull();

		var errors = new List<(string FileName, string ErrorMessage)>();

		_ = Parallel.ForEach(source: files, body: (fileName) =>
		{
			try
			{
				if (File.Exists(fileName))
				{
					File.Delete(fileName);
				}
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
	/// Download file from web and unzips it as an asynchronous operation.
	/// </summary>
	/// <param name="remoteUri">The remote file URL.</param>
	/// <param name="destination">The local expanded dir path.</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(DownloadFileFromWebAndUnzipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static async Task DownloadFileFromWebAndUnzipAsync([NotNull] Uri remoteUri, [NotNull] DirectoryInfo destination)
	{
		_ = destination.ArgumentNotNull().CheckExists();

		var tempDownloadPath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}{Path.GetExtension(remoteUri.ToString())}");

		await DownloadFileFromWebAsync(remoteUri, destination).ConfigureAwait(false);

		await UnZipAsync(new FileInfo(tempDownloadPath), destination, true).ConfigureAwait(false);
	}

	/// <summary>
	/// Downloads file from web URL as an asynchronous operation.
	/// Creates the <paramref name="destination" /> if it does not exist.
	/// </summary>
	/// <param name="remoteUri">The remote file URL.</param>
	/// <param name="destination">The local file path.</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(DownloadFileFromWebAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static async Task DownloadFileFromWebAsync(Uri remoteUri, DirectoryInfo destination)
	{
		remoteUri = remoteUri.ArgumentNotNull();

		if (destination.ArgumentNotNull().Exists is false)
		{
			destination.Create();
		}

		var pathName = destination.FullName;

		using (var client = GetHttpClient())
		{
			using (var localStream = File.Create(pathName))
			{
				using (var stream = await client.GetStreamAsync(remoteUri, CancellationToken.None).ConfigureAwait(false))
				{
					await stream.CopyToAsync(localStream, CancellationToken.None).ConfigureAwait(false);
				}

				await localStream.FlushAsync(CancellationToken.None).ConfigureAwait(false);
			}
		}
	}

	/// <summary>
	/// Determines whether [has invalid path chars] [the specified file name].
	/// Validates <paramref name="file" /> to ensure it's not null.
	/// </summary>
	/// <param name="file">The path.</param>
	/// <returns><c>true</c> if [has invalid path chars] [the specified file name]; otherwise, <c>false</c>.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static bool FileHasInvalidChars(FileInfo file)
	{
		return file.CheckExists() && file.ArgumentNotNull().FullName.IndexOfAny(InvalidFileNameChars.ToArray()) != -1;
	}

	/// <summary>
	/// Moves the file with options.
	/// </summary>
	/// <param name="file">Name of the source file.</param>
	/// <param name="destinationFile">Name of the destination file.</param>
	/// <param name="fileMoveOptions">The file move options.</param>
	[Information(nameof(MoveFile), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 99, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void MoveFile([NotNull] FileInfo file, [NotNull] FileInfo destinationFile, FileMoveOptions fileMoveOptions = FileMoveOptions.ReplaceExisting)
	{
		var fileName = file.ArgumentExists().FullName;
		fileMoveOptions = fileMoveOptions.ArgumentDefined();

		for (var retryCount = 0; retryCount < Retries; retryCount++)
		{
			try
			{
				_ = NativeMethods.MoveFileEx(fileName, destinationFile.FullName, (int)fileMoveOptions);
				return;
			}
			catch (IOException) when (retryCount < Retries - 1)
			{
				//RETRY
			}
			catch (UnauthorizedAccessException) when (retryCount < Retries - 1)
			{
				//RETRY
			}

			// If something has a transient lock on the file waiting may resolve the issue
			Thread.Sleep((retryCount + 1) * 10);
		}
	}

	/// <summary>
	/// Un-GZip's a file as an asynchronous operation.
	/// </summary>
	/// <param name="source">The source.</param>
	/// <param name="destination">The destination.</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnGZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async Task UnGZipAsync([NotNull] FileInfo source, DirectoryInfo destination)
	{
		source = source.ArgumentExists();

		if (destination.ArgumentNotNull().Exists is false)
		{
			destination.Create();
		}

		var destinationPath = destination.FullName;

		using (var gzipStream = source.OpenRead())
		{
			using (var expandedStream = new GZipStream(gzipStream, CompressionMode.Decompress))
			{
				using (var targetFileStream = File.OpenWrite(destinationPath))
				{
					await expandedStream.CopyToAsync(targetFileStream).ConfigureAwait(false);
				}
			}
		}
	}

	/// <summary>
	/// un-GZip as an asynchronous operation.
	/// </summary>
	/// <param name="file">The gzip path.</param>
	/// <param name="destination">The expanded file path.</param>
	/// <param name="deleteGZipFile">if set to <c>true</c> [delete g zip file].</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnGZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async Task UnGZipAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination, bool deleteGZipFile)
	{
		var fileName = new FileInfo(file.ArgumentExists().FullName);

		_ = destination.ArgumentNotNull().CheckExists();

		await UnGZipAsync(fileName, destination).ConfigureAwait(false);

		if (deleteGZipFile)
		{
			file.Delete();
		}
	}

	/// <summary>
	/// Unzips a file as an asynchronous operation.
	/// </summary>
	/// <param name="file">The path to the zip file.</param>
	/// <param name="destination">The directory path where files will be unzipped.</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async Task UnZipAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination)
	{
		var fileName = file.ArgumentExists().FullName;

		_ = destination.ArgumentNotNull().CheckExists();

		await UnWinZipAsync(fileName, destination.FullName).ConfigureAwait(false);
	}

	/// <summary>
	/// Unzips a file as an asynchronous operation.
	/// </summary>
	/// <param name="file">The path to the zip file.</param>
	/// <param name="destination">The directory path where files will be unzipped.</param>
	/// <param name="deleteZipFile">if set to <c>true</c> [deletes zip file].</param>
	/// <returns>Task.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(UnZipAsync), BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async Task UnZipAsync([NotNull] FileInfo file, [NotNull] DirectoryInfo destination, bool deleteZipFile)
	{
		file = file.ArgumentExists();
		_ = destination.ArgumentNotNull().CheckExists();

		await UnZipAsync(file, destination).ConfigureAwait(false);

		if (deleteZipFile)
		{
			file.Delete();
		}
	}

	/// <summary>
	/// Gets the invalid file name chars.
	/// </summary>
	/// <value>The invalid file name chars.</value>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static IEnumerable<char> InvalidFileNameChars { get; } = Path.GetInvalidFileNameChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();
}
