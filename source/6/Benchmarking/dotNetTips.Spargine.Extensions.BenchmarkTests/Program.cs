using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions.BenchmarkTests
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
				//ManualConfig config = DefaultConfig.Instance
				//.AddJob(Job.Default.WithRuntime(CoreRuntime.Core70))
				//.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

				ManualConfig config = DefaultConfig.Instance.AddJob(Job.Default.WithRuntime(CoreRuntime.Core60));

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
				//BenchmarkRunner.Run<GeneralBenchmark>(config);
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
