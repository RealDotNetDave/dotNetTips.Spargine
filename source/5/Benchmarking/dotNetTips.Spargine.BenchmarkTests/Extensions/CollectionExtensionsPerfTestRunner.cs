using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester.Models;
using CollectionExtensions = dotNetTips.Spargine.Extensions.CollectionExtensions;

namespace dotNetTips.Spargine.BenchmarkTests.Extensions
{
	[BenchmarkCategory(nameof(CollectionExtensions))]
	public class CollectionExtensionsPerfTestRunner : CollectionPerfTestRunner
	{
		[Benchmark(Description = nameof(CollectionExtensions.AddRange))]
		public void AddRange()
		{
			var people = new List<PersonProper>();

			CollectionExtensions.AddRange(people, base.personProperCollection.Take(base.CollectionCount / 10), true);

			base.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems))]
		public void HasItems()
		{
			var result = base.personProperCollection.HasItems(p => p.City.Contains("SAN"));

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }
	}
}
