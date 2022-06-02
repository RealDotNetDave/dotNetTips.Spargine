// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="Program.cs" company="DotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using DotNetTips.Spargine.Core.BenchmarkTests.Logging;

namespace DotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// Class Program.
	/// </summary>
	public class Program
	{
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		/// <param name="args">The arguments.</param>
		private static void Main()
		{
			try
			{
				var config = DefaultConfig.Instance.AddJob(Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp60));
				_ = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true)
					  .WithOption(ConfigOptions.StopOnFirstError, true);

				//_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

				BenchmarkRunner.Run<LoggingBenchmark>(config);

				Console.Beep();
				_ = Console.ReadLine();
			}
			catch (Exception ex)
			{
				Console.Beep();
				Console.Beep();
				Console.Beep();
				ConsoleLogger.Default.WriteLine(ex.Message);
				_ = Console.ReadLine();
			}
		}
	}
}
