// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

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

		[Benchmark(Description = nameof(EnumerableExtensions.Shuffle))]
		public void Shuffle()
		{
			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Shuffle) + "With Count")]
		public void ShuffleWithCount()
		{
			var result = base.GetPersonProperArray(Tristate.False).Shuffle(this.Count / 2);
			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
		public void FirstOrNull()
		{
			var result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems()
		{
			var result = base.GetPersonProperArray().AsEnumerable().HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
		public void OrderByOrdinal()
		{
			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ":Comparer")]
		public void IndexOfComparer()
		{
			var comparer = new PersonProperComparer();
			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
		public void PickRandom01()
		{
			var result = base.GetPersonProperArray(Tristate.False, CollectionSize.Half).PickRandom();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Page))]
		public void Page()
		{
			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
			{
				foreach (var person in people)
				{
					base.Consumer.Consume(person);
				}
			}
		}

		[Benchmark(Description = nameof(EnumerableExtensions.OrderBy) + "With Sort Expression")]
		public void OrderBy()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToList().OrderBy("City desc");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
		public void IndexOf()
		{
			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems) + ": With Count")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItemsWithCount()
		{
			var result = base.GetPersonProperArray().AsEnumerable().HasItems(this.Count);

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
