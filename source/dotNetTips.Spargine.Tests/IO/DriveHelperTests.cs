// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Tests
// Author           : David McCarter
// Created          : 03-15-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2021
// ***********************************************************************
// <copyright file="DriveHelperTests.cs" company="dotNetTips.Spargine.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Tests.IO
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class DriveHelperTests
    {
        [TestMethod]
        public void GetDriveSerialNumberTest()
        {
            var drive = DriveHelper.GetFixedDrives().First();
            Assert.IsNotNull(DriveHelper.GetDriveSerialNumber(drive.Name));
        }

        [TestMethod]
        public void GetFixedDrivesTest()
        {
            var result = DriveHelper.GetFixedDrives();

            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void GetRemovableDrivesTest()
        {
            var result = DriveHelper.GetRemovableDrives();

            Assert.IsNotNull(result);
        }
    }
}
