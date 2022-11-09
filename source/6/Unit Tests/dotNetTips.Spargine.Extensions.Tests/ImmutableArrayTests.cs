// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 10-06-2022
// ***********************************************************************
// <copyright file="ImmutableArrayTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Immutable;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests
{
	[TestClass]
	public class ImmutableArrayTests
	{

		[TestMethod]
		public void HasItemsTest01()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(2500).ToImmutable();
			ImmutableList<Coordinate> nullCollection = null;

			Assert.IsTrue(collection.HasItems());

			Assert.IsFalse(nullCollection.HasItems());
		}

		[TestMethod]
		public void HasItemsTest02()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(2500).ToImmutableArray();
			Func<Coordinate, bool> selector = (coordinate) => coordinate.X > 0;

			Assert.IsTrue(collection.HasItems(selector));

			Assert.IsFalse(collection.HasItems(null));
		}

		[TestMethod]
		public void HasItemsTestWithCount()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(2500).ToImmutable();
			ImmutableList<Coordinate> nullCollection = null;

			Assert.IsFalse(collection.HasItems(5));

			Assert.IsFalse(nullCollection.HasItems());
		}
		[TestMethod]
		public void ImmutableArrayTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(2500).ToHashSet().ToImmutable();
			var copyPeople = people;
			Assert.IsTrue(people == copyPeople);
			Assert.IsFalse(people == copyPeople.Shuffle());
		}
	}
}
