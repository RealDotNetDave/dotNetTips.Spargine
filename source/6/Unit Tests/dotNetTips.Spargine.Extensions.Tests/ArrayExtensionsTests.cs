// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-03-2022
// ***********************************************************************
// <copyright file="ArrayExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ArrayExtensionsTests
	{
		[TestMethod]
		public void AddFirstTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.AddFirst(person);

			Assert.IsTrue(result.FastCount() == 11);
		}

		[TestMethod]
		public void RemoveLastTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(100).ToArray();

			var result = people.RemoveLast();

			Assert.IsTrue(result.FastCount() == 99);
		}

		[TestMethod]
		public void AddIfTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.AddIf(person, people.Length == 10);

			Assert.IsTrue(result.FastCount() == 11);
		}

		[TestMethod]
		public void AddLastTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.AddLast(person);

			Assert.IsTrue(result.FastCount() == 11);
			Assert.IsTrue(result.Last() == person);

			Assert.IsTrue(result.AddLast(null).FastCount() == 11);
		}

		[TestMethod]
		public void AddTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.Add(person);

			Assert.IsTrue(result.FastCount() == 11);
		}

		[TestMethod]
		public void AreEqualTest()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var people2 = people1;
			var people3 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();


			Assert.IsFalse(people1.AreEqual(people3));

			Assert.IsTrue(people1.AreEqual(people2));

			Assert.IsFalse(people1.AreEqual(arrayToCheck: null));
		}

		[TestMethod]
		public void BytesToStringTest()
		{
			var bytes = RandomData.GenerateByteArray(100);

			var result = bytes.BytesToString();

			Assert.IsTrue(result.Length > 100);
		}

		[TestMethod]
		public void BytesToStringUsingSpanTest()
		{
			var bytes = RandomData.GenerateByteArray(100);

			var readOnlySpan = new ReadOnlySpan<byte>(bytes);
			var result = readOnlySpan.BytesToString();

			Assert.IsTrue(result.Length > 100);
		}

		[TestMethod]
		public void CloneTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();

			var result = people.Clone<PersonProper>();

			Assert.IsTrue(people.AreEqual(result));
		}

		[TestMethod]
		public void ContainsAnyTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			Assert.IsFalse(people.ContainsAny(person));

			Assert.IsTrue(people.ContainsAny(people.Last()));

			//PersonProper[] nullPerson = default;

			//Assert.IsFalse(people.ContainsAny(nullPerson));

		}

		[TestMethod]
		public void DoesNotHasItemsTest()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			PersonProper[] nullPeople = null;

			Assert.IsFalse(people1.DoesNotHaveItems());

			Assert.IsTrue(nullPeople.DoesNotHaveItems());
		}

		[TestMethod]
		public void FastProcessorTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(100).ToArray();

			people.FastProcessor((PersonProper person) =>
			{
				person.Address2 = "TEST DATA";

			});
		}

		[TestMethod]
		public void HasItemsTest()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			PersonProper[] nullPeople = null;

			Assert.IsTrue(people1.HasItems());

			Assert.IsFalse(nullPeople.HasItems());
		}

		[TestMethod]
		public void HasItemsTestWithCount()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			PersonProper[] nullPeople = null;

			Assert.IsTrue(people1.HasItems(10));

			Assert.IsFalse(people1.HasItems(100));

			Assert.IsFalse(nullPeople.HasItems(10));

		}

		[TestMethod]
		public void HasItemsTestWithFunction()
		{
			var collection = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			PersonProper[] nullCollection = null;

			Func<PersonProper, bool> selector = (person) => person.Email.IsNotNull();

			Assert.IsTrue(collection.HasItems(selector));

			Assert.IsFalse(nullCollection.HasItems(selector));

			Assert.IsFalse(nullCollection.HasItems(null));
		}

		[TestMethod]
		public void ToDistinctTest()
		{
			var people = RandomData.GenerateWords(10, 10, 100).ToArray();

			people = people.AddLast(people.First());

			Assert.IsTrue(people.ToDistinct().FastCount() == 10);
		}

		[TestMethod]
		public void UpsertTest01()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var personFromCollection = people.Shuffle().First();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.Upsert(personFromCollection);

			Assert.IsTrue(result.FastCount() == 10);

			result = people.Upsert(person);

			Assert.IsTrue(result.FastCount() == 11);

			result = people.Upsert(personFromCollection);

			Assert.IsTrue(result.FastCount() == 10);
		}
	}
}
