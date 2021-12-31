// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.Tests
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2020
// ***********************************************************************
// <copyright file="DirectoryInfoTests.cs" company="dotNetTips.Spargine.Extensions.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class DirectoryInfoExtensionsTests
	{
		[TestMethod]
		public void DirectoryInfoSizeTest01()
		{
			var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

			var result = directory.GetSize();

			Assert.IsTrue(result > 0);

			_ = Assert.ThrowsException<NullReferenceException>(() => DirectoryInfoExtensions.GetSize(null));
		}

		[TestMethod]
		public void DirectoryInfoSizeTest02()
		{
			var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

			var result = directory.GetSize("*.*");

			Assert.IsTrue(result > 0);

			_ = Assert.ThrowsException<ArgumentNullException>(() => directory.GetSize(null) == 0);
		}

		[TestMethod]
		public void DirectoryInfoSizeTest03()
		{
			var directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

			var result = directory.GetSize(searchPattern: "*.*", searchOption: SearchOption.AllDirectories);

			Assert.IsTrue(result > 0);

			_ = Assert.ThrowsException<ArgumentOutOfRangeException>(() => directory.GetSize("*.txt", (SearchOption)100) ==
				0);
		}
	}
}
