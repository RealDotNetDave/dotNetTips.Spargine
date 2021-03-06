﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
// ***********************************************************************
// <copyright file="ObjectExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	public class DisposableFields : IDisposable
	{
		private readonly DataSet _dataSet = new DataSet("TEST");
		private bool disposedValue;

		// // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
		// ~DisposableFields()
		// {
		//     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		//     Dispose(disposing: false);
		// }

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			this.Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				if (disposing)
				{
					this._dataSet.Dispose();
				}

				// TODO: free unmanaged resources (unmanaged objects) and override finalizer
				// TODO: set large fields to null
				this.disposedValue = true;
			}
		}
	}

	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ObjectExtensionsTests : TestClass
	{
		[TestMethod]
		public void AsTest()
		{
			var personProper = RandomData.GeneratePerson<PersonFixed>();

			try
			{
				Assert.IsNotNull(personProper.As<IPerson>());
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
				Assert.Fail();
			}

			PersonProper nullPerson = null;

			Assert.ThrowsException<ArgumentNullException>(() => nullPerson.As<Person>());
		}

		[TestMethod]
		public void CloneTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;

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

			Assert.ThrowsException<ArgumentNullException>(() => nullPerson.Clone<PersonProper>());
		}

		[TestMethod]
		public void ComputeSha256HashTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;

			var result = person.ComputeSha256Hash();

			PrintResult(result, nameof(this.ComputeSha256HashTest));

			Assert.IsFalse(string.IsNullOrEmpty(result));

			Assert.ThrowsException<ArgumentNullException>(() => nullPerson.ComputeSha256Hash());
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
			PersonProper nullPerson = null;

			Assert.IsTrue(person.HasProperty("Id"));

			Assert.IsFalse(person.HasProperty("XXXXXXXXXXXXX"));

			Assert.ThrowsException<ArgumentNullException>(() => nullPerson.HasProperty("Id"));
		}

		[TestMethod]
		public void InitializeFieldsTest()
		{
			var testObject = new DisposableFields();
			DisposableFields nullTestObject = null;

			testObject.InitializeFields();

			Assert.ThrowsException<ArgumentNullException>(() => nullTestObject.InitializeFields());
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

			result = propertiesTest.PropertiesToString(header: "PersonRecord", keyValueSeparator: ':', sequenceSeparator: ", ", ignoreNulls: true, includeMemeberName: false);

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
			PersonProper nullPerson = null;

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

			Assert.ThrowsException<ArgumentNullException>(() => nullPerson.ToJsonFile(fileName));
			Assert.ThrowsException<ArgumentNullException>(() => person.ToJsonFile(string.Empty));

			File.Delete(fileName);
		}

		[TestMethod]
		public void ToJsonTest()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			PersonProper nullPerson = null;

			Assert.IsFalse(string.IsNullOrEmpty(person.ToJson()));
			Assert.IsTrue(string.IsNullOrEmpty(nullPerson.ToJson()));
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

	[ExcludeFromCodeCoverage]
	public class PropertiesTest
	{

		public DateTimeOffset? ClosedOn { get; set; }
		public string Id { get; set; }

		public PersonProper PersonProper { get; set; }

		public PersonRecord PersonRecord { get; set; }

		public DateTimeOffset Today { get; set; }
	}
}
