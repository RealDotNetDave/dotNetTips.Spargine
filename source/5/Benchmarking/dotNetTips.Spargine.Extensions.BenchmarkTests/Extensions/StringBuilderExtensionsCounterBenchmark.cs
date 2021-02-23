// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2021
// ***********************************************************************
// <copyright file="StringBuilderExtensionsCounterPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// StringBuilderExtensions CounterPerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	[BenchmarkCategory(nameof(StringBuilderExtensions))]
	public class StringBuilderExtensionsCounterBenchmark : CounterBenchmark
	{
		[Benchmark(Description = nameof(StringBuilderExtensions.AppendBytes) + ":01*")]
		public void AppendBytes01()
		{
			var sb = new StringBuilder();

			sb.AppendBytes(this.ByteArray);

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(StringBuilderHelper.BytesToString) + ":01**")]
		public void AppendBytes03()
		{
			var result = StringBuilderHelper.BytesToString(this.ByteArray);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderExtensions.AppendKeyValue))]
		public void AppendKeyValue0()
		{
			var sb = new StringBuilder();

			for (var i = 0; i < this.StringArray.Length; i++)
			{
				var testString = this.StringArray[i];
				sb.AppendKeyValue(testString, testString);
			}

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(StringBuilderExtensions.AppendValues))]
		public void AppendValues01()
		{
			var sb = new StringBuilder();

			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);

			base.Consumer.Consume(sb.ToString());
		}

		public override void Setup()
		{
			base.Setup();
		}
	}
}
