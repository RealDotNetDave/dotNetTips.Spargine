// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
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
	public class DictionaryExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{
		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Dictionary")]
		[BenchmarkCategory(Categories.Collections)]
		public void GetOrAddDictionary02()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = base.GetPersonProperDictionary();

			PersonProper result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderHelper.ToDelimitedString))]
		[BenchmarkCategory(Categories.Strings)]
		public void ToDelimitedString()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = base.GetPersonProperDictionary();

			var result = StringBuilderHelper.ToDelimitedString(people);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
		public void UpsertDictionary01()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = base.GetPersonProperDictionary();
			System.Collections.Generic.KeyValuePair<string, PersonProper> person = people.Last();

			people.Upsert(person.Key, person.Value);

			base.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ": New Person")]
		public void UpsertDictionary02()
		{
			System.Collections.Generic.Dictionary<string, PersonProper> people = base.GetPersonProperDictionary();

			people.Upsert(this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(people);
		}

		//[Benchmark(Description = nameof(DictionaryExtensions.HasItems) + ": With Predicate")]
		//public void HasItemsWithPredicateTest()
		//{
		//	System.Collections.Generic.Dictionary<string, PersonProper> people = base.GetPersonProperDictionary();

		//	var result = people.HasItems(p => p.Value.Age.TotalDays > 0);

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(DictionaryExtensions.ToSortedDictionary))]
		public void ToSortedDictionaryTest()
		{
			var people = base.GetPersonProperDictionary().ToSortedDictionary();

			base.Consumer.Consume(people);
		}
	}
}
