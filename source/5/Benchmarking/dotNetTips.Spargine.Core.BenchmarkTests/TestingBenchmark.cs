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
using System;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;

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
		private readonly TimeSpan _testTimeSpan1 = new(500, 9, 24, 10, 450);
		private readonly TimeSpan _testTimeSpan2 = new(100, 10, 24, 10, 9);

		[Benchmark(Description = "CalculatePercent", Baseline = true)]
		public void CalculatePercent01()
		{
			var result = WIPTests.CalculatePercent(this._testTimeSpan1, this._testTimeSpan2);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "CalculatePercentAggressiveInline")]
		public void CalculatePercent02()
		{
			var result = WIPTests.CalculatePercentAggressiveInline(this._testTimeSpan1, this._testTimeSpan2);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "CalculatePercentNoInline")]
		public void CalculatePercent03()
		{
			var result = WIPTests.CalculatePercentNoInline(this._testTimeSpan1, this._testTimeSpan2);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "CalculatePercentNoOptimization")]
		public void CalculatePercent04()
		{
			var result = WIPTests.CalculatePercentNoOptimization(this._testTimeSpan1, this._testTimeSpan2);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "CalculatePercentSynchronized")]
		public void CalculatePercent05()
		{
			var result = WIPTests.CalculatePercentSynchronized(this._testTimeSpan1, this._testTimeSpan2);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "CalculatePercentPreserveSig")]
		public void CalculatePercent06()
		{
			var result = WIPTests.CalculatePercentPreserveSig(this._testTimeSpan1, this._testTimeSpan2);

			this.Consumer.Consume(result);
		}
	}
}
