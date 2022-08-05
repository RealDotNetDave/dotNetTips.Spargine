// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2022
// ***********************************************************************
// <copyright file="EnumerableExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// EnumerableExtensions PerfTestRunner.
	/// Implements the <see cref="LargeCollectionsBenchmark" />
	/// </summary>
	/// <seealso cref="LargeCollectionsBenchmark" />
	[BenchmarkCategory(Categories.Collections)]
	public class EnumerableExtensionsCollectionBenchmark : LargeCollectionsBenchmark
	{

		private IEnumerable<PersonProper> _people;

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
			var result = AnyWithPredicate(GetPersonProperRefArray(), p => p.City.Contains('A', StringComparison.CurrentCulture));

			Consumer.Consume(result);
		}
		[Benchmark(Description = nameof(EnumerableExtensions.Count) + ": With Predicate")]
		public void CountWithPredicate()
		{
			var result = CountWithPredicate(GetPersonProperRefArray(), p => p.City.Contains('A', StringComparison.CurrentCulture));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastAny) + ": With Predicate")]
		public void FastAnyWithPredicate()
		{
			var result = GetPersonProperRefArray().FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastCount) + ": With Predicate")]
		public void FastCountWithPredicate()
		{
			var result = GetPersonProperRefArray().FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
		public void FirstOrDefaultAlternate()
		{
			PersonProper result = GetPersonProperRefArray().FirstOrDefault(alternate: this.PersonProperRef01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
		public void FirstOrDefaultPredicateAlternate()
		{
			PersonProper result = this.GetPersonProperRefArray().FirstOrDefault(p => p.Id == this.PersonProperRef01.Id, this.PersonProperRef01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
		public void FirstOrNull()
		{
			Spargine.Tester.Models.ValueTypes.Coordinate? result = GetCoordinateValArray().FirstOrNull(p => p.X == this.Coordinate01.X);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems()
		{
			var result = this._people.HasItems();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems) + ": With Count")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItemsWithCount()
		{
			var result = this._people.HasItems(this.Count);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
		public void IndexOf()
		{
			PersonProper[] people = GetPersonProperRefArray();
			var result = people.IndexOf(people.Last());

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Comparer")]
		public void IndexOfComparer()
		{
			PersonProper[] people = GetPersonProperRefArray();
			var comparer = new PersonProperComparer();
			var result = people.IndexOf(people.Last(), comparer);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.OrderBy) + ": With Sort Expression")]
		public void OrderBy()
		{
			IEnumerable<PersonProper> result = GetPersonProperRefList().OrderBy("City desc");

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
		public void OrderByOrdinal()
		{
			IOrderedEnumerable<PersonProper> result = GetPersonProperRefArray().OrderByOrdinal(p => p.City);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Page))]
		public void Page()
		{
			foreach (IEnumerable<PersonProper> people in GetPersonProperRefArray().Page(25))
			{
				foreach (PersonProper person in people)
				{
					Consumer.Consume(person);
				}
			}
		}

		[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
		public void PickRandom()
		{
			PersonProper result = GetPersonProperRefArray(CollectionSize.Half).PickRandom();

			Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			this._people = GetPersonProperRefArray().AsEnumerable();
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Shuffle))]
		public void Shuffle()
		{
			IEnumerable<PersonProper> result = GetPersonProperRefArray().Shuffle();
			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Shuffle) + "With Count")]
		public void ShuffleWithCount()
		{
			IEnumerable<PersonProper> result = GetPersonProperRefArray().Shuffle(this.Count / 2);
			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
		public void StartsWith()
		{
			PersonProper[] people = GetPersonProperRefArray();
			var result = people.StartsWith(people.Take(10));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
		public void StructuralSequenceEqual()
		{
			PersonProper[] people = GetPersonProperRefArray();
			var result = people.StructuralSequenceEqual(people.TakeLast(10));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
		public void ToBlockingCollection01()
		{
			var result = GetPersonProperRefArray().ToBlockingCollection();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
		public void ToDelimitedString()
		{
			var result = this._people.ToDelimitedString(',');

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": Dictionary")]
		public void ToImmutableDictionary01()
		{
			System.Collections.Immutable.ImmutableDictionary<string, PersonProper> result = GetPersonProperRefDictionary().ToImmutable();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": List")]
		public void ToImmutableList01()
		{
			System.Collections.Immutable.ImmutableList<PersonProper> result = this._people.ToImmutable();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
		public void ToLinkedList01()
		{
			var result = this._people.ToLinkedList();

			Consumer.Consume(result);
		}

	}
}
