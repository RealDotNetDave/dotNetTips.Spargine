// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="Clock.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Clock Information.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Devices
{
	/// <summary>
	/// Clock Information.
	/// </summary>
	/// <remarks>Some of this code is from the Microsoft.VisualBasic.dll</remarks>
	[ExcludeFromCodeCoverage]
	[Information(nameof(Clock), "David McCarter", "11/11/2020", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.NotRequired)]
	public static class Clock
	{
		/// <summary>
		/// Gets the days in the current month (local time).
		/// </summary>
		/// <value>The days in month.</value>
		[Information(nameof(DaysInCurrentMonth), "David McCarter", "11/11/2020", Status = Status.Available)]
		public static int DaysInCurrentMonth => DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

		/// <summary>
		/// Gets the days in current UTC month.
		/// </summary>
		/// <value>The days in current UTC month.</value>
		[Information(nameof(DaysInCurrentUtcMonth), "David McCarter", "11/11/2020", Status = Status.Available)]
		public static int DaysInCurrentUtcMonth => DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month);

		/// <summary>
		/// Gets the local time.
		/// </summary>
		/// <value>The local time.</value>
		[Information(nameof(LocalTime), "David McCarter", "11/11/2020", Status = Status.Available)]
		public static DateTime LocalTime => DateTime.Now.ToLocalTime();

		/// <summary>
		/// Gets the tick count.
		/// </summary>
		/// <value>The tick count.</value>
		[Information(nameof(TickCount), "David McCarter", "11/11/2020", Status = Status.Available)]
		public static int TickCount => Environment.TickCount;

		/// <summary>
		/// Gets the UTC time.
		/// </summary>
		/// <value>The UTC time.</value>
		[Information(nameof(UtcTime), "David McCarter", "11/11/2020", Status = Status.Available)]
		public static DateTime UtcTime => DateTime.UtcNow;
	}
}
