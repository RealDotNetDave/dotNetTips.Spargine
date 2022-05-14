// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2022
// ***********************************************************************
// <copyright file="ArrayExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public class ArrayExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{
		[Benchmark(Description = nameof(ArrayExtensions.AddFirst))]
		public void AddFirst01()
		{
			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();

			var result = people.ToArray().AddFirst(this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": Params")]
		public void AddIfNotExists01()
		{
			var people = new List<PersonProper>(base.GetPersonProperArray());

			var result = people.AddIfNotExists(this.GetPeopleToInsert());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": Params with dups")]
		public void AddIfNotExists02()
		{
			var people = new List<PersonProper>(base.GetPersonProperArray());

			var result = people.AddIfNotExists(this.GetPeopleToInsert());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddLast))]
		public void AddLast01()
		{
			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);

			var result = people.AddLast(this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AreEqual))]
		public void AreEqual01()
		{
			var people1 = base.GetPersonProperArray(Tristate.False);
			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);

			var result = people1.AreEqual(people2);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.GetHashCode))]
		public void ArrayHashCode01()
		{
			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);

			base.Consumer.Consume(result.GetHashCode());
		}

		//TODO:FIGURE OUT WHY THIS DOES NOT WORK
		//[Benchmark(Description = "As<>()")]
		//public void As01()
		//{
		//	var people1 = base.GetPersonRefArrayFull().Clone<PersonProper>();

		//	var result = people1.As<List<IPerson>>();

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(ArrayExtensions.BytesToString))]
		[BenchmarkCategory(Categories.Strings)]
		public void BytesToString01()
		{
			var result = base.GetByteArray(1).BytesToString();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.BytesToString) + " ReadOnlySpan<>")]
		[BenchmarkCategory(Categories.Strings)]
		public void BytesToString02()
		{
			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
			var result = readOnlySpan.BytesToString();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-PersonProper")]
		public void Clone01()
		{
			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-PersonRecord")]
		public void Clone02()
		{
			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-CoordinateProper")]
		public void Clone03()
		{
			var result = base.GetCoordinateArray().Clone<Coordinate[]>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ContainsAny))]
		public void ContainsAny01()
		{
			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));

			base.Consumer.Consume(result);
		}
	}
}
