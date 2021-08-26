// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-24-2021
// ***********************************************************************
// <copyright file="DictionaryExtensionsCollectionBenchmark.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class DictionaryExtensionsCollectionBenchmark : CollectionBenchmark
	{

		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ":Dictionary")]
		public void GetOrAddDictionary01()
		{
			var people = base.PersonProperDictionary;
			var person = base.PersonProperDictionary.Last();

			var result = people.GetOrAdd(person.Key, person.Value);

			base.Consumer.Consume(result);
		}


		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ":Dictionary")]
		[BenchmarkCategory(Categories.New)]
		public void GetOrAddDictionary02()
		{
			var people = base.PersonProperDictionary;

			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }

		[Benchmark(Description = nameof(StringBuilderHelper.ToDelimitedString) + ":*POOL")]
		[BenchmarkCategory(Categories.Strings)]
		public void ToDelimitedString01()
		{
			var people = base.PersonProperDictionary;

			var result = StringBuilderHelper.ToDelimitedString(people);

			base.Consumer.Consume(result);
		}


		[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
		public void UpsertDictionary01()
		{
			var people = base.PersonProperDictionary;
			var person = base.PersonProperDictionary.Last();

			people.Upsert(person.Key, person.Value);

			base.Consumer.Consume(people);
		}


		/// <summary>
		/// Upserts the dictionary02.
		/// </summary>
		[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ":New Person")]
		public void UpsertDictionary02()
		{
			var people = base.PersonProperDictionary;

			people.Upsert(this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(people);
		}
	}
}
