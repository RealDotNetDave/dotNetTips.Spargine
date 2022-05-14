// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-24-2021
// ***********************************************************************
// <copyright file="EnumExtensionsBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
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
