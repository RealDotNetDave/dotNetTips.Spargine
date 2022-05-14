// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-05-2022
// ***********************************************************************
// <copyright file="CollectionCollectionBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections
{
	/// <summary>
	/// Collection type PerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Collections)]
	public class CollectionCollectionBenchmark : LargeCollectionBenchmark
	{

		/// <summary>
		/// Collections the create01.
		/// </summary>
		[Benchmark(Description = "Collection.Create: Count")]
		public void CollectionCreate01()
		{
			var result = Collection<Person>.Create(Count);

			this.Consumer.Consume(result);
		}

		/// <summary>
		/// Collections the create02.
		/// </summary>
		[Benchmark(Description = "Collection.Create: From List")]
		public void CollectionCreate02()
		{
			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), Tristate.True);

			this.Consumer.Consume(result);
		}

		/// <summary>
		/// Collections the create03.
		/// </summary>
		[Benchmark(Description = "Collection.Create: From List-Ensure Unique")]
		public void CollectionCreate03()
		{
			var result = Collection<PersonProper>.Create(this.GetPersonProperArray(), ensureUnique: Tristate.True);

			this.Consumer.Consume(result);
		}
	}
}
