// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.PersonProper.cs" company="David McCarter - dotNetTips.com">
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
		/// The person proper dictionary
		/// </summary>
		private Dictionary<string, PersonProper> _personProperDictionary;

		/// <summary>
		/// The person proper dictionary half
		/// </summary>
		private Dictionary<string, PersonProper> _personProperDictionaryHalf;

		//private SortedDictionary<string, PersonProper> _personProperSortedDictionary;

		//private SortedDictionary<string, PersonProper> _personProperSortedDictionaryHalf;

		/// <summary>
		/// The person proper reference array
		/// </summary>
		private PersonProper[] _personProperRefArray;

		/// <summary>
		/// The person proper reference array half
		/// </summary>
		private PersonProper[] _personProperRefArrayHalf;

		/// <summary>
		/// Loads the person proper reference array.
		/// </summary>
		protected void LoadPersonProperRefArray()
		{
			this._personProperRefArray = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personProperRefArray)} Length = {this._personProperRefArray.Length}.");

			this._personProperRefArrayHalf = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount / 2).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personProperRefArrayHalf)} Length = {this._personProperRefArrayHalf.Length}.");

			this._personProperDictionary = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount).ToDictionary(p => p.Id);
			ConsoleLogger.Default.WriteLine($"{nameof(this._personProperDictionary)} Count = {this._personProperDictionary.Count}.");

			this._personProperDictionaryHalf = RandomData.GeneratePersonRefCollection<PersonProper>(this.MaxCount / 2).ToDictionary(p => p.Id);
			ConsoleLogger.Default.WriteLine($"{nameof(this._personProperDictionaryHalf)} Count = {this._personProperDictionaryHalf.Count}.");
		}

		/// <summary>
		/// Gets <see cref="PersonProper" /> array.
		/// </summary>
		/// <param name="collectionSize">Size of the collection.</param>
		/// <returns>PersonProper[].</returns>
		public PersonProper[] GetPersonProperArray(CollectionSize collectionSize = CollectionSize.Full)
		{
			return collectionSize == CollectionSize.Full
				? this._personProperRefArray.Clone<PersonProper[]>()
				: this._personProperRefArrayHalf.Clone<PersonProper[]>();
		}

		/// <summary>
		/// Gets <see cref="PersonProper" /> dictionary.
		/// </summary>
		/// <param name="collectionSize">Size of the collection.</param>
		/// <returns>Dictionary&lt;System.String, PersonProper&gt;.</returns>
		public Dictionary<string, PersonProper> GetPersonProperDictionary(CollectionSize collectionSize = CollectionSize.Full)
		{
			return collectionSize is CollectionSize.Full
				? this._personProperDictionary.Clone<Dictionary<string, PersonProper>>()
				: this._personProperDictionaryHalf.Clone<Dictionary<string, PersonProper>>();
		}
	}
}
