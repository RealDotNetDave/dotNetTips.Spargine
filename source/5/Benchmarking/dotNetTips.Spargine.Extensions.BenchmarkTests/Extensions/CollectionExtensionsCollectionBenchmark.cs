// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2021
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(CollectionExtensions))]
	public class CollectionExtensionsCollectionBenchmark : CollectionBenchmark
	{
		[Benchmark(Description = nameof(CollectionExtensions.AddRange))]
		public void AddRange01()
		{
			var people = new List<PersonProper>();

			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 2), Tristate.True);

			base.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": Predicate")]
		public void HasItems01()
		{
			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }
	}
}
