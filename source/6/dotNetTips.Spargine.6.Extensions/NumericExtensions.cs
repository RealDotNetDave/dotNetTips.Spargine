// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="NumericExtensions.cs" company="dotNetTips.Spargine.6.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class IntegerExtensions.
/// </summary>
public static class NumericExtensions
{
	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Averages two numbers.
	/// </summary>
	/// <param name="a">First number to average</param>
	/// <param name="b">Second number to average</param>
	/// <returns>double.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "2/19/2023", UnitTestCoverage = 0, Status = Status.New)]
	public static double Average(this double a, double b)
	{
		return (a + b) / 2;
	}

	/// <summary>
	/// Averages two numbers.
	/// </summary>
	/// <param name="a">First number to average</param>
	/// <param name="b">Second number to average</param>
	/// <returns>double.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "2/19/2023", UnitTestCoverage = 0, Status = Status.New)]
	public static long Average(this long a, long b)
	{
		return (a + b) / 2;
	}

	/// <summary>
	/// Averages two numbers.
	/// </summary>
	/// <param name="a">First number to average</param>
	/// <param name="b">Second number to average</param>
	/// <returns>double.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "2/19/2023", UnitTestCoverage = 0, Status = Status.New)]
	public static int Average(this int a, int b)
	{
		return (a + b) / 2;
	}

	/// <summary>
	/// Averages two numbers.
	/// </summary>
	/// <param name="a">First number to average</param>
	/// <param name="b">Second number to average</param>
	/// <returns>double.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Average), "David McCarter", "2/19/2023", UnitTestCoverage = 0, Status = Status.New)]
	public static decimal Average(this decimal a, decimal b)
	{
		return (a + b) / 2;
	}

	/// <summary>
	/// Decrement a number ensuring it never passes a given lower-bound.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <param name="lowerBound">Lower bound</param>
	/// <param name="step">Step of the decrement</param>
	/// <returns>Integer</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Decrement), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int Decrement(this int value, int lowerBound = 0, int step = 1)
	{
		var n = value - step;
		return n < lowerBound ? lowerBound : n;
	}

	/// <summary>
	/// Ensures the minimum value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="minValue">The minimum value.</param>
	/// <returns>System.Int32.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EnsureMinimum), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int EnsureMinimum(this int value, int minValue)
	{
		return value < minValue ? minValue : value;
	}

	/// <summary>
	/// Formats the number to friendly <see cref="string" />.
	/// </summary>
	/// <param name="fileSize">Size of the file or other resourse.</param>
	/// <returns>System.String.</returns>
	/// <example>Return Example: 250 KB</example>
	[Information(nameof(FormatSize), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static string FormatSize(this long fileSize)
	{
		long size = 0;

		while (fileSize > 1024 && size < 4)
		{
			fileSize = Convert.ToInt64(fileSize / 1024);
			size++;
		}

		return $"{fileSize.ToString(CultureInfo.CurrentCulture)} {(new string[] { Resources.Bytes, Resources.KB, Resources.MB, Resources.GB })[Convert.ToInt64(size)]}";
	}

	/// <summary>
	/// Formats the number to friendly <see cref="string" />.
	/// </summary>
	/// <param name="fileSize">Size of the file or other resource.</param>
	/// <returns>System.String.</returns>
	/// <example>Return Example: 250.22947265625 KB</example>
	[Information(nameof(FormatSize), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static string FormatSize(this double fileSize)
	{
		double size = 0;

		while (fileSize > 1024 && size < 4)
		{
			fileSize = Convert.ToDouble(fileSize / 1024);
			size++;
		}

		return $"{fileSize.ToString(CultureInfo.CurrentCulture)} {(new string[] { Resources.Bytes, Resources.KB, Resources.MB, Resources.GB })[Convert.ToInt64(size)]}";
	}

	/// <summary>
	/// Increment a number ensuring it never passes a given upper-bound.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <param name="upperBound">Upper bound</param>
	/// <param name="step">Step of the increment</param>
	/// <returns>Integer</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Increment), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int Increment(this int value, int upperBound = 100, int step = 1)
	{
		var number = value + step;
		return number > upperBound ? upperBound : number;
	}

	/// <summary>
	/// Indicate whether the number is even.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <returns>True/False</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this decimal value)
	{
		return (value % 2) == 0;
	}

	/// <summary>
	/// Indicate whether the number is even.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <returns>True/False</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this double value)
	{
		return (value % 2) == 0;
	}

	/// <summary>
	/// Indicate whether the number is even.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <returns>True/False</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this float value)
	{
		return (value % 2) == 0;
	}

	/// <summary>
	/// Indicate whether the number is even.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <returns>True/False</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this int value)
	{
		return (value % 2) == 0;
	}

	/// <summary>
	/// Indicate whether the number is even.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <returns>True/False</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this long value)
	{
		return (value % 2) == 0;
	}

	/// <summary>
	/// Indicate whether the number is even.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <returns>True/False</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this sbyte value)
	{
		return (value % 2) == 0;
	}

	/// <summary>
	/// Indicate whether the number is even.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <returns>True/False</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEven), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEven(this short value)
	{
		return (value % 2) == 0;
	}

	/// <summary>
	/// Indicate whether the number falls in the specified range.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <param name="lower">Lower bound</param>
	/// <param name="upper">Upper bound</param>
	/// <returns>True/False</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRange), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRange(this int value, int lower, int upper)
	{
		return value >= lower && value <= upper;
	}

	/// <summary>
	/// Determines whether [is in range] [the specified lower].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRange), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRange(this long value, long lower, long upper)
	{
		return value >= lower && value <= upper;
	}

	/// <summary>
	/// Determines whether [is in range] [the specified lower].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRange), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRange(this double value, double lower, double upper)
	{
		return value >= lower && value <= upper;
	}

	/// <summary>
	/// Determines whether [is in range] [the specified lower].
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRange), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRange(this decimal value, decimal lower, decimal upper)
	{
		return value >= lower && value <= upper;
	}

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified value]. Throws Exception if invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns>System.Boolean.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Value is out of range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRangeThrowsException(this double value, double lower, double upper)
	{
		if (value.IsInRange(lower, upper) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
		}

		return true;
	}

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified value]. Throws Exception if invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns>System.Boolean.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Value is out of range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRangeThrowsException(this decimal value, decimal lower, decimal upper)
	{
		if (value.IsInRange(lower, upper) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
		}

		return true;
	}

	/// <summary>
	/// Determines whether [is in range] [the specified lower] and will throw Exception if false.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Value is out of range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRangeThrowsException(this int value, int lower, int upper)
	{
		if (value.IsInRange(lower, upper) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
		}

		return true;
	}

	/// <summary>
	/// Determines whether [is in range throws exception] [the specified value]. Throws Exception if invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="lower">The lower.</param>
	/// <param name="upper">The upper.</param>
	/// <returns>System.Boolean.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Value is out of range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInRangeThrowsException(this long value, long lower, long upper)
	{
		if (value.IsInRange(lower, upper) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(value));
		}

		return true;
	}

