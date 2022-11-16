// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-11-2022
// ***********************************************************************
// <copyright file="DictionaryExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class DictionaryExtensionsCollectionBenchmark.
/// Implements the <see cref="LargeCollectionsBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionsBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class DictionaryExtensionsCollectionBenchmark : LargeCollectionsBenchmark
{
	[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Dictionary")]
	[BenchmarkCategory(Categories.Collections)]
	public void GetOrAddDictionary02()
	{
		var people = GetPersonProperRefDictionary();

		var result = people.GetOrAdd(this.PersonProperRef01.Id, this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(FastStringBuilder.ToDelimitedString))]
	[BenchmarkCategory(Categories.Strings)]
	public void ToDelimitedString()
	{
		var people = GetPersonProperRefDictionary();

		var result = FastStringBuilder.ToDelimitedString(people);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
	public void UpsertDictionary01()
	{
		var people = GetPersonProperRefDictionary();
		var person = people.Last();

		people.Upsert(person.Key, person.Value);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ": New Person")]
	public void UpsertDictionary02()
	{
		var people = GetPersonProperRefDictionary();

		people.Upsert(this.PersonProperRef01.Id, this.PersonProperRef01);

		this.Consume(people);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.HasItems) + ": With Predicate")]
	public void HasItemsWithPredicateTest()
	{
		var people = this.GetPersonProperRefDictionary();

		var result = people.HasItems(p => p.Value.Age.TotalDays > 0);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(DictionaryExtensions.ToSortedDictionary))]
	public void ToSortedDictionaryTest()
	{
		var people = GetPersonProperRefDictionary().ToSortedDictionary();

		this.Consume(people);
	}
}
