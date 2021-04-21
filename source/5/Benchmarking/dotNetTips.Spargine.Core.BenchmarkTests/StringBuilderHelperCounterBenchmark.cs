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

using System.Globalization;
using System.Linq;
using System.Text;
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
		public void BytesToString01()
		{
			var result = StringBuilderHelper.BytesToString(this.ByteArray);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderHelper.ConcatToString))]
		public void ConcatToString01()
		{
			var result = StringBuilderHelper.ConcatToString(this.CommaDelimitedString, ",", Tristate.True, this.StringArray);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = "StringExtensions.ToDelimitedString: 01*")]
		public void ToDelimitedString01()
		{
			var people = base.PersonProperDictionary.AsEnumerable();

			var result = people.ToDelimitedString();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderHelper.ToDelimitedString) + ": 01**")]
		public void ToDelimitedString02()
		{
			var people = base.PersonProperDictionary;

			var result = StringBuilderHelper.ToDelimitedString(people);

			base.Consumer.Consume(result);
		}

		private static string BytesToStringLocal(byte[] bytes)
		{
			Validate.TryValidateParam(bytes, nameof(bytes));

			var sb = new StringBuilder();

			sb.Append("'0x");

			for (var i = 0; i < bytes.Length; i++)
			{
				sb.Append(bytes[i].ToString("X2", CultureInfo.InvariantCulture));
			}

			sb.Append('\'');

			return sb.ToString();
		}

	}
}
