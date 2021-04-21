// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-22-2021
// ***********************************************************************
// <copyright file="TypeExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{

	/// <summary>
	/// Defines test class TypeExtensionsTests.
	/// </summary>
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class TypeExtensionsTests
	{

		/// <summary>
		/// Defines the test method GetAbstractMethodsTest.
		/// </summary>
		[TestMethod]
		public void GetAbstractMethodsTest()
		{
			var result = typeof(AbstractTestType).GetAllAbstractMethods();

			Assert.IsTrue(result.Count() == 1);
		}

		/// <summary>
		/// Defines the test method GetAllFieldsTest.
		/// </summary>
		[TestMethod]
		public void GetAllFieldsTest()
		{
			var result = typeof(TestType).GetAllFields();

			Assert.IsTrue(result.Count() == 1);

			result = typeof(PersonProper).GetAllFields();

			Assert.IsTrue(result.Count() >= 12);
		}

		/// <summary>
		/// Defines the test method GetAllMethodsTest.
		/// </summary>
		[TestMethod]
		public void GetAllMethodsTest()
		{
			var result = typeof(TestType).GetAllMethods();

			Assert.IsTrue(result.Count() == 13);

			result = typeof(PersonProper).GetAllMethods();

			Assert.IsTrue(result.Count() >= 45);
		}

		/// <summary>
		/// Defines the test method GetAttributeFieldTest.
		/// </summary>
		[TestMethod]
		public void GetAttributeFieldTest()
		{
			var field = typeof(TestType).GetAllFields().FirstOrDefault();

			var result = field.GetAttribute<CompilerGeneratedAttribute>();

			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Defines the test method GetAttributeMethodTest.
		/// </summary>
		[TestMethod]
		public void GetAttributeMethodTest()
		{
			var method = typeof(TestType).GetAllMethods().Where(p => string.Compare(p.Name, "get_UserName", StringComparison.Ordinal) == 0).FirstOrDefault();

			var result = method.GetAttribute<CompilerGeneratedAttribute>();

			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Defines the test method GetAttributePropertyTest.
		/// </summary>
		[TestMethod]
		public void GetAttributePropertyTest()
		{
			var property = typeof(TestType).GetAllProperties().FirstOrDefault();

			var result = property.GetAttribute<DebuggerBrowsableAttribute>();

			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Defines the test method GetAttributeTypeTest.
		/// </summary>
		[TestMethod]
		public void GetAttributeTypeTest()
		{
			var result = typeof(TestType).GetAttribute<XmlRootAttribute>();

			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Defines the test method GetGenericMethodsTest.
		/// </summary>
		[TestMethod]
		public void GetGenericMethodsTest()
		{
			var result = typeof(TestType).GetAllGenericMethods();

			Assert.IsTrue(result.Count() == 1);
		}

		/// <summary>
		/// Defines the test method GetPropertiesTest.
		/// </summary>
		[TestMethod]
		public void GetPropertiesTest()
		{
			var result = typeof(PersonProper).GetAllProperties();

			Assert.IsTrue(result.Count() >= 10);
		}

		/// <summary>
		/// Defines the test method GetPublicMethodsTest.
		/// </summary>
		[TestMethod]
		public void GetPublicMethodsTest()
		{
			var result = typeof(PersonProper).GetAllPublicMethods();

			Assert.IsTrue(result.Count() >= 30);
		}

		/// <summary>
		/// Defines the test method GetStaticMethodsTest.
		/// </summary>
		[TestMethod]
		public void GetStaticMethodsTest()
		{
			var result = typeof(TestType).GetAllStaticMethods();

			Assert.IsTrue(result.Count() == 1);
		}

		/// <summary>
		/// Defines the test method GetTypeMembersWithGivenAttributeTest.
		/// </summary>
		[TestMethod]
		public void GetTypeMembersWithGivenAttributeTest()
		{
			var result = typeof(TestType).GetTypeMembersWithAttribute<XmlIgnoreAttribute>();

			Assert.IsTrue(result.Count() == 1);
		}

		/// <summary>
		/// Defines the test method IsNumericTest.
		/// </summary>
		[TestMethod]
		public void IsNumericTest()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(10).AsEnumerable();
			var person = RandomData.GeneratePerson<PersonProper>();

			Assert.IsTrue(people.GetType().IsEnumerable());
			Assert.IsFalse(person.GetType().IsEnumerable());
		}

	}
}
