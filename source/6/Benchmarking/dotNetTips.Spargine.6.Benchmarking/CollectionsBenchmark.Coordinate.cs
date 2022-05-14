// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-04-2022
// ***********************************************************************
// <copyright file="Collections.Coordinate.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;

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
		/// The coordinate array
		/// </summary>
		private Tester.Models.ValueTypes.Coordinate[] _coordinateArray;

		/// <summary>
		/// The coordinate array half
		/// </summary>
		private Tester.Models.ValueTypes.Coordinate[] _coordinateArrayHalf;

		/// <summary>
		/// Loads the coordinate array.
		/// </summary>
		protected void LoadCoordinateArray()
		{
			this._coordinateArray = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(this.MaxCount).ToArray();
			this._coordinateArrayHalf = RandomData.GenerateCoordinateCollection<Tester.Models.ValueTypes.Coordinate>(this.MaxCount / 2).ToArray();

			ConsoleLogger.Default.WriteLine($"{nameof(this._coordinateArray)} count = {this._coordinateArray.Length}.");
			ConsoleLogger.Default.WriteLine($"{nameof(this._coordinateArrayHalf)} count = {this._coordinateArrayHalf.Length}.");
		}

		/// <summary>
		/// Gets <see cref="Tester.Models.ValueTypes.Coordinate" /> array.
		/// </summary>
		/// <param name="clone">If set to <see cref="Tristate.UseDefault" /> or <see cref="Tristate.True" />, clones the collection.</param>
		/// <param name="collectionSize">Size of the collection.</param>
		/// <returns>Tester.Models.ValueTypes.Coordinate[].</returns>
		public Tester.Models.ValueTypes.Coordinate[] GetCoordinateArray(in Tristate clone = Tristate.True, in CollectionSize collectionSize = CollectionSize.Full)
		{
			return collectionSize is CollectionSize.Full
				? clone is Tristate.True or Tristate.UseDefault ? this._coordinateArray.Clone<Tester.Models.ValueTypes.Coordinate[]>() : this._coordinateArray
				: clone is Tristate.True or Tristate.UseDefault ? this._coordinateArrayHalf.Clone<Tester.Models.ValueTypes.Coordinate[]>() : this._coordinateArrayHalf;
		}
	}
}
