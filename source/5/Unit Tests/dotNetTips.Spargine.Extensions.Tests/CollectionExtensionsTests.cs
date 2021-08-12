// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
// ***********************************************************************
// <copyright file="CollectionExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class CollectionExtensionsTests
	{
		[TestMethod]
		public void AddIfNotExistsComparerTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var person = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;
			var comparer = new PersonProperComparer();
			PersonProperComparer nullComparer = null;
			List<PersonProper> nullList = null;

			// Test Parameters
			_ = Assert.ThrowsException<ArgumentReadOnlyException>(() => people.AsReadOnly().AddIfNotExists(person));
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(person, nullComparer));

			// TEST
			Assert.IsFalse(people.AddIfNotExists(nullPerson));

			Assert.IsTrue(nullList.AddIfNotExists(person));

			Assert.IsFalse(people.AddIfNotExists(nullPerson, nullComparer));

			Assert.IsTrue(people.AddIfNotExists(person));

			Assert.IsFalse(people.AddIfNotExists(nullPerson));

			Assert.IsTrue(people.AddIfNotExists(RandomData.GeneratePerson<PersonProper>(), comparer));

			Assert.IsFalse(people.AddIfNotExists(nullPerson, comparer));

		}

		[TestMethod]
		public void AddIfNotExistsMultipleItemTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var newPeople = RandomData.GeneratePersonCollection<PersonProper>(10);

			_ = people.AddIfNotExists(newPeople.ToArray());
			Assert.IsTrue(people.Count() == 20);

			_ = people.AddIfNotExists(newPeople.ToArray());
			Assert.IsTrue(people.Count() == 20);

			_ = people.AddIfNotExists();
			Assert.IsTrue(people.Count() == 20);
		}

		[TestMethod]
		public void AddIfNotExistsSingleItemTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			PersonProper nullPerson = null;

			// TEST
			Assert.IsFalse(people.AddIfNotExists(nullPerson));

			var testPerson = RandomData.GeneratePerson<PersonProper>();

			Assert.IsTrue(people.AddIfNotExists(testPerson));

			Assert.IsFalse(people.AddIfNotExists(testPerson));
		}

		[TestMethod]
		public void AddIfTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var person = RandomData.GeneratePerson<PersonProper>();

			// TEST
			people.AddIf(person, people.Count() == 10);

			Assert.IsTrue(people.Count() == 11);
		}

		[TestMethod]
		public void AddRangeListTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var newPeople = RandomData.GeneratePersonCollection<PersonProper>(2);

			_ = people.AddRange<PersonProper>(newPeople);

			Assert.IsTrue(people.Count() == 12);

			_ = people.AddRange<PersonProper>(newPeople, Tristate.UseDefault);

			Assert.IsTrue(people.Count() == 12);

			var nullCollection = new List<PersonProper>();

			Assert.IsFalse(people.AddRange<PersonProper>(nullCollection));
		}

		[TestMethod]
		public void DoesNotHaveItemsTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var emptyPeople = new List<PersonProper>();

			Assert.IsFalse(people.DoesNotHaveItems());

			Assert.IsTrue(emptyPeople.DoesNotHaveItems());
		}

		[TestMethod]
		public void HasItemsTest()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10);

			Assert.IsTrue(collection.HasItems());

			Assert.IsTrue(collection.HasItems(10));

			Assert.IsTrue(collection.ToList().HasItems());

			Assert.IsTrue(collection.ToList().HasItems(10));
		}

		[TestMethod]
		public void UpsertTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var personFromCollection = people.Shuffle().First();
			var person = RandomData.GeneratePerson<PersonProper>();
			var personRecords = RandomData.GeneratePersonCollection(10);
			var personRecord = RandomData.GeneratePersonCollection(1).First();

			// TEST
			people.Upsert(person);

			Assert.IsTrue(people.Count() == 11);

			people.Upsert<PersonProper, string>(personFromCollection);

			Assert.IsTrue(people.Count() == 11);

			personRecords.Upsert(personRecord);

			Assert.IsTrue(personRecords.Count() == 11);
		}
	}
}
