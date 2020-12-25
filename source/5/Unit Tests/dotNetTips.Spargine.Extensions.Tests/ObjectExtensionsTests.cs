// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
// ***********************************************************************
// <copyright file="ObjectExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void AsTest()
        {
            var personProper = RandomData.GeneratePerson<PersonFixed>();

            try
            {
                Assert.IsNotNull(personProper.As<IPerson>());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void PropertiesToNamesAndValuesTest()
        {
            var personProper = RandomData.GeneratePerson<PersonProper>();

            var result = personProper.PropertiesToDictionary();

            Assert.IsTrue(result.Count() > 1);
        }

        [TestMethod]
        public void PropertiesToStringTest()
        {
            var personProper = RandomData.GeneratePerson<PersonProper>();

            var result = personProper.PropertiesToString(false);

            Assert.IsTrue(result.Length > 300);
        }
    }
}
