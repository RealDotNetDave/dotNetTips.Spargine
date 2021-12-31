// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-13-2021
// ***********************************************************************
// <copyright file="ArrayExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ArrayExtensionsTests
	{
		[TestMethod]
		public void AddFirstTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.AddFirst(person);

			Assert.IsTrue(result.Count() == 11);
		}

		[TestMethod]
		public void FastProcessorTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(100).ToArray();

			people.FastProcessor((PersonProper person) =>
			{
				person.Address2 = "TEST DATA";

			});
		}

		[TestMethod]
		public void AddIfTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.AddIf(person, people.Length == 10);

			Assert.IsTrue(result.Count() == 11);
		}

		[TestMethod]
		public void AddLastTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.AddLast(person);

			Assert.IsTrue(result.Count() == 11);
			Assert.IsTrue(result.Last() == person);

			Assert.IsTrue(result.AddLast(null).Count() == 11);
		}

		[TestMethod]
		public void AddTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.Add(person);

			Assert.IsTrue(result.Count() == 11);
		}

		[TestMethod]
		public void AreEqualTest()
		{
			var people1 = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
			var people2 = people1;
			var people3 = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();


			Assert.IsFalse(people1.AreEqual(people3));

			Assert.IsTrue(people1.AreEqual(people2));

			Assert.IsFalse(people1.AreEqual(arrayToCheck: null));
		}

		[TestMethod]
		public void BytesToStringTest()
		{
			var bytes = RandomData.GenerateByteArray(100);

			var result = bytes.BytesToString();

			Assert.IsTrue(result.Length > 20000);

			byte[] nullBytes = null;

			_ = Assert.ThrowsException<NullReferenceException>(() => nullBytes.BytesToString());
		}

		[TestMethod]
		public void BytesToStringUsingSpanTest()
		{
			var bytes = RandomData.GenerateByteArray(100);

			var readOnlySpan = new ReadOnlySpan<byte>(bytes);
			var result = readOnlySpan.BytesToString();

			Assert.IsTrue(result.Length > 20000);

			byte[] nullBytes = null;

			_ = Assert.ThrowsException<NullReferenceException>(() => nullBytes.BytesToString());
		}

		[TestMethod]
		public void CloneTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();

			var result = people.Clone<PersonProper>();

			Assert.IsTrue(people.AreEqual(result));
		}

		[TestMethod]
		public void ContainsAnyTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
			var person = RandomData.GeneratePerson<PersonProper>();

			Assert.IsFalse(people.ContainsAny(person));

			Assert.IsTrue(people.ContainsAny(people.Last()));

			PersonProper[] nullPerson = null;

			Assert.IsFalse(people.ContainsAny(nullPerson));

		}

		[TestMethod]
		public void RemoveDuplicatesTest()
		{
			var numbers = new int[] { 1, 2, 3, 4, 5, 10, 5 };

			var result = numbers.RemoveDuplicates();

			Assert.IsTrue(result.Count() == numbers.Length - 1);

		}

		[TestMethod]
		public void ToDistinctTest()
		{
			var people = RandomData.GenerateWords(10, 10, 100).ToArray();

			people = people.AddLast(people.First());

			Assert.IsTrue(people.ToDistinct().Count() == 10);
		}

		[TestMethod]
		public void UpsertTest01()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).ToArray();
			var personFromCollection = people.Shuffle().First();
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.Upsert(personFromCollection);

			Assert.IsTrue(result.Count() == 10);

			result = people.Upsert(person);

			Assert.IsTrue(result.Count() == 11);

			result = people.Upsert(personFromCollection);

			Assert.IsTrue(result.Count() == 10);
		}
	}
}
