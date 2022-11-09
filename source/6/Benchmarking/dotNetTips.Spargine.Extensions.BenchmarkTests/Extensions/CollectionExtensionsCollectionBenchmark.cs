// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-06-2022
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class CollectionExtensionsCollectionBenchmark.
/// Implements the <see cref="LargeCollectionsBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionsBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class CollectionExtensionsCollectionBenchmark : LargeCollectionsBenchmark
{

	/// <summary>
	/// The people collection
	/// </summary>
	private Collection<PersonProper> _peopleCollection;

	/// <summary>
	/// The people to add
	/// </summary>
	private IEnumerable<PersonProper> _peopleToAdd;


	[Benchmark(Description = nameof(CollectionExtensions.HasItems))]
	public void HasItems()
	{
		var result = this._peopleCollection.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": List")]
	public void AddRange01()
	{
		var people = GetPersonProperRefList();

		var result = people.AddRange(this.GetPeopleRefToInsert(), Tristate.True);

		this.Consume(result);
	}


	[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Count")]
	public void HasItemsWithCount()
	{
		var result = this._peopleCollection.HasItems(5);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Predicate")]
	public void HasItemsWithPredicate()
	{
		var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 500);

		this.Consume(result);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._peopleCollection = GetPersonProperRefArray().ToCollection();
		this._peopleToAdd = GetPersonProperRefArray(collectionSize: CollectionSize.Half).Take(this.Count / 2);
	}

}
