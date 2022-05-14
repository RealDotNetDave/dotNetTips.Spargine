// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-20-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-04-2022
// ***********************************************************************
// <copyright file="LargeCollectionBenchmark.CoordinateProper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

namespace DotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Class CounterBenchmark.
	/// Implements the <see cref="Benchmark" />
	/// </summary>
	/// <seealso cref="Benchmark" />
	public partial class CollectionsBenchmark
	{
		/// <summary>
		/// The coordinate proper array
		/// </summary>
		private CoordinateProper[] _coordinateProperArray;

		/// <summary>
		/// The coordinate proper array half
		/// </summary>
		private CoordinateProper[] _coordinateProperArrayHalf;

		/// <summary>
		/// Loads the coordinate array.
		/// </summary>
		protected void LoadCoordinateProperArray()
		{
			this._coordinateProperArray = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.MaxCount).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._coordinateProperArray)} length = {this._coordinateProperArray.Length}.");

			this._coordinateProperArrayHalf = RandomData.GenerateCoordinateCollection<CoordinateProper>(this.MaxCount / 2).Clone<CoordinateProper[]>();
			ConsoleLogger.Default.WriteLine($"{nameof(this._coordinateProperArrayHalf)} length = {this._coordinateProperArrayHalf.Length}.");
		}

		/// <summary>
		/// Gets <see cref="CoordinateProper" /> array.
		/// </summary>
		/// <param name="clone">If set to <see cref="Tristate.UseDefault" /> or <see cref="Tristate.True" />, clones the collection.</param>
		/// <param name="collectionSize">Size of the collection.</param>
		/// <returns>CoordinateProper[].</returns>
		public CoordinateProper[] GetCoordinateProperArray(Tristate clone = Tristate.True, CollectionSize collectionSize = CollectionSize.Full)
		{
			return collectionSize is CollectionSize.Full
				? clone is Tristate.True or Tristate.UseDefault ? this._coordinateProperArray.Clone<CoordinateProper[]>() : this._coordinateProperArray
				: clone is Tristate.True or Tristate.UseDefault ? this._coordinateProperArrayHalf.Clone<CoordinateProper[]>() : this._coordinateProperArrayHalf;
		}
	}
}
