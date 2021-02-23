using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests.Tester
{
	[BenchmarkCategory(nameof(RandomData))]
	public class RandomDataBenchmark : Benchmark
	{
		[Benchmark(Description = "Creating: " + nameof(Person))]
		public void CreatePerson01()
		{
			var person = RandomData.GeneratePerson<Person>();

			base.Consumer.Consume(person);
		}

		[Benchmark(Description = "Creating: " + nameof(PersonFixed))]
		public void CreatePerson02()
		{
			var person = RandomData.GeneratePerson<PersonFixed>();

			base.Consumer.Consume(person);
		}

		[Benchmark(Description = "Creating: " + nameof(PersonPlus))]
		public void CreatePerson03()
		{
			var person = RandomData.GeneratePerson<PersonPlus>();

			base.Consumer.Consume(person);
		}

		[Benchmark(Description = "Creating: " + nameof(PersonProper))]
		public void CreatePerson04()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			base.Consumer.Consume(person);
		}

		[Benchmark(Description = "Creating: " + nameof(PersonRecord))]
		public void CreatePerson05()
		{
			var person = RandomData.GeneratePersonCollection(count: 1, addressCount: 1).First();

			base.Consumer.Consume(person);
		}

		[Benchmark(Description = "PropertiesToString(): " + nameof(PersonProper))]
		public void PropertiesToString01()
		{
			var person = RandomData.GeneratePerson<PersonProper>();

			base.Consumer.Consume(person.PropertiesToString());
		}

		[Benchmark(Description = "PropertiesToString(): " + nameof(PersonRecord))]
		public void PropertiesToString02()
		{
			var person = RandomData.GeneratePersonCollection(count: 1, addressCount: 1).First();

			base.Consumer.Consume(person.PropertiesToString());
		}
	}
}
