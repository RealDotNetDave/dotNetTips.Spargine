// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-19-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-25-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.PersonRecord.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Loggers;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

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
			ConsoleLogger.Default.WriteLine($"{nameof(this._personRecordArray)} Length = {this._personRecordArray.Length}.");

			this._personRecordArrayHalf = RandomData.GeneratePersonRecordCollection(this.MaxCount / 2).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personRecordArrayHalf)} Length = {this._personRecordArrayHalf.Length}.");
		}

		/// <summary>
		/// Gets <see cref="PersonRecord" /> array.
		/// </summary>
		/// <param name="collectionSize">Size of the collection.</param>
		/// <returns>PersonProper[].</returns>
		public PersonRecord[] GetPersonRecordArray(CollectionSize collectionSize = CollectionSize.Full)
		{
			return collectionSize is CollectionSize.Full
				? this._personRecordArray.Clone<PersonRecord[]>()
				: this._personRecordArrayHalf.Clone<PersonRecord[]>();
		}
	}
}
