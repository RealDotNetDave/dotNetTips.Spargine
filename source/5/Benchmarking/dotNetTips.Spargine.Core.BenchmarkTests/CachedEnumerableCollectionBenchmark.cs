// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-24-2021
// ***********************************************************************
// <copyright file="CachedEnumerableCollectionBenchmark.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;

namespace dotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// Collection type PerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Collections)]
	public class CachedEnumerableCollectionBenchmark : CollectionBenchmark
	{
		[Benchmark(Description = "CachedEnumerable.Create: From List")]
		[BenchmarkCategory(Categories.Collections)]
		public void CollectionCreate01()
		{
			using var result = CachedEnumerable.Create(this.PersonProperList);

			this.Consumer.Consume(result);
		}
	}
}
