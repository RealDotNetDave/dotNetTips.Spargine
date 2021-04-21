using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;

namespace dotNetTips.Spargine.BenchmarkTests
{
	public class Program
	{
		public static void Main(string[] args)
		{
			{
				try
				{
					var config = DefaultConfig.Instance.AddJob(Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp50));

					config.WithOption(ConfigOptions.DisableOptimizationsValidator, true)
						  .WithOption(ConfigOptions.StopOnFirstError, true);

					BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

					//BenchmarkRunner.Run<SerializationBenchmark>(config);

					Console.Beep();
					Console.ReadLine();
				}
				catch (Exception ex)
				{
					Console.Beep();
					Console.Beep();
					Console.Beep();
					Console.WriteLine(ex.Message);
					Console.ReadLine();
				}
			}
		}
	}
}
