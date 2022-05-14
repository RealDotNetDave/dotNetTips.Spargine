using BenchmarkDotNet.Attributes;

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Class LargeCounterBenchmark.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	public class LargeCounterBenchmark : Benchmark
	{
		/// <summary>
		/// Gets or sets the collection count.
		/// </summary>
		/// <value>The collection count.</value>
		[Params(10, 25, 50, 100, 250, 500, 1000, 2500)]
		public int Count { get; set; }
	}
}
