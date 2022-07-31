// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="ArrayExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public partial class ArrayExtensionsCollectionBenchmark : LargeCollectionBenchmark
	{
		[Benchmark(Description = nameof(ArrayExtensions.AddFirst))]
		public void AddFirst01()
		{
			PersonProper[] people = this.GetPersonProperArray();

			PersonProper[] result = people.AddFirst(this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst))]
		public void RemoveFirst()
		{
			PersonProper[] people = this.GetPersonProperArray();

			PersonProper[] result = people.RemoveFirst();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveLast))]
		public void RemoveLast()
		{
			PersonProper[] people = this.GetPersonProperArray();

			PersonProper[] result = people.RemoveLast();

			base.Consumer.Consume(result);
		}

		//[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": Params")]
		//public void AddIfNotExists()
		//{
		//	PersonProper[] people = base.GetPersonProperArray();

		//	PersonProper[] result = people.AddIfNotExists(this.GetPeopleToInsert());

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(ArrayExtensions.AddLast))]
		public void AddLast01()
		{
			PersonProper[] people = base.GetPersonProperArray();

			PersonProper[] result = people.AddLast(this.PersonProper01);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AreEqual))]
		public void AreEqual01()
		{
			PersonProper[] people1 = base.GetPersonProperArray();
			PersonProper[] people2 = base.GetPersonProperArray(collectionSize: CollectionSize.Half);

			var result = people1.AreEqual(people2);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.GetHashCode))]
		public void ArrayHashCode01()
		{
			PersonProper[] result = base.GetPersonProperArray(collectionSize: CollectionSize.Half);

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

		//[Benchmark(Description = nameof(ArrayExtensions.BytesToString))]
		//[BenchmarkCategory(Categories.Strings)]
		//public void BytesToString()
		//{
		//	var result = base.GetByteArray(1).BytesToString();

		//	base.Consumer.Consume(result);
		//}

		//[Benchmark(Description = nameof(ArrayExtensions.BytesToString) + " ReadOnlySpan<>")]
		//[BenchmarkCategory(Categories.Strings)]
		//public void BytesToStringReadOnlySpan()
		//{
		//	var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
		//	var result = readOnlySpan.BytesToString();

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-PersonProper")]
		public void ClonePerson()
		{
			PersonProper[] result = base.GetPersonProperArray().Clone<PersonProper[]>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-PersonRecord")]
		public void ClonePersonRecord()
		{
			PersonRecord[] result = base.GetPersonRecordArray().Clone<PersonRecord[]>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-CoordinateProper")]
		public void CloneCoordinate()
		{
			Coordinate[] result = base.GetCoordinateArray().Clone<Coordinate[]>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ContainsAny))]
		public void ContainsAny()
		{
			var result = base.GetPersonProperArray().ContainsAny(base.GetPersonProperArray(collectionSize: CollectionSize.Half));

			base.Consumer.Consume(result);
		}

		//[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems))]
		//public void DoesNotHaveItemsTest()
		//{
		//	var result = base.GetPersonProperArray().DoesNotHaveItems();

		//	base.Consumer.Consume(result);
		//}

		//[Benchmark(Description = nameof(ArrayExtensions.HasItems))]
		//public void HasItems()
		//{
		//	var result = base.GetPersonProperArray().HasItems();

		//	base.Consumer.Consume(result);
		//}

		//[Benchmark(Description = nameof(ArrayExtensions.HasItems) + "With Count")]
		//public void HasItemsWithCountTest()
		//{
		//	var result = base.GetPersonProperArray().HasItems(this.Count);

		//	base.Consumer.Consume(result);
		//}

		//[Benchmark(Description = nameof(ArrayExtensions.HasItems) + "With Predicate")]
		//public void HasItemsWithPredicateTest()
		//{
		//	var result = base.GetPersonProperArray().HasItems(p => p.Age.TotalDays > 5);

		//	base.Consumer.Consume(result);
		//}
	}
}
