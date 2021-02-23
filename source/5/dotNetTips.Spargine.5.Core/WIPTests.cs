// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 02-21-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="WIPTests.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.CompilerServices;

namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class WIPTests.
	/// </summary>
	public static class WIPTests
	{
		/// <summary>
		/// Calculates the percent.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		public static double CalculatePercent(TimeSpan first, TimeSpan second)
		{
			return ( second.TotalMilliseconds - first.TotalMilliseconds ) / Math.Abs(first.TotalMilliseconds) * 100;
		}
		/// <summary>
		/// Calculates the percent aggressive inline.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double CalculatePercentAggressiveInline(TimeSpan first, TimeSpan second)
		{
			return ( second.TotalMilliseconds - first.TotalMilliseconds ) / Math.Abs(first.TotalMilliseconds) * 100;
		}

		/// <summary>
		/// Calculates the percent no inline.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static double CalculatePercentNoInline(TimeSpan first, TimeSpan second)
		{
			return ( second.TotalMilliseconds - first.TotalMilliseconds ) / Math.Abs(first.TotalMilliseconds) * 100;
		}

		/// <summary>
		/// Calculates the percent no optimization.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.NoOptimization)]
		public static double CalculatePercentNoOptimization(TimeSpan first, TimeSpan second)
		{
			return ( second.TotalMilliseconds - first.TotalMilliseconds ) / Math.Abs(first.TotalMilliseconds) * 100;
		}

		/// <summary>
		/// Calculates the percent preserve sig.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.PreserveSig)]
		public static double CalculatePercentPreserveSig(TimeSpan first, TimeSpan second)
		{
			return ( second.TotalMilliseconds - first.TotalMilliseconds ) / Math.Abs(first.TotalMilliseconds) * 100;
		}

		/// <summary>
		/// Calculates the percent synchronized.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.Synchronized)]
		public static double CalculatePercentSynchronized(TimeSpan first, TimeSpan second)
		{
			return ( second.TotalMilliseconds - first.TotalMilliseconds ) / Math.Abs(first.TotalMilliseconds) * 100;
		}
	}
}
