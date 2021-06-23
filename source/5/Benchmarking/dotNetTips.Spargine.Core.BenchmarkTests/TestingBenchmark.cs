// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-20-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="TestingBenchmark.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// Testing Benchmark for temporary tests.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.Benchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.Benchmark" />
	[BenchmarkCategory("TESTS")]
	public class TestingBenchmark : Benchmark
	{
		private readonly PersonRecord person = RandomData.GeneratePersonCollection(1).First();

		[Benchmark(Description = "Baseline", Baseline = true)]
		public void WIPTest01()
		{
			var result = WIPTests.TryValidateNull(this.person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "AggressiveInline")]
		public void WIPTest02()
		{
			var result = WIPTests.TryValidateNullAgressive(this.person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "NoInline")]
		public void WIPTest03()
		{
			var result = WIPTests.TryValidateNullNoInlining(this.person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "NoOptimization")]
		public void WIPTest04()
		{
			var result = WIPTests.TryValidateNullNoOptimization(this.person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "PreserveSig")]
		public void WIPTest05()
		{
			var result = WIPTests.TryValidateNullPreserveSig(this.person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "Synchronized")]
		public void WIPTest06()
		{
			var result = WIPTests.TryValidateNullSynchronized(this.person);

			this.Consumer.Consume(result);
		}
	}
}
