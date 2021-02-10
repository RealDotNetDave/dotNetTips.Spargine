using System;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTips.Spargine.Extensions.Tests
{
	[TestClass]
	public class AssemblyExtensionsTests
	{
		[TestMethod]
		public void GetInstancesTest()
		{
			var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(p => p.FullName.Contains("dotNetTips.Spargine.Extensions.Tests")).First();

			var result = assembly.GetInstances<AssemblyExtensionsTests>().ToList();

			Assert.IsTrue(result.Count == 1);
		}

		[TestMethod]
		public void GetInterfacesTest()
		{
			var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(p => p.FullName.Contains("dotNetTips.Spargine.Extensions.Tests")).First();

			var result = assembly.GetInterfaces<AssemblyExtensionsTests>().ToList();

			Assert.IsTrue(result.Count >= 0);
		}

		[TestMethod]
		public void GetTypesTest02()
		{
			var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(p => p.FullName.Contains("dotNetTips.Spargine.Extensions.Tests")).First();

			var result = assembly.GetTypes(typeof(ICloneable));

			Assert.IsTrue(result.Count() == 0);
		}
	}
}
