// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-30-2023
// ***********************************************************************
// <copyright file="SerializationBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
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
	/// <summary>
	/// The json person reference
	/// </summary>
	private string _jsonPersonRef;

	/// <summary>
	/// The json person record
	/// </summary>
	private string _jsonPersonRecord;

	/// <summary>
	/// The XML person reference
	/// </summary>
	private string _xmlPersonRef;

	/// <summary>
	/// The XML person record
	/// </summary>
	private string _xmlPersonRecord;

	/// <summary>
	/// Deserializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize_Json_Record()
	{
		var result = JsonSerialization.Deserialize<PersonRecord>(this._jsonPersonRecord);

		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the json reference.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonProper")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize_Json_Ref()
	{
		var result = JsonSerialization.Deserialize<PersonRecord>(this._jsonPersonRef);

		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the XML record.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonRecord")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize_Xml_Record()
	{
		var result = XmlSerialization.Deserialize<PersonRecord>(this._xmlPersonRecord);

		this.Consume(result);
	}
	/// <summary>
	/// Deserializes the XML reference.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonProper")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize_Xml_Ref()
	{
		var result = XmlSerialization.Deserialize<PersonProper>(this._xmlPersonRef);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_Record()
	{
		var result = JsonSerialization.Serialize(this.PersonRecord02);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json reference.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonProper")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_Ref()
	{
		var result = JsonSerialization.Serialize(this.PersonProperRef01);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the XML reference.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Serialize) + ": XML=PersonProper")]
	[BenchmarkCategory(Categories.XML)]
	public void Serialize_XML_Ref()
	{
		var result = XmlSerialization.Serialize(this.PersonProperRef01);

		this.Consume(result);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();
		this._jsonPersonRef = JsonSerialization.Serialize(base.PersonProperRef01);
		this._jsonPersonRecord = JsonSerialization.Serialize(base.PersonRecord01);
		this._xmlPersonRef = XmlSerialization.Serialize(base.PersonProperRef01);
		this._xmlPersonRecord = XmlSerialization.Serialize(base.PersonRecord01);
	}

}
