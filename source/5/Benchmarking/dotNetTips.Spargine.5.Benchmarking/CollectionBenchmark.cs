// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Benchmarking
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-01-2021
// ***********************************************************************
// <copyright file="CollectionBenchmark.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Loggers;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester.Models;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine)
namespace dotNetTips.Spargine.Benchmarking
{
	/// <summary>
	/// Collection PerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.CounterBenchmark" />
	public abstract class CollectionBenchmark : CounterBenchmark
	{
		/// <summary>
		/// Gets the people to insert.
		/// </summary>
		/// <value>The people to insert.</value>
		protected virtual PersonProper[] PeopleToInsert { get; private set; }

		/// <summary>
		/// Setups this instance.
		/// </summary>
		public override void Setup()
		{
			base.Setup();

			this.PeopleToInsert = new List<PersonProper>(base.PersonProperCollection).Shuffle(10).ToArray();

			ConsoleLogger.Default.WriteLine(LogKind.Info, $"Collection Count={this.Count}.");
		}
	}
}
