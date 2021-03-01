// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="ListExtensionsCollectionBenchmark.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(ListExtensions))]
	public class ListExtensionsCollectionBenchmark : CollectionBenchmark
	{
		[Benchmark(Description = nameof(ListExtensions.AddLast))]
		public void AddLastToList()
		{
			var people = base.PersonProperCollection.CopyToList();

			var result = people.AddLast(this.PersonProper);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.AreEqual))]
		public void AreEqualList()
		{
			var result = base.PersonProperCollection.AreEqual(base.PersonProperListHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ClearNulls))]
		public void ClearNulls()
		{
			var people = base.PersonProperCollection;
			people.AddLast(null);

			var result = people.ClearNulls();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.CopyToList))]
		public void CopyToList()
		{
			var result = base.PersonProperCollection.CopyToList();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.IndexOf))]
		public void IndexOf()
		{
			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.IndexOf) + ":Comparer")]
		public void IndexOfComparer()
		{
			var comparer = new PersonProperComparer();
			var result = base.PersonProperCollection.IndexOf(base.PersonProperCollection.Last(), comparer);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ListHashCode))]
		public void ListHashCodeList()
		{
			var result = base.PersonProperCollection.ListHashCode();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ListHashCode) + ":Read Only")]
		public void ListHashCodeReadOnlyList()
		{
			var result = base.PersonProperCollection.ToReadOnlyCollection().ListHashCode();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.OrderBy))]
		public void OrderBy()
		{
			var result = base.PersonProperCollection.OrderBy(p => p.City);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.OrderByOrdinal))]
		public void OrderByOrdinal()
		{
			var result = base.PersonProperCollection.OrderByOrdinal(p => p.City);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.Page))]
		public void Page()
		{
			foreach (var people in base.PersonProperCollection.Page(2))
			{
				foreach (var person in people)
				{
					base.Consumer.Consume(person);
				}
			}
		}

		[Benchmark(Description = nameof(ListExtensions.PickRandom))]
		public void PickRandom()
		{
			var result = base.PersonProperCollection.Take(base.Count / 2);

			base.Consumer.Consume(result);
		}


		public override void Setup() { base.Setup(); }


		[Benchmark(Description = nameof(ListExtensions.Shuffle))]
		public void Shuffle()
		{
			var result = base.PersonProperCollection.Shuffle();
			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.Shuffle) + ": With Count")]
		public void ShuffleWithCount()
		{
			var result = base.PersonProperCollection.Shuffle(base.Count / 2);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToObservableCollection))]
		public void ToObservableCollection()
		{
			var result = base.PersonProperCollection.ToObservableCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToReadOnlyCollection))]
		public void ToReadOnlyCollection()
		{
			var result = base.PersonProperCollection.ToReadOnlyCollection();

			base.Consumer.Consume(result);
		}
	}

	public class PersonProperComparer : IEqualityComparer<PersonProper>
	{

		public bool Equals([AllowNull] PersonProper x, [AllowNull] PersonProper y)
		{
			return x.Id == y.Id;
		}

		public int GetHashCode([DisallowNull] PersonProper obj)
		{
			return obj.Id.GetHashCode();
		}

	}
}
