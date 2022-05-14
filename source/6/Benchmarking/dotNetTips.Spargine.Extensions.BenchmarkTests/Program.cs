﻿using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;

namespace DotNetTips.Spargine.BenchmarkTests
{
	/// <summary>
	/// Class Program.
	/// </summary>
	public static class Program
	{
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		/// <param name="args">The arguments.</param>
		public static void Main()
		{
			try
			{
				var config = DefaultConfig.Instance.AddJob(Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp60));
				_ = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true)
					  .WithOption(ConfigOptions.StopOnFirstError, true);

				_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

				//BenchmarkRunner.Run<ArrayExtensionsCollectionBenchmark>(config);
				//BenchmarkRunner.Run<CollectionExtensionsPerfTestRunner>(config);
				//BenchmarkRunner.Run<DictionaryExtensionsPerfTestRunner>(config);
				//BenchmarkRunner.Run<EnumerableExtensionsCollectionBenchmark>(config);
				//BenchmarkRunner.Run<EnumExtensionsBenchmark>(config);
				//BenchmarkRunner.Run<ExceptionExtensionsPerfTestRunner>(config);
				//BenchmarkRunner.Run<ListExtensionsCollectionBenchmark>(config);
				//BenchmarkRunner.Run<ObjectExtensionsBenchmark>(config);
				//BenchmarkRunner.Run<StringBuilderExtensionsCounterBenchmark>(config);
				//BenchmarkRunner.Run<StringExtensionsCounterBenchmark>(config);
				//BenchmarkRunner.Run<AssemblyExtensionsBenchmark>(config);

				Console.Beep();
				Console.Beep(frequency: 50000, duration: 5000);
				_ = Console.ReadLine();
			}
			catch (Exception ex)
			{
				ConsoleLogger.Default.WriteLine(ex.Message);
				Console.Beep(frequency: 500, duration: 2000);
				_ = Console.ReadLine();
			}
		}
	}
}
