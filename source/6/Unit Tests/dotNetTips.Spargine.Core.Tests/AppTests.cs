// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.Tests
// Author           : David McCarter
// Created          : 11-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-23-2022
// ***********************************************************************
// <copyright file="AppTests.cs" company="DotNetTips.Spargine.Core.Tests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace dotNetTips.Spargine.Core.Tests
{
	[ExcludeFromCodeCoverage]
	[TestClass]
	public class AppTests
	{
		[TestMethod]
		public void AppInfoTest()
		{
			var info = App.AppInfo;

			Assert.IsTrue(info is not null);
		}

		[TestMethod]
		public void ChangeCultureTest()
		{
			App.ChangeCulture("aa");

			Assert.AreEqual("aa", App.CurrentCulture.Name);

			App.ChangeUICulture("af");

			Assert.AreEqual("af", App.CurrentUICulture.Name);

			App.ChangeCulture("en-US");
			App.ChangeUICulture("en-US");
		}

		[TestMethod]
		public void ExecutingFolderTest()
		{
			var result = App.ExecutingFolder();

			Assert.IsTrue(string.IsNullOrEmpty(result) is false);
		}

		[TestMethod]
		public void FrameworkDescriptionTest()
		{
			var result = App.FrameworkDescription;

			Assert.IsTrue(string.IsNullOrEmpty(result) is false);
		}

		[TestMethod]
		public void GetCultureTest()
		{
			var result = App.CurrentCulture;

			Assert.IsNotNull(result);

			result = App.CurrentUICulture;

			Assert.IsNotNull(result);

			result = App.InstalledUICulture;

			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetEnvironmentVariablesTest()
		{
			var result = App.GetEnvironmentVariables();

			Assert.IsTrue(result.FastCount() > 0);

			foreach (var info in result)
			{
				Debug.WriteLine($"{info.Key}:{info.Value}");
			}
		}

		[TestMethod]
		public void InformationTest()
		{
			var result1 = App.StackTrace;

			Assert.IsTrue(string.IsNullOrEmpty(result1) is false);


			var result3 = App.OSArchitecture;

			Assert.IsTrue(result3 == Architecture.X64);

			var result4 = App.OSDescription;

			Assert.IsTrue(string.IsNullOrEmpty(result4) is false);

			var result5 = App.ProcessArchitecture;

			Assert.IsTrue(result5 == Architecture.X64);


			var result2 = App.WorkingSet;

			Assert.IsTrue(result2 > 0);
		}

		[TestMethod]
		public void IsRunningFromAspNet()
		{
			var result = App.IsRunningFromAspNet();

			Assert.IsFalse(result);
		}

		[TestMethod]
		public void IsRunningTest()
		{
			var result = App.IsRunning();

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void IsUserAdministrator()
		{
			var result = App.IsUserAdministrator();

			Assert.IsFalse(result);
		}

		[TestMethod]
		public void ReferencedAssembliesTest()
		{
			var result = App.ReferencedAssemblies();

			Assert.IsTrue(result.FastCount() > 0);
		}
	}
}
