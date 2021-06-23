// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-10-2020
// ***********************************************************************
// <copyright file="EnumHelperTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>EnumHelper Tests.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net.Cache;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spartine.Core.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class EnumHelperTests
	{

		[TestMethod]
		public void AddToPersonCollectionTest()
		{
			var result = EnumHelper.GetValues<RequestCacheLevel>(false, false);
			Assert.IsTrue(result.Count() > 0);

			result = EnumHelper.GetValues<HttpCacheAgeControl>(true, false);
			Assert.IsTrue(result.Count() > 0);

			result = EnumHelper.GetValues<HttpCacheAgeControl>(false, true);
			Assert.IsTrue(result.Count() > 0);

			result = EnumHelper.GetValues<HttpCacheAgeControl>(true, true);
			Assert.IsTrue(result.Count() > 0);
		}

	}
}
