// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-27-2021
// ***********************************************************************
// <copyright file="Program.cs" company="dotNetTips.Spargine.Core.BenchmarkTests">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;

namespace dotNetTips.Spargine.Core.BenchmarkTests
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
		private static void Main()
		{
			try
			{
				var config = DefaultConfig.Instance.AddJob(Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp50));
				_ = config.WithOption(ConfigOptions.DisableOptimizationsValidator, true)
					  .WithOption(ConfigOptions.StopOnFirstError, true);

				_ = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).RunAll(config);

				//BenchmarkRunner.Run<ChannelQueueCollectionBenchmark>(config);

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
