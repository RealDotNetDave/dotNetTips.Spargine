// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-01-2021
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
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{

	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ObjectExtensionsTests : TestClass
	{
		[TestMethod]
		public void AsTest()
		{
#pragma warning disable CS0618 // Type or member is obsolete
			var personProper = RandomData.GeneratePerson<PersonFixed>();
#pragma warning restore CS0618 // Type or member is obsolete

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
			var person = RandomData.GeneratePerson<PersonProper>();

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
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = person.ComputeSha256Hash();

			PrintResult(result, nameof(this.ComputeSha256HashTest));

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
		public void HasPropertyTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

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
			var person = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;

			Assert.IsFalse(person.IsNull());
			Assert.IsTrue(nullPerson.IsNull());

			Assert.IsTrue(person.IsNotNull());
			Assert.IsFalse(nullPerson.IsNotNull());
		}

		[TestMethod]
		public void PropertiesToDictionaryTest()
		{
			var personProper = RandomData.GeneratePersonCollection(1).First();

			var propertiesTest = new PropertiesTest
			{
				Id = RandomData.GenerateKey(),
				PersonProper = RandomData.GeneratePerson<PersonProper>(),
				PersonRecord = RandomData.GeneratePersonCollection(1).First(),
				Today = DateTime.Now
			};

			var result = personProper.PropertiesToDictionary(memberName: $"Person-{personProper.Id}", ignoreNulls: true);

			Assert.IsTrue(result.Count() > 1);

			result = propertiesTest.PropertiesToDictionary(memberName: $"TestPerson-{personProper.Id}", ignoreNulls: true);

			Assert.IsTrue(result.Count() > 1);
		}

		[TestMethod]
		public void PropertiesToStringTest()
		{
			var personRecord = RandomData.GeneratePersonCollection(1).First();

			var propertiesTest = new PropertiesTest
			{
				Id = RandomData.GenerateKey(),
				PersonProper = RandomData.GeneratePerson<PersonProper>(),
				PersonRecord = RandomData.GeneratePersonCollection(1).First(),
				Today = DateTimeOffset.Now,
				ClosedOn = DateTimeOffset.Now,
			};

			var result = personRecord.PropertiesToString(header: "PersonRecord", keyValueSeparator: ':', sequenceSeparator: ", ", ignoreNulls: true);

			Assert.IsTrue(result.Length > 1300);
			Assert.IsTrue(result.Contains("Addresses"));
			PrintResult(result, nameof(this.PropertiesToStringTest));

			result = propertiesTest.PropertiesToString(header: "PersonRecord", keyValueSeparator: ':', sequenceSeparator: ", ", ignoreNulls: true, includeMemberName: false);

			Assert.IsTrue(result.Length > 1300);
			Assert.IsTrue(result.Contains("Addresses"));
			PrintResult(result, nameof(this.PropertiesToStringTest));

			var person = RandomData.GeneratePerson<PersonProper>();

			result = person.PropertiesToString(header: person.Id);

			Assert.IsTrue(result.Length > 900);
			Assert.IsTrue(result.Contains("Address1"));
			PrintResult(result, nameof(this.PropertiesToStringTest));

			var coordinate = RandomData.GenerateCoordinate<CoordinateProper>();

			result = coordinate.PropertiesToString();

			Assert.IsTrue(result.Length > 50);
			Assert.IsTrue(result.Contains("X"));
			PrintResult(result, nameof(this.PropertiesToStringTest));

			var personCollection = RandomData.GeneratePersonCollection(5);

			result = personCollection.PropertiesToString();
			Assert.IsTrue(result.Contains("Item"));
			Assert.IsTrue(result.Length > 6000);
		}

		[TestMethod]
		public void StripNullTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;

			Assert.IsFalse(string.IsNullOrEmpty(person.StripNull()));
			Assert.IsTrue(string.IsNullOrEmpty(nullPerson.StripNull()));
		}


		[TestMethod]
		public void ToJsonFileTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

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
		public void ToJsonTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			Assert.IsFalse(string.IsNullOrEmpty(person.ToJson()));
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
}
