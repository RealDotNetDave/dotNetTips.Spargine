// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2021
// ***********************************************************************
// <copyright file="CollectionCollectionBenchmark.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core.Collections.Generic;
using dotNetTips.Spargine.Tester.Models.RefTypes;

namespace dotNetTips.Spargine.Core.BenchmarkTests.Collections
{
	/// <summary>
	/// Collection type PerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Collections)]
	public class CollectionCollectionBenchmark : CollectionBenchmark
	{
		[Benchmark(Description = "Collection.Create: Count")]
		public void CollectionCreate01()
		{
			var result = Collection<PersonProper>.Create(this.Count);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "Collection.Create: From List")]
		public void CollectionCreate02()
		{
			var result = Collection<PersonProper>.Create(this.PersonProperList);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "Collection.Create: From List-Ensure Unique")]
		public void CollectionCreate03()
		{
			var result = Collection<PersonProper>.Create(this.PersonProperList, ensureUnique: Tristate.True);

			this.Consumer.Consume(result);
		}
	}
}
