// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2021
// ***********************************************************************
// <copyright file="PathHelperTests.cs" company="dotNetTips.Spargine.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using dotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Tests.IO
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class PathHelperTests
    {

        [TestMethod]
        public void CombinePathsParamsTest()
        {
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            string[] paths = new string[] { basePath, "Test1", "Test2", "Test3" };

            var tempPath = PathHelper.CombinePaths(createIfNotExists: true, paths);

            Assert.IsNotNull(tempPath);
            Assert.IsTrue(tempPath.Exists);

            Directory.Delete(tempPath.FullName);
        }

        [TestMethod]
        public void CombinePathsTest()
        {
            var basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            Assert.IsNotNull(PathHelper.CombinePaths(false, basePath, "TEST1"));
            Assert.IsNotNull(PathHelper.CombinePaths(false, basePath, "TEST2"));
            Assert.IsNotNull(PathHelper.CombinePaths(false, basePath, "TEST3", "TEST3"));
            Assert.IsNotNull(PathHelper.CombinePaths(false, basePath, "TEST4", "TEST4", "TEST4"));

            var tempPath1 = PathHelper.CombinePaths(true, basePath, "TESTPath1");

            Directory.Delete(tempPath1.FullName);
        }

        [TestMethod()]
        public void EnsureTrailingSlashTest()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var result = PathHelper.EnsureTrailingSlash(path);

            Assert.IsTrue(result.EndsWith(Path.DirectorySeparatorChar));

            result = PathHelper.EnsureTrailingSlash(@"C:\Windows\");

            Assert.IsTrue(result.EndsWith(Path.DirectorySeparatorChar));
        }


        [TestMethod()]
        public void HasInvalidFilterCharsTest()
        {
            var filter = "*.*";

            var result = PathHelper.HasInvalidFilterChars(filter);

            Assert.IsFalse(result);

            //Test invalid filter
            filter = $":";

            result = PathHelper.HasInvalidFilterChars(filter);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidFilterCharsTest()
        {
            var result = PathHelper.InvalidFilterChars;

            Assert.IsTrue(result.Count() > 0);
        }

        [TestMethod]
        public void InvalidPathNameCharsTest()
        {
            var result = PathHelper.InvalidPathNameChars;

            Assert.IsTrue(result.Count() > 0);
        }

        [TestMethod()]
        public void PathContainsWildcardTest()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var result = PathHelper.PathContainsWildcard(path);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void PathHasInvalidCharsTest()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            var result = PathHelper.PathHasInvalidChars(path);

            Assert.IsFalse(result);

            //Test invalid path name
            path = $"{path}|";

            result = PathHelper.PathHasInvalidChars(path);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PathSeparatorsTest()
        {
            var result = PathHelper.PathSeparators;

            Assert.IsTrue(result.Count() > 0);
        }
    }
}
