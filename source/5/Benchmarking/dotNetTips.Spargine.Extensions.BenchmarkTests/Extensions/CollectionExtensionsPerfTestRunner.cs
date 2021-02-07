using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(CollectionExtensions))]
	public class CollectionExtensionsPerfTestRunner : CollectionPerfTestRunner
	{
		[Benchmark(Description = nameof(CollectionExtensions.AddRange))]
		public void AddRange()
		{
			var people = new List<PersonProper>();

			CollectionExtensions.AddRange(people, base.personProperCollection.Take(base.CollectionCount / 10), Tristate.True);

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
