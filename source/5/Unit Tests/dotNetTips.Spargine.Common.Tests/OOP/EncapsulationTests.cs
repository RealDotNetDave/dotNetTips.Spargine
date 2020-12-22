// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-26-2020
// ***********************************************************************
// <copyright file="EncapsulationTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.IO;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Collections;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests.OOP
{
    [TestClass]
    public class EncapsulationTests
    {
        private const string _badEmail = "BADEMAIL";
        private const string _badUrl = "123://www.amazon.com";
        private const string _goodEmail = "fakeemail@google.com";
        private const string _goodUrl = "http://www.amazon.com";

        [TestMethod]
        public void TryValidateParamCollectionTest()
        {
            try
            {
                var people = RandomData.GeneratePersonCollection<PersonProper>(10);
                Encapsulation.TryValidateParam(people, nameof(people));
            }
            catch
            {
                Assert.Fail();
            }

            // Test null collection
            PersonCollection<PersonProper> nullPeople = null;
            Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(nullPeople, "none"));

        }

        [TestMethod]
        public void TryValidateParamConditionTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(10);

            try
            {
                Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(people.Count == 10, "None");
            }
            catch
            {
                Assert.Fail();
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam<ArgumentOutOfRangeException>(people.Count == 100, "none"));
        }

        [TestMethod]
        public void TryValidateParamDirectoryInfoTest()
        {
            var directoryName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var directoryInfo = new DirectoryInfo(directoryName);

            try
            {
                Encapsulation.TryValidateParam(directoryInfo, "None");
            }
            catch
            {
                Assert.Fail();
            }

            DirectoryInfo nullDirectoryInfo = null;
            Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(nullDirectoryInfo, "none"));

            Assert.ThrowsException<Spargine.Core.DirectoryNotFoundException>(() => Encapsulation.TryValidateParam(new DirectoryInfo("fakefile"), "none"));
        }

        [TestMethod]
        public void TryValidateParamEnumTest()
        {
            var value = BenchMarkStatus.Completed;

            try
            {
                Encapsulation.TryValidateParam(value, "none");
            }
            catch
            {
                Assert.Fail();
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Encapsulation.TryValidateParam((BenchMarkStatus)100, "none"));
        }

        [TestMethod]
        public void TryValidateParamFileInfoTest()
        {
            var fileName = @"c:\temp\tempfileinfotest.dat";
            var file = RandomData.GenerateFile(fileName, 100);
            var fileInfo = new FileInfo(fileName);

            try
            {
                Encapsulation.TryValidateParam(fileInfo, "None");
            }
            catch
            {
                Assert.Fail();
            }

            FileInfo nullFileInfo = null;
            Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(nullFileInfo, "none"));

            Assert.ThrowsException<FileNotFoundException>(() => Encapsulation.TryValidateParam(new FileInfo("fakefile"), "none"));
        }

        [TestMethod]
        public void TryValidateParamGuidTest()
        {
            var value = Guid.NewGuid();

            try
            {
                Encapsulation.TryValidateParam(value, "none");
            }
            catch
            {
                Assert.Fail();
            }

            Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(Guid.Empty, "none"));
        }

        [TestMethod]
        public void TryValidateParamStringEmailTest()
        {
            try
            {
                Encapsulation.TryValidateParam(_goodEmail, StringType.Email, 0, 100, "none");
            }
            catch
            {
                Assert.Fail();
            }


            Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(_goodEmail, StringType.Email, 50, 100, "none"));

            Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(_goodEmail, StringType.Email, 0, 5, "none"));

            Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(_badEmail, StringType.Email, 0, 100, "none"));


        }

        [TestMethod]
        public void TryValidateParamStringTest()
        {
            var testString = RandomData.GenerateWord(100);
            try
            {
                Encapsulation.TryValidateParam(testString, "none");
            }
            catch
            {
                Assert.Fail();
            }

            Assert.ThrowsException<ArgumentNullException>(() => Encapsulation.TryValidateParam(string.Empty, "none"));
        }

        [TestMethod]
        public void TryValidateParamStringUrlTest()
        {
            try
            {
                Encapsulation.TryValidateParam(_goodUrl, StringType.Url, 0, 100, "none");
            }
            catch
            {
                Assert.Fail();
            }

            Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(_badUrl, StringType.Url, 0, 100, "none"));
        }

        [TestMethod]
        public void TryValidateParamUriTest()
        {
            var url = @"http://dotnettips.com";
            var uri = new Uri(url);

            try
            {
                Encapsulation.TryValidateParam(uri, "None");
            }
            catch
            {
                Assert.Fail();
            }

            Uri nullUri = null;
            Assert.ThrowsException<ArgumentInvalidException>(() => Encapsulation.TryValidateParam(nullUri, "none"));
        }

    }
}