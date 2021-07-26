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
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources.Extensions;
using System.Runtime.CompilerServices;
using System.Security;
using System.Xml.Serialization;
using dotNetTips.Spargine.Cache;
using dotNetTips.Spargine.Collections.Generic;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.EntityFrameworkCore.SqlServer.Scaffolding.Internal;
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

		[TestMethod]
		public void DoesObjectImplementInterfaceTest()
		{
			var table = new DataTable();

			var result = table.DoesObjectImplementInterface("IComponent");

			Assert.IsTrue(result.Count() == 1);

			result = table.DoesObjectImplementInterface("IFakeInterface");

			Assert.IsTrue(result.Count() == 0);

			result = table.DoesObjectImplementInterface("IComponent", "IDisposable");

			Assert.IsTrue(result.Count() == 2);

		}

		/// <summary>
		/// Defines the test method GetAbstractMethodsTest.
		/// </summary>
		[TestMethod]
		public void GetAbstractMethodsTest()
		{
			var result = typeof(AbstractTestType).GetAllAbstractMethods();

			Assert.IsTrue(result.Count() == 1);

			result = typeof(DataTable).GetAllAbstractMethods();

			Assert.IsTrue(result.Count() == 0);
		}

		[TestMethod]
		public void GetAllDeclaredFieldsTest()
		{
			var result = typeof(PersonProper).GetAllDeclaredFields();

			Assert.IsTrue(result.Count() > 0);
		}

		[TestMethod]
		public void GetAllDeclaredMethodsTest()
		{
			var result = typeof(PersonProper).GetAllDeclaredMethods();

			Assert.IsTrue(result.Count() > 0);
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
			var result1 = typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<DebuggerBrowsableAttribute>();

			Assert.IsNotNull(result1);

			var result2 = typeof(TestType).GetAllFields().FirstOrDefault().GetAttribute<XmlIgnoreAttribute>();

			Assert.IsNull(result2);
		}

		/// <summary>
		/// Defines the test method GetAttributeMethodTest.
		/// </summary>
		[TestMethod]
		public void GetAttributeMethodTest()
		{
			var method = typeof(TestType).GetAllMethods().Where(p => string.Compare(p.Name, "get_UserName", StringComparison.Ordinal) == 0).FirstOrDefault();

			var result1 = method.GetAttribute<CompilerGeneratedAttribute>();

			Assert.IsNotNull(result1);

			var result2 = method.GetAttribute<XmlIgnoreAttribute>();

			Assert.IsNull(result2);
		}

		/// <summary>
		/// Defines the test method GetAttributePropertyTest.
		/// </summary>
		[TestMethod]
		public void GetAttributePropertyTest()
		{
			var property = typeof(TestType).GetAllProperties().FirstOrDefault();

			var result1 = property.GetAttribute<DebuggerBrowsableAttribute>();

			Assert.IsNotNull(result1);

			var result2 = property.GetAttribute<XmlAnyAttributeAttribute>();

			Assert.IsNull(result2);
		}

		/// <summary>
		/// Defines the test method GetAttributeTypeTest.
		/// </summary>
		[TestMethod]
		public void GetAttributeTypeTest()
		{
			var result1 = typeof(TestType).GetAttribute<XmlRootAttribute>();

			Assert.IsNotNull(result1);

			var result2 = typeof(TestType).GetAttribute<XmlIgnoreAttribute>();

			Assert.IsNull(result2);
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

		[TestMethod]
		public void GetMaxTest()
		{
			var cord1 = RandomData.GenerateCoordinate<CoordinateProper>();
			var cord2 = RandomData.GenerateCoordinate<CoordinateProper>();

			var result = cord1.Max(cord2);

			Assert.IsNotNull(result);
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
			var result1 = typeof(TestType).GetTypeMembersWithAttribute<XmlIgnoreAttribute>();

			Assert.IsTrue(result1.Count() == 1);

			var result2 = typeof(TestType).GetTypeMembersWithAttribute<XmlAnyAttributeAttribute>();

			Assert.IsTrue(result2.Count() == 0);
		}

		[TestMethod]
		public void HasAttributeTest()
		{
#pragma warning disable SYSLIB0003 // Type or member is obsolete
			var result1 = typeof(PermissionSet).GetMethod("ConvertPermissionSet").HasAttribute<ObsoleteAttribute>();
#pragma warning restore SYSLIB0003 // Type or member is obsolete

			Assert.IsTrue(result1);

#pragma warning disable SYSLIB0003 // Type or member is obsolete
			var result2 = typeof(PermissionSet).GetMethod("ConvertPermissionSet").HasAttribute<XmlAnyAttributeAttribute>();
#pragma warning restore SYSLIB0003 // Type or member is obsolete

			Assert.IsFalse(result2);
		}

		[TestMethod]
		public void HasBaseClassTest()
		{
			var result1 = typeof(DataTable).HasBaseClass(typeof(MarshalByValueComponent));

			Assert.IsTrue(result1);

			var result2 = typeof(DataTable).HasBaseClass(typeof(ValueType));

			Assert.IsFalse(result2);
		}

		[TestMethod]
		public void HasParameterlessConstructorTest()
		{
			var result = typeof(PersonProper).HasParameterlessConstructor();

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void IsEnumerableTest()
		{
			var result1 = typeof(BitArray).IsEnumerable();

			Assert.IsTrue(result1);

			var result2 = typeof(DataTable).IsEnumerable();

			Assert.IsFalse(result2);
		}


		[TestMethod]
		public void IsNullableTest()
		{
			var result1 = typeof(Foo).GetProperty("Bar").PropertyType.IsNullable();

			Assert.IsTrue(result1);

			var result2 = typeof(PersonProper).GetProperty("FirstName").PropertyType.IsNullable();

			Assert.IsFalse(result2);
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

		[TestMethod]
		public void IsStaticTest()
		{
			var result1 = typeof(InMemoryCache).GetProperty("Instance").IsStatic();
			Assert.IsTrue(result1);

			var result2 = typeof(PersonProper).GetProperty("FirstName").IsStatic();
			Assert.IsFalse(result2);
		}
	}

	internal class Foo
	{
		public int? Bar { get; set; }
	}
}
