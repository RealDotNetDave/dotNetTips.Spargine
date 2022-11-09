// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 04-26-2022
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="LoggingHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests.Logging;

[BenchmarkCategory(Categories.Logging)]
public class LoggingHelperBenchmark : Benchmark
{
	//private ILogger<LoggingHelperBenchmark> _logger;

	public override void Setup()
	{
		base.Setup();

		//this._logger = new LoggerFactory().CreateLogger<LoggingHelperBenchmark>();
	}
}