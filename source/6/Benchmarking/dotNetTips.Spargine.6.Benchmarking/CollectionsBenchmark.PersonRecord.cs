﻿// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-19-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-04-2022
// ***********************************************************************
// <copyright file="LargeCollectionBenchmark.PersonRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

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
		/// The person record reference array
		/// </summary>
		private PersonRecord[] _personRecordArray;

		/// <summary>
		/// The person record reference array half
		/// </summary>
		private PersonRecord[] _personRecordArrayHalf;

		/// <summary>
		/// Loads the person record array.
		/// </summary>
		protected void LoadPersonRecordArray()
		{
			this._personRecordArray = RandomData.GeneratePersonRecordCollection(this.MaxCount).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personRecordArray)} length = {this._personRecordArray.Length}.");

			this._personRecordArrayHalf = RandomData.GeneratePersonRecordCollection(this.MaxCount / 2).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personRecordArrayHalf)} length = {this._personRecordArrayHalf.Length}.");
		}

		/// <summary>
		/// Gets <see cref="PersonRecord" /> array.
		/// </summary>
		/// <param name="clone">If set to <see cref="Tristate.UseDefault" /> or <see cref="Tristate.True" />, clones the collection.</param>
		/// <param name="collectionSize">Size of the collection.</param>
		/// <returns>PersonProper[].</returns>
		public PersonRecord[] GetPersonRecordArray(in Tristate clone = Tristate.True, in CollectionSize collectionSize = CollectionSize.Full)
		{
			return collectionSize is CollectionSize.Full
				? clone is Tristate.True or Tristate.UseDefault ? this._personRecordArray.Clone<PersonRecord[]>() : this._personRecordArray
				: clone is Tristate.True or Tristate.UseDefault ? this._personRecordArrayHalf.Clone<PersonRecord[]>() : this._personRecordArrayHalf;
		}
	}
}