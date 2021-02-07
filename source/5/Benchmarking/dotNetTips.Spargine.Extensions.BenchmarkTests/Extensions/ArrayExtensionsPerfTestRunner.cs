// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-09-2021
// ***********************************************************************
// <copyright file="ArrayExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(ArrayExtensions))]
	public class ArrayExtensionsPerfTestRunner : CollectionPerfTestRunner
	{

		[Benchmark(Description = nameof(ArrayExtensions.AddFirst))]
		public void AddFirst01()
		{
			var people = this.personProperArrayFull.Clone<PersonProper>();

			var result = people.AddFirst(RandomData.GeneratePerson<PersonProper>());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ":Parm Array")]
		public void AddIfNotExists01()
		{
			var people = new List<PersonProper>(base.personProperCollection);
			var newPeople = new List<PersonProper>(base.personProperCollection).Take(10).ToArray();


			var result = people.AddIfNotExists(newPeople);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddIfNotExists) + ":Dup Parm Array")]
		public void AddIfNotExists02()
		{
			var people = new List<PersonProper>(base.personProperCollection);
			var newPeople = people.Shuffle(10).ToArray();


			var result = people.AddIfNotExists(newPeople);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AddLast))]
		public void AddLast01()
		{
			var people = base.personProperArrayFull.Clone<PersonProper>();

			var result = people.AddLast(RandomData.GeneratePerson<PersonProper>());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.AreEqual))]
		public void AreEqual01()
		{
			var people1 = base.personProperArrayFull.Clone<PersonProper>();
			var people2 = base.personProperArrayFull.Clone<PersonProper>();

			var result = people1.AreEqual(people2);

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ArrayHashCode))]
		public void ArrayHashCode01()
		{
			var result = base.personProperArrayFull.Clone<PersonProper>();

			base.Consumer.Consume(result.ArrayHashCode());
		}

		[Benchmark(Description = "As")]
		public void As01()
		{
			var people1 = base.personProperArrayFull.Clone<PersonProper>();

			var result = people1.As<IPerson>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.BytesToString))]
		public void BytesToString()
		{
			var result = base.byteArray.BytesToString();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.Clone))]
		public void Clone01()
		{
			var result = base.personProperArrayFull.Clone<PersonProper>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.ContainsAny))]
		public void ContainsAny01()
		{
			var people = base.personProperArrayFull.Clone<PersonProper>().AddLast(RandomData.GeneratePerson<PersonProper>());

			var result = base.personProperArrayFull.ContainsAny(people.ToArray());

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveDuplicates))]
		public void RemoveDuplicates01()
		{

		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveFirst))]
		public void RemoveFirst()
		{
			var people = base.personProperArrayFull.Clone<PersonProper>();

			var result = people.RemoveFirst();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ArrayExtensions.RemoveLast))]
		public void RemoveLast()
		{
			var people = base.personProperArrayFull.Clone<PersonProper>();

			var result = people.RemoveLast();

			base.Consumer.Consume(result);
		}

		public override void Setup() { base.Setup(); }
	}
}
