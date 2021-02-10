﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="DictionaryExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(DictionaryExtensions))]
	public class DictionaryExtensionsPerfTestRunner : CollectionPerfTestRunner
	{

		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ":Dictionary")]
		public void GetOrAddDictionary()
		{
			var people = base.PersonProperDictionary;
			var person = base.PersonProperDictionary.Last();

			var result = people.GetOrAdd(person.Key, person.Value);

			base.Consumer.Consume(result);
		}


		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ":Dictionary-New")]
		public void GetOrAddDictionaryNew()
		{
			var people = base.PersonProperDictionary;
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.GetOrAdd(person.Id, person);

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }


		[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
		public void UpsertDictionary()
		{
			var people = base.PersonProperDictionary;
			var person = base.PersonProperDictionary.Last();

			var result = people.Upsert(person.Key, person.Value);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ":New Person")]
		public void UpsertDictionaryNew()
		{
			var people = base.PersonProperDictionary;
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.Upsert(person.Id, person);

			base.Consumer.Consume(result);
		}
	}
}