	/// <summary>
	/// Determines if the Integer is of the specified interval. E.g. if the interval is 100 and the integer is 400,
	/// it would return true. This function uses the Mod operator, for the above example: (300 Mod 100 = 0)
	/// </summary>
	/// <param name="value">The number.</param>
	/// <param name="interval">The interval.</param>
	/// <returns><c>true</c> if the specified number is interval; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsInterval), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsInterval(this int value, int interval)
	{
		return value % interval == 0;
	}

	/// <summary>
	/// Determines whether [is interval throws exception] [the specified value] and throws Exception if invalid.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="interval">The interval.</param>
	/// <param name="paramName">Name of the parameter.</param>
	/// <returns>System.Boolean.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Interval is out of range.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsIntervalThrowsException), author: "David McCarter", createdOn: "10/5/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsIntervalThrowsException(this int value, int interval, string paramName)
	{
		if (value.IsInterval(interval) is false)
		{
			ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
		}

		return true;
	}

	/// <summary>
	/// Determines whether the specified value is negative.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this double value) { return Math.Sign(value) == -1; }

	/// <summary>
	/// Determines whether the specified value is negative.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this int value)
	{
		return Math.Sign(value) == -1;
	}

	/// <summary>
	/// Determines whether the specified value is negative.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this long value)
	{
		return Math.Sign(value) == -1;
	}

	/// <summary>
	/// Determines whether the specified value is negative.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this sbyte value)
	{
		return Math.Sign(value) == -1;
	}

	/// <summary>
	/// Determines whether the specified value is negative.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this short value)
	{
		return Math.Sign(value) == -1;
	}

	/// <summary>
	/// Determines whether the specified value is negative.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this decimal value)
	{
		return Math.Sign(value) == -1;
	}

	/// <summary>
	/// Determines whether the specified value is negative.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsNegative(this float value)
	{
		return Math.Sign(value) == -1;
	}

	/// <summary>
	/// Converts milliseconds to a string. 
	/// <code>
	/// Example output: 02:45:00
	/// </code>
	/// </summary>
	/// <param name="totalMilliseconds">The total milliseconds.</param>
	/// <returns>string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MillisecondsToString), "David McCarter", "4/16/2003", UnitTestCoverage = 0, Status = Status.New, Documentation = "ADD URL")]
	public static string MillisecondsToString(this long totalMilliseconds)
	{
		var hours = (int)(totalMilliseconds / (1000 * 60 * 60));
		var minutes = (int)(totalMilliseconds / (1000 * 60) % 60);
		var seconds = (int)(totalMilliseconds / 1000 % 60);

		return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
	}

