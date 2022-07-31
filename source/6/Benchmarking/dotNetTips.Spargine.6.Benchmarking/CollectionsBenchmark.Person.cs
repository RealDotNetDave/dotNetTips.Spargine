// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Benchmarking
// Author           : David McCarter
// Created          : 04-18-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-25-2022
// ***********************************************************************
// <copyright file="CollectionsBenchmark.Person.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using BenchmarkDotNet.Loggers;
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
		/// The person reference array
		/// </summary>
		private Person[] _personRefArray;

		/// <summary>
		/// The person reference array half
		/// </summary>
		private Person[] _personRefArrayHalf;

		/// <summary>
		/// The person value array
		/// </summary>
		private Tester.Models.ValueTypes.Person[] _personValArray;

		/// <summary>
		/// The person value array half
		/// </summary>
		private Tester.Models.ValueTypes.Person[] _personValArrayHalf;

		/// <summary>
		/// Loads the person reference array.
		/// </summary>
		protected void LoadPersonRefArray()
		{
			this._personRefArray = RandomData.GeneratePersonRefCollection<Person>(this.MaxCount).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personRefArray)} Length = {this._personRefArray.Length}.");

			this._personRefArrayHalf = RandomData.GeneratePersonRefCollection<Person>(this.MaxCount / 2).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personRefArrayHalf)} Length = {this._personRefArrayHalf.Length}.");
		}

		/// <summary>
		/// Loads the person value array.
		/// </summary>
		protected void LoadPersonValArray()
		{
			this._personValArray = RandomData.GeneratePersonValCollection(this.MaxCount).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personValArray)} Length = {this._personValArray.Length}.");

			this._personValArrayHalf = RandomData.GeneratePersonValCollection(this.MaxCount / 2).ToArray();
			ConsoleLogger.Default.WriteLine($"{nameof(this._personValArrayHalf)} Length = {this._personValArrayHalf.Length}.");
		}

		/// <summary>
		/// Gets <see cref="Person" /> array.
		/// </summary>
		/// <param name="collectionSize">Size of the collection.</param>
		/// <returns>Person[].</returns>
		public Person[] GetPersonRefArray(CollectionSize collectionSize = CollectionSize.Full)
		{
			return collectionSize is CollectionSize.Full
				? this._personRefArray.Clone<Person[]>()
				: this._personRefArrayHalf.Clone<Person[]>();
		}

		/// <summary>
		/// Gets <see cref="Person" /> array.
		/// </summary>
		/// <param name="collectionSize">Size of the collection.</param>
		/// <returns>Tester.Models.ValueTypes.Person[].</returns>
		public Tester.Models.ValueTypes.Person[] GetPersonValArray(CollectionSize collectionSize = CollectionSize.Full)
		{
			return collectionSize is CollectionSize.Full ? this._personValArray.Clone<Tester.Models.ValueTypes.Person[]>() : this._personValArrayHalf.Clone<Tester.Models.ValueTypes.Person[]>();
		}
	}
}
