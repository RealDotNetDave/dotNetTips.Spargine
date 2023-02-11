// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-20-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2023
// ***********************************************************************
// <copyright file="TestingBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Testing Benchmark for temporary tests.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
[BenchmarkCategory("Work in Progress")]
public class TestingBenchmark : SmallCollectionsBenchmark
{
	private Tester.Models.ValueTypes.Person[] _peopleVal;
	private PersonProper[] _peopleRef;

	//[Benchmark(Description = "Clone Val")]
	//[BenchmarkCategory(Categories.New)]
	//public void Clone01()
	//{
	//	var result = _peopleVal.Clone<Tester.Models.ValueTypes.Person[]>();

	//	this.Consume(result);
	//}

	//[Benchmark(Description = "Clone Ref")]
	//[BenchmarkCategory(Categories.New)]
	//public void Clone02()
	//{
	//	var result = _peopleRef.Clone<PersonProper[]>();

	//	this.Consume(result);
	//}

	[Benchmark(Description = "AddIf() Ref")]
	[BenchmarkCategory(Categories.New)]
	public void AddIf01()
	{
		var result = this._peopleRef.AddIf<PersonProper>(this.PersonProperRef01, this._peopleRef.Length > 1);

		this.Consume(result);
	}

	[Benchmark(Description = "AddIf() Val")]
	[BenchmarkCategory(Categories.New)]
	public void AddIf02()
	{
		var result = this._peopleVal.AddIf(this.PersonVal01, this._peopleVal.Length > 1);

		this.Consume(result);
	}

	public override void Setup()
	{
		this._peopleVal = RandomData.GeneratePersonValCollection<Tester.Models.ValueTypes.Person>(this.Count).ToArray();
		this._peopleRef = RandomData.GeneratePersonRefCollection<PersonProper>(this.Count).ToArray();
	}
}
