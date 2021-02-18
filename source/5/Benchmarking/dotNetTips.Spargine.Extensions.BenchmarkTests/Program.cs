using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using dotNetTips.Spargine.Extensions.BenchmarkTests;

namespace dotNetTips.Spargine.BenchmarkTests
{
	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				var config = DefaultConfig.Instance.AddJob(Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp50));
				config.WithOption(ConfigOptions.DisableOptimizationsValidator, true)
					  .WithOption(ConfigOptions.StopOnFirstError, true);

				//BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

				BenchmarkRunner.Run<TypeHelperPerfTestRunner>(config);

				Console.Beep();
				Console.Beep(frequency: 50000, duration: 5000);
				Console.ReadLine();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.Beep(frequency: 500, duration: 2000);
				Console.ReadLine();
			}
		}
	}
}
