// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2023
// ***********************************************************************
// <copyright file="StringBuilderExtensionsCounterBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// StringBuilderExtensions CounterPerfTestRunner.
/// Implements the <see cref="CounterBenchmark" />
/// </summary>
/// <seealso cref="CounterBenchmark" />
[BenchmarkCategory(Categories.Strings)]
public class StringBuilderExtensionsCounterBenchmark : SmallCollectionsBenchmark
{
	private string[] _stringArray;
	private IEnumerable<string> _stringEnumerable;
	private byte[] _byteArray;

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendBytes) + ": 01*")]
	public void AppendBytes01()
	{
		var sb = new StringBuilder();

		sb.AppendBytes(this._byteArray);

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(FastStringBuilder.BytesToString) + ": 01**")]
	public void AppendBytes03()
	{
		var result = FastStringBuilder.BytesToString(this._byteArray);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendKeyValue))]
	public void AppendKeyValue1()
	{
		var sb = new StringBuilder();
		var stringArray = this._stringArray;

		for (var index = 0; index < stringArray.Length; index++)
		{
			var testString = stringArray[index];
			sb.AppendKeyValue(testString, testString);
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendValues) + ": String Array")]
	public void AppendValues01()
	{
		var sb = new StringBuilder();

		sb.AppendValues(ControlChars.DefaultSeparator, this._stringArray);

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(StringBuilderExtensions.AppendValues) + ": String Enumerable")]
	public void AppendValues02()
	{
		var sb = new StringBuilder();

		sb.AppendValues(ControlChars.DefaultSeparator, this._stringEnumerable);

		this.Consume(sb.ToString());
	}

	public override void Setup()
	{
		base.Setup();

		this._stringArray = this.GetStringArray(this.Count, 15, 15);
		this._stringEnumerable = this.GetStringArray(this.Count, 15, 15).AsEnumerable();
		this._byteArray = this.GetByteArray(1);
	}

}
