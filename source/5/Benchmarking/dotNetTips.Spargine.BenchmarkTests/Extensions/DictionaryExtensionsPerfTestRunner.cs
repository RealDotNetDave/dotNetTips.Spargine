using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.BenchmarkTests.Extensions
{
	[BenchmarkCategory(nameof(DictionaryExtensions))]
	public class DictionaryExtensionsPerfTestRunner : CollectionPerfTestRunner
	{

		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ":Dictionary")]
		public void GetOrAddDictionary()
		{
			var people = base.personProperDictionary;
			var person = base.personProperDictionary.Last();

			var result = people.GetOrAdd(person.Key, person.Value);

			base.Consumer.Consume(result);
		}


		[Benchmark(Description = nameof(DictionaryExtensions.GetOrAdd) + ":Dictionary-New")]
		public void GetOrAddDictionaryNew()
		{
			var people = base.personProperDictionary;
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.GetOrAdd(person.Id, person);

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }


		[Benchmark(Description = nameof(DictionaryExtensions.Upsert))]
		public void UpsertDictionary()
		{
			var people = base.personProperDictionary;
			var person = base.personProperDictionary.Last();

			var result = people.Upsert(person.Key, person.Value);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(DictionaryExtensions.Upsert) + ":New Person")]
		public void UpsertDictionaryNew()
		{
			var people = base.personProperDictionary;
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.Upsert(person.Id, person);

			base.Consumer.Consume(result);
		}
	}
}
