// ***********************************************************************
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

namespace dotNetTips.Spargine.Extensions.Tests
{

	public class DisposableFields : IDisposable
	{
		private readonly DataSet _dataSet = new DataSet("TEST");
		private readonly DataSet[] _disposableObjArray = new DataSet[] { new DataSet(), new DataSet() };
		private readonly string _testString;
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
	public class ObjectExtensionsTests
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

			var result = personProper.PropertiesToDictionary();

			Assert.IsTrue(result.Count() > 1);
		}

		[TestMethod]
		public void PropertiesToStringTest()
		{
			var personProper = RandomData.GeneratePersonCollection(1).First();

			var result = personProper.PropertiesToString();

			Assert.IsTrue(result.Length > 700);
			Assert.IsTrue(result.Contains("Addresses"));

			var person = RandomData.GeneratePerson<PersonProper>();

			result = person.PropertiesToString();

			Assert.IsTrue(result.Length > 400);
			Assert.IsTrue(result.Contains("Address1"));

			var coordinate = RandomData.GenerateCoordinate<CoordinateProper>();

			result = coordinate.PropertiesToString();

			Assert.IsTrue(result.Length > 25);
			Assert.IsTrue(result.Contains("X"));

			var personCollection = RandomData.GeneratePersonCollection(5);

			Assert.ThrowsException<ArgumentInvalidException>(() => personCollection.PropertiesToString());
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
}
