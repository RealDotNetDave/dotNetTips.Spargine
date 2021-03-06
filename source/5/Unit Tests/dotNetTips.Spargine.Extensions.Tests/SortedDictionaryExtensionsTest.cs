﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2021
// ***********************************************************************
// <copyright file="SortedDictionaryExtensionsTest.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class SortedDictionaryExtensionsTest
	{
		[TestMethod]
		public void ToImmutableTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100).ToDictionary(p => p.Id);

			var peopleSortedSet = new SortedDictionary<string, PersonProper>(people);

			var result = peopleSortedSet.ToImmutable();

			Assert.IsNotNull(result);

			SortedDictionary<string, PersonProper> nullSet = null;

			Assert.ThrowsException<ArgumentNullException>(() => nullSet.ToImmutable());
		}
	}
}
