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
	public class EnumExtensionsBenchmark : Benchmark
	{
		private readonly StringComparison _testEnum = StringComparison.OrdinalIgnoreCase;

		[Benchmark(Description = nameof(EnumExtensions.GetDescription))]
		public void GetDescription01()
		{
			var result = this._testEnum.GetDescription();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumExtensions.GetItems))]
		public void GetItems01()
		{
			var result = this._testEnum.GetItems();

			base.Consumer.Consume(result);
		}
	}
}
