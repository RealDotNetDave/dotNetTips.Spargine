// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2021
// ***********************************************************************
// <copyright file="TypeHelperTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spartine.Core.Tests
{
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
			var person = RandomData.GeneratePerson<PersonProper>();
			var testPerson = person;

			Assert.IsTrue(TypeHelper.DoesObjectEqualInstance(person, testPerson));

		}

		[TestMethod]
		public void DoesObjectEqualInstance02()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			var testPerson = RandomData.GeneratePerson<PersonProper>();

			Assert.IsFalse(TypeHelper.DoesObjectEqualInstance(person, testPerson));

		}

		[TestMethod]
		public void FindDerivedTypes01()
		{
			var result = TypeHelper.FindDerivedTypes(typeof(MulticastDelegate), Tristate.True);

			Assert.IsTrue(result.HasItems());
		}

		[TestMethod]
		public void FindDerivedTypes02()
		{
			var result = TypeHelper.FindDerivedTypes(AppDomain.CurrentDomain, typeof(MulticastDelegate), Tristate.True);

			Assert.IsTrue(result.HasItems());
		}

		[TestMethod]
		public void FindDerivedTypes03()
		{
			var result = TypeHelper.FindDerivedTypes(App.ExecutingFolder(), SearchOption.AllDirectories, typeof(MulticastDelegate), Tristate.True);

			Assert.IsTrue(result.HasItems());
		}

		[TestMethod]
		public void FromJson01()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			var json = person.ToJson();

			Assert.IsNotNull(TypeHelper.FromJson<PersonProper>(json));

		}

		[TestMethod]
		public void FromJsonFile01()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			var fileName = Path.Combine(App.ExecutingFolder(), "testjson");
			person.ToJsonFile(fileName);

			Assert.IsNotNull(TypeHelper.FromJsonFile<PersonProper>(fileName));

		}

		[TestMethod]
		public void GetDefault01()
		{
			var result = TypeHelper.GetDefault<AccessControlType>();

			Assert.IsNotNull(result);

		}

		[TestMethod]
		public void GetInstanceHashCode01()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			Assert.IsTrue(TypeHelper.GetInstanceHashCode(person).IsNegative());

		}

		[TestMethod]
		public void GetPropertyValues()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = TypeHelper.GetPropertyValues(person);

			PrintResult(result, nameof(this.GetPropertyValues));

			Assert.IsTrue(result.Count > 5);

			var exTest = new ArgumentOutOfRangeException("TESTPARAM", "TESTMESSAGE");

			result = TypeHelper.GetPropertyValues(exTest);

			Assert.IsTrue(result.Count > 1);
		}


		[TestMethod]
		public void GetTypeDisplayNameTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = TypeHelper.GetTypeDisplayName(person);

			Assert.IsTrue(string.Compare(result, "dotNetTips.Spargine.Tester.Models.PersonProper", StringComparison.Ordinal) == 0);

			result = TypeHelper.GetTypeDisplayName(person, true);

			Assert.IsTrue(string.Compare(result, "dotNetTips.Spargine.Tester.Models.PersonProper", StringComparison.Ordinal) == 0);

			result = TypeHelper.GetTypeDisplayName(typeof(int), true, true, true, '-');

			Assert.IsTrue(string.Compare(result, "int", StringComparison.Ordinal) == 0);

			var people = RandomData.GeneratePersonCollection<PersonProper>(5);

			result = TypeHelper.GetTypeDisplayName(people);

			Assert.IsTrue(result.Length > 0);

			result = TypeHelper.GetTypeDisplayName(RandomData.GeneratePerson<Person>());

			Assert.IsTrue(result.Length > 0);
		}
	}
}
