
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Loggers;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Benchmarking
{
	[ConcurrencyVisualizerProfiler()]
	public abstract class CollectionPerfTestRunner : PerfTestRunner
	{
		protected byte[] byteArray;
		protected CoordinateProper[] coordinateArray;
		protected string delimitedString;

		/// <summary>
		/// The person fixed collection
		/// </summary>
		protected List<PersonFixed> personFixedCollection;

		/// <summary>
		/// The person proper array full
		/// </summary>
		protected PersonProper[] personProperArrayFull;

		/// <summary>
		/// The person proper array half
		/// </summary>
		protected PersonProper[] personProperArrayHalf;

		/// <summary>
		/// The person proper collection
		/// </summary>
		protected List<PersonProper> personProperCollection;

		/// <summary>
		/// The person proper dictionary
		/// </summary>
		protected Dictionary<string, PersonProper> personProperDictionary;

		/// <summary>
		/// The person proper collection half count
		/// </summary>
		protected List<PersonProper> personProperListHalf;

		/// <summary>
		/// The sortable person proper collection
		/// </summary>
		protected List<PersonProper> sortablePersonProperCollection;

		/// <summary>
		/// The test email
		/// </summary>
		protected string testEmail;

		/// <summary>
		/// Gets or sets the collection count.
		/// </summary>
		/// <value>The collection count.</value>
		[Params(25, 50, 100, 250, 500, 1000)]
		public virtual int CollectionCount { get; set; }

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.CollectionCount}.");

			this.personFixedCollection = new List<PersonFixed>();
			this.personFixedCollection.AddRange(RandomData.GeneratePersonCollection<PersonFixed>(this.CollectionCount));

			this.personProperCollection = new List<PersonProper>();
			this.personProperCollection.AddRange(RandomData.GeneratePersonCollection<PersonProper>(this.CollectionCount));

			this.personProperDictionary = this.personProperCollection.ToDictionary(p => p.Id);

			this.testEmail = this.personProperCollection.Shuffle().First().Email;

			this.sortablePersonProperCollection = new List<PersonProper>(this.personProperCollection);

			this.personProperArrayFull = this.personProperCollection.ToArray();
			this.personProperArrayHalf = this.personProperCollection.Take(this.CollectionCount / 2).ToArray();

			this.personProperListHalf = this.personProperCollection.Take(this.CollectionCount / 2).ToList();

			this.byteArray = RandomData.GenerateByteArray(this.CollectionCount / 2);

			this.coordinateArray = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.CollectionCount).ToArray();

			this.delimitedString = this.coordinateArray.ToDelimitedString();
		}

	}
}
