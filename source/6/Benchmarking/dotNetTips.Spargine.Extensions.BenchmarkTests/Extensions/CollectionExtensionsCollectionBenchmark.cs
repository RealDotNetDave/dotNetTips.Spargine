// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

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
		public void HasItems()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Count")]
		public void HasItemsWithCount()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(5);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Predicate")]
		public void HasItemsWithPredicate()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToCollection().HasItems(p => p.Age.TotalDays > 5);

			base.Consumer.Consume(result);
		}
	}
}
