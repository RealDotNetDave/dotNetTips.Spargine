// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2022
// ***********************************************************************
// <copyright file="EnumerableExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// EnumerableExtensions PerfTestRunner.
	/// Implements the <see cref="LargeCollectionBenchmark" />
	/// </summary>
	/// <seealso cref="LargeCollectionBenchmark" />
	[BenchmarkCategory(Categories.Collections)]
	public class EnumerableExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{
		[Benchmark(Description = "Any: With Predicate")]
		[BenchmarkCategory(Categories.LINQ)]
		public void Any01()
		{
			var result = AnyWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastAny) + ": With Predicate")]
		public void Any02()
		{
			var result = base.GetPersonProperArray(Tristate.False).FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}
		[Benchmark(Description = nameof(EnumerableExtensions.Count) + ": With Predicate")]
		public void Count01()
		{
			var result = CountWithPredicate(base.GetPersonProperArray(Tristate.False), p => p.City.Contains('A', StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastCount) + ": With Predicate")]
		public void Count02()
		{
			var result = base.GetPersonProperArray(Tristate.False).FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
		public void FirstOrDefaultAlternate01()
		{
			var result = base.GetPersonProperArray(Tristate.False).FirstOrDefault(alternate: this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
		public void FirstOrDefaultAlternate02()
		{
			var result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
		public void FirstOrNull01()
		{
			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems01()
		{
			var result = base.GetPersonProperArray().AsEnumerable().HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems) + ": With Count")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems02()
		{
			var result = base.GetPersonProperArray().AsEnumerable().HasItems(5);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
		public void StartsWith01()
		{
			var result = base.GetPersonProperArray(Tristate.False).StartsWith(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
		public void StructuralSequenceEqual01()
		{
			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half).StructuralSequenceEqual(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
		public void ToBlockingCollection01()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToBlockingCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
		public void ToDelimitedString01()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToDelimitedString(',');

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": Dictionary")]
		public void ToImmutableDictionary01()
		{
			var result = base.GetPersonProperDictionary().ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": List")]
		public void ToImmutableList01()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
		public void ToLinkedList01()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToLinkedList();

			base.Consumer.Consume(result);
		}

		private static bool AnyWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
		{
			return list.Any(predicate);
		}

		private static int CountWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
		{
			return list.Count(predicate);
		}
	}
}
