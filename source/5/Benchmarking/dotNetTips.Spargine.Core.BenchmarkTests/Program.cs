// ***********************************************************************
// Assembly         : dotNetTips.Spargine.Core.BenchmarkTests
// Author           : David McCarter
// Created          : 02-19-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
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
using dotNetTips.Spargine.Core.BenchmarkTests.Serialization;

namespace dotNetTips.Spargine.Core.BenchmarkTests
{
	/// <summary>
	/// Class Program.
	/// </summary>
	public class Program
	{
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		/// <param name="args">The arguments.</param>
		private static void Main(string[] args)
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
