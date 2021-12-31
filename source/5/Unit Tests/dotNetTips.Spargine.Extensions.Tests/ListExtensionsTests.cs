// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-02-2021
// ***********************************************************************
// <copyright file="ListExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using dotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ListExtensionsTests
	{

		[TestMethod]
		public void AddIfNotExistsTwoListsTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(20).ToArray();

			people = people.AddIfNotExists(null);
			Assert.IsTrue(people.Count() == 20);

			var newPeople = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

			people = people.AddIfNotExists(newPeople);
			Assert.IsTrue(people.Count() == 30);

			people = people.AddIfNotExists(newPeople);
			Assert.IsTrue(people.Count() == 30);
		}

		[TestMethod]
		public void AddLastTest()
		{
			var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
			var peopleArray = peopleList.ToArray();
			var person = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;

			//Test Parameters
			_ = Assert.ThrowsException<NotSupportedException>(() => peopleList.ToReadOnlyCollection()
				.AddLast(person));

			// Test List
			peopleList.AddLast(nullPerson);
			Assert.IsTrue(peopleList.Count() == peopleList.Count());

			peopleList.AddLast(person);
			Assert.IsTrue(peopleList.Last().Equals(person));


			// Test Array
			var result2 = peopleArray.AddLast(person);
			Assert.IsTrue(result2.Last().Equals(person));
			Assert.IsTrue(peopleArray.AddLast(null).Length == peopleArray.Length);
		}
		[TestMethod]
		public void ClearNullListTest()
		{
			var count = RandomData.GenerateInteger(10, 500);
			var people = RandomData.GeneratePersonCollection<PersonProper>(count);

			people.Add(null);

			Assert.IsTrue(people.ClearNulls());

			Assert.IsFalse(people.ClearNulls());

			Assert.IsFalse(new List<PersonProper>(10).ClearNulls());
		}
		[TestMethod]
		public void CopyToListTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var newPeople = people.CopyToList();

			Assert.IsTrue(people.Count == newPeople.Count);
		}

		[TestMethod]
		public void HasItemsTest01()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10);

			Assert.IsTrue(collection.ToList().HasItems());
		}

		[TestMethod]
		public void HasItemsTest02()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10);

			Assert.IsFalse(collection.ToList().HasItems(p => p.X == 999999999));
		}

		[TestMethod]
		public void HasItemsTest03()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10);

			Assert.IsFalse(collection.ToList().HasItems(5));
		}

		[TestMethod]
		public void IndexOfTest()
		{
			var peopleList = RandomData.GeneratePersonCollection<PersonProper>(10);
			var testPerson = peopleList[5];

			//Test Parameters
			_ = Assert.ThrowsException<NullReferenceException>(() => peopleList.IndexOf(testPerson, null));
			_ = Assert.ThrowsException<NullReferenceException>(() => peopleList.IndexOf(null, new PersonProperComparer()));

			// Test 
			Assert.IsTrue(peopleList.IndexOf(testPerson, new PersonProperComparer()) >= 0);
		}
		[TestMethod]
		public void ListHashCodeTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);

			var result = people.ListHashCode();

			Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

			result = people.ToArray().ListHashCode();

			Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));

			result = people.ToReadOnlyCollection().ListHashCode();

			Assert.IsTrue(result.IsInRange(int.MinValue, int.MaxValue));
		}

		[TestMethod]
		public void PagingTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100);
			const int PageCount = 10;
			var peopleCount = 0;
			var loopedCount = 0;

			foreach (var peoplePage in people.Page(PageCount))
			{
				loopedCount++;
				peopleCount += peoplePage.Count();
			}

			Assert.IsTrue(peopleCount == 100);

			Assert.IsTrue(loopedCount == 10);
		}

		[TestMethod]
		public void PickRandomTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);

			var result = people.PickRandom();

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void RemoveFirstTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

			Assert.IsTrue(people.RemoveFirst().Count() == 9);
		}

		[TestMethod]
		public void RemoveLastTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

			Assert.IsTrue(people.RemoveLast().Count() == 9);
		}

		[TestMethod]
		public void ShuffleImmutableArrayTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToImmutable();
			List<PersonProper> nullList = null;

			_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

			var shuffledPeople = people.Shuffle();

			Assert.IsTrue(people.Count == shuffledPeople.Count());
		}

		[TestMethod]
		public void ShuffleTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			List<PersonProper> nullList = null;
			_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

			var shuffleCount = people.Shuffle().Count();

			Assert.IsTrue(people.Count == shuffleCount);
		}

		[TestMethod]
		public void ToCollectionTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100);

			var result = people.ToCollection();

			Assert.IsNotNull(result);

			Assert.IsTrue(result.Count() == 100);
		}

		[TestMethod]
		public void ToObservableListTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100);

			var result = people.ToObservableList();

			Assert.IsNotNull(result);

			Assert.IsTrue(result.Count() == 100);
		}

		[TestMethod]
		public void ToFastSortedListTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100);

			var result = people.ToFastSortedList();

			Assert.IsNotNull(result);

			Assert.IsTrue(result.Count() == 100);
		}

		[TestMethod]
		public void ToDistinctConcurrentBagTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100);

			var result = people.ToDistinctConcurrentBag();

			Assert.IsNotNull(result);

			Assert.IsTrue(result.Count() == 100);
		}

		[TestMethod]
		public void ToDistinctBlockingCollectionTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100);

			var result = people.ToDistinctBlockingCollection(true);

			Assert.IsNotNull(result);

			Assert.IsTrue(result.Count() == 100);

			Assert.IsTrue(result.IsAddingCompleted);
		}

		[TestMethod]
		public void ToImmutableArrayTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100);

			var result = people.ToImmutableArray();

			Assert.IsNotNull(result);

			Assert.IsTrue(result.Count() == 100);
		}
	}
}
