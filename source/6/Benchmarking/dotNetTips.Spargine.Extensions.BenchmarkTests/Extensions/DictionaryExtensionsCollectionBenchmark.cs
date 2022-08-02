// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2022
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
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class DictionaryExtensionsCollectionBenchmark : LargeCollectionsBenchmark
	{
		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Dictionary")]
		[BenchmarkCategory(Categories.Collections)]
		public void GetOrAddDictionary02()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = GetPersonProperRefDictionary();

			PersonProper result = people.GetOrAdd(this.PersonProperRef01.Id, this.PersonProperRef01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderHelper.ToDelimitedString))]
		[BenchmarkCategory(Categories.Strings)]
		public void ToDelimitedString()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = GetPersonProperRefDictionary();

			var result = StringBuilderHelper.ToDelimitedString(people);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
		public void UpsertDictionary01()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = GetPersonProperRefDictionary();
			System.Collections.Generic.KeyValuePair<string, PersonProper> person = people.Last();

			people.Upsert(person.Key, person.Value);

			Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ": New Person")]
		public void UpsertDictionary02()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = GetPersonProperRefDictionary();

			people.Upsert(this.PersonProperRef01.Id, this.PersonProperRef01);

			Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(DictionaryExtensions.HasItems) + ": With Predicate")]
		public void HasItemsWithPredicateTest()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = this.GetPersonProperRefDictionary();

			var result = people.HasItems(p => p.Value.Age.TotalDays > 0);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(DictionaryExtensions.ToSortedDictionary))]
		public void ToSortedDictionaryTest()
		{
			var people = GetPersonProperRefDictionary().ToSortedDictionary();

			Consumer.Consume(people);
		}
	}
}
