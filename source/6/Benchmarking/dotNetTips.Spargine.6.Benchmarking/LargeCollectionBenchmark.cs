// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-05-2022
// ***********************************************************************
// <copyright file="LargeCollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Collection PerfTestRunner.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	public class LargeCollectionBenchmark : CollectionsBenchmark
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LargeCollectionBenchmark" /> class.
		/// </summary>
		public LargeCollectionBenchmark() : base(2500)
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this.MaxCount}:LargeCollectionBenchmark");
		}

		/// <summary>
		/// Gets or sets the collection count.
		/// </summary>
		/// <value>The collection count.</value>
		[Params(10, 25, 50, 100, 250, 500, 1000, 2500)]
		public int Count { get; set; }

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}:LargeCollectionBenchmark Before Setup");

			base.MaxCount = Count;

			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Count={this.Count}:LargeCollectionBenchmark After Setup");
		}
	}
}
