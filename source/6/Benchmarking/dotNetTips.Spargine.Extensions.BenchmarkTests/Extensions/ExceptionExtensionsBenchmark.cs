// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="ExceptionExtensionsPerfTestRunner.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Security;
using System.Security.Policy;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
{
	public class ExceptionExtensionsBenchmark : Benchmark
	{
		private readonly SecurityException _testException = new("Message from SecurityException", new PolicyException("Cannot access service!"));

		[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessages))]
		public void GetAllMessages01()
		{
			base.Consumer.Consume(this._testException.GetAllMessages());
		}
	}
}
