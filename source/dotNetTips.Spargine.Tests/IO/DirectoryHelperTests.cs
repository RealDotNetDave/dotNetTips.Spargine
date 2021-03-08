// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 03-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-07-2021
// ***********************************************************************
// <copyright file="DirectoryHelperTests.cs" company="dotNetTips.Spargine.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.IO;
using dotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Tests.IO
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class DirectoryHelperTests
    {
        private DirectoryInfo _tempPath;

        [TestMethod]
        public void AppDataFolderTest()
        {
            var folder = DirectoryHelper.AppDataFolder();

            Assert.IsTrue(string.IsNullOrEmpty(folder) == false);
        }

        [TestMethod]
        public void CopyAndDeleteDirectoryTest()
        {
            var destinationPath = Path.Combine(this._tempPath.FullName, nameof(this.CopyAndDeleteDirectoryTest));

            var sourcePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "dotNetTips.com-" + DateTime.Now.Ticks);

            var generatedFiles = RandomData.GenerateFiles(sourcePath, 500, 5000);

            try
            {
                DirectoryHelper.CopyDirectory(sourcePath, destinationPath, false);

                DirectoryHelper.DeleteDirectory(destinationPath, 3);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                DirectoryHelper.DeleteDirectory(sourcePath, 3);
            }
        }

        [TestMethod]
        public void CopyAndMoveDirectoryTest()
        {
            var destinationPath = Path.Combine(this._tempPath.FullName, nameof(this.CopyAndMoveDirectoryTest));
            var folderToCopy = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).GetDirectories()
                .Where(p => p.GetFiles().Count() > 0)
                .Shuffle()
                .FirstOrDefault();

            try
            {
                DirectoryHelper.CopyDirectory(folderToCopy.FullName, this._tempPath.FullName, false);
                DirectoryHelper.MoveDirectory(folderToCopy.FullName, destinationPath, 5);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                DirectoryHelper.DeleteDirectory(destinationPath);
            }
        }

        [TestInitialize]
        public void Initialize()
        {
            this._tempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), "_DOTNETTIPS-DIRECTORYHELPER-TEST"));

            if (this._tempPath.Exists == false)
            {
                this._tempPath.Create();
            }
            else
            {
                var array = this._tempPath.EnumerateDirectories().ToArray();

                foreach (var directory in array)
                {
                    DirectoryHelper.DeleteDirectory(directory.FullName);
                }

                FileHelper.DeleteFiles(this._tempPath.EnumerateFiles().Select(p => p.FullName));
            }
        }

        [TestMethod]
        public void LoadFilesTest()
        {
            var searchFolders = new List<DirectoryInfo>();

            try
            {
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));

                var returnCount = 0;

                foreach (var file in DirectoryHelper.LoadFiles(searchFolders, "*.*", SearchOption.AllDirectories))
                {
                    returnCount++;
                }

                Assert.IsTrue(returnCount > 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LoadOneDriveFoldersTest()
        {
            var folders = DirectoryHelper.LoadOneDriveFolders();

            Assert.IsTrue(folders != null && folders.Count() > 0);
        }

        [TestMethod]
        public void SafeDirectorySearchTest()
        {
            var searchFolders = new List<DirectoryInfo>();

            try
            {
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));
                searchFolders.Add(new DirectoryInfo(Environment.GetEnvironmentVariable(EnvironmentKey.TEMP.ToString())));

                var directories = new List<DirectoryInfo>();

                foreach (var directory in searchFolders)
                {
                    directories.AddRange(DirectoryHelper.SafeDirectorySearch(directory));
                }

                Assert.IsTrue(directories.Count > 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void SafeFileSearchTest()
        {
            var searchFolders = new List<DirectoryInfo>();

            try
            {
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
                searchFolders.Add(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));
                searchFolders.Add(new DirectoryInfo(Environment.GetEnvironmentVariable(EnvironmentKey.TEMP.ToString())));


                var searchResult = DirectoryHelper.SafeFileSearch(searchFolders, "*.*", SearchOption.AllDirectories);

                Assert.IsTrue(searchResult.HasItems());
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
