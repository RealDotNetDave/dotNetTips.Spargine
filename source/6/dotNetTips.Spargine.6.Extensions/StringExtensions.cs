// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 11-09-2022
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary>Common String Extensions.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Common String Extensions.
/// </summary>
public static class StringExtensions
{
	/// <summary>
	/// Returns 0.
	/// </summary>
	private const int Zero = 0;

	/// <summary>
	/// The credit card number reg ex
	/// </summary>
	private static readonly Regex _creditCardNumberRegEx = new(Resources.RegexCreditCard, RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.Compiled);

	/// <summary>
	/// The currency code reg ex
	/// </summary>
	private static readonly Regex _currencyCodeRegEx = new(Resources.RegexCurrencyCode, RegexOptions.Compiled | RegexOptions.Singleline);

	/// <summary>
	/// The domain address reg ex
	/// </summary>
	private static readonly Regex _domainAddressRegEx = new(Resources.RegexDomain, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);

	/// <summary>
	/// The email reg ex
	/// </summary>
	private static readonly Regex _emailRegEx = new(Resources.RegexEmail, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);

	/// <summary>
	/// The first last name reg ex
	/// </summary>
	private static readonly Regex _firstLastNameRegEx = new(
		Resources.RegexFirstLastName,
		RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);

	/// <summary>
	/// The is unique identifier regex
	/// </summary>
	private static readonly Regex _guidRegEx = new(
		@"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$",
		RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.Singleline);

	/// <summary>
	/// The isbn reg ex
	/// </summary>
	private static readonly Regex _isbnRegEx = new(
		Resources.RegexISBN,
		RegexOptions.Compiled | RegexOptions.Singleline);

