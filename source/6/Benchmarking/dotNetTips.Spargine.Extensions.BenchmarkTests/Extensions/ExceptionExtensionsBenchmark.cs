// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 01-09-2021
//
// Last Modified By : David McCarter
// Last Modified On : 07-21-2023
// ***********************************************************************
// <copyright file="ExceptionExtensionsBenchmark.cs" company="DotNetTips.Spargine.Extensions.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Security;
using System.Security.Policy;
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

public class ExceptionExtensionsBenchmark : Benchmark
{
	private readonly SecurityException _testException = new("Message from SecurityException");

	[Benchmark(Description = nameof(ExceptionExtensions.GetAllMessages))]
	public void GetAllMessages()
	{
		this.Consume(this._testException.GetAllMessages());
	}
}
