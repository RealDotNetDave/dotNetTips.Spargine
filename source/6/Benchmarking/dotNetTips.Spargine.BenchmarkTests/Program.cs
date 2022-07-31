﻿using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;

namespace DotNetTips.Spargine.BenchmarkTests
{
	public static class Program
	{
		public static void Main()
		{
			try
			{
				//ManualConfig config = DefaultConfig.Instance
				//.AddJob(Job.Default.WithRuntime(CoreRuntime.Core70))
				//.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

				ManualConfig config = DefaultConfig.Instance.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

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
}
