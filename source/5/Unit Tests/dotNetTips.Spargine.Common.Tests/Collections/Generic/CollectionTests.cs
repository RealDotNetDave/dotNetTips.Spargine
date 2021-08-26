// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2021
// ***********************************************************************
// <copyright file="CollectionTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Core.Collections.Generic;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests.Collections.Generic
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class CollectionTests
	{

		[TestMethod]
		public void AddFirstTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var collection = Collection<PersonProper>.Create(people);
			var person = RandomData.GeneratePerson<PersonProper>();

			collection.AddFirst(person);

			Assert.IsTrue(collection.First() == person);
		}

		[TestMethod]
		public void AddIfNotExistsTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var collection = Collection<PersonProper>.Create(people);
			var person = RandomData.GeneratePerson<PersonProper>();

			_ = collection.AddIfNotExists(collection.First());

			Assert.IsTrue(collection.Count == 10);

			_ = collection.AddIfNotExists(person);

			Assert.IsTrue(collection.Count == 11);
		}

		[TestMethod]
		public void AddLastTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);
			var collection = Collection<PersonProper>.Create(people);
			var person = RandomData.GeneratePerson<PersonProper>();

			collection.AddLast(person);

			Assert.IsTrue(collection.Last() == person);
		}

		[TestMethod]
		public void CreateTest()
		{
			var collection = Collection<PersonProper>.Create();

			Assert.IsNotNull(collection);
		}

		[TestMethod]
		public void CreateWithCollectionTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);

			var collection = Collection<PersonProper>.Create(people);

			Assert.IsNotNull(collection);

			Assert.IsTrue(collection.Count == 10);
		}

		[TestMethod]
		public void CreateWithCollectionUniqueTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10);

			var collection = Collection<PersonProper>.Create(people, ensureUnique: Tristate.True);

			Assert.IsNotNull(collection);

			Assert.IsTrue(collection.Count == 10);
		}

		[TestMethod]
		public void CreateWithCountTest()
		{
			var collection = Collection<PersonProper>.Create(10);

			Assert.IsNotNull(collection);
		}
	}
}
