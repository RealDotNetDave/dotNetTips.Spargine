// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-11-2022
// ***********************************************************************
// <copyright file="ObjectExtensionsBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

public class ObjectExtensionsBenchmark : Benchmark
{

	private string _peopleJson;
	private Collection<PersonProper> _personCollection;
	private PersonProper _personProper;
	private PersonRecord _personRecord;

	private void CheckForNullParamNormal(object input)
	{
		if (input is null)
		{
			input = "TEST";
		}

		this.Consume(input);
	}

	private void CheckForNullParamSpargine(object input)
	{
		if (input is null)
		{
			input = "SPARGINE";
		}

		this.Consume(input);
	}

	[Benchmark(Description = nameof(ObjectExtensions.As) + ": IPerson")]
	public void As()
	{
		var result = this._personProper.As<IPerson>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.Clone) + ": PersonProper")]
	public void ClonePersonProper()
	{
		var result = this._personProper.Clone<PersonProper>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.Clone) + ": PersonProper Array")]
	public void ClonePersonProperArray()
	{
		var result = this._personCollection.ToArray().Clone<PersonProper[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.Clone) + ": PersonProper Collection")]
	public void ClonePersonProperCollection()
	{
		var result = this._personCollection.Clone<Collection<PersonProper>>();

		this.Consume(result);
	}

	[Benchmark(Description = "Clone: PersonRecord*")]
	public void ClonePersonRecord()
	{
		var result = this._personRecord with { };

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash) + ": PersonProper")]
	public void ComputeSha256Hash01()
	{
		var result = this._personProper.ComputeSha256Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash) + ": PersonRecord")]
	public void ComputeSha256Hash02()
	{
		var result = this._personRecord.ComputeSha256Hash();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.DisposeFields) + ": DataTable")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void DisposeFields()
	{
		var disposableType = new DataTable("TEST");

		disposableType.DisposeFields();
	}

	[Benchmark(Description = "PersonRecord: Duplication with new ID")]
	public void Duplicate01()
	{
		var result = this._personRecord with { Id = "12345678" };

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.FromJson))]
	public void FromJson()
	{
		var result = this._peopleJson.FromJson<PersonProper>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.HasProperty) + ": PersonProper")]
	public void HasProperty01()
	{
		var result = this._personProper.HasProperty("City");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.HasProperty) + ": PersonRecord")]
	public void HasProperty02()
	{
		var result = this._personRecord.HasProperty("City");

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNotNull) + ": PersonProper")]
	public void IsNotNull01()
	{
		var result = this._personProper.IsNotNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNotNull) + ": PersonRecord")]
	public void IsNotNull02()
	{
		var result = this._personRecord.IsNotNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNull) + ": PersonProper")]
	public void IsNull01()
	{
		var result = this._personProper.IsNull();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.IsNull) + ": PersonRecord")]
	public void IsNull02()
	{
		var result = this._personRecord.IsNull();

		this.Consume(result);
	}

	[Benchmark(Description = "PersonRecord: ToString()")]
	public void PersonRecordToString01()
	{
		var person = this._personRecord;

		var result = person.ToString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonProper-Ignore Nulls")]
	public void PropertiesToDictionary01()
	{
		var person = this._personProper;

		var result = person.PropertiesToDictionary(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonProper-With Nulls")]
	public void PropertiesToDictionary02()
	{
		var person = this._personProper;

		var result = person.PropertiesToDictionary(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonRecord-With Nulls")]
	public void PropertiesToDictionary04()
	{
		var person = this._personRecord;

		var result = person.PropertiesToDictionary(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonRecord-Ignore Nulls")]
	public void PropertiesToDictionary05()
	{
		var person = this._personRecord;

		var result = person.PropertiesToDictionary(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonProper-Ignore Nulls")]
	public void PropertiesToString01()
	{
		var person = this._personProper;

		var result = person.PropertiesToString(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonProper-With Nulls")]
	public void PropertiesToString02()
	{
		var person = this._personProper;

		var result = person.PropertiesToString(ignoreNulls: false);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonRecord-Ignore Nulls")]
	public void PropertiesToString03()
	{
		var person = this._personRecord;

		var result = person.PropertiesToString(ignoreNulls: true);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonRecord-With Nulls")]
	public void PropertiesToString04()
	{
		var person = this._personRecord;

		var result = person.PropertiesToString(ignoreNulls: false);

		this.Consume(result);
	}

	public override void Setup()
	{
		base.Setup();

		this._personProper = RandomData.GenerateRefPerson<PersonProper>();
		this._personRecord = RandomData.GeneratePersonRecordCollection(count: 1, addressCount: 1).First();
		this._peopleJson = this._personProper.ToJson();
		this._personCollection = RandomData.GeneratePersonRefCollection<PersonProper>(5000);
	}

	[Benchmark(Description = nameof(ObjectExtensions.StripNull) + ": PersonProper")]
	public void StripNull()
	{
		var result = this._personProper.StripNull();

		this.Consume(result);
	}

	[Benchmark(Description = "Testing Param for Null: != null")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TestingForNull01()
	{
		var input = new object();

		this.CheckForNullParamNormal(input);
	}

	[Benchmark(Description = "Testing Param for Null: Validate.TryValidateNull()")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TestingForNull02()
	{
		var input = new object();

		this.CheckForNullParamSpargine(input);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": PersonProper")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJson01()
	{
		var result = this._personProper.ToJson();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": PersonRecord")]
	[BenchmarkCategory(Categories.Serialization, Categories.JSON)]
	public void ToJson02()
	{
		var result = this._personRecord.ToJson();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ObjectExtensions.TryDispose) + ": PersonProper")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void TryDispose()
	{
		var disposableType = new DataTable("TEST");

		disposableType.TryDispose();
	}

}
