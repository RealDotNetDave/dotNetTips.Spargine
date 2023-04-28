// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2023
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class CollectionExtensionsCollectionBenchmark.
/// Implements the <see cref="SmallCollectionsBenchmark" />
/// </summary>
/// <seealso cref="SmallCollectionsBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class CollectionExtensionsCollectionBenchmark : SmallCollectionsBenchmark
{
	private Collection<PersonProper> _peopleRefCollection;
	private List<PersonProper> _peopleRefList;

	[Benchmark(Description = nameof(CollectionExtensions.AddRange) + ": List")]
	public void AddRange01()
	{
		var people = this._peopleRefList;

		var result = people.AddRange(this.GetPeopleRefToInsert(), Tristate.True);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.HasItems))]
	public void HasItems()
	{
		var result = this._peopleRefCollection.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Count")]
	public void HasItemsWithCount()
	{
		var result = this._peopleRefCollection.HasItems(5);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Predicate")]
	public void HasItemsWithPredicate()
	{
		var result = this._peopleRefCollection.HasItems(p => p.Address1.IsNotEmpty());

		this.Consume(result);
	}

	/// <summary>
	/// Setups this instance.
	/// </summary>
	public override void Setup()
	{
		base.Setup();

		this._peopleRefCollection = this.GetPersonProperRefArray().ToCollection();
		this._peopleRefList = this.GetPersonProperRefList();
	}
}
