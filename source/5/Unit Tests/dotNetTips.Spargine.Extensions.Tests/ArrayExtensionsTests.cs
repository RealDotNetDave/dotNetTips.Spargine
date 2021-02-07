// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
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
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
			Assert.IsTrue(result.First() == person);

			Assert.IsTrue(result.AddFirst(null).Count() == 11);
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

			Assert.ThrowsException<ArgumentNullException>(() => nullBytes.BytesToString());
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
	}
}
