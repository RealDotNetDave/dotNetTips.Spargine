// ***********************************************************************
// Assembly         : DotNetTips.Utility.Benchmarks
// Author           : David McCarter
// Created          : 12-05-2019
//
// Last Modified By : David McCarter
// Last Modified On : 07-28-2022
// ***********************************************************************
// <copyright file="SerializationBenchmark.cs" company="DotNetTips.Utility.Benchmarks">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.BenchmarkTests.Properties;
using DotNetTips.Spargine.Core.Serialization;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Serialization
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
			PersonProper result = XmlSerialization.Deserialize<PersonProper>(Resources.PersonProperXml);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Deserialize this instance.
		/// </summary>
		[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonRecord")]
		[BenchmarkCategory(Categories.XML)]
		public void Deserialize02()
		{
			PersonRecord result = XmlSerialization.Deserialize<PersonRecord>(Resources.PersonRecordXml);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Deserialize this instance.
		/// </summary>
		[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonRecord")]
		public void Deserialize03()
		{
			PersonRecord result = JsonSerialization.Deserialize<PersonRecord>(Resources.PersonRecordJson);

			base.Consumer.Consume(result);
		}

		/// <summary>
		/// Deserialize this instance.
		/// </summary>
		[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonProper")]
		public void Deserialize04()
		{
			PersonRecord result = JsonSerialization.Deserialize<PersonRecord>(Resources.PersonProperJson);

			base.Consumer.Consume(result);
		}

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
			System.Xml.Linq.XDocument result = XmlSerialization.StringToXDocument(this.XmlTestDataPersonProper);

			base.Consumer.Consume(result);
		}

	}
}
