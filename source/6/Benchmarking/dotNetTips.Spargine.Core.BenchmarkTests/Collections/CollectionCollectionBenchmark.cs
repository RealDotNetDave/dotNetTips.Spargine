// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-31-2023
// ***********************************************************************
// <copyright file="CollectionCollectionBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Collections;

/// <summary>
/// Collection type PerfTestRunner.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class CollectionCollectionBenchmark : SmallCollectionsBenchmark
{

	/// <summary>
	/// The person reference array
	/// </summary>
	private PersonProper[] _personRefArray;

	/// <summary>
	/// Collections the create01.
	/// </summary>
	[Benchmark(Description = "Collection.Create: Count")]
	public void CollectionCreate01()
	{
		var result = Collection<Person>.Create(this.Count);

		this.Consume(result);
	}

	/// <summary>
	/// Collections the create02.
	/// </summary>
	[Benchmark(Description = "Collection.Create: From List")]
	public void CollectionCreate02()
	{
		var result = Collection<PersonProper>.Create(this._personRefArray, Tristate.True);

		this.Consume(result);
	}

	/// <summary>
	/// Collections the create03.
	/// </summary>
	[Benchmark(Description = "Collection.Create: From List-Ensure Unique")]
	public void CollectionCreate03()
	{
		var result = Collection<PersonProper>.Create(this._personRefArray, ensureUnique: Tristate.True);

		this.Consume(result);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._personRefArray = GetPersonProperRefArray();
	}
}
