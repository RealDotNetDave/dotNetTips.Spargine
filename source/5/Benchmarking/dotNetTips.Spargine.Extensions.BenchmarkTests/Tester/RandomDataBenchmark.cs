// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 02-08-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2021
// ***********************************************************************
// <copyright file="RandomDataBenchmark.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests.Tester
{
	public class RandomDataBenchmark : Benchmark
	{
		[Benchmark(Description = "Creating: " + nameof(Person))]
		public void CreatePerson01()
		{
			var person = RandomData.GeneratePerson<Person>();

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
