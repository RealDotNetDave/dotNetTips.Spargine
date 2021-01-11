
using System;
using BenchmarkDotNet.Attributes;

namespace dotNetTips.Spargine.BenchmarkTests.Extensions
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

			var result = testEnum.GetItems<StringComparison>();

			base.Consumer.Consume(result);
		}
	}
}
