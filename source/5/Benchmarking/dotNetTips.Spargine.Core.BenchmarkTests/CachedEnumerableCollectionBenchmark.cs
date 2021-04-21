// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2021
// ***********************************************************************
// <copyright file="CachedEnumerableCollectionPerfTestRunner.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// Collection type PerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	[BenchmarkCategory("CachedEnumerable Class")]
	public class CachedEnumerableCollectionBenchmark : CollectionBenchmark
	{
		[Benchmark(Description = "CachedEnumerable.Create: From List")]
		public void CollectionCreate01()
		{
			var result = CachedEnumerable.Create<PersonProper>(this.PersonProperList);

			this.Consumer.Consume(result);
		}
	}
}
