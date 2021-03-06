﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-20-2021
// ***********************************************************************
// <copyright file="ArrayExtensionsCollectionPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(ArrayExtensions))]
	public class ArrayExtensionsCollectionBenchmark : CollectionBenchmark
	{

		[Benchmark(Description = nameof(ArrayExtensions.AddFirst))]
		public void AddFirst01()
		{
			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();

			var result = people.ToArray().AddFirst(this.PersonProper);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": Params")]
		public void AddIfNotExists01()
		{
			var people = new List<PersonProper>(base.PersonProperCollection);

			var result = people.AddIfNotExists(this.PeopleToInsert);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": Params with dups")]
		public void AddIfNotExists02()
		{
			var people = new List<PersonProper>(base.PersonProperCollection);

			var result = people.AddIfNotExists(this.PeopleToInsert);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddLast))]
		public void AddLast01()
		{
			var people = base.PersonProperArrayFull.Clone<PersonProper>();

			var result = people.AddLast(this.PersonProper);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AreEqual))]
		public void AreEqual01()
		{
			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();

			var result = people1.AreEqual(people2);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ArrayHashCode))]
		public void ArrayHashCode01()
		{
			var result = base.PersonProperArrayFull.Clone<PersonProper>();

			base.Consumer.Consume(result.ArrayHashCode());
		}

		//[Benchmark(Description = "As")]
		//public void As01()
		//{
		//	var people1 = base.PersonProperArrayFull.Clone<PersonProper>();

		//	var result = people1.As<List<Person>>();

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(ArrayExtensions.BytesToString))]
		public void BytesToString()
		{
			var result = base.ByteArray.BytesToString();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-PersonProper")]
		public void Clone01()
		{
			var result = base.PersonProperArrayFull.Clone();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-PersonRecord")]
		public void Clone02()
		{
			var result = base.PersonRecordArray.Clone();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-CoordinateProper")]
		public void Clone03()
		{
			var result = base.CoordinateProperArray.Clone();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ContainsAny))]
		public void ContainsAny01()
		{
			var result = base.PersonProperArrayFull.ContainsAny(this.PeopleToInsert);

			base.Consumer.Consume(result);
		}

		//[Benchmark(Description = nameof(ArrayExtensions.RemoveDuplicates))]
		//public void RemoveDuplicates01()
		//{

		//}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst))]
		public void RemoveFirst()
		{
			var people = base.PersonProperArrayFull.Clone<PersonProper>();

			var result = people.RemoveFirst();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveLast))]
		public void RemoveLast()
		{
			var people = base.PersonProperArrayFull.Clone<PersonProper>();

			var result = people.RemoveLast();

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }
	}
}