	/// <summary>
	/// The is mac address regex
	/// </summary>
	private static readonly Regex _macAddressRegEx = new("^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	/// <summary>
	/// The one to7 alpha
	/// </summary>
	private static readonly Regex _oneTo7Alpha = new(
		Resources.RegexOneToSevenAlpha,
		RegexOptions.Compiled | RegexOptions.Singleline);

	/// <summary>
	/// The remove cr lf reg ex
	/// </summary>
	private static readonly Regex _removeCrLfRegEx = new(
		@"[\r\n]+",
		RegexOptions.IgnoreCase | RegexOptions.Compiled);

	/// <summary>
	/// The sciencetific reg ex
	/// </summary>
	private static readonly Regex _sciencetificRegEx = new(
		Resources.RegexScientific,
		RegexOptions.Compiled | RegexOptions.Singleline);

	/// <summary>
	/// The sha1 hash reg ex
	/// </summary>
	private static readonly Regex _sha1HashRegEx = new(pattern: @"\b([a-fA-F0-9]{40})\b", RegexOptions.Compiled | RegexOptions.Singleline);

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// The string reg ex
	/// </summary>
	private static readonly Regex _stringRegEx = new(
		Resources.RegexString,
		RegexOptions.IgnoreCase | RegexOptions.Compiled);

	/// <summary>
	/// The URL reg ex
	/// </summary>
	private static readonly Regex _urlRegEx = new(
		Resources.RegexUrl,
		RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline);

	/// <summary>
	/// Creates a hash of the input string.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="hash">The hash.</param>
	/// <returns>System.Byte[].</returns>
	private static byte[] GetHash(string input, HashType hash)
	{
		var inputBytes = Encoding.ASCII.GetBytes(input);

		switch (hash)
		{
			case HashType.SHA256:
				{
					return SHA256.HashData(inputBytes);
				}
			case HashType.SHA384:
				{
					return SHA384.HashData(inputBytes);
				}
			case HashType.SHA512:
				{
					return SHA512.HashData(inputBytes);
				}
			default:
				break;
		}

		return Array.Empty<byte>();
	}

	/// <summary>
	/// Computes a hash from the string.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="hashType">Type of the hash.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
	[Information(nameof(ComputeHash), "David McCarter", "10/8/2020", "1/9/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static string ComputeHash(this string input, HashType hashType = HashType.SHA256)
	{
		input = input.ArgumentNotNullOrEmpty();

		var hash = GetHash(input, hashType);

		var sb = _stringBuilderPool.Get();

		try
		{
			for (var charIndex = 0; charIndex < hash.Length; charIndex++)
			{
				_ = sb.Append(hash[charIndex].ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString().ToTrimmed();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Computes the SHA256Hash.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The data.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
	[Information(nameof(ComputeSHA256Hash), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static string ComputeSHA256Hash(this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		// Create a SHA256
		// ComputeHash - returns byte array
		var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));

		// Convert byte array to a string
		return bytes.BytesToString();
	}

	/// <summary>
	/// Concatenates the specified first message with passed in string[].
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The first message.</param>
	/// <param name="delimiter">The delimiter.</param>
	/// <param name="addLineFeed">The add line feed. If set to true, delimiter will not be used.</param>
	/// <param name="args">The arguments.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
	[Information(nameof(Concat), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static string Concat(this string input, string delimiter, Tristate addLineFeed, params string[] args)
	{
		input = input.ArgumentNotNullOrEmpty();
		delimiter = delimiter.DefaultIfNull(ControlChars.DefaultSeparator);

		var sb = _stringBuilderPool.Get();

		try
		{
			sb = sb.Append(input);

			if (args.HasItems())
			{
				for (var argIndex = 0; argIndex < args.Length; argIndex++)
				{
					var value = args[argIndex];

					//TODO: ADD EXTENSION METHOD TO TEST FOR ENUM VALUES
					_ = addLineFeed is Tristate.True or Tristate.UseDefault
						? sb.AppendLine(value)
						: sb.Append(string.Concat(value, delimiter));
				}
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Determines whether the specified the string contains any of the supplied characters.
	/// </summary>
	/// <param name="input">The string.</param>
	/// <param name="stringComparison">The string comparison.</param>
	/// <param name="characters">The characters.</param>
	/// <returns><c>true</c> if the specified characters contains any; otherwise, <c>false</c>.</returns>
	[Information(nameof(ContainsAny), "David McCarter", "9/15/2017", "2/9/2021", UnitTestCoverage = 100, Status = Status.Available)]
	public static bool ContainsAny(this string input, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase, [NotNull] params string[] characters)
	{
		if (characters.CheckItemsExists() is false)
		{
			return false;
		}

		input = input.ArgumentNotNullOrEmpty();
		stringComparison = stringComparison.ArgumentDefined();

		return characters.Length != 0 && characters.FastAny(character => input.Contains(character, stringComparison));
	}

	/// <summary>
	/// Defaults to an empty string if the string is null.
	/// </summary>
	/// <param name="value">The string input.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static string DefaultIfNull(this string value)
	{
		return value ?? string.Empty;
	}

	/// <summary>
	/// Defaults to empty string if string is null.
	/// </summary>
	/// <param name="value">The string input.</param>
	/// <param name="defaultValue">The default value that will be returned if the string is null.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static string DefaultIfNull(this string value, string defaultValue)
	{
		return value ?? defaultValue ?? string.Empty;
	}

	/// <summary>
	/// Defaults to value if string is null or empty.
	/// Validates that <paramref name="defaultValue" /> is not null or empty.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <param name="defaultValue">The default value.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DefaultIfNullOrEmpty), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static string DefaultIfNullOrEmpty([AllowNull] this string value, string defaultValue)
	{
		defaultValue = defaultValue.ArgumentNotNullOrEmpty();

		return string.IsNullOrEmpty(value) ? defaultValue : value;
	}

	/// <summary>
	/// Turns a delimited string to a array of strings. Removed empty entries.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The delimited input.</param>
	/// <param name="delimiter">The delimiter.</param>
	/// <returns>System.String[].</returns>
	/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
	[Information(nameof(DelimitedStringToArray), "David McCarter", "8/13/2020", "8/13/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static string[] DelimitedStringToArray(this string input, char delimiter = ControlChars.Comma)
	{
		input = input.ArgumentNotNullOrEmpty();

		return input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
	}

	/// <summary>
	/// Determines if the two strings are equal while ignoring case.
	/// Validates that <paramref name="input" /> and <paramref name="inputToCompare" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="inputToCompare">The value to compare.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EqualsIgnoreCase), "David McCarter", "7/15/2020", "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool EqualsIgnoreCase(this string input, string inputToCompare)
	{
		input = input.ArgumentNotNullOrEmpty();
		inputToCompare = inputToCompare.ArgumentNotNullOrEmpty();

		return string.Equals(input, inputToCompare, StringComparison.OrdinalIgnoreCase);
	}

	/// <summary>
	/// Determines if the two strings are null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="inputToCompare">The value to compare.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(EqualsOrBothNullOrEmpty), "David McCarter", "7/15/2020", "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool EqualsOrBothNullOrEmpty(this string input, string inputToCompare)
	{
		return string.Equals(input ?? string.Empty, inputToCompare ?? string.Empty, StringComparison.Ordinal);
	}

	/// <summary>
	/// Extracts a string from a beginning and end value.
	/// Validates that <paramref name="input" />, <paramref name="start" />,
	/// and <paramref name="end" /> is not null or empty.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <param name="start">The start.</param>
	/// <param name="end">The end.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(Extract), "David McCarter", "10/8/2020", "2/9/2021", UnitTestCoverage = 100, Status = Status.Available)]
	public static string Extract(this string input, string start, string end)
	{
		input = input.ArgumentNotNullOrEmpty();
		start = start.ArgumentNotNullOrEmpty();
		end = end.ArgumentNotNullOrEmpty();

		var startIndex = input.IndexOf(start, StringComparison.Ordinal);
		var endIndex = input.IndexOf(end, StringComparison.Ordinal);

		return input[startIndex..endIndex];
	}

	/// <summary>
	/// Converts Base64 string, to string.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(FromBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string FromBase64(this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		var encoding = new ASCIIEncoding();
		return encoding.GetString(Convert.FromBase64String(input));
	}

	/// <summary>
	/// Converts a Brotli compressed string as an asynchronous operation.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>Uncompressed string.</returns>
	/// <remarks>Original code from: https://khalidabuhakmeh.com/compress-strings-with-dotnet-and-csharp</remarks>
	[Information(nameof(FromBrotliStringAsync), "David McCarter", "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> FromBrotliStringAsync(this string value)
	{
		var input = new MemoryStream(Convert.FromBase64String(value));

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new BrotliStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output).ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Converts a deflate compressed string as an asynchronous operation.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>A Task&lt;string&gt; representing the asynchronous operation.</returns>
	[Information(nameof(FromDeflateStringAsync), "David McCarter", "9/12/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public static async Task<string> FromDeflateStringAsync(this string value)
	{
		var bytes = Convert.FromBase64String(value);
		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new DeflateStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output).ConfigureAwait(false);
							await stream.FlushAsync().ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Converts a gzip compressed string as an asynchronous operation.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>Uncompressed string.</returns>
	/// <remarks>Original code from: https://khalidabuhakmeh.com/compress-strings-with-dotnet-and-csharp</remarks>
	[Information(nameof(FromGZipStringAsync), "David McCarter", "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> FromGZipStringAsync(this string value)
	{
		var bytes = Convert.FromBase64String(value);
		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new GZipStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output).ConfigureAwait(false);
							await stream.FlushAsync().ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Converts a zlib compressed string as an asynchronous operation.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>A Task&lt;string&gt; representing the asynchronous operation.</returns>
	[Information(nameof(FromZLibStringAsync), "David McCarter", "9/12/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
	public static async Task<string> FromZLibStringAsync(this string value)
	{
		var bytes = Convert.FromBase64String(value);
		var input = new MemoryStream(bytes);

		await using (input.ConfigureAwait(false))
		{
			using (var output = new MemoryStream())
			{
				await using (output.ConfigureAwait(false))
				{
					using (var stream = new ZLibStream(input, CompressionMode.Decompress))
					{
						await using (stream.ConfigureAwait(false))
						{
							await stream.CopyToAsync(output).ConfigureAwait(false);
							await stream.FlushAsync().ConfigureAwait(false);

							return Encoding.Unicode.GetString(output.ToArray());
						}
					}
				}
			}
		}
	}

	/// <summary>
	/// Determines whether the specified input has a value.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input has value; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasValue(this string input)
	{
		return input is not null && (input.Trim().Length > 0);
	}

	/// <summary>
	/// Determines whether the specified string length has value. Minimum length = 1.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="length">Checks for specific length of the string.</param>
	/// <returns><c>true</c> if the specified length has value; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Minimum length must be greater than 0.</exception>
	[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasValue(this string input, int length)
	{
		input = input.ArgumentNotNullOrEmpty();
		length = length.ArgumentInRange(lower: 1, upper: length);

		return input is not null && (input.Trim().Length == length);
	}

	/// <summary>
	/// Determines whether the specified string has the given value.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="value">Checks for a specific value.</param>
	/// <returns><c>true</c> if the specified value has value; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentInvalidException">Input cannot be null.</exception>
	[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasValue(this string input, string value)
	{
		return input.HasValue() && string.Equals(input, value, StringComparison.Ordinal);
	}

	/// <summary>
	/// Determines whether the specified expression has value based on a regular expression.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="expression">The expression.</param>
	/// <param name="options">The options.</param>
	/// <returns><c>true</c> if the specified expression has value; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasValue(this string input, string expression, RegexOptions options)
	{
		return input.HasValue() && expression.HasValue() && new Regex(expression, options).IsMatch(input);
	}

	/// <summary>
	/// Determines whether the strings is within the specified minimum and maximum length.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="minLength">The minimum length.</param>
	/// <param name="maxLength">The maximum length.</param>
	/// <returns><c>true</c> if the specified minimum length has value; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">Minimum length must be greater than 0.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Maximum length must be greater than Minimum length.</exception>
	[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool HasValue(this string input, int minLength, int maxLength)
	{
		input = input.ArgumentNotNullOrEmpty();
		minLength = minLength.ArgumentInRange(lower: 0, upper: maxLength);
		maxLength = maxLength.ArgumentInRange(lower: minLength, upper: int.MaxValue);

		return input is not null && input.Length.IsInRange(minLength, maxLength);
	}

	/// <summary>
	/// Determines whether the specified input is whitespace.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is whitespace; otherwise, <c>false</c>.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool HasWhitespace(this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		for (var inputIndex = 0; inputIndex < input.Length; inputIndex++)
		{
			if (!IsAsciiWhitespace(input[inputIndex]))
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// Indents the string by the specified length.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The string.</param>
	/// <param name="length">The length.</param>
	/// <param name="indentationCharacter">The indentation character.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentInvalidException">Input cannot be null or empty.</exception>
	/// <exception cref="InvalidCastException">Length must be greater a positive value.</exception>
	[Information(nameof(Indent), UnitTestCoverage = 100, Status = Status.Available)]
	public static string Indent([NotNull] this string input, int length, char indentationCharacter)
	{
		var sb = _stringBuilderPool.Get();

		try
		{
			if (length == 0)
			{
				_ = sb.Append(input);
			}

			for (var charIndex = 1; charIndex <= Math.Abs(length); charIndex++)
			{
				_ = sb.Append(indentationCharacter);
			}

			if (length > 0)
			{
				_ = sb.Append(input);
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Determines whether the specified character is digit.
	/// </summary>
	/// <param name="character">The character.</param>
	/// <returns>bool.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsAsciiDigit), author: "David McCarter", createdOn: "6/10/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsAsciiDigit(this char character)
	{
		return char.IsDigit(character);
	}

	/// <summary>
	/// Determines whether the input is ASCII letter.
	/// </summary>
	/// <param name="character">The character.</param>
	/// <returns><c>true</c> if [is ASCII letter] [the specified character]; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsAsciiLetter), author: "David McCarter", createdOn: "7/30/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsAsciiLetter(this char character)
	{
		return char.IsLetter(character);
	}

	/// <summary>
	/// Determines whether the input is ASCII letter or digit.
	/// </summary>
	/// <param name="character">The character.</param>
	/// <returns><c>true</c> if [is ASCII letter or digit] [the specified character]; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsAsciiLetterOrDigit), author: "David McCarter", createdOn: "7/30/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsAsciiLetterOrDigit(this char character)
	{
		return char.IsLetterOrDigit(character);
	}

	/// <summary>
	/// Determines whether the specified character is whitespace.
	/// </summary>
	/// <param name="character">The character.</param>
	/// <returns>bool.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsAsciiWhitespace), author: "David McCarter", createdOn: "6/10/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsAsciiWhitespace(this char character)
	{
		return char.IsWhiteSpace(character);
	}

	/// <summary>
	/// Determines whether the input is credit card number.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if [is credit card] [the specified input]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsCreditCardNumber), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsCreditCardNumber(this string input)
	{
		return _creditCardNumberRegEx.IsMatch(input);
	}

	/// <summary>
	/// Determines whether input is a code [3 letters ].
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>bool.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsCurrencyCode), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "ADD URL")]
	public static bool IsCurrencyCode(this string input)
	{
		return _currencyCodeRegEx.IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is a domain address.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if [is domain address] [the specified input]; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsDomainAddress), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsDomainAddress(this string input)
	{
		return _domainAddressRegEx.IsMatch(input);
	}

	/// <summary>
	/// Determines whether the input is and email address.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if [i ins email address] [the specified input]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsEmailAddress), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsEmailAddress(this string input)
	{
		return _emailRegEx.IsMatch(input);
	}

#nullable enable
	/// <summary>
	/// Determines whether the specified input is null or empty.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is empty; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsEmpty), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Updated, UnitTestCoverage = 100)]
	public static bool IsEmpty([NotNullWhen(false)] this string? input)
	{
		return string.IsNullOrEmpty(input);
	}
#nullable disable

	/// <summary>
	/// Determines whether the input contains a first and last name.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if [is first last name] [the specified input]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsFirstLastName), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsFirstLastName(this string input)
	{
		return _firstLastNameRegEx.IsMatch(input);
	}

	/// <summary>
	/// Determines whether the specified value is unique identifier.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <returns><c>true</c> if the specified value is unique identifier; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsGuid), "David McCarter", "3/24/2017", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsGuid(this string input)
	{
		return _guidRegEx.IsMatch(input);
	}

	/// <summary>
	/// Determines whether the specified input is an ISBN.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is ISBN; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsISBN), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsISBN(this string input)
	{
		return _isbnRegEx.IsMatch(input);
	}

	/// <summary>
	/// Determines whether [is mac address] [the specified value].
	/// </summary>
	/// <param name="input">The value.</param>
	/// <returns><c>true</c> if [is mac address] [the specified value]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsMacAddress), "David McCarter", "3/24/2017", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsMacAddress(this string input)
	{
		return _macAddressRegEx.IsMatch(input);
	}

#nullable enable
	/// <summary>
	/// Determines whether specified input is not empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if [is not empty] [the specified input]; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsNotEmpty), "David McCarter", "8/18/20", Status = Status.Updated, UnitTestCoverage = 100)]
	public static bool IsNotEmpty([NotNullWhen(false)] this string? input)
	{
		return input.IsEmpty() == false;
	}
#nullable disable

	/// <summary>
	/// Determines whether input is one to seven alpha characters.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>bool.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(IsOneToSevenAlpha), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "ADD URL")]
	public static bool IsOneToSevenAlpha(this string input)
	{
		return _oneTo7Alpha.IsMatch(input);
	}

	/// <summary>
	/// Determines whether the specified input is a scientific value.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is scientific; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsScientific), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsScientific(this string input)
	{
		return _sciencetificRegEx.IsMatch(input);
	}

	/// <summary>
	/// Determines whether the specified input is a valid string value.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is string; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsString), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsString(this string input)
	{
		return _stringRegEx.IsMatch(input);
	}

	/// <summary>
	/// Check that the string is a valid SHA-1 hash with regex
	/// </summary>
	/// <param name="input">Input hash to check</param>
	/// <returns>Boolean representing if the input is valid or not</returns>
	/// <remarks>Original Code By: Troy Hunt</remarks>
	[Information(nameof(IsStringSHA1Hash), "David McCarter", "5/31/2021", UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsStringSHA1Hash(this string input)
	{
		return _sha1HashRegEx.IsMatch(input);
	}

	/// <summary>
	/// Determines whether the specified input is an URL.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is URL; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsUrl), UnitTestCoverage = 100, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJan2022")]
	public static bool IsUrl(this string input)
	{
		return _urlRegEx.Match(input).Success;
	}

	/// <summary>
	/// Removes the CR/LF from the end of a <see cref="string" />.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="replacement">The replacement.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(RemoveCRLF), "Kristine Tran", "2/1/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Updated, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static string RemoveCRLF(this string input, [NotNull] string replacement = "")
	{
		input = input.ArgumentNotNullOrEmpty();

		return _removeCrLfRegEx.Replace(input, replacement);
	}

	/// <summary>
	/// Changes the trailing ellipsis in a string to a period.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ReplaceEllipsisWithPeriod), UnitTestCoverage = 100, Status = Status.Available)]
	public static string ReplaceEllipsisWithPeriod(this string input)
	{
		input = input.ArgumentNotNullOrEmpty(true);

		if (input.EndsWith("...", StringComparison.OrdinalIgnoreCase))
		{
			input = input[0..^2];
		}

		return input;
	}

	/// <summary>
	/// Splits the string based on the separator with options.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <param name="options">The options.</param>
	/// <param name="separator">The separator.</param>
	/// <returns>System.String[].</returns>
	/// <exception cref="ArgumentInvalidException">Input cannot be <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Options are invalid.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string[] Split(this string input, StringSplitOptions options, char separator = ControlChars.Comma)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined(nameof(options));

		return input.Split(new[] { separator }, options);
	}

	/// <summary>
	/// Splits the string based on the separator with options.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <param name="options">The options.</param>
	/// <param name="count">The count.</param>
	/// <param name="separator">The separator.</param>
	/// <returns>System.String[].</returns>
	/// <exception cref="ArgumentInvalidException">Input cannot be <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Options are invalid.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Count must be greater than 1.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string[] Split(this string input, StringSplitOptions options, int count, char separator = ControlChars.Comma)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined(nameof(options));
		count = count.ArgumentInRange(lower: 1);

		return input.Split(new[] { separator }, count, options);
	}

	/// <summary>
	/// Splits the string based on the separator.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <param name="options">The options.</param>
	/// <param name="count">The count.</param>
	/// <param name="separator">The separator.</param>
	/// <returns>System.String[].</returns>
	/// <exception cref="ArgumentInvalidException">input cannot be <see langword="null" />.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Options are invalid.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Count must be greater than 1.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string[] Split(this string input, StringSplitOptions options, int count, [NotNull] string separator = ControlChars.DefaultSeparator)
	{
		input = input.ArgumentNotNullOrEmpty();
		options = options.ArgumentDefined(nameof(options));
		count = count.ArgumentInRange(lower: 1);

		return input.Split(new[] { separator }, count, options);
	}

	/// <summary>
	/// Splits the lines of text into separate lines.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The string.</param>
	/// <returns>DotNetTips.Spargine.Extensions.LineSplitEnumerator.</returns>
	[Information(nameof(SplitLines), "David McCarter", "6/9/2022", UnitTestCoverage = 100, Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, Documentation = "ADD URL")]
	public static LineSplitEnumerator SplitLines(this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		// LineSplitEnumerator is a struct so there is no allocation here
		return new LineSplitEnumerator(input.AsSpan());
	}

	/// <summary>
	/// Splits the specified input using ',' and removes empty entries.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>IEnumerable&lt;System.String&gt;.</returns>
	/// <exception cref="ArgumentInvalidException">input string cannot be null.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(SplitRemoveEmpty), UnitTestCoverage = 100, Status = Status.Available)]
	public static IEnumerable<string> SplitRemoveEmpty(this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		return input.Trim().Split(new char[] { ControlChars.Comma }, options: StringSplitOptions.RemoveEmptyEntries);
	}

	/// <summary>
	/// Determines if the input starts with ordinal.
	/// Validates that <paramref name="input" /> and <paramref name="inputToCompare" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="inputToCompare">The value to compare.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool StartsWithOrdinal(this string input, string inputToCompare)
	{
		input = input.ArgumentNotNullOrEmpty();
		inputToCompare = inputToCompare.ArgumentNotNullOrEmpty();

		return string.Compare(input, 0, inputToCompare, 0, inputToCompare.Length, StringComparison.Ordinal) == Zero;
	}

	/// <summary>
	/// Determines if the input starts the with ordinal while ignoring case.
	/// Validates that <paramref name="input" /> and <paramref name="inputToCompare" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="inputToCompare">The value to compare.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool StartsWithOrdinalIgnoreCase(this string input, string inputToCompare)
	{
		input = input.ArgumentNotNullOrEmpty();
		inputToCompare = inputToCompare.ArgumentNotNullOrEmpty();

		return string.Compare(input, 0, inputToCompare, 0, inputToCompare.Length, StringComparison.OrdinalIgnoreCase) == Zero;
	}

	/// <summary>
	/// Substrings the trim.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="startIndex">The start index.</param>
	/// <param name="length">The length.</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentOutOfRangeException">startIndex - startIndex + length must be less than or equal to  value.Length</exception>
	/// <exception cref="ArgumentOutOfRangeException">startIndex length must be less than or
	/// equal to value.Length</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string SubstringTrim(this string input, int startIndex, int length)
	{
		input = input.ArgumentNotNullOrEmpty();

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
			ExceptionThrower.ThrowArgumentOutOfRangeException("startIndex + length must be <= value.Length", nameof(startIndex));
		}

		if (length == 0)
		{
			return string.Empty;
		}

		var endIndex = startIndex + length - 1;

		while ((startIndex <= endIndex) && char.IsWhiteSpace(input[startIndex]))
		{
			startIndex++;
		}

		while ((endIndex >= startIndex) && char.IsWhiteSpace(input[endIndex]))
		{
			endIndex--;
		}

		var newLength = endIndex - startIndex + 1;

		var condition = newLength == input.Length ? input : input.Substring(startIndex, newLength);

		return newLength == 0 ? string.Empty : condition;
	}

	/// <summary>
	/// Converts string to Base64 string.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ToBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string ToBase64(this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		return Convert.ToBase64String(new ASCIIEncoding().GetBytes(input));
	}

	/// <summary>
	/// Converts the input to a Brotli compressed string as an asynchronous operation.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <param name="level">The level.</param>
	/// <returns>Compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: iw2AZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAA==
	/// NoCompression: iw2AZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAA==
	/// Optimal: iw0A+I+UrMG9dHJoJzwdrIKg1dYDoCSJKErYXLOsvkcYAw==
	/// SmallestSize: iw0A+I+UrMG9dHJoJzwdrIKg1dYDoCSJKErYXLOsvkcYAw==
	/// </example>
	[Information(nameof(ToBrotliStringAsync), "David McCarter", "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToBrotliStringAsync(this string input, CompressionLevel level = CompressionLevel.Fastest)
	{
		var inputStream = new MemoryStream(Encoding.Unicode.GetBytes(input));

		await using (inputStream.ConfigureAwait(continueOnCapturedContext: false))
		{
			var outputStream = new MemoryStream();

			await using (outputStream.ConfigureAwait(continueOnCapturedContext: false))
			{
				var brotliStream = new BrotliStream(outputStream, level);

				await using (brotliStream.ConfigureAwait(continueOnCapturedContext: false))
				{
					await inputStream.CopyToAsync(brotliStream).ConfigureAwait(continueOnCapturedContext: false);
					await brotliStream.FlushAsync().ConfigureAwait(continueOnCapturedContext: false);

					return Convert.ToBase64String(outputStream.ToArray());
				}
			}
		}
	}

	/// <summary>
	/// To compresses string as deflate as an asynchronous operation.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="level">The level.</param>
	/// <returns>A Task&lt;System.String&gt; representing the asynchronous operation.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: SmHIZyhh8GNIZShhCGHIZChgKGbQY0hmyGfIZQAAAAD//w==
	/// NoCompression: ABwA4/9kAG8AdABOAGUAdABUAGkAcABzAC4AYwBvAG0AAAAA//8=
	/// Optimal: SmHIZyhh8GNIBZIhDJkMBQzFDHoMyUDRXAYAAAAA//8=
	/// SmallestSize: SmHIZyhh8GNIBZIhDJkMBQzFDHoMyUDRXAYAAAAA//8=
	/// </example>
	[Information(nameof(ToDeflateStringAsync), "David McCarter", "9/12/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToDeflateStringAsync(this string input, CompressionLevel level = CompressionLevel.Fastest)
	{
		var bytes = Encoding.Unicode.GetBytes(input);

		var inputStream = new MemoryStream(bytes);

		await using (inputStream.ConfigureAwait(false))
		{
			var outputStream = new MemoryStream();

			await using (outputStream.ConfigureAwait(false))
			{
				var stream = new DeflateStream(outputStream, level);

				await using (stream.ConfigureAwait(false))
				{
					await inputStream.CopyToAsync(stream).ConfigureAwait(false);
					await stream.FlushAsync().ConfigureAwait(false);

					return Convert.ToBase64String(outputStream.ToArray());
				}
			}
		}
	}

	/// <summary>
	/// To compresses string to gzip as an asynchronous operation.
	/// </summary>
	/// <param name="input">The value.</param>
	/// <param name="level">The level.</param>
	/// <returns>Compressed string.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: H4sIAAAAAAAECkphyGcoYfBjSGUoYQhhyGQoYChm0GNIZshnyGUAAAAA//8=
	/// NoCompression: H4sIAAAAAAAECgAcAOP/ZABvAHQATgBlAHQAVABpAHAAcwAuAGMAbwBtAAAAAP//
	/// Optimal: H4sIAAAAAAAACkphyGcoYfBjSAWSIQyZDAUMxQx6DMlA0VwGAAAAAP//
	/// SmallestSize: H4sIAAAAAAACCkphyGcoYfBjSAWSIQyZDAUMxQx6DMlA0VwGAAAAAP/
	/// </example>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(ToGZipStringAsync), "David McCarter", "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToGZipStringAsync(this string input, CompressionLevel level = CompressionLevel.Fastest)
	{
		var bytes = Encoding.Unicode.GetBytes(input);

		var inputStream = new MemoryStream(bytes);

		await using (inputStream.ConfigureAwait(false))
		{
			var outputStream = new MemoryStream();

			await using (outputStream.ConfigureAwait(false))
			{
				var stream = new GZipStream(outputStream, level);

				await using (stream.ConfigureAwait(false))
				{
					await inputStream.CopyToAsync(stream).ConfigureAwait(false);
					await stream.FlushAsync().ConfigureAwait(false);

					return Convert.ToBase64String(outputStream.ToArray());
				}
			}
		}
	}

	/// <summary>
	/// Converts to a string to title case.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The source.</param>
	/// <returns>System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(Extract), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static string ToTitleCase(this string input)
	{
		if (input.IsNullOrEmpty())
		{
			return input;
		}

		return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
	}

	/// <summary>
	/// Trims the beginning and end of a string.
	/// Validates that <paramref name="input" /> is not null or empty.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns>Trimmed System.String.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(ToTrimmed), UnitTestCoverage = 100, Status = Status.Available)]
	public static string ToTrimmed(this string input)
	{
		if (input.IsNullOrEmpty())
		{
			return input;
		}

		return input.TrimEnd().TrimStart();
	}

	/// <summary>
	/// To compresses string as zlib as an asynchronous operation.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="level">The level.</param>
	/// <returns>A Task&lt;System.String&gt; representing the asynchronous operation.</returns>
	/// <example>
	/// Input: "dotNetTips.com"
	/// Output
	/// Fastest: eAFKYchnKGHwY0hlKGEIYchkKGAoZtBjSGbIZ8hlAAAAAP//
	/// NoCompression: eAEAHADj/2QAbwB0AE4AZQB0AFQAaQBwAHMALgBjAG8AbQAAAAD//w==
	/// Optimal: eJxKYchnKGHwY0gFkiEMmQwFDMUMegzJQNFcBgAAAAD//w==
	/// SmallestSize: eNpKYchnKGHwY0gFkiEMmQwFDMUMegzJQNFcBgAAAAD//w==
	/// </example>
	[Information(nameof(ToZLibStringAsync), "David McCarter", "9/12/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static async Task<string> ToZLibStringAsync(this string input, CompressionLevel level = CompressionLevel.Fastest)
	{
		var bytes = Encoding.Unicode.GetBytes(input);

		var inputStream = new MemoryStream(bytes);

		await using (inputStream.ConfigureAwait(false))
		{
			var outputStream = new MemoryStream();

			await using (outputStream.ConfigureAwait(false))
			{
				var stream = new ZLibStream(outputStream, level);

				await using (stream.ConfigureAwait(false))
				{
					await inputStream.CopyToAsync(stream).ConfigureAwait(false);
					await stream.FlushAsync().ConfigureAwait(false);

					return Convert.ToBase64String(outputStream.ToArray());
				}
			}
		}
	}
}
