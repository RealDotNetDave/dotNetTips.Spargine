// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
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
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class CollectionExtensionsTests
	{
		[TestMethod]
		public void AddIfNotExists()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var person = RandomData.GenerateRefPerson<PersonProper>();
			PersonProper nullPerson = null;
			var comparer = new PersonProperComparer();
			PersonProperComparer nullComparer = null;
			List<PersonProper> nullList = null;

			// TEST
			Assert.IsFalse(people.AddIfNotExists(nullPerson));

			Assert.ThrowsException<ArgumentNullException>(() => _ = nullList.AddIfNotExists(person));

			Assert.IsFalse(people.AddIfNotExists(nullPerson, nullComparer));

			Assert.IsTrue(people.AddIfNotExists(person));

			Assert.IsFalse(people.AddIfNotExists(nullPerson));

			Assert.IsTrue(people.AddIfNotExists(RandomData.GenerateRefPerson<PersonProper>(), comparer));

			Assert.IsFalse(people.AddIfNotExists(nullPerson, comparer));

		}

		[TestMethod]
		public void AddIfNotExistsMultipleItemTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var newPeople = RandomData.GeneratePersonRefCollection<PersonProper>(10);

			_ = people.AddIfNotExists(newPeople.ToArray());
			Assert.IsTrue(people.FastCount() == 20);

			_ = people.AddIfNotExists(newPeople.ToArray());
			Assert.IsTrue(people.FastCount() == 20);

			_ = people.AddIfNotExists();
			Assert.IsTrue(people.FastCount() == 20);
		}

		[TestMethod]
		public void AddIfNotExistsSingleItemTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			PersonProper nullPerson = null;

			// TEST
			Assert.IsFalse(people.AddIfNotExists(nullPerson));

			var testPerson = RandomData.GenerateRefPerson<PersonProper>();

			Assert.IsTrue(people.AddIfNotExists(testPerson));

			Assert.IsFalse(people.AddIfNotExists(testPerson));
		}

		[TestMethod]
		public void AddIfTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var person = RandomData.GenerateRefPerson<PersonProper>();

			// TEST
			people.AddIf(person, people.FastCount() == 10);

			Assert.IsTrue(people.FastCount() == 11);
		}

		[TestMethod]
		public void AddRangeListTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var newPeople = RandomData.GeneratePersonRefCollection<PersonProper>(2);

			_ = people.AddRange(newPeople, Tristate.True);

			Assert.IsTrue(people.FastCount() == 12);

			_ = people.AddRange(newPeople, Tristate.UseDefault);

			Assert.IsTrue(people.FastCount() == 12);

			var nullCollection = new List<PersonProper>();

			Assert.IsFalse(people.AddRange<PersonProper>(nullCollection));
		}

		[TestMethod]
		public void DoesNotHaveItemsTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var emptyPeople = new List<PersonProper>();

			Assert.IsFalse(people.DoesNotHaveItems());

			Assert.IsTrue(emptyPeople.DoesNotHaveItems());
		}

		[TestMethod]
		public void HasItemsTest01()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10).ToCollection();

			Assert.IsTrue(collection.HasItems());
		}

		[TestMethod]
		public void HasItemsTest02()
		{
			var collection = RandomData.GenerateCoordinateCollection<Coordinate>(10).ToCollection();

			Assert.IsFalse(collection.HasItems(5));
		}

		[TestMethod]
		public void UpsertTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var personFromCollection = people.Shuffle().First();
			var person = RandomData.GenerateRefPerson<PersonProper>();
			var personRecords = RandomData.GeneratePersonRecordCollection(10);
			var personRecord = RandomData.GeneratePersonRecordCollection(1).First();

			// TEST
			people.Upsert(person);

			Assert.IsTrue(people.FastCount() == 11);

			people.Upsert<PersonProper, string>(personFromCollection);

			Assert.IsTrue(people.FastCount() == 11);

			personRecords.Upsert(personRecord);

			Assert.IsTrue(personRecords.FastCount() == 11);
		}
	}
}
