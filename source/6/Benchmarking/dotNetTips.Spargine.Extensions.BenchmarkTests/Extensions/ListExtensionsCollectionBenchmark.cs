// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2022
// ***********************************************************************
// <copyright file="ListExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class ListExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{
		[Benchmark(Description = nameof(ListExtensions.AddLast))]
		public void AddLastToList()
		{
			var people = base.GetPersonProperArray().ToList();

			people.AddLast(this.PersonProper01);

			this.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(ListExtensions.AreEqual))]
		public void AreEqualList()
		{
			var result = base.GetPersonProperArray(Core.Tristate.False).AreEqual(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ClearNulls))]
		public void ClearNulls()
		{
			var people = base.GetPersonProperArray().ToList();
			people.Add(null);

			var result = people.ClearNulls();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.CopyToCollection))]
		public void CopyToList()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToList().CopyToCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.HasItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems01()
		{
			var people = base.GetPersonProperArray().ToList();

			this.Consumer.Consume(people.HasItems());
		}

		[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Predicate")]
		public void HasItems02()
		{
			var people = base.GetPersonProperArray(Tristate.False).ToList();

			this.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
		}

		[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Count")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems03()
		{
			var people = base.GetPersonProperArray(Tristate.False).ToList();

			this.Consumer.Consume(people.HasItems(5));
		}

		[Benchmark(Description = nameof(EnumerableExtensions.IndexOf))]
		public void IndexOf()
		{
			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray().Last());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.IndexOf) + ":Comparer")]
		public void IndexOfComparer()
		{
			var comparer = new PersonProperComparer();
			var result = base.GetPersonProperArray(Tristate.False).IndexOf(base.GetPersonProperArray(Tristate.False, CollectionSize.Half).Last(), comparer);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.GetHashCode))]
		public void ListHashCodeList()
		{
			var result = base.GetPersonProperArray(Tristate.False).GetHashCode();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.GetHashCode) + ":Read Only")]
		public void ListHashCodeReadOnlyList()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection().GetHashCode();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.OrderBy))]
		public void OrderBy()
		{
			var result = base.GetPersonProperArray(Tristate.False).OrderBy(p => p.City);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.OrderByOrdinal))]
		public void OrderByOrdinal()
		{
			var result = base.GetPersonProperArray(Tristate.False).OrderByOrdinal(p => p.City);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.Page))]
		public void Page()
		{
			foreach (var people in base.GetPersonProperArray(Tristate.False).Page(25))
			{
				foreach (var person in people)
				{
					base.Consumer.Consume(person);
				}
			}
		}

		[Benchmark(Description = nameof(EnumerableExtensions.PickRandom))]
		public void PickRandom01()
		{
			var result = base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half).PickRandom();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = "Slice Test")]
		[BenchmarkCategory(Categories.Collections)]
		public void PickRandom02()
		{
			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Core.Tristate.False, CollectionSize.Half));

			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();
		}


		[Benchmark(Description = nameof(ListExtensions.Shuffle))]
		public void Shuffle()
		{
			var result = base.GetPersonProperArray(Tristate.False).Shuffle();
			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.Shuffle) + ": With Count")]
		public void ShuffleWithCount()
		{
			var result = base.GetPersonProperArray(Tristate.False).Shuffle(Count / 2);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToObservableCollection))]
		public void ToObservableCollection()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToObservableCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToReadOnlyCollection))]
		public void ToReadOnlyCollection()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToReadOnlyCollection();

			base.Consumer.Consume(result);
		}
	}

	/// <summary>
	/// Class PersonProperComparer.
	/// Implements the <see cref="IEqualityComparer{PersonProper}" />
	/// </summary>
	/// <seealso cref="IEqualityComparer{PersonProper}" />
	public class PersonProperComparer : IEqualityComparer<PersonProper>
	{

		/// <summary>
		/// Determines whether the specified objects are equal.
		/// </summary>
		/// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
		/// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
		/// <returns><see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
		public bool Equals([AllowNull] PersonProper x, [AllowNull] PersonProper y)
		{
			return x.Id == y.Id;
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <param name="obj">The <see cref="System.Object" /> for which a hash code is to be returned.</param>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
		public int GetHashCode([DisallowNull] PersonProper obj)
		{
			return obj.ArgumentNotNull().Id.GetHashCode(StringComparison.Ordinal);
		}
	}
}
