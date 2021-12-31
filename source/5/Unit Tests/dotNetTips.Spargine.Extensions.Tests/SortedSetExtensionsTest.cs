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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
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
		}
	}
}
