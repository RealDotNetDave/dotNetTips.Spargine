// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2021
// ***********************************************************************
// <copyright file="FileProcessorTests.cs" company="dotNetTips.Spargine.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.IO;
using dotNetTips.Spargine.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Tests.IO
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class FileProcessorTests
    {
        private readonly DirectoryInfo _tempFolder = new(Path.Combine(Environment.GetEnvironmentVariable(EnvironmentKey.TMP.ToString()), "_dotNetTipsUnitTest"));

        [TestMethod]
        public void CopyFilesWithEventTest()
        {
            var processor = new FileProcessor();

            processor.Processed += this.Processor_Processed;

            var files = this.GenerateTempFiles(fileCount: 100, fileLength: 5000);

            processor.CopyFiles(files: files, destinationFolder: new DirectoryInfo(Path.GetTempPath()));

            processor.Processed -= this.Processor_Processed;
        }

        private IEnumerable<FileInfo> GenerateTempFiles(Int32 fileCount, Int32 fileLength)
        {
            var result = RandomData.GenerateFiles(this._tempFolder.FullName, fileCount, fileLength);

            var tempFiles = new List<FileInfo>(fileCount);

            tempFiles.AddRange(result.Select(file => new FileInfo(file)));

            return tempFiles;
        }

        private void Processor_Processed(object sender, FileProgressEventArgs e)
        {
            Debug.WriteLine(e.Message);

            File.Delete(e.Name);
        }
    }
}
