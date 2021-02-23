// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Benchmarking
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="CollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Loggers;

namespace dotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Collection PerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	public abstract class CollectionBenchmark : CounterBenchmark
	{
		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.Count}.");
		}
	}
}
