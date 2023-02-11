// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2023
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.com - McCarter Consulting">
//     David McCarter
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Perfolizer.Horology;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.BenchmarkTests;

/// <summary>
/// Class Program.
/// </summary>
public static class Program
{
	/// <summary>
	/// Defines the entry point of the application.
	/// </summary>
	public static void Main()
	{
		try
		{
			var config = DefaultConfig.Instance
			.AddJob(Job.Default.WithRuntime(CoreRuntime.Core70)).WithSummaryStyle(SummaryStyle.Default.WithTimeUnit(TimeUnit.Nanosecond))
			.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60)).WithSummaryStyle(SummaryStyle.Default.WithTimeUnit(TimeUnit.Nanosecond));

			//var config = DefaultConfig.Instance.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

			_ = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true);

			_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

			//BenchmarkRunner.Run<SerializationBenchmark>(config);

			ConsoleLogger.Default.WriteLine("COMPLETE!");
			Console.Beep();
			Console.Beep(frequency: 500, duration: 1000);
			Console.Beep(frequency: 750, duration: 2000);
			Console.Beep(frequency: 800, duration: 3000);
			_ = Console.ReadLine();
		}
		catch (Exception ex)
		{
			ConsoleLogger.Default.WriteLine("ERROR!");
			ConsoleLogger.Default.WriteLine(ex.Message);
			Console.Beep(frequency: 5000, duration: 6000);
			_ = Console.ReadLine();
		}
	}
}
