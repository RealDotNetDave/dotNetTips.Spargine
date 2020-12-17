// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
// ***********************************************************************
// <copyright file="EnumExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [TestClass]
    public class EnumExtensionsTests
    {
        [TestMethod]
        public void GetDescriptionTest()
        {
            var enumValue = TaskStatus.Canceled;

            var result = enumValue.GetDescription();

            Assert.IsTrue(string.IsNullOrEmpty(result) == false);
        }

        [TestMethod]
        public void GetItemsTest()
        {
            var enumValue = TaskStatus.Canceled;

            var result = enumValue.GetItems();

            Assert.IsTrue(result.Count() > 0);
        }

        [TestMethod]
        public void ParseTest()
        {
            const string EnumName = "Canceled";

            var result = EnumName.Parse<TaskStatus>();

            Assert.IsTrue(result.ToString() == EnumName);

        }
    }
}
