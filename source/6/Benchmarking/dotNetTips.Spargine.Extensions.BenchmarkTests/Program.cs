// ***********************************************************************
// Assembly         : DotNetTips.Spargine.Extensions.BenchmarkTests
// Author           : David McCarter
// Created          : 11-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-13-2022
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

namespace DotNetTips.Spargine.Extensions.BenchmarkTests;

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
			var config = DefaultConfig.Instance
			.AddJob(Job.Default.WithRuntime(CoreRuntime.Core70))
			.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

			//var config = DefaultConfig.Instance.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

			config = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true)
				  .WithOption(ConfigOptions.StopOnFirstError, true);

			//_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

			//BenchmarkRunner.Run<ArrayExtensionsCollectionBenchmark>(config);
			//BenchmarkRunner.Run<AssemblyExtensionsBenchmark>(config);
			//BenchmarkRunner.Run<CollectionExtensionsCollectionBenchmark>(config);
			BenchmarkRunner.Run<DictionaryExtensionsCollectionBenchmark>(config);
			BenchmarkRunner.Run<EnumerableExtensionsCollectionBenchmark>(config);
			BenchmarkRunner.Run<ExceptionExtensionsBenchmark>(config);
			BenchmarkRunner.Run<GeneralBenchmark>(config);
			BenchmarkRunner.Run<ImmutableArrayExtensionsBenchmark>(config);
			BenchmarkRunner.Run<ListExtensionsCollectionBenchmark>(config);
			BenchmarkRunner.Run<ObjectExtensionsBenchmark>(config);
			BenchmarkRunner.Run<ObservableCollectionExtensionsCollectionBenchmark>(config);
			BenchmarkRunner.Run<ReadOnlyCollectionBenchmark>(config);
			BenchmarkRunner.Run<SortedDictionaryExtensionsBenchmark>(config);
			BenchmarkRunner.Run<SortedSetCollectionBenchmark>(config);
			BenchmarkRunner.Run<StringBuilderExtensionsCounterBenchmark>(config);
			BenchmarkRunner.Run<StringBuilderExtensionsCounterBenchmark>(config);
			BenchmarkRunner.Run<StringExtensionsBenchmark>(config);

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
