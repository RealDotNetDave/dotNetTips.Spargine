// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-09-2023
// ***********************************************************************
// <copyright file="InMemoryCacheTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Cache;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Cache;
[ExcludeFromCodeCoverage]
[TestClass]
public class InMemoryCacheTests
{

	[TestMethod]
	public void CountTest()
	{
		var result = InMemoryCache.Instance;

		var person = RandomData.GenerateRefPerson<PersonProper>();

		result.AddCacheItem(person.Id, person);

		Assert.IsTrue(result.Cache.Count == 1);
	}
	[TestMethod]
	public void CreateInstanceTest()
	{
		var result = InMemoryCache.Instance;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void GetCashedItemTest()
	{
		var result = InMemoryCache.Instance;

		var person = RandomData.GenerateRefPerson<PersonProper>();

		result.AddCacheItem(person.Id, person);

		var item = result.GetCacheItem<PersonProper>(person.Id);

		Assert.IsNotNull(item);
	}

}
