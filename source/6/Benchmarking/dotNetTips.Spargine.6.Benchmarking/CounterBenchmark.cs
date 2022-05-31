// ***********************************************************************
// Assembly         : dotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-22-2022
// ***********************************************************************
// <copyright file="CounterBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
using BenchmarkDotNet.Loggers;

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Class CounterBenchmark.
	/// Implements the <see cref="Benchmark" />
	/// </summary>
	/// <seealso cref="Benchmark" />
	public abstract class CounterBenchmark : Benchmark
	{
		/// <summary>
		/// The maximum collection count
		/// </summary>
		private readonly int _maxCount;

		/// <summary>
		/// Initializes a new instance of the <see cref="CounterBenchmark" /> class.
		/// </summary>
		/// <param name="maxCount">The maximum collection count.</param>
		protected CounterBenchmark(int maxCount)
		{
			this._maxCount = Math.Max(2, maxCount);

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={maxCount}: {nameof(CounterBenchmark)}.");

		}

		/// <summary>
		/// Gets the maximum collection count.
		/// </summary>
		/// <value>The maximum count.</value>
		protected int MaxCount => this._maxCount;

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Max Count={this._maxCount}: {nameof(CounterBenchmark)}.");
		}
	}
}
