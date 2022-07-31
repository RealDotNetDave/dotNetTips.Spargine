// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-28-2022
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
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class ListExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{

		private List<PersonProper> _peopleList;

		[Benchmark(Description = nameof(ListExtensions.AddLast))]
		public void AddLastToList()
		{
			var people = this._peopleList;

			people.AddLast(this.PersonProper01);

			base.Consumer.Consume(people);
		}

		[Benchmark(Description = nameof(ListExtensions.AreEqual))]
		public void AreEqualList()
		{
			var result = this._peopleList.AreEqual(_peopleListSubSet);

			base.Consumer.Consume(result);
		}

		private List<PersonProper> _peopleListSubSet;

		[Benchmark(Description = nameof(ListExtensions.ClearNulls))]
		public void ClearNulls()
		{
			var people = _peopleList;
			people.Add(null);

			var result = people.ClearNulls();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.CopyToCollection))]
		public void CopyToList()
		{
			System.Collections.ObjectModel.Collection<PersonProper> result = this._peopleList.CopyToCollection();

			base.Consumer.Consume(result);
		}

		//[Benchmark(Description = nameof(ListExtensions.DoesNotHaveItems))]
		//[BenchmarkCategory(Categories.Collections)]
		//public void DoesNotHaveItemsTest()
		//{
		//	var people = _peopleList;

		//	base.Consumer.Consume(people.DoesNotHaveItems());
		//}

		//[Benchmark(Description = nameof(ListExtensions.HasItems))]
		//[BenchmarkCategory(Categories.Collections)]
		//public void HasItems()
		//{
		//	List<PersonProper> people = this._peopleList;

		//	base.Consumer.Consume(people.HasItems());
		//}

		//[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Count")]
		//[BenchmarkCategory(Categories.Collections)]
		//public void HasItemsWithCount()
		//{
		//	List<PersonProper> people = this._peopleList;

		//	base.Consumer.Consume(people.HasItems(5));
		//}

		[Benchmark(Description = nameof(ListExtensions.IndexAtLooped))]
		public void IndexAtLooped()
		{
			PersonProper result = this._peopleList.IndexAtLooped(RandomNumberGenerator.GetInt32(0, this.Count - 1));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = "Index [] (for comparison)")]
		public void IndexAtLooppedCompare()
		{

			PersonProper result = this._peopleList[RandomNumberGenerator.GetInt32(0, this.Count - 1)];

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.HasItems) + ": With Predicate")]
		public void ListHasItemsWithPredicate()
		{
			List<PersonProper> people = this._peopleList;

			base.Consumer.Consume(people.HasItems(p => p.Age.TotalDays > 1000));
		}

		[Benchmark(Description = nameof(Enumerable.TryGetNonEnumeratedCount))]
		[BenchmarkCategory(Categories.Collections, Categories.New)]
		public void ListTryGetNonEnumeratedCount()
		{
			List<PersonProper> people = this._peopleList;

			_ = Enumerable.TryGetNonEnumeratedCount(people, out var count);

			base.Consumer.Consume(count);
		}

		[Benchmark(Description = "Count (for comparison)")]
		[BenchmarkCategory(Categories.Collections, Categories.New)]
		public void ListTryGetNonEnumeratedCountCompare()
		{
			List<PersonProper> people = this._peopleList;

			base.Consumer.Consume(people.Count);
		}

		public override void Setup()
		{
			base.Setup();

			this._peopleList = base.GetPersonProperArray().ToList();
			this._peopleListSubSet = this._peopleList.TakeLast(10).Clone<IEnumerable<PersonProper>>().ToList();
		}

		[Benchmark(Description = nameof(ListExtensions.ToObservableCollection))]
		public void ToObservableCollection()
		{
			var result = this._peopleList.ToObservableCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToReadOnlyCollection))]
		public void ToReadOnlyCollection()
		{
			var result = this._peopleList.ToReadOnlyCollection();

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
