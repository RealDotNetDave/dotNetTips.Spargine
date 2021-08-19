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

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using dotNetTips.Spargine.Collections.Generic.Concurrent;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine)
namespace dotNetTips.Spargine.Benchmarking
{
	public abstract class CounterBenchmark : Benchmark
	{

		/// <summary>
		/// Gets or sets the collection count.
		/// </summary>
		/// <value>The collection count.</value>
		[Params(10, 25, 50, 100, 250, 500, 1000)]
		public int Count { get; set; }
		public IEnumerable<PersonProper> PersonProperEnumerable { get; private set; }

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

		protected virtual IList<CoordinateProper> CoordinateProperList { get; private set; }

		/// <summary>
		/// The person fixed collection
		/// </summary>
		/// <value>The person fixed collection.</value>
		[Obsolete("This will be removed at the end of 2021.")]
		protected IList<PersonFixed> PersonFixedList { get; private set; }

		protected IList<Person> PersonList { get; private set; }

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

		protected BlockingCollection<PersonProper> PersonProperBlockingCollection { get; private set; }

		protected ConcurrentBag<PersonProper> PersonProperConcurrentBag { get; private set; }

		protected ConcurrentDictionary<string, PersonProper> PersonProperConcurrentDictionary { get; private set; }

		protected ConcurrentHashSet<PersonProper> PersonProperConcurrentHashSet { get; private set; }
		/// <summary>
		/// The person proper dictionary
		/// </summary>
		/// <value>The person proper dictionary.</value>
		protected Dictionary<string, PersonProper> PersonProperDictionary { get; private set; }

		protected DistinctConcurrentBag<PersonProper> PersonProperDistinctConcurrentBag { get; private set; }

		protected ImmutableDictionary<string, PersonProper> PersonProperImmutableDictionary { get; private set; }

		protected ImmutableList<PersonProper> PersonProperImmutableList { get; private set; }

		protected LinkedList<PersonProper> PersonProperLinkedList { get; private set; }

		/// <summary>
		/// The person proper collection
		/// </summary>
		/// <value>The person proper collection.</value>
		protected IList<PersonProper> PersonProperList { get; private set; }

		/// <summary>
		/// The person proper collection half count
		/// </summary>
		/// <value>The person proper list half.</value>
		protected IList<PersonProper> PersonProperListHalf { get; private set; }

		protected ObservableCollection<PersonProper> PersonProperObservableCollection { get; private set; }

		protected ReadOnlyCollection<PersonProper> PersonProperReadOnlyCollection { get; private set; }

		/// <summary>
		/// The sortable person proper collection
		/// </summary>
		/// <value>The sortable person proper collection.</value>
		protected IList<PersonProper> PersonProperSortableList { get; private set; }

		/// <summary>
		/// Gets the person record array.
		/// </summary>
		/// <value>The person record array.</value>
		protected PersonRecord[] PersonRecordArray { get; private set; }

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

			this.PersonFixedList = new List<PersonFixed>();
			this.PersonFixedList.AddRange(RandomData.GeneratePersonCollection<PersonFixed>(this.Count));

			this.PersonProperList = new List<PersonProper>();
			this.PersonProperList.AddRange(RandomData.GeneratePersonCollection<PersonProper>(this.Count));

			this.PersonProperDictionary = this.PersonProperList.ToDictionary(p => p.Id);

			this.PersonProperSortableList = new List<PersonProper>(this.PersonProperList);

			this.PersonProperArrayFull = this.PersonProperList.ToArray();
			this.PersonProperArrayHalf = this.PersonProperList.Take(this.Count / 2).ToArray();

			this.PersonProperListHalf = this.PersonProperList.Take(this.Count / 2).ToList();

			this.ByteArray = RandomData.GenerateByteArray(this.Count / 2);

			this.CoordinateProperArray = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.Count).ToArray();

			this.CommaDelimitedString = this.CoordinateProperArray.ToDelimitedString();

			this.StringArray = RandomData.GenerateWords(this.Count, minLength: 15, maxLength: 15).ToArray();

			this.PersonRecordArray = RandomData.GeneratePersonCollection(this.Count).ToArray();

			this.PersonProperImmutableList = this.PersonProperList.ToImmutable();

			this.PersonProperObservableCollection = this.PersonProperList.ToObservableCollection();

			this.PersonProperReadOnlyCollection = this.PersonProperList.ToReadOnlyCollection();

			this.PersonProperImmutableDictionary = this.PersonProperDictionary.ToImmutable();

			this.PersonProperLinkedList = this.PersonProperList.ToLinkedList();

			this.PersonProperConcurrentBag = new ConcurrentBag<PersonProper>(this.PersonProperList);

			this.CoordinateProperList = this.CoordinateProperArray.ToList();

			this.PersonProperConcurrentDictionary = new ConcurrentDictionary<string, PersonProper>(this.PersonProperDictionary);

			this.PersonProperBlockingCollection = this.PersonProperList.ToBlockingCollection();

			this.PersonProperConcurrentHashSet = new ConcurrentHashSet<PersonProper>(this.PersonProperList);

			this.PersonProperDistinctConcurrentBag = new DistinctConcurrentBag<PersonProper>(this.PersonProperList);

			this.PersonList = RandomData.GeneratePersonCollection<Person>(this.Count);

			this.PersonProperEnumerable = this.PersonProperList.AsEnumerable();
		}
	}
}
