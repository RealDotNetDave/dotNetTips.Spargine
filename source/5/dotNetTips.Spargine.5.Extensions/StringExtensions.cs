// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 12-21-2020
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;
using dotNetTips.Spargine.Extensions.Properties;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Common StringExtensions.
    /// </summary>
    public static class StringExtensions
    {

        /// <summary>
        /// Computes a hash from the string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="hashType">Type of the hash.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">'input' cannot be null or empty - input</exception>
        [Information(nameof(ComputeHash), "David McCarter", "10/8/2020", "10/8/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
        public static string ComputeHash(this string input, HashType hashType)
        {
            Encapsulation.TryValidateParam(input, nameof(input));

            var hash = GetHash(input, hashType);
            var sb = new StringBuilder();

            for (var i = 0; i <= hash.Length - 1; i++)
            {
                sb.Append(hash[i].ToString("x2", CultureInfo.InvariantCulture));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Computes the sha256 hash.
        /// </summary>
        /// <param name="input">The data.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(ComputeSHA256Hash), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static string ComputeSHA256Hash(this string input)
        {
            Encapsulation.TryValidateParam(input, nameof(input));

            // Create a SHA256   
            using var sha256Hash = SHA256.Create();
            // ComputeHash - returns byte array  
            var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Convert byte array to a string   
            return bytes.BytesToString();
        }


        /// <summary>
        /// Concatenates the specified first message with passed in string[].
        /// </summary>
        /// <param name="input">The first message.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="addLineFeed">The add line feed. If set to true, delimiter will not be used.</param>
        /// <param name="args">The arguments.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">firstMessage</exception>
        [Information(nameof(Concat), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 99, Status = Status.Available)]
        public static string Concat(this string input, string delimiter, Tristate addLineFeed, params string[] args)
        {
            Encapsulation.TryValidateParam(input, nameof(input));

            if (string.IsNullOrEmpty(delimiter))
            {
                delimiter = string.Empty;
            }

            var sb = new StringBuilder(input);

            if (args.HasItems())
            {
                for (var argCount = 0; argCount < args.Length; argCount++)
                {
                    var value = args[argCount];

                    //TODO: ADD EXTENSION METHOD TO TEST FOR ENUM VALUES
                    if (addLineFeed == Tristate.True || addLineFeed == Tristate.UseDefault)
                    {
                        sb.AppendLine(value);
                    }
                    else
                    {
                        sb.Append(string.Concat(value, delimiter));
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Determines whether the specified the string contains any.
        /// </summary>
        /// <param name="input">The string.</param>
        /// <param name="characters">The characters.</param>
        /// <returns><c>true</c> if the specified characters contains any; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentException">input</exception>
        /// <exception cref="ArgumentNullException">input</exception>
        /// <exception cref="System.ArgumentNullException">input</exception>
        [Information(nameof(ContainsAny), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static bool ContainsAny(this string input, params string[] characters)
        {
            Encapsulation.TryValidateParam(input, nameof(input));

            return characters.FastAny(character =>
            {
                return input.Contains(character);
            });
        }

        /// <summary>
        /// Defaults if null.
        /// </summary>
        /// <param name="value">The s.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static string DefaultIfNull(this string value) => value ?? string.Empty;

        /// <summary>
        /// Defaults if null.
        /// </summary>
        /// <param name="value">The s.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static string DefaultIfNull(this string value, string defaultValue) => value ?? defaultValue ?? string.Empty;

        /// <summary>
        /// Defaults if null or empty.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(DefaultIfNullOrEmpty), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
        public static string DefaultIfNullOrEmpty(this string value, string defaultValue)
        {
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }

        /// <summary>
        /// Turns a delimited string to a string array.
        /// </summary>
        /// <param name="input">The delimited input.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <returns>System.String[].</returns>
        [Information(nameof(DelimitedStringToArray), "David McCarter", "8/13/2020", "8/13/2020", UnitTestCoverage = 99, Status = Status.Available)]
        public static string[] DelimitedStringToArray(this string input, char delimiter = ',')
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            if (delimiter.IsNull())
            {
                delimiter = ControlChars.Comma;
            }

            return input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Equals the ignore case.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information(nameof(EqualsIgnoreCase), "David McCarter", "7/15/2020", "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool EqualsIgnoreCase(this string input, string valueToCompare)
        {
            return string.Equals(input, valueToCompare, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Equals the or both null or empty.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information(nameof(EqualsOrBothNullOrEmpty), "David McCarter", "7/15/2020", "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool EqualsOrBothNullOrEmpty(this string input, string valueToCompare)
        {
            return string.Equals(input ?? string.Empty, valueToCompare ?? string.Empty, StringComparison.Ordinal);
        }

        /// <summary>
        /// Extracts a string from a beginning and end value.
        /// </summary>
        /// <param name="input">The value.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(Extract), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static string Extract(this string input, string start, string end)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                var i = input.IndexOf(start, StringComparison.Ordinal);
                var j = input.IndexOf(end, StringComparison.Ordinal);

                return input.Substring(i, j - i);
            }
        }

        /// <summary>
        /// Converts Base64 string to string.
        /// </summary>
        /// <param name="input">The value.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(FromBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static string FromBase64(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                var encoding = new ASCIIEncoding();
                return encoding.GetString(Convert.FromBase64String(input));
            }
        }

        /// <summary>
        /// Determines whether the specified input has value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input has value; otherwise, <c>false</c>.</returns>
        [Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available)]
        public static bool HasValue(this string input)
        {
            return ( input == null ) ? false : ( input.Trim().Length > 0 );
        }

        /// <summary>
        /// Determines whether the specified length has value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="length">Checks for specific length of the string.</param>
        /// <returns><c>true</c> if the specified length has value; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">length - Minimum length must be greater than 0.</exception>
        [Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available)]
        public static bool HasValue(this string input, int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Minimum length must be greater than 0.");
            }

            return ( input == null ) ? false : ( input.Trim().Length == length );
        }

        /// <summary>
        /// Determines whether the specified value has value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="value">Checks for a specific value.</param>
        /// <returns><c>true</c> if the specified value has value; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentException">value</exception>
        [Information(nameof(HasValue), UnitTestCoverage = 99, Status = Status.Available)]
        public static bool HasValue(this string input, string value)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            return ( input == null ) ? false : ( input.Trim() == value.Trim() );
        }

        /// <summary>
        /// Determines whether the specified expression has value based on a regular expression.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="options">The options.</param>
        /// <returns><c>true</c> if the specified expression has value; otherwise, <c>false</c>.</returns>
        [Information(nameof(HasValue), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool HasValue(this string input, string expression, RegexOptions options)
        {
            if (input.HasValue() && expression.HasValue())
            {
                return new Regex(expression, options).IsMatch(input);
            }

            return false;
        }

        /// <summary>
        /// Determines whether the strings is within the specified minimum and maximum length.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="minLength">The minimum length.</param>
        /// <param name="maxLength">The maximum length.</param>
        /// <returns><c>true</c> if the specified minimum length has value; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">minLength - Minimum length must be greater than 0.</exception>
        [Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available)]
        public static bool HasValue(this string input, int minLength, int maxLength)
        {
            if (minLength.IsInRange(0, int.MaxValue) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(minLength));
            }

            if (maxLength.IsInRange(0, int.MaxValue) == false)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(maxLength));
            }

            return ( input == null ) ? false : input.Length.IsInRange(minLength, maxLength);
        }

        /// <summary>
        /// Indents the specified length.
        /// </summary>
        /// <param name="input">The string.</param>
        /// <param name="length">The length.</param>
        /// <param name="indentationCharacter">The indentation character.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">input</exception>
        /// <exception cref="ArgumentNullException">length</exception>
        [Information(nameof(Indent), UnitTestCoverage = 0, Status = Status.Available)]
        public static string Indent(this string input, int length, char indentationCharacter)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            if (length == 0)
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(length));
            }

            var sb = new StringBuilder();

            if (length < 0)
            {
                sb.Append(input);
            }

            for (var charCount = 1; charCount <= Math.Abs(length); charCount++)
            {
                sb.Append(indentationCharacter);
            }

            if (length > 0)
            {
                sb.Append(input);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Determines whether [is ASCII letter] from [the specified character].
        /// </summary>
        /// <param name="character">The character.</param>
        /// <returns><c>true</c> if [is ASCII letter] [the specified character]; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool IsAsciiLetter(this char character) { return ( ( ( (uint)character ) - 'A' ) & ( ~0x20 ) ) < 26; }

        /// <summary>
        /// Determines whether [is ASCII letter or digit] from [the specified character].
        /// </summary>
        /// <param name="character">The character.</param>
        /// <returns><c>true</c> if [is ASCII letter or digit] [the specified character]; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool IsAsciiLetterOrDigit(this char character)
        { return ( ( ( ( (uint)character ) - 'A' ) & ( ~0x20 ) ) < 26 ) || ( ( (uint)character ) - '0' < 10 ); }

        /// <summary>
        /// Determines whether [is credit card] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is credit card] [the specified input]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsCreditCard), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsCreditCard(this string input)
        {
            return input.HasValue(Resources.RegexCreditCard, RegexOptions.None);
        }

        /// <summary>
        /// Determines whether [is domain address] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is domain address] [the specified input]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsDomainAddress), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsDomainAddress(this string input)
        {
            return input.HasValue(Resources.RegexDomain, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether [is email address] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is email address] [the specified input]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsEmailAddress), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsEmailAddress(this string input)
        {
            return input.HasValue(Resources.RegexEmail, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether the specified input is empty.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is empty; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsEmpty), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 0)]
        public static bool IsEmpty(this string input)
        {
            return ( input.IsNotNull() && ( input.Length == 0 ) ) ? true : false;
        }

        /// <summary>
        /// Determines whether [is first and last name] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is first last name] [the specified input]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsFirstLastName), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsFirstLastName(this string input)
        {
            return input.HasValue(Resources.RegexFirstLastName, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether the specified input is an ISBN.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is ISBN; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsISBN), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsISBN(this string input)
        {
            return input.HasValue(Resources.RegexISBN, RegexOptions.None);
        }

        /// <summary>
        /// Determines whether specified input is not empty.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is not empty] [the specified input]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsEmpty), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 0)]
        public static bool IsNotEmpty(this string input)
        {
            return ( input.IsNotNull() && ( input.Length > 0 ) ) ? true : false;
        }

        /// <summary>
        /// Determines whether the specified input is scientific value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is scientific; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsScientific), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsScientific(this string input)
        {
            return input.HasValue(Resources.RegexScientific, RegexOptions.None);
        }

        /// <summary>
        /// Determines whether the specified input is a valid string value.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is string; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsString), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsString(this string input)
        {
            return input.HasValue(Resources.RegexString, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether the specified input is an URL.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is URL; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsUrl), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsUrl(this string input)
        {
            return input.HasValue(Resources.RegexUrl, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether [is web safe] [the specified input].
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if [is web safe] [the specified input]; otherwise, <c>false</c>.</returns>
        [Information(nameof(IsWebSafe), UnitTestCoverage = 0, Status = Status.Available)]
        public static bool IsWebSafe(this string input)
        {
            return input.HasValue(Resources.RegexStringWebSafe, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Determines whether the specified input is whitespace.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns><c>true</c> if the specified input is whitespace; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool IsWhitespace(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }


            for (var i = 0; i < input.Length; i++)
            {
                if (!IsWhitespace(input[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified character is whitespace.
        /// </summary>
        /// <param name="character">The character.</param>
        /// <returns><c>true</c> if the specified character is whitespace; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool IsWhitespace(this char character)
        {
            return ( character <= ' ' ) && ( ( character == ' ' ) || ( character == '\t' ) || ( character == '\r' ) || ( character == '\n' ) );
        }

        /// <summary>
        /// Changes the trailing ellipsis in a string to a period.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">input</exception>
        [Information(nameof(ReplaceEllipsisWithPeriod), UnitTestCoverage = 0, Status = Status.Available)]
        public static string ReplaceEllipsisWithPeriod(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            input = input.ToTrimmed();

            if (input.EndsWith("...", StringComparison.OrdinalIgnoreCase))
            {
                input = input.Substring(0, input.Length - 2);
            }

            return input;
        }

        /// <summary>
        /// Splits the string.
        /// </summary>
        /// <param name="input">The value.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.String[].</returns>
        /// <exception cref="ArgumentException">value</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static string[] Split(this string input,
                                     char separator,
                                     StringSplitOptions options = StringSplitOptions.None)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            return input.Split(new[] { separator }, options);
        }

        /// <summary>
        /// Splits the string.
        /// </summary>
        /// <param name="input">The value.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.String[].</returns>
        /// <exception cref="ArgumentException">value</exception>
        /// <exception cref="ArgumentException">separator</exception>
        /// <exception cref="ArgumentException">value</exception>
        /// <exception cref="ArgumentException">separator</exception>
        /// <exception cref="ArgumentException">value</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
        public static string[] Split(this string input, string separator, StringSplitOptions options = StringSplitOptions.None)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            if (string.IsNullOrEmpty(separator))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(separator));
            }

            return input.Split(new[] { separator }, options);
        }

        /// <summary>
        /// Splits the string.
        /// </summary>
        /// <param name="input">The value.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="count">The count.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.String[].</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static string[] Split(this string input,
                                     char separator,
                                     int count,
                                     StringSplitOptions options = StringSplitOptions.None)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            return input.Split(new[] { separator }, count, options);
        }

        /// <summary>
        /// Splits the string.
        /// </summary>
        /// <param name="input">The value.</param>
        /// <param name="separator">The separator.</param>
        /// <param name="count">The count.</param>
        /// <param name="options">The options.</param>
        /// <returns>System.String[].</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static string[] Split(this string input,
                                     string separator,
                                     int count,
                                     StringSplitOptions options = StringSplitOptions.None)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            return input.Split(new[] { separator }, count, options);
        }

        /// <summary>
        /// Splits the specified input using ',' and removes empty entries.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>IEnumerable&lt;System.String&gt;.</returns>
        /// <exception cref="ArgumentException">input</exception>
        [Information(nameof(SplitRemoveEmpty), UnitTestCoverage = 0, Status = Status.Available)]
        public static IEnumerable<string> SplitRemoveEmpty(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            return input.Trim().Split(new char[] { ',' }, options: StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Starts the with ordinal.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool StartsWithOrdinal(this string input, string valueToCompare)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(valueToCompare))
            {
                return false;
            }

            return 0 == string.Compare(input, 0, valueToCompare, 0, valueToCompare.Length, StringComparison.Ordinal);
        }

        /// <summary>
        /// Starts the with ordinal ignore case.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool StartsWithOrdinalIgnoreCase(this string input, string valueToCompare)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(valueToCompare))
            {
                return false;
            }

            return 0 == string.Compare(input, 0, valueToCompare, 0, valueToCompare.Length, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Substrings the trim.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="startIndex">The start index.</param>
        /// <param name="length">The length.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentOutOfRangeException">startIndex - startIndex + length must be
        /// less than or equal to the value.Length</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static string SubstringTrim(this string input, int startIndex, int length)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            if (startIndex.IsNegative())
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(startIndex));
            }

            if (length.IsNegative())
            {
                ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(length));
            }

            if (startIndex >= input.Length - length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex + length must be <= value.Length");
            }

            if (length == 0)
            {
                return string.Empty;
            }

            var endIndex = startIndex + length - 1;

            while (( startIndex <= endIndex ) && char.IsWhiteSpace(input[startIndex]))
            {
                startIndex++;
            }

            while (( endIndex >= startIndex ) && char.IsWhiteSpace(input[endIndex]))
            {
                endIndex--;
            }

            var newLength = endIndex - startIndex + 1;

            if (newLength == 0)
            {
                return string.Empty;
            }
            else
            {
                return ( newLength == input.Length ) ? input : input.Substring(startIndex, newLength);
            }
        }

        /// <summary>
        /// Converts string to Base64.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        [Information(nameof(ToBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static string ToBase64(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }
            else
            {
                var encoding = new ASCIIEncoding();
                return Convert.ToBase64String(encoding.GetBytes(value));
            }
        }

        /// <summary>
        /// Converts to title case.
        /// </summary>
        /// <param name="input">The source.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentException">'source' cannot be null or empty - source</exception>
        [Information(nameof(Extract), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
        }

        /// <summary>
        /// Trims the beginning and end of a string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>Trimmed System.String.</returns>
        /// <exception cref="ArgumentException">input</exception>
        [Information(nameof(ToTrimmed), UnitTestCoverage = 0, Status = Status.Available)]
        public static string ToTrimmed(this string input)
        {
            //TODO: ADD OVERLOADED METHOD TO TRIM CHARS TO RIGHT.
            if (string.IsNullOrEmpty(input))
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(input));
            }

            return input.TrimEnd().TrimStart();
        }

        /// <summary>
        /// Gets the hash.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="hash">The hash.</param>
        /// <returns>System.Byte[].</returns>
        private static byte[] GetHash(string input, HashType hash)
        {
            var inputBytes = Encoding.ASCII.GetBytes(input);

            switch (hash)
            {
                case HashType.MD5:
                    return MD5.Create().ComputeHash(inputBytes);
                case HashType.SHA1:
                    return SHA1.Create().ComputeHash(inputBytes);
                case HashType.SHA256:
                    return SHA256.Create().ComputeHash(inputBytes);
                case HashType.SHA384:
                    return SHA384.Create().ComputeHash(inputBytes);
                case HashType.SHA512:
                    return SHA512.Create().ComputeHash(inputBytes);
                default:
                    return inputBytes;
            }
        }

    }
}
