// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="TypeHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
[Guid("5AE2E147-D4DB-4FA4-AAE4-0675C3A2DFC5")]
public class TypeHelperTests : TestClass
{

	[TestMethod]
	public void BuiltInTypeNames01()
	{
		var result = TypeHelper.BuiltInTypeNames;

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void CreateTypeTest01()
	{
		var result = TypeHelper.Create<PersonProper>();

		Assert.IsNotNull(result);

	}

	[TestMethod]
	public void CreateTypeTest02()
	{
		var result = TypeHelper.Create<PersonProper>("TESTID", "DOTNETDAVE@LIVE.COM");

		Assert.IsNotNull(result);

	}

	[TestMethod]
	public void DoesObjectEqualInstance01()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();
		var testPerson = person;

		Assert.IsTrue(TypeHelper.DoesObjectEqualInstance(person, testPerson));

	}

	[TestMethod]
	public void DoesObjectEqualInstance02()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();
		var testPerson = RandomData.GenerateRefPerson<PersonProper>();

		Assert.IsFalse(TypeHelper.DoesObjectEqualInstance(person, testPerson));

	}

	[TestMethod]
	public void FindDerivedTypes01()
	{
		var result = TypeHelper.FindDerivedTypes(typeof(object), Tristate.True);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void FindDerivedTypes02()
	{
		var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(MulticastDelegate), Tristate.True);

		Assert.IsTrue(result.HasItems());
	}

	[TestMethod]
	public void FromJson01()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();
		var json = person.ToJson();

		Assert.IsNotNull(TypeHelper.FromJson<PersonProper>(json));

	}

	[TestMethod]
	public void FromJsonFile01()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();
		var fileName = Path.Combine(App.ExecutingFolder(), "testjson.json");
		person.ToJsonFile(fileName);

		Assert.IsNotNull(TypeHelper.FromJsonFile<PersonProper>(fileName));

		File.Delete(fileName);

	}

	[TestMethod]
	public void GetDefault01()
	{
		var result = TypeHelper.GetDefault<AccessControlType>();

		Assert.IsNotNull(result);

	}

	[TestMethod]
	public void GetPropertyValues()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		var result = TypeHelper.GetPropertyValues(person);
		Assert.IsTrue(result.Count > 5);

		var exTest = new ArgumentOutOfRangeException("TESTPARAM", "TESTMESSAGE");

		result = TypeHelper.GetPropertyValues(exTest);

		Assert.IsTrue(result.Count > 1);
	}

	[TestMethod]
	public void GetTypeDisplayNameTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		var result = TypeHelper.GetTypeDisplayName(person);

		Assert.IsTrue(string.Compare(result, "DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper", StringComparison.Ordinal) == 0);

		result = TypeHelper.GetTypeDisplayName(person, true);

		Assert.IsTrue(string.Compare(result, "DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper", StringComparison.Ordinal) == 0);

		result = TypeHelper.GetTypeDisplayName(typeof(int), true, true, true, '-');

		Assert.IsTrue(string.Compare(result, "int", StringComparison.Ordinal) == 0);

		var people = RandomData.GeneratePersonRefCollection<PersonProper>(5);

		result = TypeHelper.GetTypeDisplayName(people);

		Assert.IsTrue(result.Length > 0);

		result = TypeHelper.GetTypeDisplayName(RandomData.GenerateRefPerson<Person>());

		Assert.IsTrue(result.Length > 0);
	}

}
