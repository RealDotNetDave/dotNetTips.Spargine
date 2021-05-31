// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-21-2021
// ***********************************************************************
// <copyright file="DirectoryHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Win32;
using Microsoft.Win32;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.IO
{
	/// <summary>
	/// Class DirectoryHelper.
	/// </summary>
	public static class DirectoryHelper
	{
		/// <summary>
		/// Applications the application data folder for Windows or Mac.
		/// </summary>
		/// <returns>Application data folder.</returns>
		[Information(nameof(AppDataFolder), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100)]
		public static string AppDataFolder()
		{
			var userPath = Environment.GetEnvironmentVariable(RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "LOCALAPPDATA" : "Home");

			var companyName = Assembly.GetEntryAssembly().GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault().Company.Trim();

			var path = Path.Combine(userPath, companyName);

			return path;
		}

		/// <summary>
		/// Copies directory to a new location.
		/// </summary>
		/// <param name="sourceDirectory">The source directory.</param>
		/// <param name="destinationDirectory">The destination directory.</param>
		/// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
		[Information(nameof(CopyDirectory), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100)]
		public static void CopyDirectory(string sourceDirectory, string destinationDirectory, bool overwrite = true)
		{
			Validate.TryValidateParam(sourceDirectory, nameof(sourceDirectory));
			Validate.TryValidateParam(destinationDirectory, nameof(destinationDirectory));

			var directory = new DirectoryInfo(sourceDirectory);

			var directories = directory.GetDirectories();

			if (Directory.Exists(destinationDirectory) == false)
			{
				_ = Directory.CreateDirectory(destinationDirectory);
			}

			var files = directory.GetFiles();

			for (var fileCount = 0; fileCount < files.Length; fileCount++)
			{
				var file = files[fileCount];

				_ = file.CopyTo(Path.Combine(destinationDirectory, file.Name), overwrite);
			}

			for (var directoryCount = 0; directoryCount < directories.Length; directoryCount++)
			{
				var subDirectory = directories[directoryCount];

				CopyDirectory(subDirectory.FullName, Path.Combine(destinationDirectory, subDirectory.Name), overwrite);
			}
		}

		/// <summary>
		/// Deletes the directory.
		/// </summary>
		/// <param name="path">The path.</param>
		[Information(nameof(DeleteDirectory), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100)]
		public static void DeleteDirectory(string path)
		{
			DeleteDirectory(path, 1);
		}

		/// <summary>
		/// Deletes the directory.
		/// </summary>
		/// <param name="path">The path.</param>
		[Information(nameof(DeleteDirectory), "David McCarter", "4/2/2021", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0)]
		public static void DeleteDirectory(DirectoryInfo path)
		{
			DeleteDirectory(path.ToString(), 1);
		}

		/// <summary>
		/// Deletes the directory with retry.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="retries">Number of retries.</param>
		/// <remarks>Checks for the <see cref="IOException" /> and <see cref="UnauthorizedAccessException" />.</remarks>
		[Information(nameof(DeleteDirectory), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 99)]
		public static void DeleteDirectory(string path, int retries = 10)
		{
			Validate.TryValidateParam(path, nameof(path));

			if (Directory.Exists(path) == false)
			{
				return;
			}

			retries = Math.Max(1, retries);
			var tries = 0;

			do
			{
				tries++;

				if (tries > 1)
				{
					// If something has a transient lock on the file waiting may resolve the issue
					Thread.Sleep(( retries + 1 ) * 10);
				}

				try
				{
					// On some systems, directories/files created are created with attributes
					// that prevent them from being deleted. Set those attributes to be normal
					SetFileAttributesToNormal(path);
					Directory.Delete(path, recursive: true);

					return;
				}
				catch (IOException) when (tries >= retries)
				{
					throw;
				}
				catch (UnauthorizedAccessException) when (tries >= retries)
				{
					throw;
				}
			}
			while (retries > tries);
		}

		/// <summary>
		/// Delete directory, with retries, as an asynchronous operation.
		/// </summary>
		/// <param name="directory">The directory to delete.</param>
		/// <returns>Task&lt;System.Boolean&gt;.</returns>
		/// <exception cref="ArgumentNullException">directory.</exception>
		[Information(nameof(DeleteDirectoryAsync), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0)]
		public static async Task<bool> DeleteDirectoryAsync(DirectoryInfo directory)
		{
			Validate.TryValidateParam(directory, nameof(directory));

			if (directory.Exists)
			{
				_ = await Task.Factory.StartNew(() =>
				{
					DeleteDirectory(directory.FullName);
					return true;
				}).ConfigureAwait(false);
			}

			return false;
		}

		/// <summary>
		/// Load files as an asynchronous operation.
		/// </summary>
		/// <param name="directories">The directories.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="searchOption">The search option.</param>
		/// <returns>IAsyncEnumerable&lt;IEnumerable&lt;FileInfo&gt;&gt;.</returns>
		[Information(nameof(LoadFilesAsync), author: "David McCarter", createdOn: "3/1/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static async IAsyncEnumerable<IEnumerable<FileInfo>> LoadFilesAsync(IEnumerable<DirectoryInfo> directories, string searchPattern, SearchOption searchOption)
		{
			Validate.TryValidateParam(directories, nameof(directories));
			Validate.TryValidateParam(searchPattern, nameof(searchPattern));
			Validate.TryValidateParam(searchOption, nameof(searchOption));

			var options = new EnumerationOptions() { IgnoreInaccessible = true };

			if (searchOption == SearchOption.AllDirectories)
			{
				options.RecurseSubdirectories = true;
			}

			var validDirectories = directories.Where(directory => directory.Exists).Select(directory => directory).ToList();

			foreach (var directory in validDirectories)
			{
				var files = await Task.Run(() => directory.EnumerateFiles(searchPattern, options)).ConfigureAwait(false);
				yield return files;
			}
		}

		/// <summary>
		/// Loads the one drive folders.
		/// </summary>
		/// <returns>IEnumerable&lt;OneDriveFolder&gt;.</returns>
		/// <exception cref="PlatformNotSupportedException"></exception>
		[Information(nameof(LoadOneDriveFolders), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100)]
		public static ImmutableArray<OneDriveFolder> LoadOneDriveFolders()
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == false)
			{
				throw new PlatformNotSupportedException();
			}

			const string DisplayNameKey = "DisplayName";
			const string UserFolderKey = "UserFolder";
			const string AccountsKey = "Accounts";
			const string EmailKey = "UserEmail";

			var folders = new List<OneDriveFolder>();

			var oneDriveKey = RegistryHelper.GetRegistryKey(RegistryHelper.KeyCurrentUserOneDrive, RegistryHive.CurrentUser);

			if (oneDriveKey.IsNotNull())
			{
				// Get Accounts
				var accountKey = oneDriveKey.GetSubKey(AccountsKey);

				if (accountKey.IsNotNull() && accountKey.SubKeyCount > 0)
				{
					for (var subKeyCount = 0; subKeyCount < accountKey.GetSubKeyNames().Length; subKeyCount++)
					{
						var key = accountKey.OpenSubKey(accountKey.GetSubKeyNames()[subKeyCount]);

						var folder = new OneDriveFolder();
						var directoryValue = key.GetValue<string>(UserFolderKey);

						if (directoryValue.HasValue())
						{
							folder.DirectoryInfo = new DirectoryInfo(directoryValue);

							var emailValue = key.GetValue<string>(EmailKey);

							if (emailValue.IsNotNull())
							{
								folder.UserEmail = emailValue;
							}

							// Figure out account type
							var name = key.GetValue<string>(DisplayNameKey);

							if (name.HasValue())
							{
								folder.AccountType = OneDriveAccountType.Business;
								folder.AccountName = name;
							}
							else
							{
								folder.AccountName = key.GetValue<string>(string.Empty);
							}

							if (folder.AccountName.HasValue() && folder.DirectoryInfo.IsNotNull())
							{
								folders.Add(folder);
							}
						}
					}
				}
			}

			return folders.ToImmutableArray();
		}

		/// <summary>
		/// Moves the directory.
		/// </summary>
		/// <param name="sourceDirectoryName">Name of the source directory.</param>
		/// <param name="destinationDirectoryName">Name of the destination directory.</param>
		[Information(nameof(MoveDirectory), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0)]
		public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName)
		{
			MoveDirectory(sourceDirectoryName, destinationDirectoryName, 1);
		}

		/// <summary>
		/// Moves the directory with retry.
		/// </summary>
		/// <param name="sourceDirectoryName">Name of the source dir.</param>
		/// <param name="destinationDirectoryName">Name of the destination dir.</param>
		/// <param name="retries">Number of retries.</param>
		/// <remarks>Checks for the <see cref="IOException" /> and <see cref="UnauthorizedAccessException" />.</remarks>
		[Information(nameof(MoveDirectory), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 99)]
		public static void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName, int retries = 10)
		{
			Validate.TryValidateParam(sourceDirectoryName, nameof(sourceDirectoryName));
			Validate.TryValidateParam(destinationDirectoryName, nameof(destinationDirectoryName));
			Validate.TryValidateParam<ArgumentInvalidException>(Directory.Exists(sourceDirectoryName), nameof(sourceDirectoryName));

			retries = Math.Max(1, retries);
			var tries = 0;

			do
			{
				tries++;

				if (tries > 1)
				{
					// If something has a transient lock on the file waiting may resolve the issue
					Thread.Sleep(( retries + 1 ) * 10);
				}

				try
				{
					Directory.Move(sourceDirectoryName, destinationDirectoryName);
					return;
				}
				catch (IOException) when (tries >= retries)
				{
					throw;
				}
				catch (UnauthorizedAccessException) when (tries >= retries)
				{
					throw;
				}
			}
			while (tries < retries);
		}

		/// <summary>
		/// Safe directory search.
		/// </summary>
		/// <param name="rootDirectory">The root directory.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="searchOption">All or Top Directory Only.</param>
		/// <returns>IEnumerable&lt;DirectoryInfo&gt;.</returns>
		[Information(nameof(SafeDirectorySearch), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100)]
		public static IEnumerable<DirectoryInfo> SafeDirectorySearch(DirectoryInfo rootDirectory, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
		{
			Validate.TryValidateParam(rootDirectory, nameof(rootDirectory));
			Validate.TryValidateParam(searchPattern, nameof(searchPattern));

			var folders = new List<DirectoryInfo>
			{
				rootDirectory,
			};

			for (var directoryCount = 0; directoryCount < rootDirectory.GetDirectories(searchPattern, searchOption).Length; directoryCount++)
			{
				try
				{
					var searchResult = SafeDirectorySearch(rootDirectory.GetDirectories(searchPattern, searchOption)[directoryCount], searchPattern);

					if (searchResult.HasItems())
					{
						_ = folders.AddRange(searchResult, Tristate.True);
					}
				}
				catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException || ex is ArgumentOutOfRangeException || ex is System.IO.DirectoryNotFoundException || ex is UnauthorizedAccessException)
				{
					Trace.WriteLine(ex.Message);
				}
			}

			return folders;
		}

		/// <summary>
		/// Safe file search. Ignores errors accessing directories.
		/// </summary>
		/// <param name="directory">The directory to search.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="searchOption">The search option.</param>
		/// <returns>IEnumerable&lt;FileInfo&gt;.</returns>
		[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Documentation = "http://bit.ly/SpargineMarch2021")]
		public static IEnumerable<FileInfo> SafeFileSearch(DirectoryInfo directory, string searchPattern, SearchOption searchOption)
		{
			return SafeFileSearch(new List<DirectoryInfo> { directory }, searchPattern, searchOption);
		}

		/// <summary>
		/// Safe file search. Ignores errors accessing directories.
		/// </summary>
		/// <param name="directories">The directories to search.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="searchOption">The search option.</param>
		/// <returns>IEnumerable&lt;FileInfo&gt;.</returns>
		[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100)]
		public static IEnumerable<FileInfo> SafeFileSearch(IEnumerable<DirectoryInfo> directories, string searchPattern, SearchOption searchOption)
		{
			Validate.TryValidateParam(directories, nameof(directories));
			Validate.TryValidateParam(searchPattern, nameof(searchPattern));
			Validate.TryValidateParam(searchOption, nameof(searchOption));

			var files = new List<FileInfo>();

			directories.ToList().ForEach(directory =>
			{
				try
				{
					if (directory.Exists)
					{
						var directoryFiles = directory.EnumerateFiles(searchPattern, searchOption).ToArray();

						if (directoryFiles.HasItems())
						{
							_ = files.AddIfNotExists(directoryFiles);
						}
					}
				}
				catch (Exception ex) when (ex is System.IO.DirectoryNotFoundException || ex is SecurityException || ex is UnauthorizedAccessException)
				{
					Trace.WriteLine(ex.Message);
				}
			});

			return files.AsEnumerable();
		}

		/// <summary>
		/// Sets the file attributes to normal for a path.
		/// </summary>
		/// <param name="path">The path.</param>
		[Information(nameof(SetFileAttributesToNormal), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0)]
		public static void SetFileAttributesToNormal(string path)
		{
			Validate.TryValidateParam(path, nameof(path));

			for (var directoryCount = 0; directoryCount < Directory.GetDirectories(path).Length; directoryCount++)
			{
				SetFileAttributesToNormal(Directory.GetDirectories(path)[directoryCount]);
			}

			for (var fileCount = 0; fileCount < Directory.GetFiles(path).Length; fileCount++)
			{
				File.SetAttributes(Directory.GetFiles(path)[fileCount], FileAttributes.Normal);
			}
		}
	}
}
