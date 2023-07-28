// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="ObjectExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ObjectExtensionsTests : TestClass
{
	[TestMethod]
	public void AsTest()
	{
		var personProper = RandomData.GenerateRefPerson<PersonProper>();

		try
		{
			Assert.IsNotNull(personProper.As<IPerson>());
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void CloneTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		try
		{
			var clonedPerson = person.Clone<PersonProper>();

			Assert.IsNotNull(clonedPerson);
			Assert.IsFalse(person.Equals(clonedPerson));
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void ComputeSha256HashTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		var result = person.ComputeSha256Hash();

		//PrintResult(result, nameof(this.ComputeSha256HashTest));

		Assert.IsFalse(string.IsNullOrEmpty(result));
	}

	[TestMethod]
	public void DisposeFieldsTest()
	{
		var disposableObj = new DisposableFields();
		DisposableFields nullTest = null;

		try
		{
			disposableObj.DisposeFields();
			nullTest.DisposeFields();
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}

	[TestMethod]
	public void FromJsonTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>().ToJson();

		Assert.IsNotNull(person.FromJson<PersonProper>());
	}

	[TestMethod]
	public void HasPropertyTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		Assert.IsTrue(person.HasProperty("Id"));

		Assert.IsFalse(person.HasProperty("XXXXXXXXXXXXX"));
	}

	[TestMethod]
	public void InitializeFieldsTest()
	{
		var testObject = new DisposableFields();

		testObject.InitializeFields();
	}

	[TestMethod]
	public void NullObjectTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();
		PersonProper nullPerson = null;

		Assert.IsFalse(person.IsNull());
		Assert.IsTrue(nullPerson.IsNull());

		Assert.IsTrue(person.IsNotNull());
		Assert.IsFalse(nullPerson.IsNotNull());
	}

	[TestMethod]
	public void PropertiesToDictionaryTest()
	{
		var personProper = RandomData.GeneratePersonRecord();

		var propertiesTest = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			PersonProper = RandomData.GenerateRefPerson<PersonProper>(),
			PersonRecord = RandomData.GeneratePersonRecord(),
			Today = DateTime.Now
		};

		var result = personProper.PropertiesToDictionary(memberName: $"Person-{personProper.Id}", ignoreNulls: true);

		Assert.IsTrue(result.FastCount() > 1);

		result = propertiesTest.PropertiesToDictionary(
			memberName: $"TestPerson-{personProper.Id}",
			ignoreNulls: true);

		Assert.IsTrue(result.FastCount() > 1);
	}

	[TestMethod]
	public void PropertiesToStringTest()
	{
		var personRecord = RandomData.GeneratePersonRecord();

		var propertiesTest = new PropertiesTest
		{
			Id = RandomData.GenerateKey(),
			PersonProper = RandomData.GenerateRefPerson<PersonProper>(),
			PersonRecord = RandomData.GeneratePersonRecord(),
			Today = DateTimeOffset.Now,
			ClosedOn = DateTimeOffset.Now,
		};

		var result = personRecord.PropertiesToString(
			header: "PersonRecord",
			keyValueSeparator: ':',
			sequenceSeparator: ", ",
			ignoreNulls: true);

		Assert.IsTrue(result.Length > 100);
		Assert.IsTrue(result.Contains("Addresses"));
		//PrintResult(result, nameof(this.PropertiesToStringTest));

		result = propertiesTest.PropertiesToString(
			header: "PersonRecord",
			keyValueSeparator: ':',
			sequenceSeparator: ", ",
			ignoreNulls: true,
			includeMemberName: false);

		Assert.IsTrue(result.Length > 100);
		Assert.IsTrue(result.Contains("Addresses"));
		//PrintResult(result, nameof(this.PropertiesToStringTest));

		var person = RandomData.GenerateRefPerson<PersonProper>();

		result = person.PropertiesToString(header: person.Id);

		Assert.IsTrue(result.Length > 500);
		Assert.IsTrue(result.Contains("Address1"));
		//PrintResult(result, nameof(this.PropertiesToStringTest));

		var coordinate = RandomData.GenerateCoordinate<CoordinateProper>();

		result = coordinate.PropertiesToString();

		Assert.IsTrue(result.Length > 50);
		Assert.IsTrue(result.Contains("X"));
		//PrintResult(result, nameof(this.PropertiesToStringTest));

		var personCollection = RandomData.GeneratePersonRecordCollection(5);

		result = personCollection.PropertiesToString();
		Assert.IsTrue(result.Contains("LastName"));
		Assert.IsTrue(result.Length > 1000);
	}

	[TestMethod]
	public void StripNullTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();
		PersonProper nullPerson = null;

		Assert.IsFalse(string.IsNullOrEmpty(person.StripNull()));
		Assert.IsTrue(string.IsNullOrEmpty(nullPerson.StripNull()));
	}

	[TestMethod]
	public void ToJsonFileTest()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		var fileName = Path.Combine(App.ExecutingFolder(), "TEST.JSON");

		try
		{
			person.ToJsonFile(fileName);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}

		File.Delete(fileName);
	}

	[TestMethod]
	public void ToJsonTest_01()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		Assert.IsFalse(string.IsNullOrEmpty(person.ToJson()));
	}

	[TestMethod]
	public void ToJsonTest_02()
	{
		var person = RandomData.GenerateRefPerson<PersonProper>();

		var json = person.ToJson(JsonSerializerOptions.Default);

		Assert.IsTrue(json.IsSuccessful);
		Assert.IsFalse(string.IsNullOrEmpty(json.Value));
	}

	[TestMethod]
	public void TryDisposeTest()
	{
		var disposableObj = new DisposableFields();

		try
		{
			disposableObj.TryDispose();
			disposableObj.TryDispose(true);
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
			Assert.Fail();
		}
	}
}
