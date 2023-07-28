// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-07-2023
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
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// EnumerableExtensions PerfTestRunner.
/// Implements the <see cref="SmallCollectionsBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionsBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class EnumerableExtensionsCollectionBenchmark : SmallCollectionsBenchmark
{
	private IEnumerable<Coordinate> _coordinateValEnumerable;
	private IEnumerable<PersonProper> _personRefEnumerable;
	private IEnumerable<PersonProper> _personRefEnumerableToAdd;
	private List<PersonProper> _personRefListDups;

	private static bool AnyWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
	{
		return list.Any(predicate);
	}

	private static int CountWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
	{
		return list.Count(predicate);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Add))]
	public void Add()
	{
		var people = this._personRefEnumerable;

		var result = people.Add(this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Add))]
	public void AddDistinct()
	{
		var people = this._personRefEnumerable;
		var peopleToAdd = this._personRefEnumerableToAdd;

		var result = people.AddDistinct(peopleToAdd.ToArray());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.AddIf))]
	public void AddIf()
	{
		var people = this._personRefEnumerable;

		var result = people.AddIf(this.PersonProperRef01, true);

		this.Consume(result);
	}

	[Benchmark(Description = "Any: With Predicate")]
	[BenchmarkCategory(Categories.LINQ)]
	public void AnyWithPredicate()
	{
		var result = AnyWithPredicate(this._personRefEnumerable, p => p.City.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ContainsAny))]
	public void ContainsAny()
	{
		var people = this._personRefEnumerable;

		people = people.Add(people.FirstOrDefault());

		var result = people.ContainsAny(people.Take(10).ToArray());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Count))]
	public void Count_Default()
	{
		var result = this._personRefEnumerable.Count();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.CountAsync))]
	public async Task CountAsync()
	{
		var result = await this._personRefEnumerable.CountAsync(CancellationToken.None).ConfigureAwait(false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Count) + ": With Predicate")]
	public void CountWithPredicate()
	{
		var result = CountWithPredicate(this._personRefEnumerable, p => p.City.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.DoesNotHaveItems))]
	public void DoesNotHaveItems()
	{
		var people = new List<PersonProper>().AsEnumerable();

		var result = people.DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.EnsureUnique))]
	public void EnsureUnique()
	{
		var people = this._personRefEnumerable;

		people = people.Add(people.FirstOrDefault());

		var result = people.EnsureUnique().ToList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastAny) + ": With Predicate")]
	public void FastAnyWithPredicate()
	{
		var result = this._personRefEnumerable.FastAny(p => p.City.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastCount))]
	public void FastCount()
	{
		var result = this._personRefEnumerable.FastCount();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FastCount) + ": With Predicate")]
	public void FastCountWithPredicate()
	{
		var result = this._personRefEnumerable.FastCount(p => p.City.Contains('a', StringComparison.CurrentCulture));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
	public void FirstOrDefaultAlternate()
	{
		var result = this._personRefEnumerable.FirstOrDefault(alternate: this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
	public void FirstOrDefaultPredicateAlternate()
	{
		var result = this._personRefEnumerable.FirstOrDefault(p => p.Id == this.PersonProperRef01.Id, this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
	public void FirstOrNull()
	{
		var result = this._coordinateValEnumerable.FirstOrNull(p => p.X == this.Coordinate01.X);

		this.Consume(result);
	}


	[Benchmark(Description = nameof(EnumerableExtensions.HasDuplicates))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasDuplicates()
	{
		var result = this._personRefListDups.HasDuplicates();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.HasItems))]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItems()
	{
		var result = this._personRefEnumerable.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.HasItems) + ": With Count")]
	[BenchmarkCategory(Categories.Collections)]
	public void HasItemsWithCount()
	{
		var result = this._personRefEnumerable.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
	public void IndexOf()
	{
		var people = this._personRefEnumerable;
		var result = people.IndexOf(people.Last());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ": Comparer")]
	public void IndexOfComparer()
	{
		var people = this._personRefEnumerable;
		var comparer = new PersonProperComparer();
		var result = people.IndexOf(people.Last(), comparer);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.IsNullOrEmpty))]
	public void IsNullOrEmpty()
	{
		var people = new List<PersonProper>().AsEnumerable();

		var result = people.IsNullOrEmpty();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Join))]
	public void Join()
	{
		var people = this._personRefEnumerable;

		var result = people.Join();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderBy) + ": With Sort Expression")]
	public void OrderBy()
	{
		var result = this._personRefEnumerable.OrderBy("City desc");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
	public void OrderByOrdinal()
	{
		var result = this._personRefEnumerable.OrderByOrdinal(p => p.City);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Page))]
	public void Page()
	{
		foreach (var people in this._personRefEnumerable.Page(25))
		{
			foreach (var person in people)
			{
				this.Consume(person);
			}
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Partition))]
	public void Partition()
	{
		var people = this._personRefEnumerable;

		var splitPeople = people.Partition(this.Count / 2);

		this.Consume(splitPeople);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
	public void PickRandom()
	{
		var result = this._personRefEnumerable.PickRandom();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.RemoveDuplicates))]
	[BenchmarkCategory(Categories.Collections)]
	public void RemoveDuplicates()
	{
		var result = this._personRefListDups.RemoveDuplicates();

		this.Consume(result.Value);
	}

	public override void Setup()
	{
		base.Setup();

		this._personRefEnumerable = this.GetPersonProperRefList().AsEnumerable();
		this._coordinateValEnumerable = this.GetCoordinateValArray().AsEnumerable();

		var peopleToAdd = this._personRefEnumerable.ToList();
		peopleToAdd.AddRange(this.GetPeopleRefToInsert().Take(this.Count / 10));
		this._personRefEnumerableToAdd = peopleToAdd.AsEnumerable();

		// Create collection with duplicates
		var dups = this._personRefEnumerable.Shuffle().Take(this.Count / 10);
		this._personRefListDups = this._personRefEnumerable.ToList();
		foreach (var person in dups)
		{
			_ = this._personRefListDups.Append(person);
		}
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Shuffle))]
	public void Shuffle()
	{
		var result = this._personRefEnumerable.Shuffle();
		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Shuffle) + "With Count")]
	public void ShuffleWithCount()
	{
		var result = this._personRefEnumerable.Shuffle(this.Count / 2);
		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Partition))]
	public void Split()
	{
		var people = this._personRefEnumerable;

		var splitPeople = people.Split(10);

		this.Consume(splitPeople);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
	public void StartsWith()
	{
		var people = this._personRefEnumerable;
		var result = people.StartsWith(people.Take(10));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
	public void StructuralSequenceEqual()
	{
		var people = this._personRefEnumerable;
		var result = people.StructuralSequenceEqual(people.TakeLast(10));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
	public void ToBlockingCollection01()
	{
		var result = this._personRefEnumerable.ToBlockingCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToCollection))]
	public void ToCollection()
	{
		var result = this._personRefEnumerable.ToCollection();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
	public void ToDelimitedString()
	{
		var result = this._personRefEnumerable.ToDelimitedString(',');

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable))]
	public void ToImmutable()
	{
		var result = this._personRefEnumerable.AsEnumerable().ToImmutable();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
	public void ToLinkedList()
	{
		var result = this._personRefEnumerable.ToLinkedList();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.ToListAsync))]
	public async Task ToListAsync()
	{
		var people = this._personRefEnumerable;

		var result = await people.ToListAsync().ConfigureAwait(false);

		await this.ConsumeAsync(result).ConfigureAwait(false);
	}

	[Benchmark(Description = nameof(EnumerableExtensions.Upsert))]
	public void Upsert()
	{
		var people = this._personRefEnumerable;

		var result = people.Upsert(this.PersonProperRef01);

		this.Consume(result);
	}

}
