// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="ObservableCollectionExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ObservableCollectionExtensionsTests
{
	private readonly int _count = 2500;

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(this._count).ToList().ToObservableCollection();
		ObservableCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(this._count).ToList().ToObservableCollection();
		ObservableCollection<Coordinate> nullCollection = null;

		Assert.IsTrue(collection.HasItems(this._count));

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsWithFunctionTest()
	{
		var collection = RandomData.GenerateCoordinateCollection<Coordinate>(this._count).ToList().ToObservableCollection();
		ObservableCollection<Coordinate> nullCollection = null;

		Func<Coordinate, bool> selector = (coordinate) => coordinate.X > 0;

		Assert.IsTrue(collection.HasItems(selector));

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void ToObservableCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(this._count);

		//Test 
		Assert.IsTrue(people.ToObservableCollection().HasItems());
	}

	[TestMethod]
	public void ToReadOnlyObservableCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(this._count);

		//Test 
		Assert.IsTrue(people.ToReadOnlyObservableCollection().HasItems());
	}
}
