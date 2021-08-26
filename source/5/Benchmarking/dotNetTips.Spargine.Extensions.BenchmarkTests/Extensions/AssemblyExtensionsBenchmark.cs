// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 02-21-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-24-2021
// ***********************************************************************
// <copyright file="AssemblyExtensionsBenchmark.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Reflection;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions
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

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(AssemblyExtensions.GetAllTypes))]
		[BenchmarkCategory(Categories.Reflection)]
		public void GetAllTypes01()
		{
			var result = Assembly.GetExecutingAssembly().GetAllTypes();

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(AssemblyExtensions.GetInstances))]
		[BenchmarkCategory(Categories.Reflection)]
		public void GetInstances01()
		{
			var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsBenchmark>();

			this.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();
		}
	}
}
