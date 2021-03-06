﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2021
// ***********************************************************************
// <copyright file="EnumerableExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	/// <summary>
	/// EnumerableExtensions PerfTestRunner.
	/// Implements the <see cref="dotNetTips.Spargine.Benchmarking.CollectionBenchmark" />
	/// </summary>
	/// <seealso cref="dotNetTips.Spargine.Benchmarking.CollectionBenchmark" />
	[BenchmarkCategory(nameof(EnumerableExtensions))]
	public class EnumerableExtensionsCollectionBenchmark : CollectionBenchmark
	{
		[Benchmark(Description = nameof(EnumerableExtensions.Count))]
		public void Count01()
		{
			var result = base.PersonProperCollection.Count();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastAny))]
		public void FastAny01()
		{
			var result = base.PersonProperCollection.FastAny(p => p.City.Contains("SAN"));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FastCount))]
		public void FastCount01()
		{
			var result = base.PersonProperCollection.FastCount(p => p.City.Contains("SAN"));

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Alternate")]
		public void FirstOrDefaultAlternate01()
		{
			var result = base.PersonProperCollection.FirstOrDefault(alternate: this.PersonProper);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrDefault) + ": Predicate, Alternate")]
		public void FirstOrDefaultAlternate02()
		{
			var result = this.PersonProperCollection.FirstOrDefault(p => p.Id == this.PersonProper.Id, this.PersonProper);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.FirstOrNull))]
		public void FirstOrNull01()
		{
			var result = base.CoordinateProperArray.FirstOrNull(p => p.X == this.Coordinate.X);

			base.Consumer.Consume(result);
		}

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

		[Benchmark(Description = nameof(EnumerableExtensions.ToDelimitedString))]
		public void ToDelimitedString01()
		{
			var result = base.PersonProperCollection.ToDelimitedString(',');

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToDictionary))]
		public void ToDictionary01()
		{
			var result = base.PersonProperCollection.ToDictionary(p => p.Email);

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
			var result = base.PersonProperCollection.ToImmutable();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(EnumerableExtensions.ToLinkedList))]
		public void ToLinkedList01()
		{
			var result = base.PersonProperCollection.ToLinkedList();

			base.Consumer.Consume(result);
		}
	}
}
