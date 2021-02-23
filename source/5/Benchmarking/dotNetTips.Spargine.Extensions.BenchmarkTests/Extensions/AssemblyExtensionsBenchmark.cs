// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 02-21-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
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
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.Benchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.Benchmark" />
	[BenchmarkCategory(nameof(AssemblyExtensions))]
	public class AssemblyExtensionsBenchmark : Benchmark
	{

		[Benchmark(Description = nameof(AssemblyExtensions.GetAllTypes))]
		public void GetAllTypes01()
		{
			var result = Assembly.GetExecutingAssembly().GetAllTypes();

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(AssemblyExtensions.GetInstances))]
		public void GetInstances01()
		{
			var result = Assembly.GetExecutingAssembly().GetInstances<AssemblyExtensionsBenchmark>();

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(AssemblyExtensions.GetInterfaces))]
		public void GetInterfaces01()
		{
			var result = Assembly.GetExecutingAssembly().GetInterfaces();

			this.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();
		}
	}
}
