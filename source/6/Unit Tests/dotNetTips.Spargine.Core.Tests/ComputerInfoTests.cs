// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Common.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="ComputerInfoTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests;

[ExcludeFromCodeCoverage]
[TestClass]
public class ComputerInfoTests
{

	[TestMethod]
	public void ComputerInfoTest()
	{
		var ci = new ComputerInfo();

		Assert.IsNotNull(ci);
	}
}
