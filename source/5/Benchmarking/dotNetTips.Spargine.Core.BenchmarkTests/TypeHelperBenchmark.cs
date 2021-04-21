// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-22-2021
// ***********************************************************************
// <copyright file="TypeHelperBenchmark.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// TypeHelper PerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.PerfTestRunner" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.PerfTestRunner" />
	[BenchmarkCategory(nameof(TypeHelper))]
	public class TypeHelperBenchmark : Benchmark
	{

		private readonly int _collectionCount = 50;

		private ImmutableDictionary<string, string> _immutableDictionary;
		private List<PersonProper> _people;

		[Benchmark(Description = "Looping Collection: Normal StringBuilder")]
		public void CreateStringBuilder01()
		{
			var sb = new StringBuilder();

			foreach (var person in this._people)
			{
				sb.AppendFormat("{0}={1}", person.Email, person.PostalCode);
			}

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(TypeHelper.GetPropertyValues))]
		public void GetPropertyValues01()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = TypeHelper.GetPropertyValues(person);

			this.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();


			var list = new Dictionary<string, string>(this._collectionCount);
			for (var i = 0; i < this._collectionCount; i++)
			{
				list.Add(RandomData.GenerateKey(), RandomData.GenerateKey());
			}

			this._immutableDictionary = list.ToImmutableDictionary();

			this._people = RandomData.GeneratePersonCollection<PersonProper>(this._collectionCount);
		}
	}
}
