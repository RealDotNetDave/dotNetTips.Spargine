// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-22-2021
// ***********************************************************************
// <copyright file="TypeHelperBenchmark.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// TypeHelper PerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.PerfTestRunner" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.PerfTestRunner" />
	[BenchmarkCategory(nameof(TypeHelper))]
	public class TypeHelperBenchmark : Benchmark
	{
		private List<PersonProper> _people;

		[Benchmark(Description = "Looping Collection: Normal StringBuilder")]
		public void CreateStringBuilder02()
		{
			var sb = new StringBuilder();

			foreach (var person in this._people)
			{
				sb.AppendFormat("{0}={1}", person.Email, person.PostalCode);
			}

			base.Consumer.Consume(sb.ToString());
		}

		public override void Setup()
		{
			base.Setup();

			this._people = RandomData.GeneratePersonCollection<PersonProper>(500);
		}
	}
}
