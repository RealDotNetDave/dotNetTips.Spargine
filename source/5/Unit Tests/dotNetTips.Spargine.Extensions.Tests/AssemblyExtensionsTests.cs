// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="AssemblyExtensionsTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class AssemblyExtensionsTests
	{

		[TestMethod]
		public void GetAllTypesTest()
		{
			var result = Assembly.GetExecutingAssembly().GetAllTypes();

			Assert.IsTrue(result.Count() >= 1);
		}

		[TestMethod]
		public void GetInstancesTest()
		{
			var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsTests>();

			Assert.IsTrue(result.Count() == 1);
		}

		[TestMethod]
		public void GetInterfacesTest()
		{
			var assembly = Assembly.GetExecutingAssembly();

			var result = assembly.GetAllInterfaces().ToList();

			Assert.IsTrue(result.Count >= 0);
		}

		[TestMethod]
		public void GetTypesTest()
		{
			var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsTests>();

			Assert.IsTrue(result.Count() == 1);
		}
	}
}
