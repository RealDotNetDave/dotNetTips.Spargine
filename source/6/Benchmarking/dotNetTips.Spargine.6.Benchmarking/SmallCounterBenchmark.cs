// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-22-2022
// ***********************************************************************
// <copyright file="SmallCounterBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Class SmallCounterBenchmark.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	public class SmallCounterBenchmark : Benchmark
	{
		/// <summary>
		/// Gets or sets the collection count.
		/// </summary>
		/// <value>The collection count.</value>
		[Params(2, 5, 10, 20, 25, 50, 75, 100, 250)]
		public int Count { get; set; }
	}
}
