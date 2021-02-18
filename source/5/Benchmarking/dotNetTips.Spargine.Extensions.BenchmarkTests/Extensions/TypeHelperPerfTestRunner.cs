using System.Text;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(TypeExtensions))]
	public class TypeHelperPerfTestRunner : PerfTestRunner
	{
		[Benchmark(Description = "Looping Collection: " + nameof(TypeHelper.CreateStringBuilder))]
		public void CreateStringBuilder01()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(500);

			var sb = TypeHelper.CreateStringBuilder();

			foreach (var person in people)
			{
				sb.AppendFormat("{0}={1}", person.Email, person.PostalCode);
			}

			base.Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = "Looping Collection: Normal StringBuilder")]
		public void CreateStringBuilder02()
		{
			var people = RandomData.GeneratePersonCollection<PersonProper>(500);

			var sb = new StringBuilder();

			foreach (var person in people)
			{
				sb.AppendFormat("{0}={1}", person.Email, person.PostalCode);
			}

			base.Consumer.Consume(sb.ToString());
		}
	}
}
