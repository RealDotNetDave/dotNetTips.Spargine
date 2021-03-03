// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-01-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-01-2021
// ***********************************************************************
// <copyright file="DirectoryHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Win32;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.IO
{
	public static class DirectoryHelper
	{
		/// <summary>
		/// Load files as an asynchronous operation.
		/// </summary>
		/// <param name="directories">The directories.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="searchOption">The search option.</param>
		/// <returns>IAsyncEnumerable&lt;IEnumerable&lt;FileInfo&gt;&gt;.</returns>
		[Information(nameof(LoadFilesAsync), author: "David McCarter", createdOn: "3/1/2021", UnitTestCoverage = 0, Status = Status.New)]
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
		/// <exception cref="PlatformNotSupportedException">The method only supports Windows.</exception>
		[Information(nameof(LoadOneDriveFolders), author: "David McCarter", createdOn: "3/1/2021", UnitTestCoverage = 0, Status = Status.New)]
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

			var oneDriveKey = RegistryHelper.GetCurrentUserRegistryKey(RegistryHelper.KeyCurrentUserOneDrive);

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
	}
}
