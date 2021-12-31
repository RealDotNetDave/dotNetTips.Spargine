// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2021
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester.Models.RefTypes;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class CollectionExtensionsCollectionBenchmark : CollectionBenchmark
	{
		[Benchmark(Description = nameof(CollectionExtensions.AddRange))]
		public void AddRange01()
		{
			var people = new List<PersonProper>().ToCollection();

			people.AddRange(base.PersonProperList.Take(base.Count / 2), Tristate.True);

			base.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems))]
		public void HasItems01()
		{
			var result = base.PersonProperList.ToCollection().HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Count")]
		public void HasItems02()
		{
			var result = base.PersonProperList.ToCollection().HasItems(5);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToCollection))]
		public void To100()
		{
			var result = base.PersonProperList.ToCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(HashSetExtensions.ToConcurrentHashSet))]
		public void To101()
		{
			var result = base.PersonProperHashSet.ToConcurrentHashSet();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToDistinctBlockingCollection))]
		public void To102()
		{
			var result = base.PersonProperList.ToDistinctBlockingCollection(false);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToDistinctConcurrentBag))]
		public void To103()
		{
			var result = base.PersonProperList.ToDistinctConcurrentBag();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToFastSortedList))]
		public void To104()
		{
			var result = base.PersonProperList.ToFastSortedList();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToObservableList))]
		public void To105()
		{
			var result = base.PersonProperList.ToObservableList();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToImmutableArray))]
		public void To106()
		{
			var result = base.PersonProperList.ToImmutableArray();

			base.Consumer.Consume(result);
		}

	}
}
