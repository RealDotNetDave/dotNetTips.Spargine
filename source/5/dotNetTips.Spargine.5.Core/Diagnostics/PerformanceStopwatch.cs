// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-03-2020
// ***********************************************************************
// <copyright file="PerformanceStopwatch.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Performance Stopwatch</summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Core.Diagnostics
{
	/// <summary>
	/// Performance Stopwatch.
	/// </summary>
	/// <seealso cref="System.Diagnostics.Stopwatch" />
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
			var sw = TypeHelper.Create<PerformanceStopwatch>();
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
			var result = this.Elapsed;
			base.Reset();

			return result;
		}

		/// <summary>
		/// Stops the restart.
		/// </summary>
		/// <returns>TimeSpan.</returns>
		[Information(nameof(StopRestart), "David McCarter", "11/11/2020", Status = Status.Available)]
		public TimeSpan StopRestart()
		{
			var result = this.Elapsed;

			base.Restart();

			return result;
		}
	}
}
