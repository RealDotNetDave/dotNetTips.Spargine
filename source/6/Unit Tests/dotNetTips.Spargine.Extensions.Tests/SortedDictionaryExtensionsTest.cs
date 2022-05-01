// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-23-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-03-2021
// ***********************************************************************
// <copyright file="SortedDictionaryExtensionsTest.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
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
	public class SortedDictionaryExtensionsTest
	{
		[TestMethod]
		public void ToImmutableTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(100).ToDictionary(p => p.Id);

			var peopleSortedSet = new SortedDictionary<string, PersonProper>(people);

			var result = peopleSortedSet.ToImmutable();

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void UpsertTest()
		{
			var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToDictionary(p => p.Id);
			var peopleSortedSet = new SortedDictionary<string, PersonProper>(people);
			var person = RandomData.GenerateRefPerson<PersonProper>();

			var personFromCollection = peopleSortedSet.Shuffle().First();

			_ = peopleSortedSet.Upsert(person.Id, person);

			Assert.IsTrue(peopleSortedSet.Count() == 11);

			_ = peopleSortedSet.Upsert(personFromCollection.Key, personFromCollection.Value);

			Assert.IsTrue(peopleSortedSet.Count() == 11);

		}
	}
}
