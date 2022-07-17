// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 02-08-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-22-2022
// ***********************************************************************
// <copyright file="RandomDataBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests.Tester
{
	public class RandomDataBenchmark : Benchmark
	{
		[Benchmark(Description = "Creating: " + nameof(Person))]
		public void CreatePerson01()
		{
			var person = RandomData.GenerateRefPerson<Person>();

			base.Consumer.Consume(person);
		}

		[Benchmark(Description = "Creating: " + nameof(PersonProper))]
		public void CreatePerson04()
		{
			var person = RandomData.GenerateRefPerson<PersonProper>();

			base.Consumer.Consume(person);
		}

		[Benchmark(Description = "Creating: " + nameof(PersonRecord))]
		public void CreatePerson05()
		{
			var person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();

			base.Consumer.Consume(person);
		}

		[Benchmark(Description = "PropertiesToString(): " + nameof(PersonProper))]
		public void PropertiesToString01()
		{
			var person = RandomData.GenerateRefPerson<PersonProper>();

			base.Consumer.Consume(person.PropertiesToString());
		}

		[Benchmark(Description = "PropertiesToString(): " + nameof(PersonRecord))]
		public void PropertiesToString02()
		{
			var person = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();

			base.Consumer.Consume(person.PropertiesToString());
		}
	}
}
