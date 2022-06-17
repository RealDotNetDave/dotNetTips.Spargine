// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 05-25-2022
// ***********************************************************************
// <copyright file="MathExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class MathExtensions.
	/// </summary>
	public static class MathExtensions
	{
		/// <summary>
		/// Calculates the percent from the first and second <see cref="TimeSpan" />.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(CalculatePercent), UnitTestCoverage = 0, Status = Status.Available)]
		public static double CalculatePercent(this TimeSpan first, TimeSpan second)
		{
			return ( second.TotalMilliseconds - first.TotalMilliseconds ) / Math.Abs(first.TotalMilliseconds) * 100;
		}

		/// <summary>
		/// Calculates the percent.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(CalculatePercent), UnitTestCoverage = 0, Status = Status.Available)]
		public static double CalculatePercent(this int first, int second)
		{
			return ( second - first ) / Math.Abs(first) * 100;
		}

		/// <summary>
		/// Calculates the percent.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(CalculatePercent), UnitTestCoverage = 0, Status = Status.Available)]
		public static double CalculatePercent(this double first, double second)
		{
			return ( second - first ) / Math.Abs(first) * 100;
		}

		/// <summary>
		/// Calculates the percent.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(CalculatePercent), UnitTestCoverage = 0, Status = Status.Available)]
		public static double CalculatePercent(this long first, long second)
		{
			return ( second - first ) / Math.Abs(first) * 100;
		}

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this double value)
		{
			return Convert.ToInt32(Math.Round(value));
		}

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this decimal value)
		{
			return Convert.ToInt32(Math.Round(value));
		}

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="digits">The digits.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this double value, int digits)
		{
			return Convert.ToInt32(Math.Round(value, digits));
		}

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this double value, MidpointRounding mode)
		{
			mode = mode.ArgumentDefined(nameof(mode));

			return Convert.ToInt32(Math.Round(value, mode));
		}

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="digits">The digits.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this decimal value, int digits)
		{
			return Convert.ToInt32(Math.Round(value, digits));
		}

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value</exception>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this decimal value, MidpointRounding mode)
		{
			mode = mode.ArgumentDefined(nameof(mode));

			return Convert.ToInt32(Math.Round(value, mode));
		}

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="digits">The digits.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this double value, int digits, MidpointRounding mode)
		{
			mode = mode.ArgumentDefined(nameof(mode));

			return Convert.ToInt32(Math.Round(value, digits, mode));
		}

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="digits">The digits.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value</exception>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this decimal value, int digits, MidpointRounding mode)
		{
			mode = mode.ArgumentDefined(nameof(mode));

			return Convert.ToInt32(Math.Round(value, digits, mode));
		}
	}
}
