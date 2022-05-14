// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2022
// ***********************************************************************
// <copyright file="StringBuilderExtensionsCounterBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// StringBuilderExtensions CounterPerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	[BenchmarkCategory(Categories.Strings)]
	public class StringBuilderExtensionsCounterBenchmark : SmallCounterBenchmark
	{
		[Benchmark(Description = nameof(StringBuilderExtensions.AppendBytes) + ":01*")]
		public void AppendBytes01()
		{
			var sb = new StringBuilder();

			sb.AppendBytes(this.GetByteArray(1));

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(StringBuilderHelper.BytesToString) + ":01**")]
		public void AppendBytes03()
		{
			var result = StringBuilderHelper.BytesToString(this.GetByteArray(1));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(StringBuilderExtensions.AppendKeyValue))]
		public void AppendKeyValue1()
		{
			var sb = new StringBuilder();
			var stringArray = this.GetStringArray(10, 15, 20);

			for (var index = 0; index < stringArray.Length; index++)
			{
				var testString = stringArray[index];
				sb.AppendKeyValue(testString, testString);
			}

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(StringBuilderExtensions.AppendValues))]
		public void AppendValues02()
		{
			var sb = new StringBuilder();

			sb.AppendValues(ControlChars.DefaultSeparator, this.GetStringArray(10, 15, 20));

			base.Consumer.Consume(sb.ToString());
		}
	}
}
