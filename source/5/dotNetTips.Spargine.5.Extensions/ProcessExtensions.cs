// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 07-15-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="ProcessExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics;
using System.IO;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.Logging;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Process Extensions.
	/// </summary>
	public static class ProcessExtensions
	{
		/// <summary>
		/// Ensures the high priority.
		/// </summary>
		/// <param name="process">The process.</param>
		/// <param name="logger">The logger.</param>
		/// <exception cref="ArgumentNullException">process</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static void EnsureHighPriority(this Process process, ILogger logger)
		{
			Validate.TryValidateNullParam(process, nameof(process));

			try
			{
				process.PriorityClass = ProcessPriorityClass.High;
			}
			catch (Exception ex)
			{
				logger?.LogError(ex, Resources.FailedToSetUpHighPriority);
			}
		}

		/// <summary>
		/// Ensures the low priority.
		/// </summary>
		/// <param name="process">The process.</param>
		/// <param name="logger">The logger.</param>
		/// <exception cref="ArgumentNullException">process</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static void EnsureLowPriority(this Process process, ILogger logger)
		{
			Validate.TryValidateNullParam(process, nameof(process));

			try
			{
				process.PriorityClass = ProcessPriorityClass.BelowNormal;
			}
			catch (Exception ex)
			{
				logger?.LogError(ex, Resources.FailedToSetUpLowPriority);
			}
		}

		/// <summary>
		/// Runs the process and ignore output.
		/// </summary>
		/// <param name="fileName">Name of the file.</param>
		/// <param name="arguments">The arguments.</param>
		/// <param name="timeout">The timeout.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentException">fileName</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static int RunProcessAndIgnoreOutput(string fileName, string arguments, TimeSpan timeout)
		{
			if (string.IsNullOrEmpty(fileName) && File.Exists(fileName) == false)
			{
				ExceptionThrower.ThrowArgumentException(string.Format(Resources.FileIsNullEmptyOrDoesNotExist, nameof(fileName)), nameof(fileName));
			}

			var startInfo = new ProcessStartInfo
			{
				FileName = fileName,
				Arguments = arguments,
				RedirectStandardOutput = false,
				RedirectStandardError = false,
				UseShellExecute = false,
				CreateNoWindow = true
			};

			using var process = Process.Start(startInfo);
			if (!process.WaitForExit((int)timeout.TotalMilliseconds))
			{
				process.Kill();
			}

			return process.ExitCode;
		}


		/// <summary>
		/// Runs the process and read output.
		/// </summary>
		/// <param name="fileName">Name of the file.</param>
		/// <param name="arguments">The arguments.</param>
		/// <param name="timeout">The timeout.</param>
		/// <returns>System.ValueTuple&lt;System.Int32, System.String&gt;.</returns>
		/// <exception cref="ArgumentException">fileName</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static (int exitCode, string output) RunProcessAndReadOutput(string fileName, string arguments, TimeSpan timeout)
		{
			if (string.IsNullOrEmpty(fileName) && File.Exists(fileName) == false)
			{
				ExceptionThrower.ThrowArgumentException(string.Format(Resources.FileIsNullEmptyOrDoesNotExist, nameof(fileName)), nameof(fileName));
			}

			var startInfo = new ProcessStartInfo
			{
				FileName = fileName,
				Arguments = arguments,
				RedirectStandardOutput = true,
				UseShellExecute = false
			};

			using var process = Process.Start(startInfo);
			if (process.WaitForExit((int)timeout.TotalMilliseconds))
			{
				return (process.ExitCode, process.StandardOutput.ReadToEnd());
			}
			else
			{
				process.Kill();
			}

			return (process.ExitCode, default);
		}

		/// <summary>
		/// Tries the set priority.
		/// </summary>
		/// <param name="process">The process.</param>
		/// <param name="priority">The priority.</param>
		/// <param name="logger">The logger.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">process or logger error</exception>
		/// <exception cref="ArgumentOutOfRangeException">priority</exception>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool TrySetPriority(this Process process, ProcessPriorityClass priority, ILogger logger)
		{
			Validate.TryValidateNullParam(process, nameof(process));
			Validate.TryValidateParam(priority, nameof(priority));

			try
			{
				process.PriorityClass = priority;
				return true;
			}
			catch (Exception ex)
			{
				logger?.LogError(ex,
					$"// ! Failed to set up priority {priority} for process {process}. Make sure you have the right permissions.");
			}

			return false;
		}

	}
}
