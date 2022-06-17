// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-17-2022
// ***********************************************************************
// <copyright file="SortedSetExtensionsTest.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class SortedSetExtensionsTest
	{

		[TestMethod]
		public void DoesNotHaveItemsTest()
		{
			var collection = new SortedSet<PersonProper>((IEnumerable<PersonProper>)RandomData.GeneratePersonRefCollection<PersonProper>(100));
			SortedSet<PersonProper> nullCollection = null;

			Assert.IsFalse(collection.DoesNotHaveItems());

			Assert.IsTrue(nullCollection.DoesNotHaveItems());
		}

		[TestMethod]
		public void HasItemsTest()
		{
			var collection = new SortedSet<PersonProper>((IEnumerable<PersonProper>)RandomData.GeneratePersonRefCollection<PersonProper>(100));
			SortedSet<PersonProper> nullCollection = null;

			Assert.IsTrue(collection.HasItems());

			Assert.IsFalse(nullCollection.HasItems());
		}

		[TestMethod]
		public void HasItemsWithCountTest()
		{
			var collection = new SortedSet<PersonProper>((IEnumerable<PersonProper>)RandomData.GeneratePersonRefCollection<PersonProper>(100));
			ObservableCollection<Coordinate> nullCollection = null;

			Assert.IsTrue(collection.HasItems(100));

			Assert.IsFalse(collection.HasItems(5));

			Assert.IsFalse(nullCollection.HasItems());
		}

		[TestMethod]
		public void HasItemsWithFunctionTest()
		{
			var collection = new SortedSet<PersonProper>((IEnumerable<PersonProper>)RandomData.GeneratePersonRefCollection<PersonProper>(100));
			ObservableCollection<Coordinate> nullCollection = null;

			Func<PersonProper, bool> selector = (person) => person.Email.IsNotNull();

			Assert.IsTrue(collection.HasItems(selector));

			Assert.IsFalse(nullCollection.HasItems());
		}
		[TestMethod]
		public void ToImmutableTest()
		{
			var peopleSortedSet = new SortedSet<PersonProper>((IEnumerable<PersonProper>)RandomData.GeneratePersonRefCollection<PersonProper>(100));

			var result = peopleSortedSet.ToImmutable();

			Assert.IsNotNull(result);
		}
	}
}
