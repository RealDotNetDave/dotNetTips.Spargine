// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-11-2022
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

		/// <summary>
		/// Determines whether the specified number is prime.
		/// </summary>
		/// <param name="number">The number.</param>
		/// <returns><c>true</c> if the specified number is prime; otherwise, <c>false</c>.</returns>
		/// <remarks>Orginal code: https://khalidabuhakmeh.com/find-prime-numbers-with-csharp-9</remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(IsPrime), UnitTestCoverage = 0, Status = Status.New)]
		public static bool IsPrime(this int number)
		{
			// local function
			bool CalculatePrime(int value)
			{
				// A simple but slow method of checking
				// the primality of a given number
				// n, called trial division, tests whether n is a multiple
				// of any integer between 2 and sqrt(n)
				var possibleFactors = Math.Sqrt(number);

				// we start with low factors (2,3,4,5,etc...)
				// this makes sure we short circuit as early
				// as possible during calculations
				for (var factor = 2; factor <= possibleFactors; factor++)
				{
					if (value % factor == 0)
					{
						return false;
					}
				}

				// we've exhausted all factors
				// so we know this number is prime
				return true;
			}

			// negative numbers can't be prime
			// only call CalculatePrime if non-negative
			return number > 1 && CalculatePrime(number);
		}
	}
}
