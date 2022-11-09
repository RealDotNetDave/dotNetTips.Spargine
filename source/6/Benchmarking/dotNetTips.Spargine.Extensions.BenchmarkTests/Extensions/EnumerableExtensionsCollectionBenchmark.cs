// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-31-2022
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

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

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

		this.Consume(result);
	}
	[Benchmark(Description = nameof(EnumerableExtensions.Count) + ": With Predicate")]
	public void CountWithPredicate()
	{
		var result = CountWithPredicate(GetPersonProperRefArray(), p => p.City.Contains('A', StringComparison.CurrentCulture));

		this.Consume(result);
	}


	[Benchmark(Description = nameof(EnumerableExtensions.FastAny) + ": With Predicate")]
	public void FastAnyWithPredicate()
	{
		var result = GetPersonProperRefArray().FastAny(p => p.City.Contains('A', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastCount) + ": With Predicate")]
	public void FastCountWithPredicate()
	{
		var result = GetPersonProperRefArray().FastCount(p => p.City.Contains('A', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
	public void FirstOrDefaultAlternate()
	{
		var result = GetPersonProperRefArray().FirstOrDefault(alternate: this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
	public void FirstOrDefaultPredicateAlternate()
	{
		var result = this.GetPersonProperRefArray().FirstOrDefault(p => p.Id == this.PersonProperRef01.Id, this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
	public void FirstOrNull()
	{
		var result = GetCoordinateValArray().FirstOrNull(p => p.X == this.Coordinate01.X);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.HasItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItems()
	{
		var result = this._people.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.HasItems) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithCount()
	{
		var result = this._people.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
	public void IndexOf()
	{
		var people = GetPersonProperRefArray();
		var result = people.IndexOf(people.Last());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Comparer")]
	public void IndexOfComparer()
	{
		var people = GetPersonProperRefArray();
		var comparer = new PersonProperComparer();
		var result = people.IndexOf(people.Last(), comparer);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderBy) + ": With Sort Expression")]
	public void OrderBy()
	{
		var result = GetPersonProperRefList().OrderBy("City desc");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
	public void OrderByOrdinal()
	{
		var result = GetPersonProperRefArray().OrderByOrdinal(p => p.City);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Page))]
	public void Page()
	{
		foreach (var people in GetPersonProperRefArray().Page(25))
		{
			foreach (var person in people)
			{
				this.Consume(person);
			}
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
	public void PickRandom()
	{
		var result = GetPersonProperRefArray(CollectionSize.Half).PickRandom();

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._people = GetPersonProperRefArray().AsEnumerable();
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Shuffle))]
	public void Shuffle()
	{
		var result = GetPersonProperRefArray().Shuffle();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Shuffle) + "With Count")]
	public void ShuffleWithCount()
	{
		var result = GetPersonProperRefArray().Shuffle(this.Count / 2);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
	public void StartsWith()
	{
		var people = GetPersonProperRefArray();
		var result = people.StartsWith(people.Take(10));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
	public void StructuralSequenceEqual()
	{
		var people = GetPersonProperRefArray();
		var result = people.StructuralSequenceEqual(people.TakeLast(10));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
	public void ToBlockingCollection01()
	{
		var result = GetPersonProperRefArray().ToBlockingCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
	public void ToDelimitedString()
	{
		var result = this._people.ToDelimitedString(',');

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": Dictionary")]
	public void ToImmutableDictionary01()
	{
		var result = GetPersonProperRefDictionary().ToImmutable();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": List")]
	public void ToImmutableList01()
	{
		var result = this._people.ToImmutable();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
	public void ToLinkedList01()
	{
		var result = this._people.ToLinkedList();

		this.Consume(result);
	}

}
