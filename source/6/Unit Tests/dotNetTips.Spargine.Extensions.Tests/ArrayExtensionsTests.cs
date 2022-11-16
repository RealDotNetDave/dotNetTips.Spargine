// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-14-2022
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
	/// <summary>
	/// Defines test class ArrayExtensionsTests.
	/// </summary>
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ArrayExtensionsTests
	{
		/// <summary>
		/// Defines the test method AddFirstTest.
		/// </summary>
		[TestMethod]
		public void AddFirstTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.AddFirst(person);

			Assert.IsTrue(result.FastCount() == 11);
		}

		/// <summary>
		/// Defines the test method RemoveLastTest.
		/// </summary>
		[TestMethod]
		public void RemoveLastTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(100).ToArray();

			var result = people.RemoveLast();

			Assert.IsTrue(result.FastCount() == 99);
		}

		/// <summary>
		/// Defines the test method AddIfTest.
		/// </summary>
		[TestMethod]
		public void AddIfTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.AddIf(person, people.Length == 10);

			Assert.IsTrue(result.FastCount() == 11);
		}

		/// <summary>
		/// Defines the test method AddLastTest.
		/// </summary>
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

		/// <summary>
		/// Defines the test method AddTest.
		/// </summary>
		[TestMethod]
		public void AddTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.Add<PersonProper>(person);

			Assert.IsTrue(result.FastCount() == 11);
		}

		/// <summary>
		/// Defines the test method AreEqualTest.
		/// </summary>
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

		/// <summary>
		/// Defines the test method BytesToStringTest.
		/// </summary>
		[TestMethod]
		public void BytesToStringTest()
		{
			var bytes = RandomData.GenerateByteArray(100);

			var result = bytes.BytesToString();

			Assert.IsTrue(result.Length > 100);
		}

		/// <summary>
		/// Defines the test method BytesToStringUsingSpanTest.
		/// </summary>
		[TestMethod]
		public void BytesToStringUsingSpanTest()
		{
			var bytes = RandomData.GenerateByteArray(100);

			var readOnlySpan = new ReadOnlySpan<byte>(bytes);
			var result = readOnlySpan.BytesToString();

			Assert.IsTrue(result.Length > 100);
		}

		/// <summary>
		/// Defines the test method CloneTest.
		/// </summary>
		[TestMethod]
		public void CloneTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();

			var result = people.Clone<PersonProper>();

			Assert.IsTrue(people.AreEqual(result));
		}

		/// <summary>
		/// Defines the test method ContainsAnyTest.
		/// </summary>
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

		/// <summary>
		/// Defines the test method DoesNotHasItemsTest.
		/// </summary>
		[TestMethod]
		public void DoesNotHasItemsTest()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			PersonProper[] nullPeople = null;

			Assert.IsFalse(people1.DoesNotHaveItems());

			Assert.IsTrue(nullPeople.DoesNotHaveItems());
		}

		/// <summary>
		/// Defines the test method FastProcessorTest.
		/// </summary>
		[TestMethod]
		public void FastProcessorTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(100).ToArray();

			people.FastProcessor((PersonProper person) =>
			{
				person.Address2 = "TEST DATA";

			});
		}

		/// <summary>
		/// Defines the test method HasItemsTest.
		/// </summary>
		[TestMethod]
		public void HasItemsTest()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			PersonProper[] nullPeople = null;

			Assert.IsTrue(people1.HasItems());

			Assert.IsFalse(nullPeople.HasItems());
		}

		/// <summary>
		/// Defines the test method HasItemsTestWithCount.
		/// </summary>
		[TestMethod]
		public void HasItemsTestWithCount()
		{
			var people1 = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			PersonProper[] nullPeople = null;

			Assert.IsTrue(people1.HasItems(10));

			Assert.IsFalse(people1.HasItems(100));

			Assert.IsFalse(nullPeople.HasItems(10));

		}

		/// <summary>
		/// Defines the test method HasItemsTestWithFunction.
		/// </summary>
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

		/// <summary>
		/// Defines the test method ToDistinctTest.
		/// </summary>
		[TestMethod]
		public void ToDistinctTest()
		{
			var people = RandomData.GenerateWords(10, 10, 100).ToArray();

			people = people.AddLast(people.First());

			Assert.IsTrue(people.ToDistinct().FastCount() == 10);
		}

		/// <summary>
		/// Defines the test method UpsertTest01.
		/// </summary>
		[TestMethod]
		public void UpsertTest01()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToArray();
			var personFromCollection = people.Shuffle().First();
			personFromCollection.HomePhone = "1234567890";
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var result = people.Upsert(personFromCollection);

			Assert.IsTrue(result.FastCount() == 10);

			result = people.Upsert(person);

			Assert.IsTrue(result.FastCount() == 11);

			result = people.Upsert(personFromCollection);

			Assert.IsTrue(result.FastCount() == 10);

			result = people.Upsert(null);

			Assert.IsTrue(result.FastCount() == 10);
		}
	}
}
