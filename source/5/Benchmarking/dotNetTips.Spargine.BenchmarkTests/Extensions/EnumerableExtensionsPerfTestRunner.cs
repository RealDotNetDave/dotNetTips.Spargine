
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.BenchmarkTests.Extensions
{
	[BenchmarkCategory(nameof(EnumerableExtensions))]
	public class EnumerableExtensionsPerfTestRunner : CollectionPerfTestRunner
	{
		[Benchmark(Description = nameof(EnumerableExtensions.Count))]
		public void Count()
		{
			var result = base.personProperCollection.Count();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDistinct))]
		public void Distinct()
		{
			var comparer = new PersonProperComparer();
			var result = base.personProperCollection.Distinct(comparer);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastAny))]
		public void FastAny()
		{
			var result = base.personProperCollection.FastAny(p => p.City.Contains("SAN"));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastCount))]
		public void FastCount()
		{
			var result = base.personProperCollection.FastCount(p => p.City.Contains("SAN"));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
		public void FirstOrDefaultAlternate()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = base.personProperCollection.FirstOrDefault(person);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
		public void FirstOrDefaultPredicateAlternate()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = base.personProperCollection.FirstOrDefault(p => p.Id == person.Id, person);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
		public void FirstOrNull()
		{
			var coord = RandomData.GenerateCoordinate<CoordinateProper>();

			var result = base.coordinateArray.FirstOrNull(p => p.X == coord.X);

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }

		[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
		public void StartsWith()
		{
			var result = base.personProperArrayFull.StartsWith(base.personProperArrayHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
		public void StructuralSequenceEqual()
		{
			var result = base.personProperArrayFull.StructuralSequenceEqual(base.personProperArrayHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
		public void ToDelimitedString()
		{
			var result = base.personProperCollection.ToDelimitedString(',');

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDictionary))]
		public void ToDictionary()
		{
			var result = base.personProperCollection.ToDictionary(p => p.Email);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDistinct))]
		public void ToDistinct()
		{
			var result = base.personProperCollection.Select(p => p.Email).ToArray().ToDistinct();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": Dictionary")]
		public void ToImmutableDictionary()
		{
			var result = base.personProperDictionary.ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": List")]
		public void ToImmutableList()
		{
			var result = base.personProperCollection.ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
		public void ToLinkedList()
		{
			var result = base.personProperCollection.ToLinkedList();

			base.Consumer.Consume(result);
		}
	}
}
