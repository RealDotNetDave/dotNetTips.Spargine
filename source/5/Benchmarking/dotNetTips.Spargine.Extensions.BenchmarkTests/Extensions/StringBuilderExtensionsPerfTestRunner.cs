// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-16-2021
// ***********************************************************************
// <copyright file="StringBuilderExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(StringBuilderExtensions))]
	public class StringBuilderExtensionsPerfTestRunner : PerfTestRunner
	{

		private byte[] _testByteArray;
		private string[] _testStringArray;

		[Params(25, 50, 100, 250, 500, 1000)]
		public virtual int Count { get; set; }

		[Benchmark(Description = nameof(StringBuilderExtensions.AppendBytes))]
		public void AppendBytes01()
		{
			var sb = new StringBuilder();

			sb.AppendBytes(this._testByteArray);

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(StringBuilderExtensions.AppendBytes) + ": Pool")]
		public void AppendBytes02()
		{
			var sb = TypeHelper.CreateStringBuilder();

			sb.AppendBytes(this._testByteArray);

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(StringBuilderExtensions.AppendKeyValue))]
		public void AppendKeyValue0()
		{
			var sb = new StringBuilder();

			for (var i = 0; i < this._testStringArray.Length; i++)
			{
				var testString = this._testStringArray[i];
				sb.AppendKeyValue(testString, testString);
			}

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(StringBuilderExtensions.AppendValues))]
		public void AppendValues01()
		{
			var sb = new StringBuilder();

			sb.AppendValues(ControlChars.DefaultSeparator, this._testStringArray);

			base.Consumer.Consume(sb.ToString());
		}

		public override void Setup()
		{
			this._testByteArray = RandomData.GenerateByteArray(5).Take(this.Count).ToArray();
			this._testStringArray = RandomData.GenerateWords(this.Count, 10, 10).ToArray();

			this.Setup();
		}
	}
}
