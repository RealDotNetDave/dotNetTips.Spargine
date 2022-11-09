// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-06-2022
// ***********************************************************************
// <copyright file="ArrayExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
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

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class ArrayExtensionsCollectionBenchmark.
/// Implements the <see cref="DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark" />
/// </summary>
/// <seealso cref="DotNetTips.Spargine.Benchmarking.LargeCollectionsBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class ArrayExtensionsCollectionBenchmark : LargeCollectionsBenchmark
{

	[Benchmark(Description = nameof(ArrayExtensions.Add))]
	[BenchmarkCategory(Categories.ValueType)]
	public void Add()
	{
		var people = this.GetPersonValArray();

		var result = people.Add(this.PersonVal01);

		this.Consume(result);
	}
	[Benchmark(Description = nameof(ArrayExtensions.AddFirst) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void AddFirstRef()
	{
		var people = this.GetPersonProperRefArray();

		var result = people.AddFirst(this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddFirst) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void AddFirstVal()
	{
		var people = this.GetPersonValArray();

		var result = people.AddFirst(this.PersonVal01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddIf))]
	[BenchmarkCategory(Categories.ValueType)]
	public void AddIf()
	{
		var people = this.GetPersonValArray();

		var result = people.AddIf(this.PersonVal01, people.Count() > 10);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": as Reference + Params")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void AddIfNotExistsRef()
	{
		var people = GetPersonProperRefArray();

		var result = people.AddIfNotExists(this.GetPeopleRefToInsert());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ": as Value + Params")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void AddIfNotExistsVal()
	{
		var people = GetPersonValArray();

		var result = people.AddIfNotExists(this.GetPeopleValToInsert());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddLast) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void AddLastRef()
	{
		var people = GetPersonProperRefArray();

		var result = people.AddLast(this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AddLast) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void AddLastVal()
	{
		var people = base.GetPersonValArray();

		var result = people.AddLast(this.PersonVal01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void AreEqualRef()
	{
		var people1 = GetPersonProperRefArray();
		var people2 = people1.Take(this.Count / 2).ToArray();

		var result = people1.AreEqual(people2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void AreEqualVal()
	{
		var people1 = GetPersonValArray();
		var people2 = people1.Take(this.Count / 2).ToArray();

		var result = people1.AreEqual(people2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.GetHashCode))]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ArrayHashCode01()
	{
		var result = GetPersonProperRefArray(collectionSize: CollectionSize.Half);

		this.Consume(result.GetHashCode());
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

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.BytesToString) + ": ReadOnlySpan<>")]
	[BenchmarkCategory(Categories.Strings)]
	public void BytesToStringReadOnlySpan()
	{
		var readOnlySpan = new ReadOnlySpan<byte>(GetByteArray(1));
		var result = readOnlySpan.BytesToString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array:CoordinateProper as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void CloneCoordinateProperRef()
	{
		var result = GetCoordinateProperValArray().Clone<CoordinateProper[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array:Coordinate as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void CloneCoordinateVal()
	{
		var result = GetCoordinateValArray().Clone<Coordinate[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array:PersonRecord as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ClonePersonRecordRef()
	{
		var result = GetPersonRecordArray().Clone<PersonRecord[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array:PersonProper as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ClonePersonRef()
	{
		var result = GetPersonProperRefArray().Clone<PersonProper[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array:Person as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void ClonePersonVal()
	{
		var result = GetPersonValArray().Clone<Spargine.Tester.Models.ValueTypes.Person[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ContainsAny) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ContainsAnyRef()
	{
		var result = GetPersonProperRefArray().ContainsAny(GetPersonProperRefArray(collectionSize: CollectionSize.Half));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ContainsAny) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void ContainsAnyVal()
	{
		var result = GetPersonValArray().ContainsAny(GetPersonValArray(collectionSize: CollectionSize.Half));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void DoesNotHaveItemsRef()
	{
		var result = GetPersonProperRefArray().DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void DoesNotHaveItemsVal()
	{
		var result = GetPersonValArray().DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastProcessor))]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void FastProcessor()
	{
		var people = GetPersonProperRefArray();

		people.FastProcessor(
			(PersonProper person) =>
			{
				person.Address2 = "Address #2";
			});

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ArrayExtensions.GenerateHashCode))]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void GenerateHashCode()
	{
		var people = GetPersonProperRefArray();
		var result = people.GenerateHashCode();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void HasItemsRef()
	{
		var people = GetPersonProperRefArray();
		var result = people.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void HasItemsVal()
	{
		var people = GetPersonValArray();
		var result = people.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Count as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void HasItemsWithCountRef()
	{
		var people = GetPersonProperRefArray();
		var result = people.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Count as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void HasItemsWithCountVal()
	{
		var people = GetPersonValArray();
		var result = people.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Predicate as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void HasItemsWithPredicateRef()
	{
		var people = GetPersonProperRefArray();
		var result = people.HasItems(p => p.Age.TotalDays > 500);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Predicate as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void HasItemsWithPredicateVal()
	{
		var people = GetPersonValArray();
		var result = people.HasItems(p => p.Age.TotalDays > 500);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void RemoveFirstRef()
	{
		var people = this.GetPersonProperRefArray();

		var result = people.RemoveFirst();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void RemoveFirstVal()
	{
		var people = this.GetPersonValArray();

		var result = people.RemoveFirst();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveLast) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void RemoveLastRef()
	{
		var people = this.GetPersonProperRefArray();

		var result = people.RemoveLast();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.RemoveLast) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void RemoveLastVal()
	{
		var people = this.GetPersonValArray();

		var result = people.RemoveLast();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ToDistinct))]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ToDistinct()
	{
		var result = GetPersonProperRefArray().ToDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert))]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void Upsert()
	{
		var people = GetPersonProperRefArray();

		var result = people.Upsert(this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + ": Record")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void UpsertRecord()
	{
		var people = GetPersonRecordArray();

		var result = people.Upsert(this.PersonRecord01);

		this.Consume(result);
	}

}
