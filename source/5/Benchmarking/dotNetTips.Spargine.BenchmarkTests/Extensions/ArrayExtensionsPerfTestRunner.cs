
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.BenchmarkTests.Extensions
{
	[BenchmarkCategory(nameof(ArrayExtensions))]
	public class ArrayExtensionsPerfTestRunner : CollectionPerfTestRunner
	{

		[Benchmark(Description = nameof(ArrayExtensions.BytesToString))]
		public void BytesToString()
		{
			var result = base.byteArray.BytesToString();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone))]
		public void Clone()
		{
			var result = base.personProperCollection.Clone<List<PersonProper>>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ContainsAny) + ":Array")]
		public void ContainsAnyArray()
		{
			var people = base.personProperArrayFull.Take(base.CollectionCount / 10).ToList();
			people.Add(RandomData.GeneratePerson<PersonProper>());

			var result = base.personProperArrayFull.ContainsAny(people.ToArray());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ContainsAny) + ":List")]
		public void ContainsAnyList()
		{
			var people = base.personProperCollection.Take(base.CollectionCount / 10).ToList();
			people.Add(RandomData.GeneratePerson<PersonProper>());

			var result = base.personProperCollection.ContainsAny(people.ToArray());

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }
	}
}
