// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class AssemblyExtensionsTests
{

	[TestMethod]
	public void GetAllTypesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetAllTypes();

		Assert.IsTrue(result.FastCount() >= 1);
	}

	[TestMethod]
	public void GetInstancesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsTests>();

		Assert.IsTrue(result.FastCount() == 1);
	}

	[TestMethod]
	public void GetInterfacesTest()
	{
		var assembly = Assembly.GetExecutingAssembly();

		var result = assembly.GetAllInterfaces().ToList();

		Assert.IsTrue(result.FastCount() > 0);
	}

	[TestMethod]
	public void GetTypesTest()
	{
		var result = Assembly.GetExecutingAssembly().GetTypes();

		Assert.IsTrue(result.FastCount() > 0);
	}

}
