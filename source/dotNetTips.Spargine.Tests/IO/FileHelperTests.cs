// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 03-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-04-2021
// ***********************************************************************
// <copyright file="FileHelperTests.cs" company="dotNetTips.Spargine.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.IO;
using dotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Tests.IO
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class FileHelperTests
	{
		private DirectoryInfo _tempPath;

		[TestMethod]
		public async Task CopyFileAsyncTest()
		{
			try
			{
				var fileToCopy = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetDirectories().Where(p => p.GetFiles().Length > 0).Shuffle().FirstOrDefault().GetFiles().FirstOrDefault();

				var result = await FileHelper.CopyFileAsync(file: fileToCopy, destinationFolder: _tempPath).ConfigureAwait(false);

				Assert.IsTrue(result > 0);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}

		[TestMethod]
		public void CopyFileTest()
		{
			try
			{
				var fileToCopy = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetDirectories().Where(p => p.GetFiles().Length > 0).Shuffle().FirstOrDefault().GetFiles().FirstOrDefault();

				var result = FileHelper.CopyFile(file: fileToCopy, destinationFolder: _tempPath);

				Assert.IsTrue(result > 0);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}

		[TestMethod]
		public void DeleteFilesTest()
		{
			try
			{
				var filesToDelete = RandomData.GenerateFiles(_tempPath.FullName, 100, 500);

				var result = FileHelper.DeleteFiles(filesToDelete);

				Assert.IsTrue(result.Count() == 0);

				Assert.IsNull(FileHelper.DeleteFiles(null));
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}

		[TestMethod]
		public async Task DownloadFileFromWebAsyncTest()
		{
			try
			{
				const string fileToDownload = @"https://dotnettips.files.wordpress.com/2018/03/cropped-rtw-dotnettips-com-logo05x1.png";

				await FileHelper.DownloadFileFromWebAsync(remoteFileUrl: new Uri(fileToDownload), localFilePath: Path.Combine(_tempPath.FullName, "dotNetTips.Com.logo.png")).ConfigureAwait(false);
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}

		[TestMethod]
		public void DownloadFileFromWebTest()
		{
			try
			{
				const string fileToDownload = @"https://dotnettips.files.wordpress.com/2018/03/cropped-rtw-dotnettips-com-logo05x1.png";

				FileHelper.DownloadFileFromWeb(new Uri(fileToDownload), Path.Combine(_tempPath.FullName, "dotNetTips.Com.logo.png"));
			}
			catch (Exception ex)
			{
				Assert.Fail(ex.Message);
			}
		}


		[TestMethod]
		public void FileHasInvalidPathCharsTest()
		{
			var fileName = "dotnettips.config";

			var result = FileHelper.FileHasInvalidChars(fileName);

			Assert.IsFalse(result);

			//Test invalid path
			fileName = $"{fileName}:";

			result = FileHelper.FileHasInvalidChars(fileName);

			Assert.IsTrue(result);

		}

		[TestInitialize]
		public void Initialize()
		{
			_tempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "_DOTNETTIPS-FILEHELPER-TEMP"));

			if (_tempPath.Exists == false)
			{
				_tempPath.Create();
			}
			else
			{
				foreach (var directory in _tempPath.EnumerateDirectories().ToArray())
				{
					directory.Delete();
				}

				var filesToDelete = _tempPath.EnumerateFiles().Select(p => p.FullName);

				if (filesToDelete.HasItems())
				{
					FileHelper.DeleteFiles(filesToDelete);
				}
			}

		}

		[TestMethod]
		public void InvalidFileNameCharsTest()
		{
			Assert.IsTrue(FileHelper.InvalidFileNameChars.HasItems());
		}

		[TestMethod]
		public void MoveFileTest01()
		{
			var file = RandomData.GenerateFile(Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.TEMP.ToString()), $"{RandomData.GenerateKey()}.test"));
			var newFile = Path.Combine(Path.Combine(_tempPath.ToString(), $"{RandomData.GenerateKey()}.moved"));

			FileHelper.MoveFile(file, newFile, FileMoveOptions.ReplaceExisting);
		}

	}
}
