// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-06-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-06-2021
// ***********************************************************************
// <copyright file="ConcurrentHashSetTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using dotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Core.Tests.Collections.Generic.Concurrent
{
	[TestClass]
	public class ConcurrentHashSetTests
	{

		[TestMethod]
		public void AddTest()
		{
			var people = new ConcurrentHashSet<PersonProper>(RandomData.GeneratePersonCollection<PersonProper>(100));

			var result = people.Add(RandomData.GeneratePerson<PersonProper>());

			Assert.IsTrue(result);
			Assert.IsTrue(people.Count == 101);
		}

		[TestMethod]
		public void ClearEmptyTest()
		{
			var people = new ConcurrentHashSet<PersonProper>(RandomData.GeneratePersonCollection<PersonProper>(100));

			people.Clear();

			Assert.IsTrue(people.Count == 0);

			Assert.IsTrue(people.IsEmpty);

		}
		[TestMethod]
		public void ConstructorsTest()
		{
			var comparer = new PersonProperComparer();

			var test1 = new ConcurrentHashSet<PersonProper>();

			Assert.IsNotNull(test1);

			var test2 = new ConcurrentHashSet<PersonProper>(RandomData.GeneratePersonCollection<PersonProper>(100));

			Assert.IsNotNull(test2);
			Assert.IsTrue(test2.Count == 100);

			var test3 = new ConcurrentHashSet<PersonProper>(comparer);

			Assert.IsNotNull(test3);

			var test4 = new ConcurrentHashSet<PersonProper>(2, 100);

			Assert.IsNotNull(test4);

			var test5 = new ConcurrentHashSet<PersonProper>(RandomData.GeneratePersonCollection<PersonProper>(100), comparer);

			Assert.IsNotNull(test5);
			Assert.IsTrue(test5.Count == 100);

			var test6 = new ConcurrentHashSet<PersonProper>(2, 100, comparer);

			Assert.IsNotNull(test6);

			var test7 = new ConcurrentHashSet<PersonProper>(2, RandomData.GeneratePersonCollection<PersonProper>(100), comparer);

			Assert.IsNotNull(test7);
			Assert.IsTrue(test7.Count == 100);
		}

		[TestMethod]
		public void ContainsTest()
		{
			var people = new ConcurrentHashSet<PersonProper>(RandomData.GeneratePersonCollection<PersonProper>(100));
			var person = people.Shuffle(1).First();

			var result = people.Contains(person);

			Assert.IsTrue(result);

			Assert.IsFalse(people.Contains(RandomData.GeneratePerson<PersonProper>()));
		}

		[TestMethod]
		public void TryRemoveTest()
		{
			var people = new ConcurrentHashSet<PersonProper>(RandomData.GeneratePersonCollection<PersonProper>(100));
			var person = people.Shuffle(1).First();

			var result = people.TryRemove(person);

			Assert.IsTrue(result);

			Assert.IsFalse(people.TryRemove(RandomData.GeneratePerson<PersonProper>()));
		}

		[TestMethod]
		public void GetEnumeratorTest()
		{
			var people = new ConcurrentHashSet<PersonProper>(RandomData.GeneratePersonCollection<PersonProper>(100));

			var result = people.GetEnumerator();

			Assert.IsNotNull(result);
		}
	}
}
