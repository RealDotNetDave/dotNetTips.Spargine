// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2022
// ***********************************************************************
// <copyright file="TypeHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// TypeHelper PerfTestRunner.
	/// Implements the <see cref="Benchmarking.PerfTestRunner" />
	/// </summary>
	/// <seealso cref="Benchmarking.PerfTestRunner" />
	public class TypeHelperBenchmark : Benchmark
	{
		private readonly int _collectionCount = 50;
		private List<PersonProper> _people;

		[Benchmark(Description = "Looping Collection: Normal StringBuilder")]
		[BenchmarkCategory(Categories.Strings)]
		public void CreateStringBuilder01()
		{
			var sb = new StringBuilder();

			foreach (PersonProper person in this._people)
			{
				_ = sb.AppendFormat(CultureInfo.InvariantCulture, "{0}={1}", person.Email, person.PostalCode);
			}

			Consumer.Consume(sb.ToString());
		}

		[Benchmark(Description = nameof(TypeHelper.GetPropertyValues))]
		[BenchmarkCategory(Categories.Reflection)]
		public void GetPropertyValues01()
		{
			PersonProper person = RandomData.GenerateRefPerson<PersonProper>();

			System.Collections.Immutable.ImmutableDictionary<string, string> result = TypeHelper.GetPropertyValues(person);

			Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			var list = new Dictionary<string, string>(this._collectionCount);
			for (var i = 0; i < this._collectionCount; i++)
			{
				list.Add(RandomData.GenerateKey(), RandomData.GenerateKey());
			}

			this._people = RandomData.GeneratePersonRefCollection<PersonProper>(this._collectionCount).ToList();
		}
	}
}
