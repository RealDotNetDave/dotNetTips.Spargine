
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Loggers;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Benchmarking
{
	//[ConcurrencyVisualizerProfiler()]
	public abstract class CollectionPerfTestRunner : PerfTestRunner
	{

		/// <summary>
		/// Gets or sets the collection count.
		/// </summary>
		/// <value>The collection count.</value>
		[Params(25, 50, 100, 250, 500, 1000)]
		public virtual int CollectionCount { get; set; }
		protected byte[] ByteArray { get; set; }
		protected CoordinateProper[] CoordinateArray { get; set; }
		protected string DelimitedString { get; set; }

		/// <summary>
		/// The person fixed collection
		/// </summary>
		protected List<PersonFixed> PersonFixedCollection { get; set; }

		/// <summary>
		/// The person proper array full
		/// </summary>
		protected PersonProper[] PersonProperArrayFull { get; set; }

		/// <summary>
		/// The person proper array half
		/// </summary>
		protected PersonProper[] PersonProperArrayHalf { get; set; }

		/// <summary>
		/// The person proper collection
		/// </summary>
		protected List<PersonProper> PersonProperCollection { get; set; }

		/// <summary>
		/// The person proper dictionary
		/// </summary>
		protected Dictionary<string, PersonProper> PersonProperDictionary { get; set; }

		/// <summary>
		/// The person proper collection half count
		/// </summary>
		protected List<PersonProper> PersonProperListHalf { get; set; }

		/// <summary>
		/// The sortable person proper collection
		/// </summary>
		protected List<PersonProper> SortablePersonProperCollection { get; set; }

		/// <summary>
		/// The test email
		/// </summary>
		protected string TestEmail { get; set; }

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.CollectionCount}.");

			this.PersonFixedCollection = new List<PersonFixed>();
			this.PersonFixedCollection.AddRange(RandomData.GeneratePersonCollection<PersonFixed>(this.CollectionCount));

			this.PersonProperCollection = new List<PersonProper>();
			this.PersonProperCollection.AddRange(RandomData.GeneratePersonCollection<PersonProper>(this.CollectionCount));

			this.PersonProperDictionary = this.PersonProperCollection.ToDictionary(p => p.Id);

			this.TestEmail = this.PersonProperCollection.Shuffle().First().Email;

			this.SortablePersonProperCollection = new List<PersonProper>(this.PersonProperCollection);

			this.PersonProperArrayFull = this.PersonProperCollection.ToArray();
			this.PersonProperArrayHalf = this.PersonProperCollection.Take(this.CollectionCount / 2).ToArray();

			this.PersonProperListHalf = this.PersonProperCollection.Take(this.CollectionCount / 2).ToList();

			this.ByteArray = RandomData.GenerateByteArray(this.CollectionCount / 2);

			this.CoordinateArray = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.CollectionCount).ToArray();

			this.DelimitedString = this.CoordinateArray.ToDelimitedString();
		}

	}
}
