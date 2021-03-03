// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2021
// ***********************************************************************
// <copyright file="TypeHelperTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spartine.Core.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class TypeHelperTests : TestClass
	{

		[TestMethod]
		public void CreateTypeTest()
		{

		}

		[TestMethod]
		public void GetPropertyValuesTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = TypeHelper.GetPropertyValues(person);

			PrintResult(result, nameof(this.GetPropertyValuesTest));

			Assert.IsTrue(result.Count > 5);

			var exTest = new ArgumentOutOfRangeException("TESTPARAM", "TESTMESSAGE");

			result = TypeHelper.GetPropertyValues(exTest);

			Assert.IsTrue(result.Count > 1);
		}

		[TestMethod]
		public void GetTypeDisplayNameTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = TypeHelper.GetTypeDisplayName(person);

			Assert.IsTrue(result == "dotNetTips.Spargine.Tester.Models.PersonProper");

			result = TypeHelper.GetTypeDisplayName(person, true);

			Assert.IsTrue(result == "dotNetTips.Spargine.Tester.Models.PersonProper");

			result = TypeHelper.GetTypeDisplayName(typeof(int), true, true, true, '-');

			Assert.IsTrue(result == "int");
		}
	}
}
