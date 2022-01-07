// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Benchmarking
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-06-2022
// ***********************************************************************
// <copyright file="CounterBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using dotNetTips.Spargine.Core.Collections.Generic;
using dotNetTips.Spargine.Core.Collections.Generic.Concurrent;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models.RefTypes;
using dotNetTips.Spargine.Tester.Models.ValueTypes;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine)
namespace dotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Class CounterBenchmark.
	/// Implements the <see cref="Benchmark" />
	/// </summary>
	/// <seealso cref="Benchmark" />
	public abstract class CounterBenchmark : Benchmark
	{
		/// <summary>
		/// The person reference array
		/// </summary>
		private Tester.Models.RefTypes.Person[] _personRefArray;

		/// <summary>
		/// The person value array
		/// </summary>
		private Tester.Models.RefTypes.Person[] _personValArray;

		/// <summary>
		/// Loads the person reference array.
		/// </summary>
		private void LoadPersonRefArray()
		{
			var people = RandomData.GeneratePersonCollection<Tester.Models.RefTypes.Person>(this.Count);

			this._personRefArray = people.ToArray();
		}

		/// <summary>
		/// Loads the person value array.
		/// </summary>
		private void LoadPersonValArray()
		{
			var people = RandomData.GeneratePersonCollection<Tester.Models.RefTypes.Person>(this.Count);

			this._personValArray = people.ToArray();
		}

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
		/// Gets the coordinate proper list.
		/// </summary>
		/// <value>The coordinate proper list.</value>
		protected virtual List<CoordinateProper> CoordinateProperList { get; private set; }

		/// <summary>
		/// Gets the person list.
		/// </summary>
		/// <value>The person list.</value>
		protected List<Tester.Models.RefTypes.Person> PersonList { get; private set; }

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
		/// Gets the person proper blocking collection.
		/// </summary>
		/// <value>The person proper blocking collection.</value>
		protected BlockingCollection<PersonProper> PersonProperBlockingCollection { get; private set; }

		/// <summary>
		/// Gets the person proper collection.
		/// </summary>
		/// <value>The person proper collection.</value>
		protected Core.Collections.Generic.Collection<PersonProper> PersonProperCollection { get; private set; }

		/// <summary>
		/// Gets the person proper concurrent bag.
		/// </summary>
		/// <value>The person proper concurrent bag.</value>
		protected ConcurrentBag<PersonProper> PersonProperConcurrentBag { get; private set; }

		/// <summary>
		/// Gets the person proper concurrent dictionary.
		/// </summary>
		/// <value>The person proper concurrent dictionary.</value>
		protected ConcurrentDictionary<string, PersonProper> PersonProperConcurrentDictionary { get; private set; }

		/// <summary>
		/// Gets the person proper concurrent hash set.
		/// </summary>
		/// <value>The person proper concurrent hash set.</value>
		protected ConcurrentHashSet<PersonProper> PersonProperConcurrentHashSet { get; private set; }

		/// <summary>
		/// The person proper dictionary
		/// </summary>
		/// <value>The person proper dictionary.</value>
		protected Dictionary<string, PersonProper> PersonProperDictionary { get; private set; }

		/// <summary>
		/// Gets the person proper distinct blocking collection.
		/// </summary>
		/// <value>The person proper distinct blocking collection.</value>
		protected DistinctBlockingCollection<PersonProper> PersonProperDistinctBlockingCollection { get; private set; }

		/// <summary>
		/// Gets the person proper distinct concurrent bag.
		/// </summary>
		/// <value>The person proper distinct concurrent bag.</value>
		protected DistinctConcurrentBag<PersonProper> PersonProperDistinctConcurrentBag { get; private set; }

		/// <summary>
		/// Gets the person proper fast sorted list.
		/// </summary>
		/// <value>The person proper fast sorted list.</value>
		protected FastSortedList<PersonProper> PersonProperFastSortedList { get; private set; }

		/// <summary>
		/// Gets the person proper hash set.
		/// </summary>
		/// <value>The person proper hash set.</value>
		protected HashSet<PersonProper> PersonProperHashSet { get; private set; }

		/// <summary>
		/// Gets the person proper immutable dictionary.
		/// </summary>
		/// <value>The person proper immutable dictionary.</value>
		protected ImmutableDictionary<string, PersonProper> PersonProperImmutableDictionary { get; private set; }

		/// <summary>
		/// Gets the person proper immutable list.
		/// </summary>
		/// <value>The person proper immutable list.</value>
		protected ImmutableList<PersonProper> PersonProperImmutableList { get; private set; }

		/// <summary>
		/// Gets the person proper linked list.
		/// </summary>
		/// <value>The person proper linked list.</value>
		protected LinkedList<PersonProper> PersonProperLinkedList { get; private set; }

		/// <summary>
		/// The person proper collection
		/// </summary>
		/// <value>The person proper collection.</value>
		protected List<PersonProper> PersonProperList { get; private set; }

		/// <summary>
		/// The person proper collection half count
		/// </summary>
		/// <value>The person proper list half.</value>
		protected List<PersonProper> PersonProperListHalf { get; private set; }

		/// <summary>
		/// Gets the person proper observable collection.
		/// </summary>
		/// <value>The person proper observable collection.</value>
		protected ObservableCollection<PersonProper> PersonProperObservableCollection { get; private set; }

		/// <summary>
		/// Gets the person proper observable list.
		/// </summary>
		/// <value>The person proper observable list.</value>
		protected ObservableList<PersonProper> PersonProperObservableList { get; private set; }

		/// <summary>
		/// Gets the person proper read only collection.
		/// </summary>
		/// <value>The person proper read only collection.</value>
		protected ReadOnlyCollection<PersonProper> PersonProperReadOnlyCollection { get; private set; }

		/// <summary>
		/// The sortable person proper collection
		/// </summary>
		/// <value>The sortable person proper collection.</value>
		protected List<PersonProper> PersonProperSortableList { get; private set; }

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
		/// Clones the person reference array.
		/// </summary>
		/// <returns>Tester.Models.RefTypes.Person[].</returns>
		public Tester.Models.RefTypes.Person[] ClonePersonRefArray()
		{
			return this._personRefArray.Clone() as Tester.Models.RefTypes.Person[];
		}

		/// <summary>
		/// Clones the person value array.
		/// </summary>
		/// <returns>Person[].</returns>
		public Tester.Models.RefTypes.Person[] ClonePersonValArray()
		{
			return this._personValArray.Clone() as Tester.Models.RefTypes.Person[];
		}

		/// <summary>
		/// Clones the person value list.
		/// </summary>
		/// <returns>List&lt;Tester.Models.RefTypes.Person&gt;.</returns>
		public List<Tester.Models.RefTypes.Person> ClonePersonValList()
		{
			return this.PersonValList.Clone<List<Tester.Models.RefTypes.Person>>();
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.Count}.");

			this.PersonProperList = new List<PersonProper>();
			this.PersonProperList.AddRange(RandomData.GeneratePersonCollection<PersonProper>(this.Count));

			this.LoadPersonRefArray();
			this.LoadPersonValArray();

			this.PersonProperCollection = this.PersonProperList.ToCollection();

			this.PersonProperObservableList = this.PersonProperList.ToObservableList();

			this.PersonProperFastSortedList = this.PersonProperList.ToFastSortedList();

			this.PersonProperHashSet = this.PersonProperList.ToHashSet();

			this.PersonProperConcurrentHashSet = this.PersonProperHashSet.ToConcurrentHashSet();

			this.PersonProperDistinctBlockingCollection = this.PersonProperList.ToDistinctBlockingCollection(false);

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

			this.PersonRecordList = RandomData.GeneratePersonCollection(this.Count);

			this.PersonProperImmutableList = this.PersonProperList.ToImmutable();

			this.PersonProperObservableCollection = this.PersonProperList.ToObservableCollection();

			this.PersonProperReadOnlyCollection = this.PersonProperList.ToReadOnlyCollection();

			this.PersonProperImmutableDictionary = this.PersonProperDictionary.ToImmutable();

			this.PersonProperLinkedList = this.PersonProperList.ToLinkedList();

			this.PersonProperConcurrentBag = new ConcurrentBag<PersonProper>(this.PersonProperList);

			this.CoordinateProperList = this.CoordinateProperArray.ToList();

			this.PersonProperConcurrentDictionary = new ConcurrentDictionary<string, PersonProper>(this.PersonProperDictionary);

			this.PersonProperBlockingCollection = this.PersonProperList.ToBlockingCollection();

			this.PersonProperDistinctConcurrentBag = this.PersonProperList.ToDistinctConcurrentBag();

			this.PersonList = RandomData.GeneratePersonCollection<Tester.Models.RefTypes.Person>(this.Count);

			this.PersonProperEnumerable = this.PersonProperList.AsEnumerable();

			this.PersonValList = RandomData.GeneratePersonCollection<Tester.Models.ValueTypes.Person>(Count);
		}

		/// <summary>
		/// Gets or sets the collection count.
		/// </summary>
		/// <value>The collection count.</value>
		[Params(10, 25, 50, 100, 250, 500, 1000)]
		public int Count { get; set; }

		/// <summary>
		/// Gets the person proper enumerable.
		/// </summary>
		/// <value>The person proper enumerable.</value>
		public IEnumerable<PersonProper> PersonProperEnumerable { get; private set; }

		/// <summary>
		/// Gets the person record collection.
		/// </summary>
		/// <value>The person record collection.</value>
		public List<PersonRecord> PersonRecordList { get; private set; }

		/// <summary>
		/// Gets the clone person value list.
		/// </summary>
		/// <value>The clone person value list.</value>
		public List<Tester.Models.ValueTypes.Person> PersonValList { get; private set; }
	}
}
