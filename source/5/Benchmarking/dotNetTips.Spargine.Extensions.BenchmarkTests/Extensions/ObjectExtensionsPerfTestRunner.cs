// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="ObjectExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;
using dotNetTips.Spargine.Tester;
using dotNetTips.Spargine.Tester.Models;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(ObjectExtensions))]
	public class ObjectExtensionsPerfTestRunner : PerfTestRunner
	{
		private string _peopleJson;

		private PersonProper _person;

		[Benchmark(Description = nameof(ObjectExtensions.As))]
		public void As()
		{
			var result = this._person.As<IPerson>();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.Clone))]
		public void Clone()
		{
			var result = this._person.Clone<PersonProper>();

			base.Consumer.Consume(result);
		}

		//[Benchmark(Description = nameof(ObjectExtensions.ComputeMD5Hash))]
		//public void ComputeMD5Hash()
		//{
		//	var result = this._person.ComputeMD5Hash();

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(ObjectExtensions.ComputeSha256Hash))]
		public void ComputeSha256Hash()
		{
			var result = this._person.ComputeSha256Hash();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.DisposeFields))]
		public void DisposeFields()
		{
			var disposableType = new DataTable("TEST");

			disposableType.DisposeFields();
		}

		//[Benchmark(Description = nameof(ObjectExtensions.FromJson))]
		//public void FromJson()
		//{
		//	var result = this._peopleJson.FromJson<PersonProper>();

		//	base.Consumer.Consume(result);
		//}

		[Benchmark(Description = nameof(ObjectExtensions.HasProperty))]
		public void HasProperty()
		{
			var result = this._person.HasProperty("City");

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.IsNotNull))]
		public void IsNotNull()
		{
			var result = this._person.IsNotNull();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.IsNull))]
		public void IsNull()
		{
			var result = this._person.IsNull();

			base.Consumer.Consume(result);
		}

		public override void Setup()
		{
			base.Setup();

			this._person = RandomData.GeneratePerson<PersonProper>();
			this._peopleJson = this._person.ToJson();
		}

		[Benchmark(Description = nameof(ObjectExtensions.StripNull))]
		public void StripNull()
		{
			var result = this._person.StripNull();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.ToJson))]
		public void ToJson()
		{
			var result = this._person.ToJson();

			base.Consumer.Consume(result);
		}

		[Benchmark(Description = nameof(ObjectExtensions.TryDispose))]
		public void TryDispose()
		{
			var disposableType = new DataTable("TEST");

			disposableType.TryDispose();
		}
	}
}
