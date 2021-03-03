// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 03-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-03-2021
// ***********************************************************************
// <copyright file="FileHelperTests.cs" company="dotNetTips.Spargine.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                var directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                var fileToCopy = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetDirectories().Where(p => p.GetFiles().Count() > 0).Shuffle().FirstOrDefault().GetFiles().FirstOrDefault();

                var result = await FileHelper.CopyFileAsync(file: fileToCopy, destinationFolder: this._tempPath).ConfigureAwait(true);

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
                var directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                var fileToCopy = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetDirectories().Where(p => p.GetFiles().Count() > 0).Shuffle().FirstOrDefault().GetFiles().FirstOrDefault();

                var result = FileHelper.CopyFile(fileToCopy, this._tempPath);

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
                var filesToCopy = new DirectoryInfo(Environment.CurrentDirectory).GetFiles("*.*", SearchOption.AllDirectories).Shuffle().Take(5);

                var filesCopied = new List<FileInfo>(filesToCopy.Count());

                foreach (var file in filesToCopy)
                {
                    filesCopied.Add(file.CopyTo(Path.Combine(this._tempPath.FullName, file.Name), true));
                }

                var result = FileHelper.DeleteFiles(filesCopied.Select(p => p.FullName));

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

                await FileHelper.DownloadFileFromWebAsync(new Uri(fileToDownload), Path.Combine(this._tempPath.FullName, "dotNetTips.Com.logo.png"));
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

                FileHelper.DownloadFileFromWeb(new Uri(fileToDownload), Path.Combine(this._tempPath.FullName, "dotNetTips.Com.logo.png"));
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
            this._tempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "_DOTNETTIPS-FILEHELPER-TEST"));

            if (this._tempPath.Exists == false)
            {
                this._tempPath.Create();
            }
            else
            {
                foreach (var directory in this._tempPath.EnumerateDirectories().ToArray())
                {
                    directory.Delete();
                }

                var filesToDelete = this._tempPath.EnumerateFiles().Select(p => p.FullName);

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

    }
}
