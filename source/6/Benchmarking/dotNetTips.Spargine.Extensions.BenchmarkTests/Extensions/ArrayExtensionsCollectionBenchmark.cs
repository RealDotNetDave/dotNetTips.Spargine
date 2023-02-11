// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-31-2023
// ***********************************************************************
// <copyright file="ArrayExtensionsCollectionBenchmark.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Tester.Models.RefTypes;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

/// <summary>
/// Class ArrayExtensionsCollectionBenchmark.
/// Implements the <see cref="LargeCollectionsBenchmark" />
/// </summary>
/// <seealso cref="LargeCollectionsBenchmark" />
[BenchmarkCategory(Categories.Collections)]
public class ArrayExtensionsCollectionBenchmark : SmallCollectionsBenchmark
{
	private PersonRecord[] _personRecordArray;
	private PersonProper[] _personRefArray;
	private Spargine.Tester.Models.ValueTypes.Person[] _personValArray;

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void AreEqual_Ref()
	{
		var people1 = this._personRefArray;
		var people2 = people1.Take(this.Count / 2).ToArray();

		var result = people1.AreEqual(people2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.AreEqual) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void AreEqual_Val()
	{
		var people1 = this._personValArray;
		var people2 = people1.Take(this.Count / 2).ToArray();

		var result = people1.AreEqual(people2);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.GetHashCode))]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ArrayHashCode_Ref()
	{
		var result = this._personRefArray;

		this.Consume(result.GetHashCode());
	}

	//TODO:FIGURE OUT WHY THIS DOES NOT WORK
	[Benchmark(Description = "As<>()")]
	public void As01()
	{
		var people1 = this._personRefArray.Clone<PersonProper>();
		var result = people1.As<List<IPerson>>();
		base.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.BytesToString))]
	[BenchmarkCategory(Categories.Strings)]
	public void BytesToString_Val()
	{
		var result = this.GetByteArray(1).BytesToString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.BytesToString) + ": ReadOnlySpan<>")]
	[BenchmarkCategory(Categories.Strings)]
	public void BytesToStringReadOnlySpan_Val()
	{
		var readOnlySpan = new ReadOnlySpan<byte>(this.GetByteArray(1));
		var result = readOnlySpan.BytesToString();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void ClonePerson_Val()
	{
		var result = this._personValArray.Clone<Spargine.Tester.Models.ValueTypes.Person>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ClonePersonProper_Ref()
	{
		var result = this._personRefArray.Clone<PersonProper[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Clone) + ": Array as Record")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ClonePersonRecord_Record()
	{
		var result = this._personRecordArray.Clone<PersonRecord[]>();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ContainsAny) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ContainsAny_Ref()
	{
		var result = this._personRefArray.ContainsAny(this.GetPersonProperRefArray(collectionSize: CollectionSize.Half));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.ContainsAny) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void ContainsAny_Val()
	{
		var result = this._personValArray.ContainsAny(this.GetPersonValArray(collectionSize: CollectionSize.Half));

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void DoesNotHaveItems_Ref()
	{
		var result = this._personRefArray.DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.DoesNotHaveItems) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void DoesNotHaveItems_Val()
	{
		var result = this._personValArray.DoesNotHaveItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.FastProcessor) + " : Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void FastProcessor_Ref()
	{
		var people = this._personRefArray;

		people.FastProcessor(
			(PersonProper person) =>
			{
				person.Address2 = "Address #2";
			});

		this.Consume(people);
	}

	[Benchmark(Description = nameof(ArrayExtensions.GenerateHashCode) + " : Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void GenerateHashCode_Ref()
	{
		var people = this._personRefArray;
		var result = people.GenerateHashCode();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void HasItems_Ref()
	{
		var people = this._personRefArray;
		var result = people.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void HasItems_Val()
	{
		var people = this._personValArray;
		var result = people.HasItems();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Count as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void HasItemsWithCount_Ref()
	{
		var people = this._personRefArray;
		var result = people.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Count as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void HasItemsWithCount_Val()
	{
		var people = this._personValArray;
		var result = people.HasItems(this.Count);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Predicate as Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void HasItemsWithPredicate_Ref()
	{
		var people = this._personRefArray;
		var result = people.HasItems(p => p.Address1.IsNotEmpty());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.HasItems) + ": With Predicate as Value")]
	[BenchmarkCategory(Categories.ValueType)]
	public void HasItemsWithPredicate_Val()
	{
		var people = this._personValArray;
		var result = people.HasItems(p => p.Address1.IsNotEmpty());

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Record")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void PerformAction_Record()
	{
		var people = this._personRecordArray;
		var sb = new StringBuilder();

		people.PerformAction((person) =>
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{person.PropertiesToString()}|");
		});

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Record (Comparison)")]
	[BenchmarkCategory(Categories.ReferenceType, Categories.ForComparison)]
	public void PerformAction_Record_Comparison()
	{
		var people = this._personRecordArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].PropertiesToString()}|");
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Ref")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void PerformAction_Ref()
	{
		var people = this._personRefArray;
		var sb = new StringBuilder();

		people.PerformAction((person) =>
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{person.ToString()}|");
		});

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Ref (Comparison)")]
	[BenchmarkCategory(Categories.ReferenceType, Categories.ForComparison)]
	public void PerformAction_Ref_Comparison()
	{
		var people = this._personRefArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].ToString()}|");
		}

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Val")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void PerformAction_Val()
	{
		var people = this._personValArray;
		var sb = new StringBuilder();

		people.PerformAction((person) =>
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{person.ToString()}|");
		});

		this.Consume(sb.ToString());
	}

	[Benchmark(Description = nameof(ArrayExtensions.PerformAction) + " :Val (Comparison)")]
	[BenchmarkCategory(Categories.ReferenceType, Categories.ForComparison)]
	public void PerformAction_Val_Comparison()
	{
		var people = this._personValArray;
		var sb = new StringBuilder();

		for (var index = 0; index < people.LongLength; index++)
		{
			_ = sb.Append(CultureInfo.CurrentCulture, $"{people[index].ToString()}|");
		}

		this.Consume(sb.ToString());
	}

	public override void Setup()
	{
		base.Setup();

		this._personRecordArray = this.GetPersonRecordArray();
		this._personRefArray = this.GetPersonProperRefArray();
		this._personValArray = this.GetPersonValArray();
	}

	[Benchmark(Description = nameof(ArrayExtensions.ToDistinct) + " : Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void ToDistinct_Ref()
	{
		var result = this._personRefArray.ToDistinct();

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + " : Reference")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void Upsert_Ref()
	{
		var people = this._personRefArray;

		var result = people.Upsert(this.PersonProperRef01);

		this.Consume(result);
	}

	[Benchmark(Description = nameof(ArrayExtensions.Upsert) + ": Record")]
	[BenchmarkCategory(Categories.ReferenceType)]
	public void UpsertRecord_Record()
	{
		var people = this._personRecordArray;

		var result = people.Upsert(this.PersonRecord01);

		this.Consume(result);
	}

}
