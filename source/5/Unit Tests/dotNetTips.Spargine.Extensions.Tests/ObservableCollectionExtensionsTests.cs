// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2021
// ***********************************************************************
// <copyright file="ObservableCollectionExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ObservableCollectionExtensionsTests
	{
		[TestMethod]
		public void HasItemsTest01()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10).ToList().ToObservableCollection();

			Assert.IsTrue(collection.HasItems());
		}

		[TestMethod]
		public void HasItemsTest02()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10).ToList().ToObservableCollection();

			Assert.IsFalse(collection.HasItems(5));
		}

		[TestMethod]
		public void ToObservableCollectionTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);

			//Test 
			Assert.IsTrue(people.ToObservableCollection().HasItems());
		}
	}
}
