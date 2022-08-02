// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Partial class for Collections benchmark.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	public partial class CollectionsBenchmark : Benchmark
	{

		/// <summary>
		/// The people to insert
		/// </summary>
		private PersonProper[] _peopleRefToInsert;

		/// <summary>
		/// The people value to insert
		/// </summary>
		private Tester.Models.ValueTypes.Person[] _peopleValToInsert;

		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionsBenchmark" /> class.
		/// </summary>
		/// <param name="maxCount">The maximum count.</param>
		protected CollectionsBenchmark(int maxCount)
		{
			this.MaxCount = Math.Max(2, maxCount);
		}

		/// <summary>
		/// Gets the people to insert.
		/// </summary>
		/// <returns>PersonProper[].</returns>
		protected virtual PersonProper[] GetPeopleRefToInsert()
		{
			return this._peopleRefToInsert;
		}

		/// <summary>
		/// Gets the people value to insert.
		/// </summary>
		/// <returns>Tester.Models.ValueTypes.Person[].</returns>
		protected virtual Tester.Models.ValueTypes.Person[] GetPeopleValToInsert()
		{
			return this._peopleValToInsert;
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.MaxCount}: {nameof(CollectionsBenchmark)}.");

			//Load collections
			this.LoadCoordinateCollections();
			this.LoadCoordinateProperCollections();
			this.LoadPersonProperCollections();
			this.LoadPersonRecordCollections();
			this.LoadPersonCollections();

			this._peopleRefToInsert = new List<PersonProper>(this.GetPersonProperRefArray().Shuffle(Math.Max(2, this.MaxCount / 2))).ToArray();
			this._peopleValToInsert = new List<Tester.Models.ValueTypes.Person>(this.GetPersonValArray().Shuffle(Math.Max(2, this.MaxCount / 2))).ToArray();
		}

		/// <summary>
		/// Gets the maximum count.
		/// </summary>
		/// <value>The maximum count.</value>
		public int MaxCount { get; internal set; }

	}
}
