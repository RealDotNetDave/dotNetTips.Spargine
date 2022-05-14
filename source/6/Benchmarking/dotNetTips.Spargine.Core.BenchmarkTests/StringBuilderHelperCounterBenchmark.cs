// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2022
// ***********************************************************************
// <copyright file="StringBuilderHelperCounterBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;

namespace DotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// StringBuilderHelper PerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Strings)]
	public class StringBuilderHelperCounterBenchmark : SmallCounterBenchmark
	{

		[Benchmark(Description = nameof(StringBuilderHelper.BytesToString))]
		[BenchmarkCategory(Categories.Collections)]
		public void BytesToString01()
		{
			var result = StringBuilderHelper.BytesToString(this.GetByteArray(this.Count));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = "StringExtensions.ToDelimitedString: 01*")]
		[BenchmarkCategory(Categories.Collections)]
		public void ToDelimitedString01()
		{
			var bytes = base.GetByteArray(1).AsEnumerable();

			var result = bytes.ToDelimitedString();

			base.Consumer.Consume(result);
		}
	}
}
