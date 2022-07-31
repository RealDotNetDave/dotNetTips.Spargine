// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="CollectionExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
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

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class CollectionExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{

		private Collection<PersonProper> _peopleCollection;
		private IEnumerable<PersonProper> _peopleToAdd;

		[Benchmark(Description = nameof(CollectionExtensions.AddRange))]
		public void AddRange01()
		{
			var people = base.GetPersonProperArray().ToCollection();

			_ = people.AddRange(this._peopleToAdd, Tristate.True);

			base.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems))]
		public void HasItems()
		{
			var result = this._peopleCollection.HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Count")]
		public void HasItemsWithCount()
		{
			var result = _peopleCollection.HasItems(5);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(CollectionExtensions.HasItems) + ": With Predicate")]
		public void HasItemsWithPredicate()
		{
			var result = this._peopleCollection.HasItems(p => p.Age.TotalDays > 5);

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			this._peopleCollection = base.GetPersonProperArray().ToCollection();
			this._peopleToAdd = base.GetPersonProperArray(collectionSize: CollectionSize.Half).Take(this.Count / 2);
		}

	}
}
