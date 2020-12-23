﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2020
// ***********************************************************************
// <copyright file="SortedSetExtensionsTest.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Utility.Standard.Tester;
using dotNetTips.Utility.Standard.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class SortedSetExtensionsTest
    {
        [TestMethod]
        public void ToImmutableTest()
        {
            var people = RandomData.GeneratePersonCollection<PersonProper>(100);

            var peopleSortedSet = new SortedSet<PersonProper>(people);

            var result = peopleSortedSet.ToImmutable();

            Assert.IsNotNull(result);

            SortedSet<PersonProper> nullSet = null;

            Assert.ThrowsException<ArgumentNullException>(() => nullSet.ToImmutable());
        }
    }
}
