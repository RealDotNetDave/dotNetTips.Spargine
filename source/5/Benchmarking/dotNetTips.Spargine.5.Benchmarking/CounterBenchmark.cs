// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Benchmarking
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-01-2021
// ***********************************************************************
// <copyright file="CounterBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine)
namespace dotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Class CounterPerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.PerfTestRunner" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.PerfTestRunner" />
	public abstract class CounterBenchmark : Benchmark
	{
		/// <summary>
		/// Gets or sets the collection count.
		/// </summary>
		/// <value>The collection count.</value>
		[Params(10, 25, 50, 100, 250, 500, 1000)]
		public int Count { get; set; }

		/// <summary>
		/// Gets the byte array.
		/// </summary>
		/// <value>The byte array.</value>
		protected virtual byte[] ByteArray { get; private set; }

		/// <summary>
		/// Gets the comma delimited string.
		/// </summary>
		/// <value>The comma delimited string.</value>
		protected virtual string CommaDelimitedString { get; private set; }

		/// <summary>
		/// Gets the coordinate array.
		/// </summary>
		/// <value>The coordinate array.</value>
		protected virtual CoordinateProper[] CoordinateProperArray { get; private set; }

		/// <summary>
		/// The person fixed collection
		/// </summary>
		/// <value>The person fixed collection.</value>
		protected List<PersonFixed> PersonFixedCollection { get; private set; }

		/// <summary>
		/// The person proper array full
		/// </summary>
		/// <value>The person proper array full.</value>
		protected PersonProper[] PersonProperArrayFull { get; private set; }

		/// <summary>
		/// The person proper array half
		/// </summary>
		/// <value>The person proper array half.</value>
		protected PersonProper[] PersonProperArrayHalf { get; private set; }

		/// <summary>
		/// The person proper collection
		/// </summary>
		/// <value>The person proper collection.</value>
		protected List<PersonProper> PersonProperCollection { get; private set; }

		/// <summary>
		/// The person proper dictionary
		/// </summary>
		/// <value>The person proper dictionary.</value>
		protected Dictionary<string, PersonProper> PersonProperDictionary { get; private set; }

		/// <summary>
		/// The person proper collection half count
		/// </summary>
		/// <value>The person proper list half.</value>
		protected List<PersonProper> PersonProperListHalf { get; private set; }

		/// <summary>
		/// Gets the person record array.
		/// </summary>
		/// <value>The person record array.</value>
		protected PersonRecord[] PersonRecordArray { get; private set; }

		/// <summary>
		/// The sortable person proper collection
		/// </summary>
		/// <value>The sortable person proper collection.</value>
		protected List<PersonProper> SortablePersonProperCollection { get; private set; }

		/// <summary>
		/// Gets the string array.
		/// </summary>
		/// <value>The string array.</value>
		protected virtual string[] StringArray { get; private set; }

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.Count}.");

			this.PersonFixedCollection = new List<PersonFixed>();
			this.PersonFixedCollection.AddRange(RandomData.GeneratePersonCollection<PersonFixed>(this.Count));

			this.PersonProperCollection = new List<PersonProper>();
			this.PersonProperCollection.AddRange(RandomData.GeneratePersonCollection<PersonProper>(this.Count));

			this.PersonProperDictionary = this.PersonProperCollection.ToDictionary(p => p.Id);

			this.SortablePersonProperCollection = new List<PersonProper>(this.PersonProperCollection);

			this.PersonProperArrayFull = this.PersonProperCollection.ToArray();
			this.PersonProperArrayHalf = this.PersonProperCollection.Take(this.Count / 2).ToArray();

			this.PersonProperListHalf = this.PersonProperCollection.Take(this.Count / 2).ToList();

			this.ByteArray = RandomData.GenerateByteArray(this.Count / 2);

			this.CoordinateProperArray = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.Count).ToArray();

			this.CommaDelimitedString = this.CoordinateProperArray.ToDelimitedString();

			this.StringArray = RandomData.GenerateWords(this.Count, minLength: 15, maxLength: 15).ToArray();

			this.PersonRecordArray = RandomData.GeneratePersonCollection(this.Count).ToArray();

		}

	}
}
