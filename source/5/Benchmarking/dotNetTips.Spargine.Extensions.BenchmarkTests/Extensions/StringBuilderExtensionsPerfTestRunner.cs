// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="StringBuilderExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Text;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(StringBuilderExtensions))]
	public class StringBuilderExtensionsPerfTestRunner : PerfTestRunner
	{
		[Benchmark(Description = nameof(StringBuilderExtensions.AppendBytes))]
		public void AppendBytes()
		{
			var sb = new StringBuilder();

			sb.AppendBytes(RandomData.GenerateByteArray(1));

			base.Consumer.Consume(sb.ToString());
		}

		//[Benchmark(Description = nameof(StringBuilderExtensions.AppendJoin))]
		//public void AppendJoin()
		//{
		//	var sb = new StringBuilder();

		//	sb.AppendJoin<byte>('-', RandomData.GenerateByteArray(1));

		//	base.Consumer.Consume(sb.ToString());
		//}

		//[Benchmark(Description = nameof(StringBuilderExtensions.AppendJoin) + ":Params")]
		//public void AppendJoinParams()
		//{
		//	var sb = new StringBuilder();

		//	sb.AppendJoin('-', RandomData.GenerateByteArray(1));

		//	base.Consumer.Consume(sb.ToString());
		//}
	}
}
