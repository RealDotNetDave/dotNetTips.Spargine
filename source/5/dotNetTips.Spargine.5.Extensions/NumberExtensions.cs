// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 10-05-2020
// ***********************************************************************
// <copyright file="NumberExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions.Properties;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Class IntegerExtensions.
    /// </summary>
    public static class NumberExtensions
    {
        /// <summary>
        /// Decrement a number ensuring it never passes a given lower-bound.
        /// </summary>
        /// <param name="value">Number to process</param>
        /// <param name="lowerBound">Lower bound</param>
        /// <param name="step">Step of the decrement</param>
        /// <returns>Integer</returns>
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
        public static int EnsureMinimumValue(this int value, int minValue)
        {
            return value < minValue ? minValue : value;
        }

        /// <summary>
        /// Formats the number to size string.
        /// </summary>
        /// <param name="fileSize">Size of the file.</param>
        /// <returns>System.String.</returns>
        public static string FormatSizeToString(this long fileSize)
        {
            long size = 0;

            while (fileSize > 1024 && size < 4)
            {
                fileSize = Convert.ToInt64(fileSize / 1024);
                size += 1;
            }

            return $"{fileSize} { ( new string[] { Resources.Bytes, Resources.KB, Resources.MB, Resources.GB } )[Convert.ToInt32(size)] }";
        }

        /// <summary>
        /// Increment a number ensuring it never passes a given upper-bound.
        /// </summary>
        /// <param name="value">Number to process</param>
        /// <param name="upperBound">Upper bound</param>
        /// <param name="step">Step of the increment</param>
        /// <returns>Integer</returns>
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
        public static bool IsEven(this int value) => ( value % 2 ) == 0;

        /// <summary>
        /// Indicate whether the number falls in the specified range.
        /// </summary>
        /// <param name="value">Number to process</param>
        /// <param name="lower">Lower bound</param>
        /// <param name="upper">Upper bound</param>
        /// <returns>True/False</returns>
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
        public static bool IsInRange(this decimal value, decimal lower, decimal upper)
        {
            return value >= lower && value <= upper;
        }

        /// <summary>
        /// Determines whether [is in range throws exception] [the specified value].
        /// Throws Exception if invalid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="lower">The lower.</param>
        /// <param name="upper">The upper.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <returns>System.Boolean.</returns>
        [Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", modifiedOn: "10/5/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsInRangeThrowsException(this long value, long lower, long upper, string paramName)
        {
            if (value.IsInRange(lower, upper) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
            }

            return true;
        }

        /// <summary>
        /// Determines whether [is in range throws exception] [the specified value].
        /// Throws Exception if invalid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="lower">The lower.</param>
        /// <param name="upper">The upper.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <returns>System.Boolean.</returns>
        [Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", modifiedOn: "10/5/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsInRangeThrowsException(this double value, double lower, double upper, string paramName)
        {
            if (value.IsInRange(lower, upper) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
            }

            return true;
        }

        /// <summary>
        /// Determines whether [is in range throws exception] [the specified value].
        /// Throws Exception if invalid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="lower">The lower.</param>
        /// <param name="upper">The upper.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <returns>System.Boolean.</returns>
        [Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", modifiedOn: "10/5/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsInRangeThrowsException(this decimal value, decimal lower, decimal upper, string paramName)
        {
            if (value.IsInRange(lower, upper) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
            }

            return true;
        }

        /// <summary>
        /// Determines whether [is in range] [the specified lower] and will throw Exception if false.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="lower">The lower.</param>
        /// <param name="upper">The upper.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <returns>
        ///   <c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsInRangeThrowsException), author: "David McCarter", createdOn: "10/5/2020", modifiedOn: "10/5/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsInRangeThrowsException(this int value, int lower, int upper, string paramName)
        {
            if (value.IsInRange(lower, upper) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(paramName);
            }

            return true;
        }

        /// <summary>
        /// Determines if the Integer is of the specified interval. E.g. if the interval is 100 and
        /// the integer is 400, it would return true. This function uses the Mod operator, for the
        /// above example: (300 Mod 100 = 0)
        /// </summary>
        /// <param name="value">The number.</param>
        /// <param name="interval">The interval.</param>
        /// <returns><c>true</c> if the specified number is interval; otherwise, <c>false</c>.</returns>
        public static bool IsInterval(this int value, int interval)
        {
            return value % interval == 0 ? true : false;
        }

        /// <summary>
        /// Determines whether [is interval throws exception] [the specified value] and throws Exception
        /// if invalid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <returns>System.Boolean.</returns>
        [Information(nameof(IsIntervalThrowsException), author: "David McCarter", createdOn: "10/5/2020", modifiedOn: "10/5/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsIntervalThrowsException(this int value, int interval, string paramName)
        {
            if (value.IsInterval(interval) == false)
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
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsNegative(this double value)
        {
            return Math.Sign(value) == -1;
        }

        /// <summary>
        /// Determines whether the specified value is negative.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsNegative(this int value)
        {
            return Math.Sign(value) == -1;
        }

        /// <summary>
        /// Determines whether the specified value is negative.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsNegative(this long value)
        {
            return Math.Sign(value) == -1;
        }

        /// <summary>
        /// Determines whether the specified value is negative.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsNegative(this sbyte value)
        {
            return Math.Sign(value) == -1;
        }

        /// <summary>
        /// Determines whether the specified value is negative.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsNegative(this short value)
        {
            return Math.Sign(value) == -1;
        }

        /// <summary>
        /// Determines whether the specified value is negative.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsNegative(this decimal value)
        {
            return Math.Sign(value) == -1;
        }

        /// <summary>
        /// Determines whether the specified value is negative.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if the specified value is negative; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsNegative(this float value)
        {
            return Math.Sign(value) == -1;
        }

        /// <summary>
        /// Noes the duplicates.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>System.Int32().</returns>
        /// <remarks>Code by: Kevin S Gallagher</remarks>
        public static IEnumerable<int> RemoveDuplicates(this int[] values) => values.Distinct().AsEnumerable();

        /// <summary>
        /// Returns the nearest power of 2 that is bigger than the number.
        /// </summary>
        /// <param name="value">Number to process</param>
        /// <returns>Integer</returns>
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
        /// To the positive value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        public static int ToPositiveValue(this int value)
        {
            return value.IsInRange(0, int.MaxValue) ? value : 0;
        }

        /// <summary>
        /// To the positive value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int64.</returns>
        public static long ToPositiveValue(this long value)
        {
            return value.IsInRange(0, int.MaxValue) ? value : 0;
        }

        /// <summary>
        /// To the positive value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal ToPositiveValue(this decimal value)
        {
            return value.IsInRange(0, int.MaxValue) ? value : 0;
        }

        /// <summary>
        /// Parse the number to a string or a default string if outside given range.
        /// </summary>
        /// <param name="value">Number to process</param>
        /// <param name="lowerLimit">Lower bound</param>
        /// <param name="upperLimit">Upper bound</param>
        /// <param name="defaultText">Default text</param>
        /// <returns>String</returns>
        public static string ToStringOrEmpty(this int value, int lowerLimit = 0, int upperLimit = 9000, string defaultText = "")
        {
            if (value <= lowerLimit || value > upperLimit)
            {
                return defaultText;
            }
            else
            {
                return value.ToString(CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Translate the number in words (English)
        /// </summary>
        /// <param name="value">Number to translate</param>
        /// <returns>String</returns>
        public static string ToWords(this int value)
        {
            if (value == 0)
            {
                return "Zero";
            }

            if (value < 0)
            {
                return "Minus " + ToWords(Math.Abs(value));
            }

            var words = string.Empty;

            if (( value / 1000000 ) > 0)
            {
                words += ToWords(value / 1000000) + " million ";
                value %= 1000000;
            }

            if (( value / 1000 ) > 0)
            {
                words += ToWords(value / 1000) + " Thousand ";
                value %= 1000;
            }

            if (( value / 100 ) > 0)
            {
                words += ToWords(value / 100) + " Hundred ";
                value %= 100;
            }

            if (value > 0)
            {
                if (string.IsNullOrEmpty(words) == false)
                {
                    words += "and ";
                }

                var units = new[]
                {
                    "Zero",
                    "One",
                    "Two",
                    "Three",
                    "Four",
                    "Five",
                    "Six",
                    "Seven",
                    "Eight",
                    "Nine",
                    "Ten",
                    "Eleven",
                    "Twelve",
                    "Thirteen",
                    "Fourteen",
                    "Fifteen",
                    "Sixteen",
                    "Seventeen",
                    "Eighteen",
                    "Nineteen"
                };
                var tens = new[]
                {
                "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
                };

                if (value < 20)
                {
                    words += units[value];
                }
                else
                {
                    words += tens[value / 10];

                    if (( value % 10 ) > 0)
                    {
                        words += "-" + units[value % 10];
                    }
                }
            }

            return words;
        }
    }
}
