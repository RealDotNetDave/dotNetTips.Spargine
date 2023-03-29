// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 01-16-2022
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="HashSetTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[TestClass]
public class HashSetTests
{
	[TestMethod]
	public void AddIfTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToHashSet();
		var person = RandomData.GenerateRefPerson<PersonProper>();

		people.AddIf(person, true);

		Assert.IsTrue(people.FastCount() == 11);

		people.AddIf(person, false);

		Assert.IsTrue(people.FastCount() == 11);

	}

	[TestMethod]
	public void ToImmutableTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToHashSet().ToImmutable();

		Assert.IsTrue(people.FastCount() == 10);
	}

	[TestMethod]
	public void ToConcurrentHashSetTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToHashSet().ToConcurrentHashSet();

		Assert.IsTrue(people.FastCount() == 10);
	}

	[TestMethod]
	public void UpsertTest()
	{
		var people = RandomData.GeneratePersonRefCollection<PersonProper>(10).ToHashSet();
		var person = RandomData.GenerateRefPerson<PersonProper>();
		var personFromCollection = people.Shuffle().First();

		people.Upsert(person);

		Assert.IsTrue(people.FastCount() == 11);

		people.Upsert(personFromCollection);

		Assert.IsTrue(people.FastCount() == 11);

	}

}
