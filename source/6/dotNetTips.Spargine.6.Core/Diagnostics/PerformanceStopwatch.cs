// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-14-2021
// ***********************************************************************
// <copyright file="PerformanceStopwatch.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Performance Stopwatch</summary>
// ***********************************************************************
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
namespace DotNetTips.Spargine.Core.Diagnostics
{
	/// <summary>
	/// <see cref="Stopwatch"/> with added features.
	/// </summary>
	/// <seealso cref="Stopwatch" />
	[ExcludeFromCodeCoverage]
	[Information(nameof(PerformanceStopwatch), "David McCarter", "11/11/2020", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired)]
	public class PerformanceStopwatch : Stopwatch
	{
		/// <summary>
		/// Starts the new.
		/// </summary>
		/// <returns>PerformanceStopwatch.</returns>
		[Information(nameof(StartNew), "David McCarter", "11/11/2020", Status = Status.Available)]
		public static new PerformanceStopwatch StartNew()
		{
			PerformanceStopwatch sw = TypeHelper.Create<PerformanceStopwatch>();
			sw.Start();

			return sw;
		}

		/// <summary>
		/// Stops the reset.
		/// </summary>
		/// <returns>TimeSpan.</returns>
		[Information(nameof(StopReset), "David McCarter", "11/11/2020", Status = Status.Available)]
		public TimeSpan StopReset()
		{
			this.Stop();
			TimeSpan result = this.Elapsed;
			this.Reset();

			return result;
		}

		/// <summary>
		/// Stops the restart.
		/// </summary>
		/// <returns>TimeSpan.</returns>
		[Information(nameof(StopRestart), "David McCarter", "11/11/2020", Status = Status.Available)]
		public TimeSpan StopRestart()
		{
			TimeSpan result = this.Elapsed;

			this.Restart();

			return result;
		}
	}
}
