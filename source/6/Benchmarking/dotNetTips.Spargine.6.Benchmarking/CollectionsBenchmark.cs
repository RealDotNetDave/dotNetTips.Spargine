// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-05-2022
// ***********************************************************************
// <copyright file="Collections.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester.Models.RefTypes;

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Class for Collections.
	/// Implements the <see cref="CounterBenchmark" />
	/// </summary>
	/// <seealso cref="CounterBenchmark" />
	public partial class CollectionsBenchmark : Benchmark
	{
		/// <summary>
		/// The people to insert
		/// </summary>
		private PersonProper[] _peopleToInsert;

		/// <summary>
		/// Initializes a new instance of the <see cref="CollectionsBenchmark"/> class.
		/// </summary>
		/// <param name="maxCount">The maximum count.</param>
		protected CollectionsBenchmark(in int maxCount)
		{
			this.MaxCount = Math.Max(2, maxCount);
		}

		/// <summary>
		/// Gets the people to insert.
		/// </summary>
		/// <returns>PersonProper[].</returns>
		protected virtual PersonProper[] GetPeopleToInsert()
		{
			return this._peopleToInsert.Clone<PersonProper[]>();
		}

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.MaxCount}:{this.GetType().FullName}.");

			//Load collections
			this.LoadCoordinateArray();
			this.LoadCoordinateProperArray();
			this.LoadPersonProperRefArray();
			this.LoadPersonRecordArray();
			this.LoadPersonRefArray();
			this.LoadPersonValArray();

			this._peopleToInsert = new List<PersonProper>(this.GetPersonProperArray(Core.Tristate.False)).Shuffle(10).ToArray();
		}

		/// <summary>
		/// Gets the maximum count.
		/// </summary>
		/// <value>The maximum count.</value>
		public int MaxCount { get; internal set; }
	}
}
