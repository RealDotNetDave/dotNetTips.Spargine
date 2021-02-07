// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="ListExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Extensions;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(ListExtensions))]
	public class ListExtensionsPerfTestRunner : CollectionPerfTestRunner
	{


		//[Benchmark(Description = nameof(ListExtensions.AddIfNotExists) + ":Comparer")]
		//public void AddIfNotExistsComparer()
		//{
		//	var people = new List<PersonProper>(base.CollectionCount);
		//	var comparer = new PersonProperComparer();

		//	foreach (var person in base.personProperCollection)
		//	{
		//		people.AddIfNotExists(person, comparer);
		//	}

		//	base.Consumer.Consume(people);
		//}

		//[Benchmark(Description = nameof(ListExtensions.AddIfNotExists) + ":Dictionary")]
		//public void AddIfNotExistsDictionary()
		//{
		//	var people = new Dictionary<string, PersonProper>(base.CollectionCount);

		//	foreach (var person in base.personProperDictionary)
		//	{
		//		people.AddIfNotExists(person.Key, person.Value);
		//	}

		//	base.Consumer.Consume(people);
		//}

		//[Benchmark(Description = nameof(ListExtensions.AddIfNotExists) + ":Param Array")]
		//public void AddIfNotExistsParamArray()
		//{
		//	var people = new List<PersonProper>(this.CollectionCount / 2);

		//	people.AddIfNotExists(base.personProperArrayHalf);

		//	base.Consumer.Consume(people);
		//}

		//[Benchmark(Description = nameof(ListExtensions.AddIfNotExists) + ":Single")]
		//public void AddIfNotExistsSingle()
		//{
		//	var people = new List<PersonProper>(base.CollectionCount);

		//	foreach (var person in base.personProperCollection)
		//	{
		//		people.AddIfNotExists(person);
		//	}

		//	base.Consumer.Consume(people);
		//}


		[Benchmark(Description = nameof(ListExtensions.AddLast) + ":Array")]
		public void AddLastToArray()
		{
			var people = base.personProperArrayFull.Clone<PersonProper>();
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.AddLast(person);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.AddLast) + ":List")]
		public void AddLastToList()
		{
			var people = base.personProperCollection.CopyToList();
			var person = RandomData.GeneratePerson<PersonProper>();

			var result = people.AddLast(person);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.AreEqual) + ":Array")]
		public void AreEqualArray()
		{
			var result = base.personProperArrayFull.AreEqual(base.personProperArrayHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.AreEqual) + ":List")]
		public void AreEqualList()
		{
			var result = base.personProperCollection.AreEqual(base.personProperListHalf);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ClearNulls))]
		public void ClearNulls()
		{
			var people = base.personProperCollection;
			people.Add(null);

			var result = people.ClearNulls();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.CopyToList))]
		public void CopyToList()
		{
			var result = base.personProperCollection.CopyToList();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.IndexOf))]
		public void IndexOf()
		{
			var result = base.personProperCollection.IndexOf(base.personProperCollection.Last());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.IndexOf) + ":Comparer")]
		public void IndexOfComparer()
		{
			var comparer = new PersonProperComparer();
			var result = base.personProperCollection.IndexOf(base.personProperCollection.Last(), comparer);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ListHashCode) + ":Array")]
		public void ListHashCodeArray()
		{
			var result = base.personProperArrayFull.ArrayHashCode();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ListHashCode) + ":List")]
		public void ListHashCodeList()
		{
			var result = base.personProperCollection.ListHashCode();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ListHashCode) + ":List-Read Only")]
		public void ListHashCodeReadOnlyList()
		{
			var result = base.personProperCollection.ToReadOnlyCollection().ListHashCode();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.OrderBy))]
		public void OrderBy()
		{
			var result = base.personProperCollection.OrderBy(p => p.City);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.OrderByOrdinal))]
		public void OrderByOrdinal()
		{
			var result = base.personProperCollection.OrderByOrdinal(p => p.City);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.Page))]
		public void Page()
		{
			foreach (var people in base.personProperCollection.Page(10))
			{
				foreach (var person in people)
				{
					base.Consumer.Consume(person);
				}
			}
		}

		[Benchmark(Description = nameof(ListExtensions.PickRandom))]
		public void PickRandom()
		{
			var result = base.personProperCollection.Take(base.CollectionCount / 10);

			base.Consumer.Consume(result);
		}


		public override void Setup() { base.Setup(); }


		[Benchmark(Description = nameof(ListExtensions.Shuffle))]
		public void Shuffle()
		{
			var result = base.personProperCollection.Shuffle();
			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.Shuffle) + ": With Count")]
		public void ShuffleWithCount()
		{
			var result = base.personProperCollection.Shuffle(base.CollectionCount / 10);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToObservableCollection))]
		public void ToObservableCollection()
		{
			var result = base.personProperCollection.ToObservableCollection();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ListExtensions.ToReadOnlyCollection))]
		public void ToReadOnlyCollection()
		{
			var result = base.personProperCollection.ToReadOnlyCollection();

			base.Consumer.Consume(result);
		}
	}

	public class PersonProperComparer : IEqualityComparer<PersonProper>
	{

		public bool Equals([AllowNull] PersonProper x, [AllowNull] PersonProper y)
		{
			return x.Id == y.Id;
		}

		public int GetHashCode([DisallowNull] PersonProper obj)
		{
			return obj.Id.GetHashCode();
		}

	}
}
