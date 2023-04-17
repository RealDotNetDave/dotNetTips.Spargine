// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-08-2023
// ***********************************************************************
// <copyright file="SerializationBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
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
	private string _jsonPersonProperRefList;
	private string _jsonPersonRecord;
	private string _jsonPersonRef;
	private List<PersonProper> _personProperRefList;
	private string _xmlPersonRecord;
	private string _xmlPersonRef;

	[Benchmark(Description = "Deserialize JSON: JsonSerializer + Generator - PersonProper")]
	[BenchmarkCategory(Categories.JSON, Categories.New, "JsonSerializer")]
	public void Deserialize_Json_JsonSerializer_Generator_PersonProper()
	{
		var result = System.Text.Json.JsonSerializer.Deserialize(this._jsonPersonRef, typeof(PersonProper), PersonProperJsonSerializerContext.Default) as PersonProper;
		base.Consume(result);
	}

	[Benchmark(Description = "Deserialize JSON: JsonSerializer + Generator - List<PersonProper>")]
	[BenchmarkCategory(Categories.JSON, Categories.New, "JsonSerializer")]
	public void Deserialize_Json_JsonSerializer_Generator_PersonProper_List()
	{
		var result = System.Text.Json.JsonSerializer.Deserialize(this._jsonPersonProperRefList, typeof(List<PersonProper>), PersonProperJsonSerializerContext.Default) as List<PersonProper>;
		base.Consume(result);
	}

	/// <summary>
	/// Deserializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": List<PersonProper>")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize_Json_PersonProper_List()
	{
		var result = JsonSerialization.Deserialize<List<PersonProper>>(this._jsonPersonProperRefList);

		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Deserialize_Json_PersonRecord()
	{
		var result = JsonSerialization.Deserialize<PersonRecord>(this._jsonPersonRecord);

		this.Consume(result);
	}

	/// <summary>
	/// Deserializes the XML record.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonRecord")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize_Xml_PersonRecord()
	{
		var result = XmlSerialization.Deserialize<PersonRecord>(this._xmlPersonRecord);

		this.Consume(result);
	}
	/// <summary>
	/// Deserializes the XML reference.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonProper")]
	[BenchmarkCategory(Categories.XML)]
	public void Deserialize_Xml_Ref_PersonProper()
	{
		var result = XmlSerialization.Deserialize<PersonProper>(this._xmlPersonRef);

		this.Consume(result);
	}

	[Benchmark(Description = "Serialize JSON: JsonSerializer + Generator - PersonProper")]
	[BenchmarkCategory(Categories.JSON, Categories.New, "JsonSerializer")]
	public void Serialize_Json_JsonSerializer_Generator_PersonProper()
	{
		var result = System.Text.Json.JsonSerializer.Serialize(base.PersonProperRef01, typeof(PersonProper), PersonProperJsonSerializerContext.Default);

		base.Consume(result);
	}

	[Benchmark(Description = "Serialize JSON: JsonSerializer + Generator - List<PersonProper>")]
	[BenchmarkCategory(Categories.JSON, Categories.New, "JsonSerializer")]
	public void Serialize_Json_JsonSerializer_Generator_PersonProper_List()
	{
		var result = System.Text.Json.JsonSerializer.Serialize(this._personProperRefList, typeof(List<PersonProper>), PersonProperJsonSerializerContext.Default);
		base.Consume(result);
	}

	/// <summary>
	/// Serializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": List<PersonProper>")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_PersonProper_List()
	{
		var result = JsonSerialization.Serialize(this._personProperRefList);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json record.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonRecord")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_PersonRecord()
	{
		var result = JsonSerialization.Serialize(this.PersonRecord02);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the json reference.
	/// </summary>
	[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonProper")]
	[BenchmarkCategory(Categories.JSON)]
	public void Serialize_Json_Ref_PersonProper()
	{
		var result = JsonSerialization.Serialize(this.PersonProperRef01);

		this.Consume(result);
	}

	/// <summary>
	/// Serializes the XML reference.
	/// </summary>
	[Benchmark(Description = nameof(XmlSerialization.Serialize) + ": XML=PersonProper")]
	[BenchmarkCategory(Categories.XML)]
	public void Serialize_XML_Ref_PersonProper()
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
		this._jsonPersonProperRefList = RandomData.GeneratePersonRefCollection<PersonProper>(100).ToJson();
		this._personProperRefList = RandomData.GeneratePersonRefCollection<PersonProper>(100).ToList();
	}

}
