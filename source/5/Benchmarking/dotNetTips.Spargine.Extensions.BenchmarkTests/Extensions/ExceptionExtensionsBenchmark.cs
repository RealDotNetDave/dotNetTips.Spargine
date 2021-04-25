// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="ExceptionExtensionsPerfTestRunner.cs" company="dotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Data.Services.Client;
using System.Security;
using BenchmarkDotNet.Attributes;
using dotNetTips.Spargine.Benchmarking;

namespace dotNetTips.Spargine.Extensions.BenchmarkTests
{
	[BenchmarkCategory(nameof(ExceptionExtensions))]
	public class ExceptionExtensionsBenchmark : Benchmark
	{
		private readonly SecurityException _testException = new SecurityException("Message from SecurityException", new DataServiceClientException("Cannot access service!"));

		[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessages))]
		public void GetAllMessages01()
		{
			this.Consumer.Consume(this._testException.GetAllMessages());
		}
	}
}
