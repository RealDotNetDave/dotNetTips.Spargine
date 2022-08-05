// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-04-2022
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
		[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonProper")]
		[BenchmarkCategory(Categories.XML)]
		public void Deserialize01()
		{
			PersonProper result = XmlSerialization.Deserialize<PersonProper>(Resources.PersonProperXml);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(XmlSerialization.Deserialize) + ": XML=PersonRecord")]
		[BenchmarkCategory(Categories.XML)]
		public void Deserialize02()
		{
			PersonRecord result = XmlSerialization.Deserialize<PersonRecord>(Resources.PersonRecordXml);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonRecord")]
		public void Deserialize03()
		{
			PersonRecord result = JsonSerialization.Deserialize<PersonRecord>(Resources.PersonRecordJson);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(JsonSerialization.Deserialize) + ": JSON-PersonProper")]
		public void Deserialize04()
		{
			PersonRecord result = JsonSerialization.Deserialize<PersonRecord>(Resources.PersonProperJson);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(XmlSerialization.Serialize) + ": XML=PersonProper")]
		[BenchmarkCategory(Categories.XML)]
		public void Serialize01()
		{
			var result = XmlSerialization.Serialize(this.PersonProperRef01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonProper")]
		[BenchmarkCategory(Categories.JSON)]
		public void Serialize02()
		{
			var result = JsonSerialization.Serialize(this.PersonProperRef01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(JsonSerialization.Serialize) + ": JSON=PersonRecord")]
		[BenchmarkCategory(Categories.JSON)]
		public void Serialize03()
		{
			var result = JsonSerialization.Serialize(this.PersonRecord02);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(XmlSerialization.StringToXDocument))]
		[BenchmarkCategory(Categories.XML)]
		public void StringToXDocument()
		{
			System.Xml.Linq.XDocument result = XmlSerialization.StringToXDocument(this.XmlTestDataPersonProper);

			Consumer.Consume(result);
		}

	}
}
