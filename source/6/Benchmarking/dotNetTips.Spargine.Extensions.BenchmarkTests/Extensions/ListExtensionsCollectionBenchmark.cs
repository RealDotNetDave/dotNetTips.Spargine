// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
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
using DotNetTips.Spargine.Tester;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

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

			base.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(ListExtensions.AreEqual))]
		public void AreEqualList()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToList().AreEqual(base.GetPersonProperArray(Tristate.False, CollectionSize.Half));

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

		[Benchmark(Description = nameof(ListExtensions.IndexAtLooped))]
		public void IndexAtLooped()
		{
			var result = base.GetPersonProperArray(Tristate.False).ToList().IndexAtLooped(this.Count / 2);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.HasItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems()
		{
			var people = base.GetPersonProperArray().ToList();

			base.Consumer.Consume(people.HasItems());
		}

		[Benchmark(Description = nameof(ListExtensions.DoesNotHaveItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void DoesNotHaveItemsTest()
		{
			var people = base.GetPersonProperArray().ToList();

			base.Consumer.Consume(people.DoesNotHaveItems());
		}

		[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Count")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItemsWithCount()
		{
			var people = base.GetPersonProperArray(Tristate.False).ToList();

			base.Consumer.Consume(people.HasItems(5));
		}

		[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Predicate")]
		public void ListHasItemsWithPredicate()
		{
			var people = base.GetPersonProperArray(Tristate.False).ToList();

			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
		}

		[Benchmark(Description = nameof(Enumerable.TryGetNonEnumeratedCount))]
		[BenchmarkCategory(Categories.Collections, Categories.New)]
		public void ListTryGetNonEnumeratedCount()
		{
			var people = base.GetPersonProperArray(Tristate.False).ToList();

			_ = Enumerable.TryGetNonEnumeratedCount(people, out var count);

			base.Consumer.Consume(count);
		}

		[Benchmark(Description = "Slice Test")]
		[BenchmarkCategory(Categories.Collections)]
		public void PickRandom02()
		{
			var people = new ArraySegment<PersonProper>(base.GetPersonProperArray(Tristate.False, CollectionSize.Half));

			var result = people.Slice(RandomData.GenerateInteger(0, people.Count - 1));

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();
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
