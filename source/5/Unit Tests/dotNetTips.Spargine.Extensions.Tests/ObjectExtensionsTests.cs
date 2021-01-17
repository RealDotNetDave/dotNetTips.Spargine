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
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
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
		public void PropertiesToDictionaryTest()
		{
			var personProper = RandomData.GeneratePersonCollection(1).First();

			var result = personProper.PropertiesToDictionary();

			Assert.IsTrue(result.Count() > 1);
		}

		[TestMethod]
		public void PropertiesToStringTest()
		{
			var personProper = RandomData.GeneratePersonCollection(1).First();

			var result = personProper.PropertiesToString();

			Assert.IsTrue(result.Length > 700);
			Assert.IsTrue(result.Contains("Addresses"));

			var person = RandomData.GeneratePerson<PersonProper>();

			result = person.PropertiesToString();

			Assert.IsTrue(result.Length > 400);
			Assert.IsTrue(result.Contains("Address1"));

			var coordinate = RandomData.GenerateCoordinate<CoordinateProper>();

			result = coordinate.PropertiesToString();

			Assert.IsTrue(result.Length > 25);
			Assert.IsTrue(result.Contains("X"));

			var personCollection = RandomData.GeneratePersonCollection(5);

			Assert.ThrowsException<ArgumentInvalidException>(() => personCollection.PropertiesToString());
		}
	}
}
