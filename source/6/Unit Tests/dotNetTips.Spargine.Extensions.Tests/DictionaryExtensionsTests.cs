// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-27-2022
// ***********************************************************************
// <copyright file="DictionaryExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests
{
	/// <summary>
	/// Defines test class DictionaryExtensionsTests.
	/// </summary>
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class DictionaryExtensionsTests
	{

		/// <summary>
		/// Defines the test method AddIfNotExistDictionaryTest.
		/// </summary>
		[TestMethod]
		public void AddIfNotExistDictionaryTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var newPerson = RandomData.GenerateRefPerson<PersonProper>();

			// Test parameters
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(null, newPerson));

			// Test
			Assert.IsTrue(people.AddIfNotExists(newPerson.Id, newPerson));

			Assert.IsFalse(people.AddIfNotExists(newPerson.Id, newPerson));
		}

		/// <summary>
		/// Defines the test method AddRangeDictionaryTest01.
		/// </summary>
		[TestMethod]
		public void AddRangeDictionaryTest01()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var newPeople = RandomData.GeneratePersonRefCollection<PersonProper>(2).ToDictionary(p => p.Id);

			var result = people.AddRange(newPeople, Tristate.True);
			Assert.IsTrue(people.FastCount() == 12);

			result = people.AddRange(newPeople, Tristate.True);
			Assert.IsTrue(people.FastCount() == 12);
		}

		/// <summary>
		/// Defines the test method AddRangeDictionaryTest02.
		/// </summary>
		[TestMethod]
		public void FastCountTest()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);

			Assert.IsTrue(people1.FastCount() == 10);

		}

		/// <summary>
		/// Defines the test method DoesNotHaveItemsTest.
		/// </summary>
		[TestMethod]
		public void DoesNotHaveItemsTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);

			Assert.IsFalse(people.DoesNotHaveItems());
		}

		/// <summary>
		/// Defines the test method GetOrAddTest.
		/// </summary>
		[TestMethod]
		public void GetOrAddTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var newPerson = RandomData.GenerateRefPerson<PersonProper>();

			// Test Parameters
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.GetOrAdd(null, newPerson));

			// TEST
			_ = people.GetOrAdd(newPerson.Id, newPerson);
			Assert.IsTrue(people.FastCount() == 11);

			_ = people.GetOrAdd(newPerson.Id, newPerson);
			Assert.IsTrue(people.FastCount() == 11);
		}

		/// <summary>
		/// Defines the test method HasItemsTest.
		/// </summary>
		[TestMethod]
		public void HasItemsTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);
			Dictionary<string, PersonProper> nullPeople = null;

			Assert.IsTrue(people.HasItems());

			Assert.IsFalse(nullPeople.HasItems());
		}

		/// <summary>
		/// Defines the test method HasItemsTestWithFunction.
		/// </summary>
		[TestMethod]
		public void HasItemsTestWithFunction()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);

			Func<KeyValuePair<string, PersonProper>, bool> selector = p => p.Value.Email.IsNotNull();

			Assert.IsTrue(people.HasItems(selector));
		}

		/// <summary>
		/// Defines the test method HasItemsWithCountTest.
		/// </summary>
		[TestMethod]
		public void HasItemsWithCountTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);
			Dictionary<string, PersonProper> nullPeople = null;

			Assert.IsTrue(people.HasItems(10));
			Assert.IsFalse(people.HasItems(100));

			Assert.IsFalse(nullPeople.HasItems(10));
		}
		/// <summary>
		/// Defines the test method ToDelimitedDictionaryTest.
		/// </summary>
		[TestMethod]
		public void ToDelimitedDictionaryTest()
		{
			var words = RandomData.GenerateWords(10, 25, 50);

			var dic = new Dictionary<string, string>(10);

			foreach (var item in words)
			{
				dic.Add(item, item);
			}

			Assert.IsNotNull((dic as IDictionary).ToDelimitedString(','));
		}

		/// <summary>
		/// Defines the test method ToImmutableTest.
		/// </summary>
		[TestMethod]
		public void ToImmutableTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);

			var result = people.ToImmutable();

			Assert.IsTrue(result.HasItems());
		}

		/// <summary>
		/// Defines the test method ToSortedDictionaryTest.
		/// </summary>
		[TestMethod]
		public void ToSortedDictionaryTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);

			var result = people.ToSortedDictionary();

			Assert.IsTrue(result.HasItems());
		}

		[TestMethod]
		public void ToConcurrentDictionaryTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);

			var result = people.ToConcurrentDictionary();

			Assert.IsTrue(result.HasItems());
		}

		/// <summary>
		/// Defines the test method UpsertDictionaryTest.
		/// </summary>
		[TestMethod]
		public void UpsertDictionaryTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var newPerson = RandomData.GenerateRefPerson<PersonProper>();
			var personFromCollection = people.Shuffle().First();

			// Test Parameters
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.Upsert(null, newPerson));

			// Test
			people.Upsert(newPerson.Id, newPerson);
			Assert.IsTrue(people.FastCount() == 11);

			people.Upsert(newPerson);
			Assert.IsTrue(people.FastCount() == 11);

			people.Upsert(personFromCollection.Value.Id, personFromCollection.Value);
			Assert.IsTrue(people.FastCount() == 11);
		}
	}
}