	/// <summary>
	/// Converts milliseconds to a string.
	/// <code>
	/// Example output: 02:45:00
	/// </code>
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MillisecondsToString), "David McCarter", "4/16/2003", UnitTestCoverage = 0, Status = Status.New, Documentation = "ADD URL")]
	public static string MillisecondsToString(this TimeSpan input)
	{
		var totalMilliseconds = input.TotalMilliseconds;
		var hours = (int)(totalMilliseconds / (1000 * 60 * 60));
		var minutes = (int)(totalMilliseconds / (1000 * 60) % 60);
		var seconds = (int)(totalMilliseconds / 1000 % 60);

		return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
	}

	/// <summary>
	/// Converts milliseconds to a string. 
	/// <code>
	/// Example output: 02:45:00
	/// </code>
	/// </summary>
	/// <param name="totalMilliseconds">The total milliseconds.</param>
	/// <returns>string.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(MillisecondsToString), "David McCarter", "4/16/2003", UnitTestCoverage = 0, Status = Status.New, Documentation = "ADD URL")]
	public static string MillisecondsToString(this int totalMilliseconds)
	{
		var hours = totalMilliseconds / (1000 * 60 * 60);
		var minutes = totalMilliseconds / (1000 * 60) % 60;
		var seconds = totalMilliseconds / 1000 % 60;

		return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
	}

	/// <summary>
	/// Returns the nearest power of 2 that is bigger than the number.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <returns>Integer</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(RoundToPowerOf2), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int RoundToPowerOf2(this int value)
	{
		var exponent = 1;

		while (true)
		{
			var powerOf2 = (uint)Math.Pow(2, exponent++);

			if (powerOf2 >= value)
			{
				return (int)powerOf2;
			}
		}
	}

	/// <summary>
	/// Converts number to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">Invalid number format.</exception>
	/// <example>
	/// Output: Currency: $2,103,162,670.00, Decimal: 2103162670, Exponential: 2.103163E+009 FixedPoint:
	/// 2103162670.00, General: 2103162670, Hexadecimal: 7D5BB72E Number: 2,103,162,670.00, Percent:
	/// 210,316,267,000.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this int input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException("Invalid number format.", nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts to a Double to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>string.</returns>
	/// <example>
	/// Output: Currency: $555.55, RoundTrip: 555.555, Exponential: 5.555550E+002, FixedPoint: 555.55, General:
	/// 555.555, Number: 555.55, Percent: 55,555.50%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" /> or <see cref="NumericFormat.Hexadecimal" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this double input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.Decimal || format == NumericFormat.Hexadecimal)
		{
			ExceptionThrower.ThrowArgumentInvalidException("Invalid number format.", nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts a Long to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>string.</returns>
	/// <example>
	/// Output: Currency: $4,611,686,018,427,387.00, Decimal: 4611686018427387, Exponential: 4.611686E+015
	/// FixedPoint: 4611686018427387.00, General: 4611686018427387, Hexadecimal: 10624DD2F1A9FB Number:
	/// 4,611,686,018,427,387.00, Percent: 461,168,601,842,738,700.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this long input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException("Invalid number format.", nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts a ULong to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>string.</returns>
	/// <example>
	/// Output: Currency: $9,223,372,036,854.00, Decimal: 9223372036854, Exponential: 9.223372E+012 FixedPoint:
	/// 9223372036854.00, General: 9223372036854, Hexadecimal: 8637BD05AF6 Number: 9,223,372,036,854.00, Percent:
	/// 922,337,203,685,400.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this ulong input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException("Invalid number format.", nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts a UInt to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>string.</returns>
	/// <example>
	/// Output: Currency: $21,474,836.00, Decimal: 21474836, Exponential: 2.147484E+007 FixedPoint: 21474836.00,
	/// General: 21474836, Hexadecimal: 147AE14 Number: 21,474,836.00, Percent: 2,147,483,600.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this uint input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException("Invalid number format.", nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts a Short to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>string.</returns>
	/// <example>
	/// Output: Currency: $32,767.00, Decimal: 32767, Exponential: 3.276700E+004 FixedPoint: 32767.00, General:
	/// 32767, Hexadecimal: 7FFF, Number: 32,767.00 Percent: 3,276,700.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this short input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException("Invalid number format.", nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// Converts a UShort to a formatted string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="format">The format.</param>
	/// <returns>string.</returns>
	/// <example>
	/// Output: Currency: $65,535.00, Decimal: 65535, Exponential: 6.553500E+004, FixedPoint: 65535.00 General:
	/// 65535, Hexadecimal: FFFF, Number: 65,535.00, Percent: 6,553,500.00%.
	/// </example>
	/// <remarks>This method does not support <see cref="NumericFormat.RoundTrip" />.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToFormattedString), "David McCarter", "12/21/2020", UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToFormattedString(this ushort input, NumericFormat format)
	{
		format = format.ArgumentNotNull();

		if (format == NumericFormat.RoundTrip)
		{
			ExceptionThrower.ThrowArgumentInvalidException("Invalid number format.", nameof(format));
		}

		return input.ToString(format.DisplayName, CultureInfo.CurrentCulture);
	}

	/// <summary>
	/// To the positive value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>System.Int32.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToPositiveValue), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static int ToPositiveValue(this int value)
	{
		return value.IsInRange(0, int.MaxValue) ? value : 0;
	}

	/// <summary>
	/// To the positive value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>System.Int64.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToPositiveValue), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static long ToPositiveValue(this long value)
	{
		return value.IsInRange(0, int.MaxValue) ? value : 0;
	}

	/// <summary>
	/// To the positive value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>System.Decimal.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToPositiveValue), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static decimal ToPositiveValue(this decimal value)
	{
		return value.IsInRange(0, int.MaxValue) ? value : 0;
	}

	/// <summary>
	/// Converts to roman numeral using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>string.</returns>
	/// <remarks>Original code from: https://www.c-sharpcorner.com/article/convert-numbers-to-roman-characters-in-c-sharp/</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToRomanNumeral), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static string ToRomanNumeral(this int input)
	{
		var sb = _stringBuilderPool.Get();

		try
		{
			string[] romanLetters = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
			int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

			var index = 0;

			while (input != 0)
			{
				if (input >= numbers[index])
				{
					input -= numbers[index];
					_ = sb.Append(romanLetters[index]);
				}
				else
				{
					index++;
				}
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Parses the number to a string or a default string if outside given range.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <param name="lowerLimit">Lower bound</param>
	/// <param name="upperLimit">Upper bound</param>
	/// <param name="defaultText">Default text</param>
	/// <returns>String</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToStringOrEmpty), UnitTestCoverage = 0, Status = Status.Available)]
	public static string ToStringOrEmpty(this int value, int lowerLimit = 100, int upperLimit = 9000, string defaultText = ControlChars.DoubleQuote)
	{
		return value <= lowerLimit || value > upperLimit
			? defaultText
			: value.ToString(CultureInfo.InvariantCulture);
	}

	/// <summary>
	/// Translate the number in words (English)
	/// </summary>
	/// <param name="value">Number to translate</param>
	/// <returns>String</returns>
	/// <example>
	/// Input: 54928 Output: Fifty-Four Thousand Nine Hundred and Twenty-Eight"
	/// </example>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToWords), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static string ToWords(this int value)
	{
		if (value == 0)
		{
			return Resources.Zero;
		}

		if (value < 0)
		{
			return $"{Resources.Minus}{ControlChars.Space}{ToWords(Math.Abs(value))}";
		}

		var words = string.Empty;

		if ((value / 1000000) > 0)
		{
			words += $"{ToWords(value / 1000000)}{ControlChars.Space}{Resources.Million}{ControlChars.Space}";
			value %= 1000000;
		}

		if ((value / 1000) > 0)
		{
			words += $"{ToWords(value / 1000)}{ControlChars.Space}{Resources.Thousand}{ControlChars.Space}";
			value %= 1000;
		}

		if ((value / 100) > 0)
		{
			words += $"{ToWords(value / 100)}{ControlChars.Space}{Resources.Hundred}{ControlChars.Space}";
			value %= 100;
		}

		if (value > 0)
		{
			if (string.IsNullOrEmpty(words) is false)
			{
				words += $"{Resources.AndLowerCase}{ControlChars.Space}";
			}

			var units = new[]
			{
				Resources.Zero,
				Resources.One,
				Resources.Two,
				Resources.Three,
				Resources.Four,
				Resources.Five,
				Resources.Six,
				Resources.Seven,
				Resources.Eight,
				Resources.Nine,
				Resources.Ten,
				Resources.Eleven,
				Resources.Twelve,
				Resources.Thirteen,
				Resources.Fourteen,
				Resources.Fifteen,
				Resources.Sixteen,
				Resources.Seventeen,
				Resources.Eighteen,
				Resources.Nineteen
			};

			var tens = new[]
			{
				Resources.Zero,
				Resources.Ten,
				Resources.Twenty,
				Resources.Thirty,
				Resources.Forty,
				Resources.Fifty,
				Resources.Sixty,
				Resources.Seventy,
				Resources.Eighty,
				Resources.Ninety
			};

			if (value < 20)
			{
				words += units[value];
			}
			else
			{
				words += tens[value / 10];

				if ((value % 10) > 0)
				{
					words += $"{ControlChars.Dash}{units[value % 10]}";
				}
			}
		}

		return words;
	}
}
