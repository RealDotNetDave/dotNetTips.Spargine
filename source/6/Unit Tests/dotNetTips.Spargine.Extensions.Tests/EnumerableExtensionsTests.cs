// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
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

[ExcludeFromCodeCoverage]
[TestClass]
public class EnumerableExtensionsTests
{
	private const int Count = 256;
	private const string TestData = "TEST DATA";

	[TestMethod]
	public void AddTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		var person1 = RandomData.GenerateRefPerson<PersonProper>();

		Assert.IsTrue(people.Add<PersonProper>(person1).Count() == Count + 1);

		Assert.IsTrue(people.Add<PersonProper>(null).Count() == Count);
	}

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

	[TestMethod]
	public void AdTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var person = RandomData.GenerateRefPerson<PersonProper>();

		Assert.IsTrue(people.Add<PersonProper>(null).Count() == Count);

		Assert.IsTrue(people.Add<PersonProper>(person).Count() == Count + 1);
	}

	[TestMethod]
	public void ContainsAnyTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		var people2 = RandomData.GeneratePersonRefCollection<PersonProper>(Count / 2);

		Assert.IsFalse(people1.ContainsAny(people2.ToArray()));

		Assert.IsTrue(people1.AddRange(people2, ensureUnique: Tristate.True));
	}

	[TestMethod]
	public void CountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		Assert.IsTrue(people.Count() == Count);
	}

	[TestMethod]
	public void DoesNotHaveItemsTest()
	{
		var people = new List<PersonProper>().AsEnumerable();

		Assert.IsTrue(people.DoesNotHaveItems());
	}

	[TestMethod]
	public void EnsureUniqueTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).ToList();

		people.Add(people.FirstOrDefault());

		var result = people.EnsureUnique().ToList();

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void FastAnyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		//Test Params
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

		//Test Finding Days of over 100
		Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
	}

	[TestMethod]
	public void FastCountPredicateTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		// Test Params
		_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

		//Test Finding City names that contain 'A'.
		Assert.IsNotNull(people.FastCount(p => p.City.Contains('A', StringComparison.CurrentCultureIgnoreCase)));
	}

	[TestMethod]
	public void FastCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		Assert.IsTrue(people.FastCount() == Count);

		Assert.IsTrue(people.FastCount(p => p.Age.TotalDays > 365) > 0);
	}

	[TestMethod]
	public void FastProcessorTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		people.FastProcessor((PersonProper person) => person.Address2 = TestData);

		Assert.IsTrue(people.All(p => p.Address2 == TestData));
	}

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

	[TestMethod]
	public void FirstOrNullTest()
	{
		var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(Count);
		var searchValue = coordinates.Last().X;

		//Test Finding Days of over 100
		Assert.IsNotNull(coordinates.FirstOrNull(p => p.X == searchValue));
		Assert.IsNull(coordinates.FirstOrNull(p => p.X == int.MinValue));
	}

	[TestMethod]
	public void FromDelimitedStringTest()
	{
		var testValue = ".net, c#, vb, f#";

		//Test
		Assert.IsTrue(testValue.ToDelimitedString(',').HasItems());
		Assert.IsTrue(testValue.ToDelimitedString().HasItems());
		Assert.IsTrue(string.Empty.ToDelimitedString().DoesNotHaveItems());
	}

	[TestMethod]
	public void HasItemsTest()
	{
		var collection = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();
		IEnumerable<PersonProper> nullCollection = null;

		Assert.IsTrue(collection.HasItems());

		Assert.IsFalse(nullCollection.HasItems());
	}

	[TestMethod]
	public void HasItemsWithCountTest()
	{
		var collection = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();
		IEnumerable<PersonProper> nullCollection = null;

		Assert.IsTrue(collection.HasItems(Count));

		Assert.IsFalse(collection.HasItems(100));

		Assert.IsFalse(nullCollection.HasItems(Count));
	}

	[TestMethod]
	public void IndexOfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		var person1 = people.Shuffle(1).First();

		Assert.IsTrue(people.IndexOf(person1).IsNegative() == false);

		Assert.IsTrue(people.IndexOf(person1, new PersonProperComparer()).IsNegative() == false);
	}

	[TestMethod]
	public void IsNullOrEmptyTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.IsNullOrEmpty();

		Assert.IsFalse(result);

		result = people.Take(0).IsNullOrEmpty();

		Assert.IsTrue(result);
	}

	[TestMethod]
	public void JoinTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.Join();

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void OrderByOrdinalTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.OrderByOrdinal(p => p.Email);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void OrderByTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.OrderBy("Email desc");

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void PageTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.Page(10);

		Assert.IsTrue(result.HasItems());
	}

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

	[TestMethod]
	public void PickRandomTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.PickRandom();

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void ShuffleTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		List<PersonProper> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		Assert.IsTrue(people.Shuffle().Count() == Count);
	}

	[TestMethod]
	public void ShuffleWithCountTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		List<PersonProper> nullList = null;

		_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

		Assert.IsTrue(people.Shuffle(5).FastCount() == 5);
	}

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

	[TestMethod]
	public async Task CountAsync()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var peopleCount = await people.CountAsync(CancellationToken.None);

		Assert.IsTrue(peopleCount == Count);
	}

	[TestMethod]
	public void StartsWithTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);
		var people1 = people.Take(5);
		var people2 = people1;

		Assert.IsTrue(people.StartsWith(people.Take(5)));

		Assert.IsTrue(people1.StartsWith(people2));
	}

	[TestMethod]
	public void StructuralSequenceEqualTest()
	{
		var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		var people2 = people1.Clone<List<PersonProper>>();

		Assert.IsFalse(people1.StructuralSequenceEqual(people2));

		Assert.IsTrue(people1.StructuralSequenceEqual(people1));
	}

	[TestMethod]
	public void ToBlockingTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = people.ToBlockingCollection();

		Assert.IsTrue(result.FastCount() == Count);
	}

	[TestMethod]
	public void ToCollectionTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		Assert.IsTrue(people.ToCollection().HasItems());
	}

	[TestMethod]
	public void ToDelimitedStringTest()
	{
		var words = RandomData.GenerateWords(Count, 25, 50);

		Assert.IsNotNull(words.ToDelimitedString(','));
	}

	[TestMethod]
	public void ToImmutableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		Assert.IsTrue(people.ToImmutable().HasItems());
	}

	[TestMethod]
	public void ToLinkedListTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count);

		Assert.IsTrue(people.ToLinkedList().HasItems());
	}

	[TestMethod]
	public async Task ToListAsyncTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

		var result = await people.ToListAsync().ConfigureAwait(false);

		Assert.IsNotNull(result);
	}

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
