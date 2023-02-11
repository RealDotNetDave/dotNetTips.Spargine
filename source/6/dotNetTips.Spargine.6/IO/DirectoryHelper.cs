// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-18-2023
// ***********************************************************************
// <copyright file="DirectoryHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.AccessControl;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Properties;
using DotNetTips.Spargine.Win32;
using Microsoft.Win32;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Class DirectoryHelper.
/// </summary>
[SupportedOSPlatform("windows")]
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
	/// Checks the permission of a directory.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <param name="permission">The requested permission.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(CheckPermission), author: "David McCarter", createdOn: "6/17/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool CheckPermission(string path, FileSystemRights permission = FileSystemRights.Read)
	{
		path = path.ArgumentNotNullOrEmpty(trim: true);

		var access = FileSystemAclExtensions.GetAccessControl(new DirectoryInfo(path));

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
			var rule = (FileSystemAccessRule)rules[index];

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

	/// <summary>
	/// Copies directory to a new location.
	/// </summary>
	/// <param name="source">The source directory.</param>
	/// <param name="destination">The destination directory.</param>
	/// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
	[Information(nameof(CopyDirectory), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100)]
	public static void CopyDirectory([NotNull] DirectoryInfo source, [NotNull] DirectoryInfo destination, bool overwrite = true)
	{
		var directories = source.ArgumentExists().GetDirectories();

		_ = destination.ArgumentNotNull().CheckExists();

		var destinationPath = destination.FullName;

		var files = source.GetFiles();

		for (var fileIndex = 0; fileIndex < files.Length; fileIndex++)
		{
			var file = files[fileIndex];

			_ = file.CopyTo(Path.Combine(destinationPath, file.Name), overwrite);
		}

		for (var directoryIndex = 0; directoryIndex < directories.Length; directoryIndex++)
		{
			var subDirectory = directories[directoryIndex];

			CopyDirectory(subDirectory, new DirectoryInfo(Path.Combine(destinationPath, subDirectory.Name)), overwrite);
		}
	}

	/// <summary>
	/// Deletes the directory with retry.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <param name="retries">Number of retries.</param>
	/// <remarks>Checks for the <see cref="IOException" /> and <see cref="UnauthorizedAccessException" />.</remarks>
	[Information(nameof(DeleteDirectory), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 99)]
	public static void DeleteDirectory([NotNull] DirectoryInfo path, int retries = 10)
	{
		if (path.Exists is false)
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
				Thread.Sleep((retries + 1) * 10);
			}

			try
			{
				// On some systems, directories/files created are created with attributes
				// that prevent them from being deleted. Set those attributes to be normal
				SetFileAttributesToNormal(path);

				path.Delete(true);

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
	/// Load files as an asynchronous operation.
	/// </summary>
	/// <param name="directories">The directories.</param>
	/// <param name="searchPattern">The search pattern.</param>
	/// <param name="searchOption">The search options.</param>
	/// <returns>IAsyncEnumerable&lt;IEnumerable&lt;FileInfo&gt;&gt;.</returns>
	[Information(nameof(LoadFilesAsync), author: "David McCarter", createdOn: "3/1/2021", BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Status = Status.Available)]
	public static async IAsyncEnumerable<IEnumerable<FileInfo>> LoadFilesAsync([NotNull] IEnumerable<DirectoryInfo> directories, [NotNull] string searchPattern, SearchOption searchOption)
	{
		directories = directories.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNull();

		if (searchOption.CheckIsDefined() is false)
		{
			searchOption = SearchOption.TopDirectoryOnly;
		}

		var options = new EnumerationOptions() { IgnoreInaccessible = true };

		if (searchOption == SearchOption.AllDirectories)
		{
			options.RecurseSubdirectories = true;
		}

		var validDirectories = directories.Where(directory => directory.Exists).Select(directory => directory).ToList();

		for (var directoryCount = 0; directoryCount < validDirectories.FastCount(); directoryCount++)
		{
			var files = await Task.Run(() => validDirectories[directoryCount].EnumerateFiles(searchPattern, options), CancellationToken.None).ConfigureAwait(false);

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
		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) is false)
		{
			throw new PlatformNotSupportedException();
		}

		const string DisplayNameKey = "DisplayName";
		const string UserFolderKey = "UserFolder";
		const string AccountsKey = "Accounts";
		const string EmailKey = "UserEmail";

		var folders = new List<OneDriveFolder>();

		using (var oneDriveKey = RegistryHelper.GetRegistryKey(RegistryHelper.KeyCurrentUserOneDrive, RegistryHive.CurrentUser))
		{
			if (oneDriveKey.IsNotNull())
			{
				// Get Accounts
				using (var accountKey = oneDriveKey.GetSubKey(AccountsKey))
				{
					if (accountKey.IsNotNull() && accountKey.SubKeyCount > 0)
					{
						for (var subKeyIndex = 0; subKeyIndex < accountKey.GetSubKeyNames().Length; subKeyIndex++)
						{
							using var key = accountKey.OpenSubKey(accountKey.GetSubKeyNames()[subKeyIndex]);

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
									folder.AccountName = (string)key.GetValue(string.Empty);
								}

								if (folder.AccountName.HasValue() && folder.DirectoryInfo.IsNotNull())
								{
									folders.Add(folder);
								}
							}
						}
					}
				}
			}
		}

		return folders.ToImmutableArray();
	}

	/// <summary>
	/// Moves the directory with retry. Retry max count is 100.
	/// </summary>
	/// <param name="source">Name of the source dir.</param>
	/// <param name="destination">Name of the destination dir.</param>
	/// <param name="retries">Number of retries.</param>
	/// <remarks>Checks for the <see cref="IOException" /> and <see cref="UnauthorizedAccessException" />.</remarks>
	[Information(nameof(MoveDirectory), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 99)]
	public static void MoveDirectory([NotNull] DirectoryInfo source, [NotNull] DirectoryInfo destination, int retries = 10)
	{
		source = source.ArgumentExists();
		retries = retries.ArgumentInRange(1, upper: 100, defaultValue: 10, errorMessage: Resources.RetriesAreLimitedTo0100);

		if (destination.ArgumentNotNull().CheckExists(throwException: true))
		{
			var tries = 0;

			do
			{
				tries++;

				if (tries > 1)
				{
					// If something has a transient lock on the file waiting may resolve the issue
					Thread.Sleep((retries + 1) * 10);
				}

				try
				{
					Directory.Move(source.FullName, destination.FullName);
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
	}

	/// <summary>
	/// Searches folder and returns true if it contains any files that meet one of the
	/// search criteria.
	/// </summary>
	/// <param name="path">The root directory.</param>
	/// <param name="searchOption">The search options.</param>
	/// <param name="searchPatterns">The search patterns.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(SafeDirectorySearch), "David McCarter", "6/14/2021", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 0, Documentation = "https://bit.ly/SpargineSep2022")]
	public static bool SafeDirectoryContainsAny([NotNull] DirectoryInfo path, SearchOption searchOption = SearchOption.TopDirectoryOnly, [NotNull] params string[] searchPatterns)
	{
		path = path.ArgumentExists();
		searchOption = searchOption.ArgumentDefined();
		searchPatterns = searchPatterns.ArgumentNotNull();

		for (var patternCount = 0; patternCount < searchPatterns.Length; patternCount++)
		{
			try
			{
				var searchResult = SafeDirectorySearch(path, searchPatterns[patternCount], searchOption);

				if (searchResult.HasItems())
				{
					return true;
				}
			}
			catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or ArgumentOutOfRangeException or UnauthorizedAccessException)
			{
				Trace.WriteLine(ex.Message);
			}
		}

		return false;
	}

	/// <summary>
	/// Safe directory search.
	/// </summary>
	/// <param name="path">The root directory.</param>
	/// <param name="searchPattern">The search pattern.</param>
	/// <param name="searchOption">All or Top Directory Only.</param>
	/// <returns>IEnumerable&lt;DirectoryInfo&gt;.</returns>
	[Information(nameof(SafeDirectorySearch), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100)]
	public static IEnumerable<DirectoryInfo> SafeDirectorySearch([NotNull] DirectoryInfo path, [NotNull] string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		path = path.ArgumentExists();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		var folders = new List<DirectoryInfo>
		{
			path,
		};

		var options = new EnumerationOptions { IgnoreInaccessible = true, ReturnSpecialDirectories = false, RecurseSubdirectories = false };

		if (searchOption == SearchOption.AllDirectories)
		{
			options.RecurseSubdirectories = true;
		}

		for (var directoryCount = 0; directoryCount < path.GetDirectories(searchPattern, options).Length; directoryCount++)
		{
			try
			{
				var searchResult = SafeDirectorySearch(path.GetDirectories(searchPattern, options)[directoryCount], searchPattern);

				if (searchResult.HasItems())
				{
					folders.AddRange(searchResult);
				}
			}
			catch (Exception ex) when (ex is ArgumentException or ArgumentNullException or ArgumentOutOfRangeException or System.IO.DirectoryNotFoundException or UnauthorizedAccessException)
			{
				Trace.WriteLine(ex.Message);
			}
		}

		return folders;
	}

	/// <summary>
	/// Safe file search. Ignores errors accessing directories.
	/// </summary>
	/// <param name="path">The directory to search.</param>
	/// <param name="searchPattern">The search pattern.</param>
	/// <param name="searchOption">The search options.</param>
	/// <returns>IEnumerable&lt;FileInfo&gt;.</returns>
	[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static IEnumerable<FileInfo> SafeFileSearch(DirectoryInfo path, string searchPattern, SearchOption searchOption)
	{
		var dirs = new List<DirectoryInfo>(1)
		{
			path
		};

		return SafeFileSearch(dirs, searchPattern, searchOption);
	}

	/// <summary>
	/// Safe file search. Ignores errors accessing directories.
	/// </summary>
	/// <param name="directories">The directories to search.</param>
	/// <param name="searchPattern">The search pattern.</param>
	/// <param name="searchOption">The search options.</param>
	/// <returns>IEnumerable&lt;FileInfo&gt;.</returns>
	[Information(nameof(SafeFileSearch), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired, UnitTestCoverage = 100)]
	public static IReadOnlyList<FileInfo> SafeFileSearch([NotNull] IEnumerable<DirectoryInfo> directories, [NotNull] string searchPattern, SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		directories = directories.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		var files = new List<FileInfo>();

		var options = new EnumerationOptions { IgnoreInaccessible = true, ReturnSpecialDirectories = false, RecurseSubdirectories = false };

		if (searchOption == SearchOption.AllDirectories)
		{
			options.RecurseSubdirectories = true;
		}

		directories.ToList().ForEach(directory =>
		{
			try
			{
				if (directory.Exists)
				{
					var directoryFiles = directory.EnumerateFiles(searchPattern, options).ToArray();

					if (directoryFiles.HasItems())
					{
						_ = files.AddRange(directoryFiles, Tristate.True);
					}
				}
			}
			catch (Exception ex) when (ex is System.IO.DirectoryNotFoundException or SecurityException or UnauthorizedAccessException)
			{
				Trace.WriteLine(ex.Message);
			}
		});

		return files;
	}

	/// <summary>
	/// Sets the file attributes to normal for a path.
	/// </summary>
	/// <param name="path">The path.</param>
	[Information(nameof(SetFileAttributesToNormal), "David McCarter", "2/14/2018", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 99)]
	public static void SetFileAttributesToNormal([NotNull] DirectoryInfo path)
	{
		path = path.ArgumentExists();

		var directories = path.GetDirectories();

		for (var directoryCount = 0; directoryCount < path.GetDirectories().Length; directoryCount++)
		{
			SetFileAttributesToNormal(directories[directoryCount]);
		}

		for (var fileCount = 0; fileCount < path.GetDirectories().Length; fileCount++)
		{
			File.SetAttributes(directories[fileCount].FullName, FileAttributes.Normal);
		}
	}
}
