﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-10-2020
// ***********************************************************************
// <copyright file="EnumHelperTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System.Net.Cache;
using dotNetTips.Spargine.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests
{
    [TestClass]
    public class EnumHelperTests
    {

        [TestMethod]
        public void AddToPersonCollectionTest()
        {
            var result = EnumHelper.GetEnumValues<RequestCacheLevel>(false, false);
            Assert.IsTrue(result.Count > 0);

            result = EnumHelper.GetEnumValues<HttpCacheAgeControl>(true, false);
            Assert.IsTrue(result.Count > 0);

            result = EnumHelper.GetEnumValues<HttpCacheAgeControl>(false, true);
            Assert.IsTrue(result.Count > 0);

            result = EnumHelper.GetEnumValues<HttpCacheAgeControl>(true, true);
            Assert.IsTrue(result.Count > 0);
        }

    }
}
