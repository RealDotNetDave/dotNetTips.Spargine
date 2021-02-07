// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-07-2021
// ***********************************************************************
// <copyright file="WebHelperTests.cs" company="dotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;
using dotNetTips.Spargine.Core.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spartine.Core.Tests.Web
{
	[TestClass]
	public class WebHelperTests
	{
		[TestMethod]
		public void DownloadStringAsyncTest()
		{
			var result = WebHelper.DownloadStringAsync(new Uri(@"https://dotnettips.com"), clientId: "UNITTEST1").Result;

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void DownloadStringTest()
		{
			var result = WebHelper.DownloadString(new Uri(@"https://www.google.com/"), clientId: "UNITTEST2");

			Assert.IsTrue(string.IsNullOrEmpty(result) == false);
		}

		[TestMethod]
		public void GetHeaderNamesTest()
		{
			var result = WebHelper.HttpHeaderNames;

			Assert.IsTrue(result.Count() > 0);
		}
	}
}
