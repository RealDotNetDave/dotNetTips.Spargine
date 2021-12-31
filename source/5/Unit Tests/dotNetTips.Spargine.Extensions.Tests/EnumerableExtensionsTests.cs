// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
// ***********************************************************************
// <copyright file="EnumerableExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using dotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class EnumerableExtensionsTests
	{

		[TestMethod]
		public void AdIfTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).AsEnumerable();

			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.AddIf(person, true);

			Assert.IsTrue(result.Count() == 11);

			result = people.AddIf(person, false);

			Assert.IsTrue(result.Count() == 10);
		}

		[TestMethod]
		public void AdTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).AsEnumerable();

			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.Add(person);

			Assert.IsTrue(result.Count() == 11);
		}

		[TestMethod]
		public void FastParallelProcessorTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100).AsEnumerable();

			var task = people.FastParallelProcessor((PersonProper person) =>
			  {
				  person.Address2 = "TEST DATA";

			  }, App.MaxDegreeOfParallelism());

			Debug.WriteLine(task.IsCompleted);
		}


		[TestMethod]
		public void ContainsAnyTest()
		{
			var people1 = RandomData.GeneratePersonCollection<PersonProper>(10);

			var people2 = RandomData.GeneratePersonCollection<PersonProper>(10);

			Assert.IsFalse(people1.ContainsAny(people2.ToArray()));

			people1.AddRange(people2);

			Assert.IsTrue(people1.ContainsAny(people2.ToArray()));
		}

		[TestMethod]
		public void CountTest()
		{
			const int Count = 10;
			var people = RandomData.GeneratePersonCollection<PersonProper>(Count).AsEnumerable();

			Assert.IsTrue(people.Count() == Count);
		}

		[TestMethod]
		public void DoesNotHaveItemsTest()
		{
			var people = new List<PersonProper>();

			Assert.IsTrue(people.DoesNotHaveItems());
		}

		[TestMethod]
		public void FastAnyTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

			//Test Params
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

			//Test Finding Days of over 100
			Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
		}

		[TestMethod]
		public void FastCountTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(1000);

			// Test Params
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

			//Test Finding Days of over 100
			Assert.IsTrue(people.FastCount(p => p.Age.TotalDays >= 1) > 0);
		}

		[TestMethod]
		public void FirstOrDefaultTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var person1 = RandomData.GeneratePerson<PersonProper>();

			people.Add(person1);

			//Test Finding item in collection
			Assert.IsNotNull(people.FirstOrDefault(person1) == person1);
			Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 100, person1).Equals(person1));
			Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 50000, person1).Equals(person1));
		}

		[TestMethod]
		public void FirstOrNullTest()
		{
			var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(10).AsEnumerable();
			var searchValue = coordinates.Last().X;

			//Test Finding Days of over 100
			Assert.IsNotNull(coordinates.FirstOrNull(p => p.X == searchValue));
			Assert.IsNull(coordinates.FirstOrNull(p => p.X == int.MinValue));
			Assert.IsNull(coordinates.Take(0).FirstOrNull(p => p.X == int.MinValue));

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
		public void HasItemsTest01()
		{
			var collection = RandomData.GeneratePersonCollection<PersonProper>(10).AsEnumerable();

			Assert.IsTrue(collection.HasItems());
		}

		[TestMethod]
		public void HasItemsTest02()
		{
			var collection = RandomData.GeneratePersonCollection<PersonProper>(10).AsEnumerable();

			Assert.IsFalse(collection.HasItems(5));
		}

		[TestMethod]
		public void IsNullOrEmptyTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).AsEnumerable();

			var result = people.IsNullOrEmpty();

			Assert.IsFalse(result);

			result = people.Take(0).IsNullOrEmpty();

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void ShuffleWithCountTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			List<PersonProper> nullList = null;

			_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

			Assert.IsTrue(people.Shuffle(5).Count() == 5);
		}

		[TestMethod]
		public void StartsWithTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(50);
			var people1 = people.Take(5);
			var people2 = people1;

			Assert.IsTrue(people.StartsWith(people.Take(5)));

			Assert.IsTrue(people1.StartsWith(people2));
		}

		[TestMethod]
		public void StructuralSequenceEqualTest()
		{
			var people1 = RandomData.GeneratePersonCollection<PersonProper>(50);

			var people2 = people1.Clone<List<PersonProper>>();

			Assert.IsFalse(people1.StructuralSequenceEqual(people2));

			Assert.IsTrue(people1.StructuralSequenceEqual(people1));
		}



		[TestMethod]
		public void ToBlockingTest()
		{
			const int Count = 10;
			var people = RandomData.GeneratePersonCollection<PersonProper>(Count).AsEnumerable();

			var result = people.ToBlockingCollection();

			Assert.IsTrue(result.Count() == Count);
		}

		[TestMethod]
		public void ToDelimitedStringTest()
		{
			var words = RandomData.GenerateWords(10, 25, 50);

			Assert.IsNotNull(words.ToDelimitedString(','));
		}

		[TestMethod]
		public void ToLinkedListTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(50);

			Assert.IsTrue(people.ToLinkedList().HasItems());
		}

		[TestMethod]
		public async Task ToListAsyncTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(50).AsEnumerable();

			var result = await people.ToListAsync().ConfigureAwait(false);

			Assert.IsNotNull(result);
		}


		[TestMethod]
		public void UpsertTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).AsEnumerable();

			var personFromCollection = people.Shuffle().First();

			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.Upsert(person);

			Assert.IsTrue(result.Count() == 11);

			result = people.Upsert(personFromCollection);

			Assert.IsTrue(result.Count() == 10);
		}
	}
}
