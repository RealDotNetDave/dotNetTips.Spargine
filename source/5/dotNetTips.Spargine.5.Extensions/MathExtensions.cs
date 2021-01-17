// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 12-17-2020
// ***********************************************************************
// <copyright file="MathExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class MathExtensions.
	/// </summary>
	public static class MathExtensions
	{

		/// <summary>
		/// Calculates the percent.
		/// </summary>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns>System.Double.</returns>
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
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this double value) => Convert.ToInt32(Math.Round(value));

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this decimal value) => Convert.ToInt32(Math.Round(value));

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="digits">The digits.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this double value, int digits) => Convert.ToInt32(Math.Round(value, digits));

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this double value, MidpointRounding mode) => Convert.ToInt32(Math.Round(value, mode));

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="digits">The digits.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value - Value is invalid.</exception>
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this decimal value, int digits) => Convert.ToInt32(Math.Round(value, digits));

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value</exception>
		/// <exception cref="System.ArgumentNullException">value - Value is invalid.</exception>
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this decimal value, MidpointRounding mode)
		{
			if (value <= decimal.MinValue || value >= decimal.MaxValue)
			{
				throw new ArgumentNullException(nameof(value), Resources.ValueIsInvalid);
			}

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
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this double value, int digits, MidpointRounding mode) => Convert.ToInt32(Math.Round(value, digits, mode));

		/// <summary>
		/// Rounds the specified value.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="digits">The digits.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">value</exception>
		/// <exception cref="System.ArgumentNullException">value - Value is invalid.</exception>
		[Information(nameof(Round), UnitTestCoverage = 0, Status = Status.Available)]
		public static int Round(this decimal value, int digits, MidpointRounding mode)
		{
			if (value <= decimal.MinValue || value >= decimal.MaxValue)
			{
				throw new ArgumentNullException(nameof(value), Resources.ValueIsInvalid);
			}

			return Convert.ToInt32(Math.Round(value, digits, mode));
		}
	}
}
