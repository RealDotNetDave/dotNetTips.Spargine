using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;

namespace dotNetTips.Spargine.BenchmarkTests
{
	public static class Program
	{
		public static void Main()
		{
			{
				try
				{
					var config = DefaultConfig.Instance.AddJob(Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp50));

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
					Console.WriteLine(ex.Message);
					_ = Console.ReadLine();
				}
			}
		}
	}
}
