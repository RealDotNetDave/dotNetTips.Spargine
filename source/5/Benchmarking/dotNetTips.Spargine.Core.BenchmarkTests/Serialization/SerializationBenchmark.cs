﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 12-05-2019
//
// Last Modified By : David McCarter
// Last Modified On : 08-24-2021
// ***********************************************************************
// <copyright file="SerializationBenchmark.cs" company="dotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Core.Serialization;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Core.BenchmarkTests.Serialization
{
	/// <summary>
	/// Class SerializationBenchmark.
	/// Implements the <see cref="Benchmark" />
	/// </summary>
	/// <seealso cref="Benchmark" />
	[BenchmarkCategory(Categories.Serialization)]
	public class SerializationBenchmark : Benchmark
	{
		/// <summary>
		/// Deserialize this instance.
		/// </summary>
		[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonProper")]
		[BenchmarkCategory(Categories.XML)]
		public void Deserialize01()
		{
			var result = XmlSerialization.Deserialize<PersonProper>(this.XmlTestDataPersonProper);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Deserialize this instance.
		/// </summary>
		[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonRecord")]
		[BenchmarkCategory(Categories.XML)]
		public void Deserialize02()
		{
			var result = XmlSerialization.Deserialize<PersonRecord>(this.XmlTestDataPersonRecord);

			base.Consumer.Consume(result);
		}

		///// <summary>
		///// Deserialize this instance.
		///// </summary>
		//[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonRecord")]
		//public void Deserialize03()
		//{
		//	var result = JsonSerialization.Deserialize<PersonRecord>(this.JsonTestDataPersonRecord);

		//	base.Consumer.Consume(result);
		//}

		/// <summary>
		/// Serialize this instance.
		/// </summary>
		[Benchmark(Description = nameof(XmlSerialization.Serialize) + ": XML=PersonProper")]
		[BenchmarkCategory(Categories.XML)]
		public void Serialize01()
		{
			var result = XmlSerialization.Serialize(this.PersonProper01);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Serialize this instance.
		/// </summary>
		[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonProper")]
		[BenchmarkCategory(Categories.JSON)]
		public void Serialize02()
		{
			var result = JsonSerialization.Serialize(this.PersonProper01);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Serialize this instance.
		/// </summary>
		[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonRecord")]
		[BenchmarkCategory(Categories.JSON)]
		public void Serialize03()
		{
			var result = JsonSerialization.Serialize(this.PersonRecord02);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();
		}

		/// <summary>
		/// Strings to x document.
		/// </summary>
		[Benchmark(Description = nameof(XmlSerialization.StringToXDocument))]
		[BenchmarkCategory(Categories.XML)]
		public void StringToXDocument()
		{
			var result = XmlSerialization.StringToXDocument(this.XmlTestDataPersonProper);

			base.Consumer.Consume(result);
		}

	}
}
