// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="EnumExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(EnumExtensions))]
	public class EnumExtensionsPerfTestRunner : PerfTestRunner
	{
		[Benchmark(Description = nameof(EnumExtensions.GetDescription))]
		public void GetDescription()
		{
			var testEnum = StringComparison.OrdinalIgnoreCase;

			var result = testEnum.GetDescription();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumExtensions.GetItems))]
		public void GetItems()
		{
			var testEnum = StringComparison.OrdinalIgnoreCase;

			var result = testEnum.GetItems();

			base.Consumer.Consume(result);
		}
	}
}
