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
using DotNetTips.Spargine.Tester.Models.RefTypes;

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

		private IEnumerable<PersonProper> _people;
		private List<PersonProper> _peopleList;

		private static bool AnyWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
		{
			return list.Any(predicate);
		}

		private static int CountWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
		{
			return list.Count(predicate);
		}

		[Benchmark(Description = "Any: With Predicate")]
		[BenchmarkCategory(Categories.LINQ)]
		public void AnyWithPredicate()
		{
			var result = AnyWithPredicate(base.GetPersonProperArray(), p => p.City.Contains('A', StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}
		[Benchmark(Description = nameof(EnumerableExtensions.Count) + ": With Predicate")]
		public void CountWithPredicate()
		{
			var result = CountWithPredicate(base.GetPersonProperArray(), p => p.City.Contains('A', StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastAny) + ": With Predicate")]
		public void FastAnyWithPredicate()
		{
			var result = base.GetPersonProperArray().FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastCount) + ": With Predicate")]
		public void FastCountWithPredicate()
		{
			var result = base.GetPersonProperArray().FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
		public void FirstOrDefaultAlternate()
		{
			PersonProper result = base.GetPersonProperArray().FirstOrDefault(alternate: this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
		public void FirstOrDefaultPredicateAlternate()
		{
			PersonProper result = this.GetPersonProperArray().FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
		public void FirstOrNull()
		{
			Spargine.Tester.Models.ValueTypes.Coordinate? result = base.GetCoordinateArray().FirstOrNull(p => p.X == this.Coordinate01.X);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems()
		{
			var result = this._people.HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems) + ": With Count")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItemsWithCount()
		{
			var result = this._people.HasItems(this.Count);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
		public void IndexOf()
		{
			var people = base.GetPersonProperArray();
			var result = people.IndexOf(people.Last());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Comparer")]
		public void IndexOfComparer()
		{
			PersonProper[] people = base.GetPersonProperArray();
			var comparer = new PersonProperComparer();
			var result = people.IndexOf(people.Last(), comparer);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.OrderBy) + "With Sort Expression")]
		public void OrderBy()
		{
			IEnumerable<PersonProper> result = _peopleList.OrderBy("City desc");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
		public void OrderByOrdinal()
		{
			IOrderedEnumerable<PersonProper> result = base.GetPersonProperArray().OrderByOrdinal(p => p.City);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Page))]
		public void Page()
		{
			foreach (IEnumerable<PersonProper> people in base.GetPersonProperArray().Page(25))
			{
				foreach (PersonProper person in people)
				{
					base.Consumer.Consume(person);
				}
			}
		}

		[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
		public void PickRandom()
		{
			PersonProper result = base.GetPersonProperArray(CollectionSize.Half).PickRandom();

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			this._people = base.GetPersonProperArray().AsEnumerable();
			this._peopleList = base.GetPersonProperArray().ToList();
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Shuffle))]
		public void Shuffle()
		{
			IEnumerable<PersonProper> result = base.GetPersonProperArray().Shuffle();
			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Shuffle) + "With Count")]
		public void ShuffleWithCount()
		{
			IEnumerable<PersonProper> result = base.GetPersonProperArray().Shuffle(this.Count / 2);
			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
		public void StartsWith()
		{
			var people = base.GetPersonProperArray();
			var result = people.StartsWith(people.Take(10));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
		public void StructuralSequenceEqual()
		{
			var people = base.GetPersonProperArray();
			var result = people.StructuralSequenceEqual(people.TakeLast(10));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
		public void ToBlockingCollection01()
		{
			var result = base.GetPersonProperArray().ToBlockingCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
		public void ToDelimitedString()
		{
			var result = this._people.ToDelimitedString(',');

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": Dictionary")]
		public void ToImmutableDictionary01()
		{
			System.Collections.Immutable.ImmutableDictionary<string, PersonProper> result = base.GetPersonProperDictionary().ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": List")]
		public void ToImmutableList01()
		{
			System.Collections.Immutable.ImmutableList<PersonProper> result = _people.ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
		public void ToLinkedList01()
		{
			var result = _people.ToLinkedList();

			base.Consumer.Consume(result);
		}

	}
}
