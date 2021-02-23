// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-10-2021
// ***********************************************************************
// <copyright file="ObjectExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(ObjectExtensions))]
	public class ObjectExtensionsBenchmark : Benchmark
	{
		private string _peopleJson;
		private PersonProper _person;
		private PersonRecord _personRecord;

		[Benchmark(Description = nameof(ObjectExtensions.As) + ": IPerson")]
		public void As()
		{
			var result = this._person.As<IPerson>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.Clone) + ": PersonProper")]
		public void Clone01()
		{
			var result = this._person.Clone<PersonProper>();

			base.Consumer.Consume(result);
		}

		//[Benchmark(Description = nameof(ObjectExtensions.ComputeMD5Hash))]
		//public void ComputeMD5Hash()
		//{
		//	var result = this._person.ComputeMD5Hash();

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash) + ": PersonProper")]
		public void ComputeSha256Hash01()
		{
			var result = this._person.ComputeSha256Hash();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash) + ": PersonRecord")]
		public void ComputeSha256Hash02()
		{
			var result = this._personRecord.ComputeSha256Hash();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.DisposeFields) + ": DataTable")]
		public void DisposeFields()
		{
			var disposableType = new DataTable("TEST");

			disposableType.DisposeFields();
		}

		[Benchmark(Description = "PersonRecord: Duplication with new ID")]
		public void Duplicate01()
		{
			var result = this._personRecord with { Id = "12345678" };

			base.Consumer.Consume(result);
		}

		//[Benchmark(Description = nameof(ObjectExtensions.FromJson))]
		//public void FromJson()
		//{
		//	var result = this._peopleJson.FromJson<PersonProper>();

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(ObjectExtensions.HasProperty) + ": PersonProper")]
		public void HasProperty()
		{
			var result = this._person.HasProperty("City");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.IsNotNull) + ": PersonProper")]
		public void IsNotNull()
		{
			var result = this._person.IsNotNull();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.IsNull) + ": PersonProper")]
		public void IsNull()
		{
			var result = this._person.IsNull();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = "PersonRecord: ToString()")]
		public void PersonRecordToString01()
		{
			var person = this._personRecord;

			var result = person.ToString();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonProper-Ignore Nulls")]
		public void PropertiesToDictionary01()
		{
			var person = this._person;

			var result = person.PropertiesToDictionary(ignoreNulls: true);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonProper-With Nulls")]
		public void PropertiesToDictionary02()
		{
			var person = this._person;

			var result = person.PropertiesToDictionary(ignoreNulls: false);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonRecord-With Nulls")]
		public void PropertiesToDictionary04()
		{
			var person = this._personRecord;

			var result = person.PropertiesToDictionary(ignoreNulls: false);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.PropertiesToDictionary) + ": PersonRecord-Ignore Nulls")]
		public void PropertiesToDictionary05()
		{
			var person = this._personRecord;

			var result = person.PropertiesToDictionary(ignoreNulls: true);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonProper-Ignore Nulls")]
		public void PropertiesToString01()
		{
			var person = this._person;

			var result = person.PropertiesToString(ignoreNulls: true);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonProper-With Nulls")]
		public void PropertiesToString02()
		{
			var person = this._person;

			var result = person.PropertiesToString(ignoreNulls: false);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonRecord-Ignore Nulls")]
		public void PropertiesToString03()
		{
			var person = this._personRecord;

			var result = person.PropertiesToString(ignoreNulls: true);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.PropertiesToString) + ": PersonRecord-With Nulls")]
		public void PropertiesToString04()
		{
			var person = this._personRecord;

			var result = person.PropertiesToString(ignoreNulls: false);

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			this._person = RandomData.GeneratePerson<PersonProper>();
			this._personRecord = RandomData.GeneratePersonCollection(count: 1, addressCount: 1).First();
			this._peopleJson = this._person.ToJson();
		}

		[Benchmark(Description = nameof(ObjectExtensions.StripNull) + ": PersonProper")]
		public void StripNull()
		{
			var result = this._person.StripNull();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": PersonProper")]
		public void ToJson01()
		{
			var result = this._person.ToJson();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.ToJson) + ": PersonRecord")]
		public void ToJson02()
		{
			var result = this._personRecord.ToJson();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.TryDispose) + ": PersonProper")]
		public void TryDispose()
		{
			var disposableType = new DataTable("TEST");

			disposableType.TryDispose();
		}
	}
}
