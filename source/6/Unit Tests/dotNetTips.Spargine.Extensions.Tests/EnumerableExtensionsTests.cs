// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-10-2023
// ***********************************************************************
// <copyright file="EnumerableExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetTips.Spargine.Extensions.Tests;

/// <summary>
/// Defines test class EnumerableExtensionsTests.
/// </summary>
[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerableExtensionsTests
{

	/// <summary>
	/// The count
	/// </summary>
	private const int Count = 256;
	/// <summary>
	/// The test data
	/// </summary>
	private const string TestData = "TEST DATA";

	/// <summary>
	/// Defines the test method AddTest.
	/// </summary>
	[TestMethod]
	public void AddTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		var person1 = RandomData.GenerateRefPerson<PersonProper>();

		Assert.IsTrue(people.Add<PersonProper>(person1).Count() == Count + 1);

		Assert.IsTrue(people.Add<PersonProper>(null).Count() == Count);
	}

	/// <summary>
	/// Defines the test method AdIfTest.
	/// </summary>
	[TestMethod]
	public void AdIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var person = RandomData.GenerateRefPerson<PersonProper>();

		var result = people.AddIf(person, true);

		Assert.IsTrue(result.FastCount() == people.Count() + 1);

		result = people.AddIf(person, false);

		Assert.IsTrue(result.FastCount() == Count);
	}

	/// <summary>
	/// Defines the test method AdTest.
	/// </summary>
	[TestMethod]
	public void AdTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var person = RandomData.GenerateRefPerson<PersonProper>();

		Assert.IsTrue(people.Add(null).Count() == Count);

		Assert.IsTrue(people.Add(person).Count() == Count + 1);
	}

	/// <summary>
	/// Defines the test method ContainsAnyTest.
	/// </summary>
	[TestMethod]
	public void ContainsAnyTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		var people2 = RandomData.GeneratePersonRefCollection<PersonProper>(Count / 2);

		Assert.IsFalse(people1.ContainsAny(people2.ToArray()));

		Assert.IsTrue(people1.AddRange(people2, ensureUnique: Tristate.True));
	}

	/// <summary>
	/// Count as an asynchronous operation.
	/// </summary>
	/// <returns>A Task representing the asynchronous operation.</returns>
	[TestMethod]
	public async Task CountAsync()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var peopleCount = await people.CountAsync(CancellationToken.None);

		Assert.IsTrue(peopleCount == Count);
	}

	/// <summary>
	/// Defines the test method CountTest.
	/// </summary>
	[TestMethod]
	public void CountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		Assert.IsTrue(people.Count() == Count);
	}

	/// <summary>
	/// Defines the test method DoesNotHaveItemsTest.
	/// </summary>
	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = new List<PersonProper>().AsEnumerable();

		Assert.IsTrue(people.DoesNotHaveItems());
	}

	/// <summary>
	/// Defines the test method EnsureUniqueTest.
	/// </summary>
	[TestMethod]
	public void EnsureUniqueTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).ToList();

		people.Add(people.FirstOrDefault());

		var result = people.EnsureUnique().ToList();

		Assert.IsTrue(result.FastCount() == Count);
	}

	/// <summary>
	/// Defines the test method FastAnyTest.
	/// </summary>
	[TestMethod]
	public void FastAnyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		//Test Params
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

		//Test Finding Days of over 100
		Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
	}

	/// <summary>
	/// Defines the test method FastCountPredicateTest.
	/// </summary>
	[TestMethod]
	public void FastCountPredicateTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		// Test Params
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

		//Test Finding City names that contain 'A'.
		Assert.IsNotNull(people.FastCount(p => p.City.Contains('A', StringComparison.CurrentCultureIgnoreCase)));
	}

	/// <summary>
	/// Defines the test method FastCountTest.
	/// </summary>
	[TestMethod]
	public void FastCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		Assert.IsTrue(people.FastCount() == Count);

		Assert.IsTrue(people.FastCount(p => p.Age.TotalDays > 365) > 0);
	}

	/// <summary>
	/// Defines the test method FastProcessorTest.
	/// </summary>
	[TestMethod]
	public void FastProcessorTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		people.FastProcessor((PersonProper person) => person.Address2 = TestData);

		Assert.IsTrue(people.All(p => p.Address2 == TestData));
	}

	/// <summary>
	/// Defines the test method FirstOrDefaultTest.
	/// </summary>
	[TestMethod]
	public void FirstOrDefaultTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		var person1 = RandomData.GenerateRefPerson<PersonProper>();

		_ = people.Add<PersonProper>(person1);

		//Test Finding item in collection
		Assert.IsNotNull(people.FirstOrDefault(person1) == person1);
		Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 2500, person1).Equals(person1));
		Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 50000, person1).Equals(person1));
	}

	/// <summary>
	/// Defines the test method FirstOrNullTest.
	/// </summary>
	[TestMethod]
	public void FirstOrNullTest()
	{
		var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(Count);
		var searchValue = coordinates.Last().X;

		//Test Finding Days of over 100
		Assert.IsNotNull(coordinates.FirstOrNull(p => p.X == searchValue));
		Assert.IsNull(coordinates.FirstOrNull(p => p.X == int.MinValue));
	}

	/// <summary>
	/// Defines the test method FromDelimitedStringTest.
	/// </summary>
	[TestMethod]
	public void FromDelimitedStringTest()
	{
		var testValue = ".net, c#, vb, f#";

		//Test
		Assert.IsTrue(testValue.ToDelimitedString(',').HasItems());
		Assert.IsTrue(testValue.ToDelimitedString().HasItems());
		Assert.IsTrue(string.Empty.ToDelimitedString().DoesNotHaveItems());
	}

	/// <summary>
	/// Defines the test method HasDuplicatesTest.
	/// </summary>
	[TestMethod]
	public void HasDuplicatesTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		Assert.IsFalse(people.HasDuplicates());

		var dups = people.Shuffle().Take(Count / 10).ToList();

		foreach (var person in dups)
		{
			_ = people.AddLast(person);
		}

		var result = people.HasDuplicates();
		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method HasItemsTest.
	/// </summary>
	[TestMethod]
	public void HasItemsTest()
	{
		var collection = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();
		IEnumerable<PersonProper> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	/// <summary>
	/// Defines the test method HasItemsWithCountTest.
	/// </summary>
	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();
		IEnumerable<PersonProper> nullCollection = null;

		Assert.IsTrue(collection.HasItems(Count));

		Assert.IsFalse(collection.HasItems(100));

		Assert.IsFalse(nullCollection.HasItems(Count));
	}

	/// <summary>
	/// Defines the test method IndexOfTest.
	/// </summary>
	[TestMethod]
	public void IndexOfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		var person1 = people.Shuffle(1).First();

		Assert.IsTrue(people.IndexOf(person1).IsNegative() == false);

		Assert.IsTrue(people.IndexOf(person1, new PersonProperComparer()).IsNegative() == false);
	}

	/// <summary>
	/// Defines the test method IsNullOrEmptyTest.
	/// </summary>
	[TestMethod]
	public void IsNullOrEmptyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.IsNullOrEmpty();

		Assert.IsFalse(result);

		result = people.Take(0).IsNullOrEmpty();

		Assert.IsTrue(result);
	}

	/// <summary>
	/// Defines the test method JoinTest.
	/// </summary>
	[TestMethod]
	public void JoinTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.Join();

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	/// <summary>
	/// Defines the test method OrderByOrdinalTest.
	/// </summary>
	[TestMethod]
	public void OrderByOrdinalTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.OrderByOrdinal(p => p.Email);

		Assert.IsTrue(result.HasItems());
	}

	/// <summary>
	/// Defines the test method OrderByTest.
	/// </summary>
	[TestMethod]
	public void OrderByTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.OrderBy("Email desc");

		Assert.IsTrue(result.HasItems());
	}

	/// <summary>
	/// Defines the test method PageTest.
	/// </summary>
	[TestMethod]
	public void PageTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.Page(10);

		Assert.IsTrue(result.HasItems());
	}

	/// <summary>
	/// Defines the test method PartitionTest.
	/// </summary>
	[TestMethod]
	public void PartitionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var splitPeople = people.Partition(people.Count() / 10);

		Assert.IsNotNull(splitPeople);
		Assert.IsTrue(splitPeople.Count() == 11);

		var emptyPeople = new List<PersonProper>();

		var splitEmptyPeople = emptyPeople.Partition(10);

		Assert.IsNotNull(splitEmptyPeople);

	}

	/// <summary>
	/// Defines the test method PickRandomTest.
	/// </summary>
	[TestMethod]
	public void PickRandomTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.PickRandom();

		Assert.IsNotNull(result);
	}

	/// <summary>
	/// Defines the test method RemoveDuplicatesTest.
	/// </summary>
	[TestMethod]
	public void RemoveDuplicatesTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		var dups = people.Shuffle().Take(Count / 10).ToList();

		foreach (var person in dups)
		{
			_ = people.AddLast(person);
		}

		var result = people.RemoveDuplicates();
		Assert.IsTrue(result.IsSuccessful);
		Assert.IsTrue(result.Value.Count() == Count);
	}

	/// <summary>
	/// Defines the test method ShuffleTest.
	/// </summary>
	[TestMethod]
	public void ShuffleTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		List<PersonProper> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		Assert.IsTrue(people.Shuffle().Count() == Count);
	}

	/// <summary>
	/// Defines the test method ShuffleWithCountTest.
	/// </summary>
	[TestMethod]
	public void ShuffleWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		List<PersonProper> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		Assert.IsTrue(people.Shuffle(5).FastCount() == 5);
	}

	/// <summary>
	/// Defines the test method SplitTest.
	/// </summary>
	[TestMethod]
	public void SplitTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var splitPeople = people.Split(Count / 10);

		Assert.IsNotNull(splitPeople);
		Assert.IsTrue(splitPeople.Count() == 24);

		var emptyPeople = new List<PersonProper>();

		var splitEmptyPeople = emptyPeople.Split(10);

		Assert.IsNull(splitEmptyPeople);
	}

	/// <summary>
	/// Defines the test method StartsWithTest.
	/// </summary>
	[TestMethod]
	public void StartsWithTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		var people1 = people.Take(5);
		var people2 = people1;

		Assert.IsTrue(people.StartsWith(people.Take(5)));

		Assert.IsTrue(people1.StartsWith(people2));
	}

	/// <summary>
	/// Defines the test method StructuralSequenceEqualTest.
	/// </summary>
	[TestMethod]
	public void StructuralSequenceEqualTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		var people2 = people1.Clone<List<PersonProper>>();

		Assert.IsFalse(people1.StructuralSequenceEqual(people2));

		Assert.IsTrue(people1.StructuralSequenceEqual(people1));
	}

	/// <summary>
	/// Defines the test method ToBlockingTest.
	/// </summary>
	[TestMethod]
	public void ToBlockingTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.ToBlockingCollection();

		Assert.IsTrue(result.FastCount() == Count);
	}

	/// <summary>
	/// Defines the test method ToCollectionTest.
	/// </summary>
	[TestMethod]
	public void ToCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		Assert.IsTrue(people.ToCollection().HasItems());
	}

	/// <summary>
	/// Defines the test method ToDelimitedStringTest.
	/// </summary>
	[TestMethod]
	public void ToDelimitedStringTest()
	{
		var words = RandomData.GenerateWords(Count, 25, 50);

		Assert.IsNotNull(words.ToDelimitedString(','));
	}

	/// <summary>
	/// Defines the test method ToImmutableTest.
	/// </summary>
	[TestMethod]
	public void ToImmutableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		Assert.IsTrue(people.ToImmutable().HasItems());
	}

	/// <summary>
	/// Defines the test method ToLinkedListTest.
	/// </summary>
	[TestMethod]
	public void ToLinkedListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		Assert.IsTrue(people.ToLinkedList().HasItems());
	}

	/// <summary>
	/// Defines the test method ToListAsyncTest.
	/// </summary>
	[TestMethod]
	public async Task ToListAsyncTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = await people.ToListAsync().ConfigureAwait(false);

		Assert.IsNotNull(result);
	}

	/// <summary>
	/// Defines the test method UpsertTest.
	/// </summary>
	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var personFromCollection = people.Shuffle().First();

		var person = RandomData.GenerateRefPerson<PersonProper>();

		var result = people.Upsert(person);

		Assert.IsTrue(result.FastCount() == people.Count() + 1);

		result = people.Upsert(personFromCollection);

		Assert.IsTrue(result.FastCount() == Count);
	}

}
