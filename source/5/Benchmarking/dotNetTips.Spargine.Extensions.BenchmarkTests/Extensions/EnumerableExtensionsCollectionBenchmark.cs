// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-15-2021
// ***********************************************************************
// <copyright file="EnumerableExtensionsCollectionBenchmark.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// EnumerableExtensions PerfTestRunner.
	/// Implements the <see cref="CollectionBenchmark" />
	/// </summary>
	/// <seealso cref="CollectionBenchmark" />
	[BenchmarkCategory(Categories.Collections)]
	public class EnumerableExtensionsCollectionBenchmark : CollectionBenchmark
	{

		private bool AnyWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
		{
			return list.Any(predicate);
		}

		private int CountWithPredicate<T>([NotNull] IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
		{
			return list.Count(predicate);
		}

		[Benchmark(Description = "Any: With Predicate")]
		[BenchmarkCategory(Categories.LINQ)]
		public void Any01()
		{
			var result = this.AnyWithPredicate(base.PersonProperList, p => p.City.Contains("A", StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastAny) + ": With Predicate")]
		public void Any02()
		{
			var result = base.PersonProperList.FastAny(p => p.City.Contains("A", StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}
		[Benchmark(Description = nameof(EnumerableExtensions.Count) + ": With Predicate")]
		public void Count01()
		{
			var result = this.CountWithPredicate(base.PersonProperList, p => p.City.Contains("A", StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastCount) + ": With Predicate")]
		public void Count02()
		{
			var result = base.PersonProperList.FastCount(p => p.City.Contains("A", StringComparison.CurrentCulture));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
		public void FirstOrDefaultAlternate01()
		{
			var result = base.PersonProperList.FirstOrDefault(alternate: this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
		public void FirstOrDefaultAlternate02()
		{
			var result = this.PersonProperList.FirstOrDefault(p => p.Id == this.PersonProper01.Id, this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
		public void FirstOrNull01()
		{
			var result = base.CoordinateProperArray.FirstOrNull(p => p.X == this.Coordinate01.X);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems))]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems01()
		{
			var result = base.PersonProperList.AsEnumerable().HasItems();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.HasItems) + ": With Count")]
		[BenchmarkCategory(Categories.Collections)]
		public void HasItems02()
		{
			var result = base.PersonProperList.AsEnumerable().HasItems(5);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = "Process Collection: for()")]
		[BenchmarkCategory(Categories.New)]
		public void Processor01()
		{
			var result = base.PersonProperList;

			for (var count = 0; count < result.Count; count++)
			{
				result[count].Address2 = "TEST DATA";
			}

			base.Consumer.Consume(result);
		}

		//[Benchmark(Description = "Process Collection: FastProcessor")]
		//[BenchmarkCategory(Categories.New)]
		//public void Processor02()
		//{
		//	var result = base.PersonProperList.ToArray();

		//	Action<PersonProper> action = (PersonProper person) => person.Address2 = "TEST DATA";

		//	result.FastProcessor(action);

		//	base.Consumer.Consume(result);
		//}

		//[Benchmark(Description = "FastParallelProcessor(): MaxDegree=Default")]
		//[BenchmarkCategory(Categories.Collections, Categories.New)]
		//public void Processor03()
		//{
		//	var collection = PersonProperList.AsEnumerable();

		//	_ = collection.FastParallelProcessor((PersonProper person) =>
		//	{
		//		person.Address2 = "TEST DATA";

		//	});

		//	Consumer.Consume(collection.Count());
		//}

		//[Benchmark(Description = "FastParallelProcessor(): MaxDegree=App.MaxDegreeOfParallelism()")]
		//[BenchmarkCategory(Categories.Collections, Categories.New)]
		//public void Processor04()
		//{
		//	var collection = PersonProperList.AsEnumerable();

		//	_ = collection.FastParallelProcessor((PersonProper person) =>
		//	{
		//		person.Address2 = "TEST DATA";

		//	}, dotNetTips.Spargine.Core.App.MaxDegreeOfParallelism());

		//	Consumer.Consume(collection.Count());
		//}
		//[Benchmark(Description = "FastParallelProcessor():Ensure Ordered & MaxDegree=App.MaxDegreeOfParallelism()")]
		//[BenchmarkCategory(Categories.Collections, Categories.New)]
		//public void Processor05()
		//{
		//	var collection = PersonProperList.AsEnumerable();

		//	_ = collection.FastParallelProcessor((PersonProper person) =>
		//	{
		//		person.Address2 = "TEST DATA";

		//	}, dotNetTips.Spargine.Core.App.MaxDegreeOfParallelism(), true);

		//	Consumer.Consume(collection.Count());
		//}


		public override void Setup() { base.Setup(); }

		[Benchmark(Description = nameof(EnumerableExtensions.StartsWith))]
		public void StartsWith01()
		{
			var result = base.PersonProperArrayFull.StartsWith(base.PersonProperArrayHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.StructuralSequenceEqual))]
		public void StructuralSequenceEqual01()
		{
			var result = base.PersonProperArrayFull.StructuralSequenceEqual(base.PersonProperArrayHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToBlockingCollection))]
		public void ToBlockingCollection01()
		{
			var result = base.PersonRecordArray.ToBlockingCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
		public void ToDelimitedString01()
		{
			var result = base.PersonProperList.ToDelimitedString(',');

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDictionary))]
		public void ToDictionary01()
		{
			var result = base.PersonProperList.ToDictionary(p => p.Email);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": Dictionary")]
		public void ToImmutableDictionary01()
		{
			var result = base.PersonProperDictionary.ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToImmutable) + ": List")]
		public void ToImmutableList01()
		{
			var result = base.PersonProperList.ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
		public void ToLinkedList01()
		{
			var result = base.PersonProperList.ToLinkedList();

			base.Consumer.Consume(result);
		}
	}
}
