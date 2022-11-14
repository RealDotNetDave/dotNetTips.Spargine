// ***********************************************************************
// Assembly         : DotNetTips.Spargine.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-08-2022
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
using BenchmarkDotNet.Running;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.BenchmarkTests;

public static class Program
{
	public static void Main()
	{
		try
		{
			var config = DefaultConfig.Instance
			.AddJob(Job.Default.WithRuntime(CoreRuntime.Core70))
			.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

			//var config = DefaultConfig.Instance.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

			_ = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true)
				  .WithOption(ConfigOptions.StopOnFirstError, true);

			_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

			//BenchmarkRunner.Run<SerializationBenchmark>(config);

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
