// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2021
// ***********************************************************************
// <copyright file="ExecutionHelperTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class ExecutionHelperTests
	{
		[TestMethod]
		public void ProgressiveRetryTest()
		{
			var tries = 0;

			try
			{
				tries = ExecutionHelper.ProgressiveRetry(() =>
				  {
					  var drives = DriveHelper.GetRemovableDrives();
				  }, 3, 10);
			}
			catch (Exception ex)
			{
				Assert.Fail($"Progressive retry failed: {ex.Message}.");
			}

			Assert.IsTrue(tries > 0);
		}
	}
}
