// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2022
// ***********************************************************************
// <copyright file="ArrayExtensionsCollectionBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;
using DotNetTips.Spargine.Tester.Models.ValueTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(Categories.Collections)]
	public partial class ArrayExtensionsCollectionBenchmark : LargeCollectionsBenchmark
	{

		[Benchmark(Description = nameof(ArrayExtensions.AddFirst))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void AddFirstRef()
		{
			PersonProper[] people = this.GetPersonProperRefArray();

			PersonProper[] result = people.AddFirst(this.PersonProperRef01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddFirst))]
		[BenchmarkCategory(Categories.ValueType)]
		public void AddFirstVal()
		{
			var people = this.GetPersonValArray();

			var result = people.AddFirst(this.PersonVal01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": Params")]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void AddIfNotExistsRef()
		{
			PersonProper[] people = GetPersonProperRefArray();

			PersonProper[] result = people.AddIfNotExists(this.GetPeopleRefToInsert());

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": Params")]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void AddIfNotExistsVal()
		{
			var people = GetPersonValArray();

			var result = people.AddIfNotExists(this.GetPeopleValToInsert());

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddLast))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void AddLastRef()
		{
			PersonProper[] people = GetPersonProperRefArray();

			PersonProper[] result = people.AddLast(this.PersonProperRef01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddLast))]
		[BenchmarkCategory(Categories.ValueType)]
		public void AddLastVal()
		{
			var people = GetPersonValArray();

			var result = people.AddLast(this.PersonVal01);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AreEqual))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void AreEqualRef()
		{
			var people1 = GetPersonProperRefArray();
			var people2 = people1.Take(this.Count / 2).ToArray();

			var result = people1.AreEqual(people2);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AreEqual))]
		[BenchmarkCategory(Categories.ValueType)]
		public void AreEqualVal()
		{
			var people1 = GetPersonValArray();
			var people2 = people1.Take(this.Count / 2).ToArray();

			var result = people1.AreEqual(people2);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.GetHashCode))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void ArrayHashCode01()
		{
			PersonProper[] result = GetPersonProperRefArray(collectionSize: CollectionSize.Half);

			Consumer.Consume(result.GetHashCode());
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
		public void BytesToString()
		{
			var result = GetByteArray(1).BytesToString();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.BytesToString) + " ReadOnlySpan<>")]
		[BenchmarkCategory(Categories.Strings)]
		public void BytesToStringReadOnlySpan()
		{
			var readOnlySpan = new ReadOnlySpan<byte>(GetByteArray(1));
			var result = readOnlySpan.BytesToString();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-CoordinateProper")]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void CloneCoordinateProperRef()
		{
			CoordinateProper[] result = GetCoordinateProperRefArray().Clone<CoordinateProper[]>();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-Coordinate")]
		[BenchmarkCategory(Categories.ValueType)]
		public void CloneCoordinateRef()
		{
			Coordinate[] result = GetCoordinateValArray().Clone<Coordinate[]>();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-PersonRecord")]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void ClonePersonRecordRef()
		{
			PersonRecord[] result = GetPersonRecordArray().Clone<PersonRecord[]>();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-PersonProper")]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void ClonePersonRef()
		{
			PersonProper[] result = GetPersonProperRefArray().Clone<PersonProper[]>();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array-Person")]
		[BenchmarkCategory(Categories.ValueType)]
		public void ClonePersonVal()
		{
			Spargine.Tester.Models.ValueTypes.Person[] result = GetPersonValArray().Clone<Spargine.Tester.Models.ValueTypes.Person[]>();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ContainsAny))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void ContainsAnyRef()
		{
			var result = GetPersonProperRefArray().ContainsAny(GetPersonProperRefArray(collectionSize: CollectionSize.Half));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ContainsAny))]
		[BenchmarkCategory(Categories.ValueType)]
		public void ContainsAnyVal()
		{
			var result = GetPersonValArray().ContainsAny(GetPersonValArray(collectionSize: CollectionSize.Half));

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void DoesNotHaveItemsRef()
		{
			var result = GetPersonProperRefArray().DoesNotHaveItems();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems))]
		[BenchmarkCategory(Categories.ValueType)]
		public void DoesNotHaveItemsVal()
		{
			var result = GetPersonValArray().DoesNotHaveItems();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.HasItems))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void HasItemsRef()
		{
			var result = GetPersonProperRefArray().HasItems();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.HasItems))]
		[BenchmarkCategory(Categories.ValueType)]
		public void HasItemsVal()
		{
			var result = GetPersonValArray().HasItems();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.HasItems) + "With Count")]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void HasItemsWithCountRef()
		{
			var result = GetPersonProperRefArray().HasItems(this.Count);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.HasItems) + "With Count")]
		[BenchmarkCategory(Categories.ValueType)]
		public void HasItemsWithCountVal()
		{
			var result = GetPersonValArray().HasItems(this.Count);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.HasItems) + "With Predicate")]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void HasItemsWithPredicateRef()
		{
			var result = GetPersonProperRefArray().HasItems(p => p.Age.TotalDays > 5);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.HasItems) + "With Predicate")]
		[BenchmarkCategory(Categories.ValueType)]
		public void HasItemsWithPredicateVal()
		{
			var result = GetPersonValArray().HasItems(p => p.Age.TotalDays > 5);

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void RemoveFirstRef()
		{
			PersonProper[] people = this.GetPersonProperRefArray();

			PersonProper[] result = people.RemoveFirst();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst))]
		[BenchmarkCategory(Categories.ValueType)]
		public void RemoveFirstVal()
		{
			var people = this.GetPersonValArray();

			var result = people.RemoveFirst();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveLast))]
		[BenchmarkCategory(Categories.ReferenceType)]
		public void RemoveLastRef()
		{
			PersonProper[] people = this.GetPersonProperRefArray();

			PersonProper[] result = people.RemoveLast();

			Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveLast))]
		[BenchmarkCategory(Categories.ValueType)]
		public void RemoveLastVal()
		{
			var people = this.GetPersonValArray();

			var result = people.RemoveLast();

			Consumer.Consume(result);
		}

	}
}
