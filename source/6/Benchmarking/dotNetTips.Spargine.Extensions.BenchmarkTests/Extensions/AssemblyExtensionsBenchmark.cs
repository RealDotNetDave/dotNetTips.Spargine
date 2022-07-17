// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 02-21-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-23-2022
// ***********************************************************************
// <copyright file="AssemblyExtensionsBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Reflection;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests.Extensions
{
	/// <summary>
	/// AssemblyExtensions Benchmark tests.
	/// Implements the <see cref="Benchmark" />
	/// </summary>
	/// <seealso cref="Benchmark" />
	public class AssemblyExtensionsBenchmark : Benchmark
	{

		[Benchmark(Description = nameof(AssemblyExtensions.GetAllInterfaces))]
		[BenchmarkCategory(Categories.Reflection)]
		public void GetAllInterfaces01()
		{
			var result = Assembly.GetExecutingAssembly().GetAllInterfaces();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(AssemblyExtensions.GetAllTypes))]
		[BenchmarkCategory(Categories.Reflection)]
		public void GetAllTypes01()
		{
			var result = Assembly.GetExecutingAssembly().GetAllTypes();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(AssemblyExtensions.GetInstances))]
		[BenchmarkCategory(Categories.Reflection)]
		public void GetInstances01()
		{
			var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsBenchmark>();

			base.Consumer.Consume(result);
		}
	}
}
