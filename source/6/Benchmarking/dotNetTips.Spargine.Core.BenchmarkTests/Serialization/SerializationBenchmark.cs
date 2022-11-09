// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-03-2022
// ***********************************************************************
// <copyright file="SerializationBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.BenchmarkTests.Properties;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Serialization;

/// <summary>
/// Class SerializationBenchmark.
/// Implements the <see cref="Benchmark" />
/// </summary>
/// <seealso cref="Benchmark" />
[BenchmarkCategory(Categories.Serialization)]
public class SerializationBenchmark : Benchmark
{
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonProper")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize01()
	{
		var result = XmlSerialization.Deserialize<PersonProper>(base.XmlTestDataPersonProper);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonRecord")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize02()
	{
		var result = XmlSerialization.Deserialize<PersonRecord>(base.XmlTestDataPersonRecord);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize03()
	{
		var result = JsonSerialization.Deserialize<PersonRecord>(base.JsonTestDataPersonRecord);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonProper")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize04()
	{
		var result = JsonSerialization.Deserialize<PersonRecord>(base.XmlTestDataPersonProper);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(XmlSerialization.Serialize) + ": XML=PersonProper")]
	[BenchmarkCategory(Categories.XML)]
	public void Serialize01()
	{
		var result = XmlSerialization.Serialize(this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonProper")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize02()
	{
		var result = JsonSerialization.Serialize(this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize03()
	{
		var result = JsonSerialization.Serialize(this.PersonRecord02);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(XmlSerialization.StringToXDocument))]
	[BenchmarkCategory(Categories.XML)]
	public void StringToXDocument()
	{
		var result = XmlSerialization.StringToXDocument(this.XmlTestDataPersonProper);

		this.Consume(result);
	}

}
