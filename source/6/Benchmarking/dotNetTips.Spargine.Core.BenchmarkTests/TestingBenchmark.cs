// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-20-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-24-2021
// ***********************************************************************
// <copyright file="TestingBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

namespace DotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// Testing Benchmark for temporary tests.
	/// Implements the <see cref="Benchmark" />
	/// </summary>
	/// <seealso cref="Benchmark" />
	[BenchmarkCategory("Work in Progress")]
	public class TestingBenchmark : Benchmark
	{
		private readonly PersonRecord _person = RandomData.GeneratePersonRecordCollection(1).First();

		[Benchmark(Description = "MethodImplOptions:Baseline", Baseline = true)]
		[BenchmarkCategory(Categories.New)]
		public void WIPTest01()
		{
			var result = WIPTests.TryValidateNull(this._person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "MethodImplOptions:AggressiveInline")]
		[BenchmarkCategory(Categories.New)]
		public void WIPTest02()
		{
			var result = WIPTests.TryValidateNullAgressive(this._person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "MethodImplOptions:NoInline")]
		[BenchmarkCategory(Categories.New)]
		public void WIPTest03()
		{
			var result = WIPTests.TryValidateNullNoInlining(this._person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "MethodImplOptions:NoOptimization")]
		[BenchmarkCategory(Categories.New)]
		public void WIPTest04()
		{
			var result = WIPTests.TryValidateNullNoOptimization(this._person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "MethodImplOptions:PreserveSig")]
		[BenchmarkCategory(Categories.New)]
		public void WIPTest05()
		{
			var result = WIPTests.TryValidateNullPreserveSig(this._person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "MethodImplOptions:Synchronized")]
		[BenchmarkCategory(Categories.New)]
		public void WIPTest06()
		{
			var result = WIPTests.TryValidateNullSynchronized(this._person);

			this.Consumer.Consume(result);
		}

		[Benchmark(Description = "IN TEST WITHOUT IN")]
		[BenchmarkCategory(Categories.New)]
		public void WIPTest07()
		{
			var ex = new ArgumentNullException(DateTime.Now.ToString(CultureInfo.CurrentCulture));

			WIPTests.InTest01(ex);
		}

		[Benchmark(Description = "IN TEST WITH IN")]
		[BenchmarkCategory(Categories.New)]
		public void WIPTest08()
		{
			var ex = new ArgumentNullException(DateTime.Now.ToString(CultureInfo.CurrentCulture));

			WIPTests.InTest02(ex);
		}
	}
}
