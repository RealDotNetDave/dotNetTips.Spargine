// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 08-27-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="ObservableCollectionExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class ObservableCollectionExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{
		[Benchmark(Description = nameof(ObservableCollectionExtensions.HasItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection().HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObservableCollectionExtensions.HasItems) + ": With Count")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItemsWithCount()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection().HasItems(5);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObservableCollectionExtensions.HasItems) + ": With Predicate")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItemsWithPredicate()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection().HasItems(p => p.Age.TotalDays > 5);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup() { base.Setup(); }
	}
}
