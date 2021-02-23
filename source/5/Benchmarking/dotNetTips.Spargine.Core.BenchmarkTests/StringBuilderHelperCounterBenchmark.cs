// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2021
// ***********************************************************************
// <copyright file="StringBuilderHelperCounterPerfTestRunner.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;

namespace dotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// StringBuilderHelper PerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	[BenchmarkCategory(nameof(StringBuilderHelper))]
	public class StringBuilderHelperCounterBenchmark : CounterBenchmark
	{
		[Benchmark(Description = nameof(StringBuilderHelper.BytesToString))]
		public void AppendBytes03()
		{
			var result = StringBuilderHelper.BytesToString(this.ByteArray);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderHelper.ConcatToString))]
		public void SplitCharSeparator01()
		{
			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = "StringExtensions.ToDelimitedString:01*")]
		public void ToDelimitedString01()
		{
			var people = base.PersonProperDictionary.AsEnumerable();

			var result = people.ToDelimitedString();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderHelper.ToDelimitedString) + ":01**")]
		public void ToDelimitedString02()
		{
			var people = base.PersonProperDictionary;

			var result = StringBuilderHelper.ToDelimitedString(people);

			base.Consumer.Consume(result);
		}

	}
}
