// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2023
// ***********************************************************************
// <copyright file="WebHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Tests.Web;

[ExcludeFromCodeCoverage]
[TestClass]
public class WebHelperTests
{

	[TestMethod]
	public void DownloadStringAsyncTest()
	{
		var result = WebHelper.DownloadStringAsync(new Uri(@"https://dotnettips.com"), clientId: "UNITTEST1").GetAwaiter().GetResult;

		Assert.IsNotNull(result);
	}

	[TestMethod]
	public void DownloadStringTest()
	{
		var result = WebHelper.DownloadStringAsync(new Uri(@"https://www.google.com/"), clientId: "UNITTEST2").GetAwaiter().GetResult();

		Assert.IsTrue(string.IsNullOrEmpty(result) is false);
	}

}
