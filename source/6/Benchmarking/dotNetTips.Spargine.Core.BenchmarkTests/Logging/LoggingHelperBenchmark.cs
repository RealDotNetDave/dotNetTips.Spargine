// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 04-26-2022
//
// Last Modified By : David McCarter
// Last Modified On : 05-13-2022
// ***********************************************************************
// <copyright file="LoggingHelperBenchmark.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) dotNetTips.com - David McCarter. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using BenchmarkDotNet.Attributes;
using DotNetTips.Spargine.Benchmarking;
using DotNetTips.Spargine.Core.Logging;
using Microsoft.Extensions.Logging;

namespace DotNetTips.Spargine.Core.BenchmarkTests.Logging
{
	[BenchmarkCategory(Categories.Logging)]
	public class LoggingHelperBenchmark : LargeCounterBenchmark
	{
		private ILogger<LoggingHelperBenchmark> _logger;

		[Benchmark(Description = "EasyLogger.LogCritical")]
		[BenchmarkCategory(Categories.Logging)]
		public void LogEasyCriticalBenchmark()
		{
			var testException = new ArgumentInvalidException("TEST EX MESSAGE");

			for (var index = 0; index < this.Count; index++)
			{
				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
			}
		}

		[Benchmark(Description = "EasyLogger.LogDebug")]
		[BenchmarkCategory(Categories.Logging)]
		public void LogEasyDebugBenchmark()
		{
			var testException = new ArgumentInvalidException("TEST EX MESSAGE");

			for (var index = 0; index < this.Count; index++)
			{
				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
			}
		}

		[Benchmark(Description = "EasyLogger.LogError")]
		[BenchmarkCategory(Categories.Logging)]
		public void LogEasyErrorBenchmark()
		{
			var testException = new ArgumentInvalidException("TEST EX MESSAGE");

			for (var index = 0; index < this.Count; index++)
			{
				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
			}
		}

		[Benchmark(Description = "EasyLogger.LogInformation")]
		[BenchmarkCategory(Categories.Logging)]
		public void LogEasyInformationBenchmark()
		{
			for (var index = 0; index < this.Count; index++)
			{
				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
			}
		}

		[Benchmark(Description = "EasyLogger.LogTrace")]
		[BenchmarkCategory(Categories.Logging)]
		public void LogEasyTraceBenchmark()
		{
			for (var index = 0; index < this.Count; index++)
			{
				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
			}
		}

		[Benchmark(Description = "LoggingHelper.LogError")]
		[BenchmarkCategory(Categories.Logging)]
		public void LogErrorBenchmark()
		{
			var testException = new ArgumentInvalidException("TEST EX MESSAGE");

			for (var index = 0; index < this.Count; index++)
			{
				this._logger.LogError(100, testException, "ERROR ENTRY");
			}
		}

		[Benchmark(Description = "LoggingHelper.LogInformation")]
		[BenchmarkCategory(Categories.Logging)]
		public void LogInformationBenchmark()
		{
			var testException = new ArgumentInvalidException("TEST EX MESSAGE");

			for (var index = 0; index < this.Count; index++)
			{
				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
			}
		}

		[Benchmark(Description = "LoggingHelper.LogTrace")]
		[BenchmarkCategory(Categories.Logging)]
		public void LogTraceBenchmark()
		{
			var testException = new ArgumentInvalidException("TEST EX MESSAGE");

			for (var index = 0; index < this.Count; index++)
			{
				this._logger.LogTrace(100, testException, "TRACE ENTRY");
			}
		}

		public override void Setup()
		{
			base.Setup();

			this._logger = new LoggerFactory().CreateLogger<LoggingHelperBenchmark>();
		}
	}
}
