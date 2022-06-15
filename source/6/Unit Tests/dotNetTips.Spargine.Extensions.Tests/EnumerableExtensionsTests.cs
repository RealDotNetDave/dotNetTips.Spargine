// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-15-2022
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
	public class EnumerableExtensionsTests
	{

		[TestMethod]
		public void AdIfTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();

			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.AddIf(person, true);

			Assert.IsTrue(result.FastCount() == 11);

			result = people.AddIf(person, false);

			Assert.IsTrue(result.FastCount() == 10);
		}

		[TestMethod]
		public void AdTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();

			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.Add(person);

			Assert.IsTrue(result.FastCount() == 11);
		}

		[TestMethod]
		public void FastParallelProcessorTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(100).AsEnumerable();

			var task = people.FastParallelProcessor((PersonProper person) =>
			  {
				  person.Address2 = "TEST DATA";

			  }, App.MaxDegreeOfParallelism());

			Debug.WriteLine(task.IsCompleted);
		}


		[TestMethod]
		public void ContainsAnyTest()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(5);

			var people2 = RandomData.GeneratePersonRefCollection<PersonProper>(2);

			Assert.IsFalse(people1.ContainsAny(people2.ToArray()));

			people1.AddRange(people2);

			Assert.IsTrue(people1.ContainsAny(people2.ToArray()));
		}

		[TestMethod]
		public void CountTest()
		{
			const int Count = 10;
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

			Assert.IsTrue(people.FastCount() == Count);
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
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(1000);

			//Test Params
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastAny(null));

			//Test Finding Days of over 100
			Assert.IsTrue(people.FastAny(p => p.Age.TotalDays > 100));
		}

		[TestMethod]
		public void FastCountTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(1000);

			// Test Params
			_ = Assert.ThrowsException<ArgumentNullException>(() => people.FastCount(null));

			//Test Finding City names that contain 'A'.
			Assert.IsNotNull(people.FastCount(p => p.City.Contains('A', StringComparison.CurrentCultureIgnoreCase)));
		}

		[TestMethod]
		public void FirstOrDefaultTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			var person1 = RandomData.GenerateRefPerson<PersonProper>();

			people.Add(person1);

			//Test Finding item in collection
			Assert.IsNotNull(people.FirstOrDefault(person1) == person1);
			Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 100, person1).Equals(person1));
			Assert.IsNotNull(people.FirstOrDefault(p => p.Age.TotalDays > 50000, person1).Equals(person1));
		}

		[TestMethod]
		public void FirstOrNullTest()
		{
			var coordinates = RandomData.GenerateCoordinateCollection<CoordinateProper>(10);
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
			var collection = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();
			IEnumerable<PersonProper> nullCollection = null;

			Assert.IsTrue(collection.HasItems());

			Assert.IsFalse(nullCollection.HasItems());
		}

		[TestMethod]
		public void HasItemsWithCountTest()
		{
			var collection = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();
			IEnumerable<PersonProper> nullCollection = null;

			Assert.IsTrue(collection.HasItems(10));

			Assert.IsFalse(collection.HasItems(100));

			Assert.IsFalse(nullCollection.HasItems(10));
		}

		[TestMethod]
		public void IsNullOrEmptyTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();

			var result = people.IsNullOrEmpty();

			Assert.IsFalse(result);

			result = people.Take(0).IsNullOrEmpty();

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void ShuffleWithCountTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10);
			List<PersonProper> nullList = null;

			_ = Assert.ThrowsException<ArgumentNullException>(nullList.Shuffle);

			Assert.IsTrue(people.Shuffle(5).FastCount() == 5);
		}

		[TestMethod]
		public void StartsWithTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(50);
			var people1 = people.Take(5);
			var people2 = people1;

			Assert.IsTrue(people.StartsWith(people.Take(5)));

			Assert.IsTrue(people1.StartsWith(people2));
		}

		[TestMethod]
		public void StructuralSequenceEqualTest()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(50);

			var people2 = people1.Clone<List<PersonProper>>();

			Assert.IsFalse(people1.StructuralSequenceEqual(people2));

			Assert.IsTrue(people1.StructuralSequenceEqual(people1));
		}



		[TestMethod]
		public void ToBlockingTest()
		{
			const int Count = 10;
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(Count).AsEnumerable();

			var result = people.ToBlockingCollection();

			Assert.IsTrue(result.FastCount() == Count);
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
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(50);

			Assert.IsTrue(people.ToLinkedList().HasItems());
		}

		[TestMethod]
		public async Task ToListAsyncTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(50).AsEnumerable();

			var result = await people.ToListAsync().ConfigureAwait(false);

			Assert.IsNotNull(result);
		}


		[TestMethod]
		public void UpsertTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).AsEnumerable();

			var personFromCollection = people.Shuffle().First();

			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.Upsert(person);

			Assert.IsTrue(result.FastCount() == 11);

			result = people.Upsert(personFromCollection);

			Assert.IsTrue(result.FastCount() == 10);
		}
	}
}
