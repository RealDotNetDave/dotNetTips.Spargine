// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2022
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class CollectionExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{
		[Benchmark(Description = nameof(CollectionExtensions.AddRange))]
		public void AddRange01()
		{
			var people = base.GetPersonProperArray(Tristate.False).ToCollection();

			_ = people.AddRange(base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(Count / 2), Tristate.True);

			base.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems))]
		public void HasItems01()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Count")]
		public void HasItems02()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);

			base.Consumer.Consume(result);
		}
	}
}
