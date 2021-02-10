
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(EnumerableExtensions))]
	public class EnumerableExtensionsPerfTestRunner : CollectionPerfTestRunner
	{
		[Benchmark(Description = nameof(EnumerableExtensions.Count))]
		public void Count()
		{
			var result = base.PersonProperCollection.Count();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastAny))]
		public void FastAny()
		{
			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastCount))]
		public void FastCount()
		{
			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
		public void FirstOrDefaultAlternate()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = base.PersonProperCollection.FirstOrDefault(alternate: person);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
		public void FirstOrDefaultPredicateAlternate()
		{
			var person = RandomData.GeneratePerson<PersonProper>();
			var people = base.PersonProperCollection;

			var result = people.FirstOrDefault(p => p.Id == person.Id, person);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
		public void FirstOrNull()
		{
			var coord = RandomData.GenerateCoordinate<CoordinateProper>();

			var result = base.CoordinateArray.FirstOrNull(p => p.X == coord.X);

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }

		[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
		public void StartsWith()
		{
			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
		public void StructuralSequenceEqual()
		{
			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
		public void ToDelimitedString()
		{
			var result = base.PersonProperCollection.ToDelimitedString(',');

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDictionary))]
		public void ToDictionary()
		{
			var result = base.PersonProperCollection.ToDictionary(p => p.Email);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": Dictionary")]
		public void ToImmutableDictionary()
		{
			var result = base.PersonProperDictionary.ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": List")]
		public void ToImmutableList()
		{
			var result = base.PersonProperCollection.ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
		public void ToLinkedList()
		{
			var result = base.PersonProperCollection.ToLinkedList();

			base.Consumer.Consume(result);
		}
	}
}
