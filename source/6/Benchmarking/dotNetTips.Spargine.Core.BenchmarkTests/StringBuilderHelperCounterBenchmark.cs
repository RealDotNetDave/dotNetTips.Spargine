// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-31-2022
// ***********************************************************************
// <copyright file="StringBuilderHelperCounterBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// StringBuilderHelper PerfTestRunner.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
[BenchmarkCategory(Categories.Strings)]
public class StringBuilderHelperCounterBenchmark : SmallCollectionsBenchmark
{
	private byte[] _byteArray;
	private IEnumerable<byte> _bytes1Kb;

	[Benchmark(Description = nameof(StringBuilderHelper.BytesToString))]
	[BenchmarkCategory(Categories.Collections)]
	public void BytesToString()
	{
		var result = StringBuilderHelper.BytesToString(this._byteArray);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._bytes1Kb = this.GetByteArray(this.Count).AsEnumerable();
		this._byteArray = this.GetByteArray(this.Count);
	}

	//[Benchmark(Description = nameof(StringBuilderHelper.ToDelimitedString))]
	//[BenchmarkCategory(Categories.Collections)]
	//public void ToDelimitedString()
	//{
	//	var result = _bytes1Kb.ToDelimitedString();

	//	base.Consumer.Consume(result);
	//}

}
