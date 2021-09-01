// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-27-2021
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
using dotNetTips.Spargine.Tester.Models;

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

		public override void Setup() { base.Setup(); }
	}
}
