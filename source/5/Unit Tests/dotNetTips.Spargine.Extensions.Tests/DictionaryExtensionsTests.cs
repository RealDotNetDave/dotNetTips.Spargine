// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-08-2020
// ***********************************************************************
// <copyright file="DictionaryExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class DictionaryExtensionsTests
	{

		[TestMethod]
		public void AddIfNotExistDictionaryTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var newPerson = RandomData.GeneratePerson<PersonProper>();

			// Test parameters
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.AddIfNotExists(null, newPerson));

			// Test
			Assert.IsTrue(people.AddIfNotExists(newPerson.Id, newPerson));

			Assert.IsFalse(people.AddIfNotExists(newPerson.Id, newPerson));

			var readOnlyPeople = new ReadOnlyDictionary<string, PersonProper>(people);

			_ = Assert.ThrowsException<ArgumentReadOnlyException>(() => readOnlyPeople.AddIfNotExists(newPerson.Id, newPerson));

		}

		[TestMethod]
		public void AddRangeDictionaryTest01()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var newPeople = RandomData.GeneratePersonCollection<PersonProper>(2).ToDictionary(p => p.Id);

			_ = people.AddRange(newPeople);
			Assert.IsTrue(people.Count == 12);

			_ = people.AddRange(newPeople, Tristate.UseDefault);
			Assert.IsTrue(people.Count == 12);
		}

		[TestMethod]
		public void AddRangeDictionaryTest02()
		{
			var people1 = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var people2 = RandomData.GeneratePersonCollection<PersonProper>(2).ToDictionary(p => p.Id);

			Assert.IsTrue(people1.AddRange(people2));

			Assert.IsTrue(people1.Count() == 12);

		}

		[TestMethod]
		public void GetOrAddTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var newPerson = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;

			// Test Parameters
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.GetOrAdd(null, newPerson));
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.GetOrAdd(newPerson.Id, nullPerson));

			// TEST
			_ = people.GetOrAdd(newPerson.Id, newPerson);
			Assert.IsTrue(people.Count == 11);

			_ = people.GetOrAdd(newPerson.Id, newPerson);
			Assert.IsTrue(people.Count == 11);
		}
		[TestMethod]
		public void ToDelimitedDictionaryTest()
		{
			var words = RandomData.GenerateWords(10, 25, 50);

			var dic = new Dictionary<string, string>(10);

			foreach (var item in words)
			{
				dic.Add(item, item);
			}

			Assert.IsNotNull(( dic as IDictionary ).ToDelimitedString(','));
		}

		[TestMethod]
		public void ToImmutableTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);

			var result = people.ToImmutable();

			Assert.IsTrue(result.HasItems());
		}
		[TestMethod]
		public void UpsertDictionaryTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var newPerson = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;

			// Test Parameters
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.Upsert(null, newPerson));
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.Upsert(newPerson.Id, nullPerson));

			// Test
			var item = people.Upsert(newPerson.Id, newPerson);
			Assert.IsNotNull(item);
			Assert.IsTrue(people.Count == 11);

			item = people.Upsert(newPerson.Id, newPerson);
			Assert.IsNotNull(item);
			Assert.IsTrue(people.Count == 11);
		}
	}
}
