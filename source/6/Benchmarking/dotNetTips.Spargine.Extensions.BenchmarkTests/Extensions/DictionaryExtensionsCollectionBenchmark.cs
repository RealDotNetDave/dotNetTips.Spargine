// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2022
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

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// Class DictionaryExtensionsCollectionBenchmark.
	/// Implements the <see cref="LargeCollectionBenchmark" />
	/// </summary>
	/// <seealso cref="LargeCollectionBenchmark" />
	[BenchmarkCategory(Categories.Collections)]
	public class DictionaryExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{
		/// <summary>
		/// Gets the or add dictionary02.
		/// </summary>
		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ": Dictionary")]
		[BenchmarkCategory(Categories.Collections)]
		public void GetOrAddDictionary02()
		{
			var people = base.GetPersonProperDictionary();

			var result = people.GetOrAdd(this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Converts to delimitedstring01.
		/// </summary>
		[Benchmark(Description = nameof(StringBuilderHelper.ToDelimitedString) + ": *POOL")]
		[BenchmarkCategory(Categories.Strings)]
		public void ToDelimitedString01()
		{
			var people = base.GetPersonProperDictionary(Tristate.False);

			var result = StringBuilderHelper.ToDelimitedString(people);

			base.Consumer.Consume(result);
		}


		/// <summary>
		/// Upserts the dictionary01.
		/// </summary>
		[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
		public void UpsertDictionary01()
		{
			var people = base.GetPersonProperDictionary();
			var person = people.Last();

			people.Upsert(person.Key, person.Value);

			base.Consumer.Consume(people);
		}


		/// <summary>
		/// Upserts the dictionary02.
		/// </summary>
		[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ": New Person")]
		public void UpsertDictionary02()
		{
			var people = base.GetPersonProperDictionary();

			people.Upsert(this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(people);
		}
	}
}
