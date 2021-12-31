// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-03-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-03-2021
// ***********************************************************************
// <copyright file="InMemoryCacheTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Spargine.Cache;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Tests.Cache
{
	[TestClass]
	public class InMemoryCacheTests
	{
		[TestMethod]
		public void CreateInstanceTest()
		{
			var result = InMemoryCache.Instance;

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void CountTest()
		{
			var result = InMemoryCache.Instance;

			var person = RandomData.GeneratePerson<PersonProper>();

			result.AddCacheItem(person.Id, person);

			Assert.IsTrue(InMemoryCache.Count == 1);
		}

		[TestMethod]
		public void GetCashedItemTest()
		{
			var result = InMemoryCache.Instance;

			var person = RandomData.GeneratePerson<PersonProper>();

			result.AddCacheItem(person.Id, person);

			var item = result.GetCacheItem<PersonProper>(person.Id);

			Assert.IsNotNull(item);
		}
	}
}
