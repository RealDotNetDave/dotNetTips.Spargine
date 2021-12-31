// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 12-31-2021
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
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Common String Extensions.
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Converts a Brotli compressed string as an asynchronous operation.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>Uncompressed string.</returns>
		/// <remarks>Original code from: https://khalidabuhakmeh.com/compress-strings-with-dotnet-and-csharp</remarks>
		[Information(nameof(FromBrotliStringAsync), "David McCarter", "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		private static async Task<string> FromBrotliStringAsync(string value)
		{
			await using var input = new MemoryStream(Convert.FromBase64String(value));
			await using var output = new MemoryStream();
			await using var stream = new BrotliStream(input, CompressionMode.Decompress);

			await stream.CopyToAsync(output).ConfigureAwait(false);

			return Encoding.Unicode.GetString(output.ToArray());
		}

		/// <summary>
		/// From Gzip compressed string as an asynchronous operation.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>Uncompressed string.</returns>
		/// <remarks>Original code from: https://khalidabuhakmeh.com/compress-strings-with-dotnet-and-csharp</remarks>
		[Information(nameof(FromGZipStringAsync), "David McCarter", "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		private static async Task<string> FromGZipStringAsync(string value)
		{
			var bytes = Convert.FromBase64String(value);
			await using var input = new MemoryStream(bytes);
			await using var output = new MemoryStream();
			await using var stream = new GZipStream(input, CompressionMode.Decompress);

			await stream.CopyToAsync(output).ConfigureAwait(false);
			await stream.FlushAsync().ConfigureAwait(false);

			return Encoding.Unicode.GetString(output.ToArray());
		}

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
				case HashType.MD5:
					{
						using var hasher = MD5.Create();
						return hasher.ComputeHash(inputBytes);
					}
				case HashType.SHA1:
					{
						using var hasher = SHA1.Create();
						return hasher.ComputeHash(inputBytes);
					}
				case HashType.SHA256:
					{
						using var hasher = SHA256.Create();
						return hasher.ComputeHash(inputBytes);
					}
				case HashType.SHA384:
					{
						using var hasher = SHA384.Create();
						return hasher.ComputeHash(inputBytes);
					}
				case HashType.SHA512:
					{
						using var hasher = SHA512.Create();
						return hasher.ComputeHash(inputBytes);
					}
				default:
					break;
			}

			return Array.Empty<byte>();
		}

		/// <summary>
		/// To brotli as an asynchronous operation.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="level">The level.</param>
		/// <returns>Compressed string.</returns>
		[Information(nameof(ToBrotliStringAsync), "David McCarter", "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		private static async Task<string> ToBrotliStringAsync(string value, CompressionLevel level = CompressionLevel.Fastest)
		{
			var bytes = Encoding.Unicode.GetBytes(value);
			await using var input = new MemoryStream(bytes);
			await using var output = new MemoryStream();
			await using var stream = new BrotliStream(output, level);

			await input.CopyToAsync(stream).ConfigureAwait(false);
			await stream.FlushAsync().ConfigureAwait(false);

			return Convert.ToBase64String(output.ToArray());
		}

		/// <summary>
		/// To gzip as an asynchronous operation.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="level">The level.</param>
		/// <returns>Compressed string.</returns>
		[Information(nameof(ToGZipStringAsync), "David McCarter", "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
		private static async Task<string> ToGZipStringAsync(string value, CompressionLevel level = CompressionLevel.Fastest)
		{
			var bytes = Encoding.Unicode.GetBytes(value);
			await using var input = new MemoryStream(bytes);
			await using var output = new MemoryStream();
			await using var stream = new GZipStream(output, level);

			await input.CopyToAsync(stream);

			await stream.FlushAsync()
				;

			return Convert.ToBase64String(output.ToArray());
		}

		/// <summary>
		/// Computes a hash from the string.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="hashType">Type of the hash.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
		[Information(nameof(ComputeHash), "David McCarter", "10/8/2020", "1/9/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static string ComputeHash([NotNull] this string input, HashType hashType = HashType.SHA256)
		{
			var hash = GetHash(input, hashType);

			var sb = new StringBuilder(input.Count());

			for (var charCount = 0; charCount < hash.Length; charCount++)
			{
				_ = sb.Append(hash[charCount].ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString().ToTrimmed();
		}

		/// <summary>
		/// Computes the SHA256Hash.
		/// </summary>
		/// <param name="input">The data.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
		[Information(nameof(ComputeSHA256Hash), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static string ComputeSHA256Hash([NotNull] this string input)
		{
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
		/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
		[Information(nameof(Concat), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static string Concat([NotNull] this string input, string delimiter, Tristate addLineFeed, params string[] args)
		{
			delimiter = delimiter.DefaultIfNull();

			var sb = new StringBuilder(input);

			if (args.HasItems())
			{
				for (var argCount = 0; argCount < args.Length; argCount++)
				{
					var value = args[argCount];

					//TODO: ADD EXTENSION METHOD TO TEST FOR ENUM VALUES
					if (addLineFeed is Tristate.True or Tristate.UseDefault)
					{
						//TODO: THIS CONDITION NOT BEING TESTED
						_ = sb.AppendLine(value);
					}
					else
					{
						_ = sb.Append(string.Concat(value, delimiter));
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
		[Information(nameof(ContainsAny), "David McCarter", "9/15/2017", "2/9/2021", UnitTestCoverage = 100, Status = Status.Available)]
		public static bool ContainsAny([NotNull] this string input, [NotNull] params string[] characters)
		{
			return characters.Length != 0 && characters.FastAny(character =>
			{
				return input.Contains(character);
			});
		}

		/// <summary>
		/// Defaults if the string is null.
		/// </summary>
		/// <param name="value">The s.</param>
		/// <returns>System.String.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static string DefaultIfNull(this string value) => value ?? string.Empty;

		/// <summary>
		/// Defaults to value if string is null.
		/// </summary>
		/// <param name="value">The s.</param>
		/// <param name="defaultValue">The default value.</param>
		/// <returns>System.String.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(DefaultIfNull), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static string DefaultIfNull(this string value, [NotNull] string defaultValue) => value ?? defaultValue ?? string.Empty;

		/// <summary>
		/// Defaults to value if string is null or empty.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="defaultValue">The default value.</param>
		/// <returns>System.String.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(DefaultIfNullOrEmpty), "David McCarter", "9/15/2017", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static string DefaultIfNullOrEmpty(this string value, [NotNull] string defaultValue) => string.IsNullOrEmpty(value) ? defaultValue : value;

		/// <summary>
		/// Turns a delimited string to a array of strings. Removed empty entries.
		/// </summary>
		/// <param name="input">The delimited input.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String[].</returns>
		/// <exception cref="ArgumentInvalidException">input cannot be null.</exception>
		[Information(nameof(DelimitedStringToArray), "David McCarter", "8/13/2020", "8/13/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static string[] DelimitedStringToArray([NotNull] this string input, char delimiter = ControlChars.Comma)
		{
			return input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
		}

		/// <summary>
		/// Determines if the two strings are equal while ignoring case.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="valueToCompare">The value to compare.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(EqualsIgnoreCase), "David McCarter", "7/15/2020", "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool EqualsIgnoreCase([NotNull] this string input, [NotNull] string valueToCompare) => string.Equals(input, valueToCompare, StringComparison.OrdinalIgnoreCase);

		/// <summary>
		/// Determines if the two strings are null or empty.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="valueToCompare">The value to compare.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(EqualsOrBothNullOrEmpty), "David McCarter", "7/15/2020", "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool EqualsOrBothNullOrEmpty(this string input, [NotNull] string valueToCompare) => string.Equals(input ?? string.Empty, valueToCompare ?? string.Empty, StringComparison.Ordinal);

		/// <summary>
		/// Extracts a string from a beginning and end value.
		/// </summary>
		/// <param name="input">The value.</param>
		/// <param name="start">The start.</param>
		/// <param name="end">The end.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(Extract), "David McCarter", "10/8/2020", "2/9/2021", UnitTestCoverage = 100, Status = Status.Available)]
		public static string Extract([NotNull] this string input, [NotNull] string start, [NotNull] string end)
		{
			var i = input.IndexOf(start, StringComparison.Ordinal);
			var j = input.IndexOf(end, StringComparison.Ordinal);

			return input[i..j];
		}

		/// <summary>
		/// Converts Base64 string, to string.
		/// </summary>
		/// <param name="input">The value.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(FromBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string FromBase64([NotNull] this string input)
		{
			var encoding = new ASCIIEncoding();
			return encoding.GetString(Convert.FromBase64String(input));
		}

		/// <summary>
		/// Converts Brotli compressed string to an uncompressed string as an asynchronous operation.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns>Uncompressed string.</returns>
		/// <example>
		/// Original string: C`sk^yOurOCd]KVIXpR]QBf`T
		/// Converted string: ixiAQwBgAHMAawBeAHkATwB1AHIATwBDAGQAXQBLAFYASQBYAHAAUgBdAFEAQgBmAGAAVAA=
		/// </example>
		[Information(nameof(FromBrotliAsync), author: "David McCarter", createdOn: "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static async Task<string> FromBrotliAsync([NotNull] this string input)
		{
			return await FromBrotliStringAsync(input);
		}

		/// <summary>
		/// Converts Gzip compressed string as an asynchronous operation.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns>Unpressed string.</returns>
		[Information(nameof(FromGZipAsync), author: "David McCarter", createdOn: "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static async Task<string> FromGZipAsync([NotNull] this string input)
		{
			return await FromGZipStringAsync(input);
		}

		/// <summary>
		/// Determines whether the specified input has a value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input has value; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool HasValue(this string input) => input is not null && ( input.Trim().Length > 0 );

		/// <summary>
		/// Determines whether the specified string length has value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="length">Checks for specific length of the string.</param>
		/// <returns><c>true</c> if the specified length has value; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Minimum length must be greater than 0.</exception>
		[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool HasValue(this string input, int length)
		{
			Validate.TryValidateParam(length, minimumValue: 1, maximumValue: length, nameof(input));

			return input is not null && ( input.Trim().Length == length );
		}

		/// <summary>
		/// Determines whether the specified string has the given value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="value">Checks for a specific value.</param>
		/// <returns><c>true</c> if the specified value has value; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentInvalidException">Input cannot be null.</exception>
		[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool HasValue(this string input, [NotNull] string value)
		{
			Validate.TryValidateParam(input, nameof(input));

			return input is not null && string.Equals(input.Trim(), value.Trim(), StringComparison.Ordinal);
		}

		/// <summary>
		/// Determines whether the specified expression has value based on a regular expression.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="expression">The expression.</param>
		/// <param name="options">The options.</param>
		/// <returns><c>true</c> if the specified expression has value; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool HasValue(this string input, string expression, RegexOptions options)
		{
			return input.HasValue() && expression.HasValue() && new Regex(expression, options).IsMatch(input);
		}

		/// <summary>
		/// Determines whether the strings is within the specified minimum and maximum length.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="minLength">The minimum length.</param>
		/// <param name="maxLength">The maximum length.</param>
		/// <returns><c>true</c> if the specified minimum length has value; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Minimum length must be greater than 0.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Maximum length must be greater than Minimum length.</exception>
		[Information(nameof(HasValue), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool HasValue(this string input, int minLength, int maxLength)
		{
			Validate.TryValidateParam(minLength, minimumValue: 0, maximumValue: maxLength, nameof(minLength));
			Validate.TryValidateParam(maxLength, minimumValue: minLength, maximumValue: int.MaxValue, nameof(maxLength));

			return input is not null && input.Length.IsInRange(minLength, maxLength);
		}

		/// <summary>
		/// Determines whether the specified input is whitespace.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input is whitespace; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool HasWhitespace([NotNull] this string input)
		{
			for (var i = 0; i < input.Length; i++)
			{
				if (!IsAsciiWhitespace(input[i]))
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Indents the string by the specified length.
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
			Validate.TryValidateParam<ArgumentOutOfRangeException>(length.IsNegative() is false, nameof(length));

			var sb = new StringBuilder(input.Count());

			if (length == 0)
			{
				_ = sb.Append(input);
			}

			for (var charCount = 1; charCount <= Math.Abs(length); charCount++)
			{
				_ = sb.Append(indentationCharacter);
			}

			if (length > 0)
			{
				_ = sb.Append(input);
			}

			return sb.ToString();
		}

		/// <summary>
		/// Determines whether the specified character is digit.
		/// </summary>
		/// <param name="character">The character.</param>
		/// <returns>bool.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(IsAsciiDigit), author: "David McCarter", createdOn: "6/10/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsAsciiDigit(this char character) => char.IsDigit(character);

		/// <summary>
		/// Determines whether the input is ASCII letter.
		/// </summary>
		/// <param name="character">The character.</param>
		/// <returns><c>true</c> if [is ASCII letter] [the specified character]; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(IsAsciiLetter), author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsAsciiLetter(this char character) => char.IsLetter(character);

		/// <summary>
		/// Determines whether the input is ASCII letter or digit.
		/// </summary>
		/// <param name="character">The character.</param>
		/// <returns><c>true</c> if [is ASCII letter or digit] [the specified character]; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(IsAsciiLetterOrDigit), author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "7/30/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsAsciiLetterOrDigit(this char character) => char.IsLetterOrDigit(character);

		/// <summary>
		/// Determines whether the specified character is whitespace.
		/// </summary>
		/// <param name="character">The character.</param>
		/// <returns>bool.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(IsAsciiWhitespace), author: "David McCarter", createdOn: "6/10/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsAsciiWhitespace(this char character) => char.IsWhiteSpace(character);

		/// <summary>
		/// Determines whether the input is credit card number.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if [is credit card] [the specified input]; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsCreditCard), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsCreditCard(this string input) => input.HasValue(Resources.RegexCreditCard, RegexOptions.Compiled); //TODO: CHANGE TO IsCreditCardNumber

		/// <summary>
		/// Determines whether the input is a domain address.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if [is domain address] [the specified input]; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(IsDomainAddress), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsDomainAddress(this string input) => input.HasValue(Resources.RegexDomain, RegexOptions.IgnoreCase | RegexOptions.Compiled);

		/// <summary>
		/// Determines whether the input is and email address.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if [is email address] [the specified input]; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsEmailAddress), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsEmailAddress(this string input) => input.HasValue(Resources.RegexEmail, RegexOptions.IgnoreCase | RegexOptions.Compiled);

		/// <summary>
		/// Determines whether the specified input is null or empty.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input is empty; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(IsEmpty), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 100)]
		public static bool IsEmpty([NotNull] this string input) => input.Length == 0;

		/// <summary>
		/// Determines whether the input contains a first and last name.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if [is first last name] [the specified input]; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsFirstLastName), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsFirstLastName(this string input) => input.HasValue(Resources.RegexFirstLastName, RegexOptions.IgnoreCase | RegexOptions.Compiled);

		/// <summary>
		/// Determines whether the specified value is unique identifier.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if the specified value is unique identifier; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsGuid), "David McCarter", "3/24/2017", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsGuid([NotNull] this string value)
		{
			var reg = new Regex(@"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$", RegexOptions.Compiled);

			return reg.IsMatch(value);
		}

		/// <summary>
		/// Determines whether the specified input is an ISBN.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input is ISBN; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsISBN), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsISBN(this string input) => input.HasValue(Resources.RegexISBN, RegexOptions.Compiled);

		/// <summary>
		/// Determines whether [is mac address] [the specified value].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if [is mac address] [the specified value]; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsMacAddress), "David McCarter", "3/24/2017", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsMacAddress([NotNull] this string value)
		{
			var reg = new Regex("^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$", RegexOptions.Compiled);

			return reg.IsMatch(value);
		}

		/// <summary>
		/// Determines whether specified input is not empty.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if [is not empty] [the specified input]; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(IsEmpty), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 100)]
		public static bool IsNotEmpty(this string input) => input.IsNotNull() && ( input.Length > 0 );

		/// <summary>
		/// Determines whether the specified input is a scientific value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input is scientific; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsScientific), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsScientific(this string input) => input.HasValue(Resources.RegexScientific, RegexOptions.Compiled);

		/// <summary>
		/// Determines whether the specified input is a valid string value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input is string; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsString), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsString(this string input) => input.HasValue(Resources.RegexString, RegexOptions.IgnoreCase | RegexOptions.Compiled);

		/// <summary>
		/// Check that the string is a valid SHA-1 hash with regex
		/// </summary>
		/// <param name="input">Input hash to check</param>
		/// <returns>Boolean representing if the input is valid or not</returns>
		/// <remarks>Original Code By: Troy Hunt</remarks>
		[Information(nameof(IsStringSHA1Hash), "David McCarter", "5/31/2021", UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsStringSHA1Hash([NotNull] this string input)
		{
			//TODO: CHANGE TO ISSHA1HASH
			return Regex.Match(input, pattern: @"\b([a-fA-F0-9]{40})\b").Length > 0;
		}

		/// <summary>
		/// Determines whether the specified input is an URL.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input is URL; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsUrl), UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static bool IsUrl(this string input) => input.HasValue(Resources.RegexUrl, RegexOptions.IgnoreCase | RegexOptions.Compiled);

		/// <summary>
		/// Removes the CR/LF from the end of a <see cref="string" />.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="replacement">The replacement.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(RemoveCRLF), "Kristine Tran", "2/1/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
		public static string RemoveCRLF([NotNull] this string input, [NotNull] string replacement = "")
		{
			return Regex.Replace(input, @"[\r\n]+", replacement, RegexOptions.IgnoreCase | RegexOptions.Compiled);
		}

		/// <summary>
		/// Changes the trailing ellipsis in a string to a period.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(ReplaceEllipsisWithPeriod), UnitTestCoverage = 100, Status = Status.Available)]
		public static string ReplaceEllipsisWithPeriod([NotNull] this string input)
		{
			input = input.ToTrimmed();

			if (input.EndsWith("...", StringComparison.OrdinalIgnoreCase))
			{
				input = input[0..^2];
			}

			return input;
		}

		/// <summary>
		/// Splits the string based on the separator with options.
		/// </summary>
		/// <param name="input">The value.</param>
		/// <param name="options">The options.</param>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String[].</returns>
		/// <exception cref="ArgumentInvalidException">Input cannot be <see langword="null" />.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Options are invalid.</exception>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string[] Split([NotNull] this string input, StringSplitOptions options, char separator = ControlChars.Comma)
		{
			Validate.TryValidateParam(options, nameof(options));

			return input.Split(new[] { separator }, options);
		}

		/// <summary>
		/// Splits the string based on the separator with options.
		/// </summary>
		/// <param name="input">The value.</param>
		/// <param name="options">The options.</param>
		/// <param name="count">The count.</param>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String[].</returns>
		/// <exception cref="ArgumentInvalidException">Input cannot be <see langword="null" />.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Options are invalid.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Count must be greater than 1.</exception>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string[] Split([NotNull] this string input, StringSplitOptions options, int count, char separator = ControlChars.Comma)
		{
			Validate.TryValidateParam(options, nameof(options));
			Validate.TryValidateParam(value: count, minimumValue: 1, paramName: nameof(count));

			return input.Split(new[] { separator }, count, options);
		}

		/// <summary>
		/// Splits the string based on the separator.
		/// </summary>
		/// <param name="input">The value.</param>
		/// <param name="options">The options.</param>
		/// <param name="count">The count.</param>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String[].</returns>
		/// <exception cref="ArgumentInvalidException">input cannot be <see langword="null" />.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Options are invalid.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Count must be greater than 1.</exception>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string[] Split([NotNull] this string input, StringSplitOptions options, int count, [NotNull] string separator = ControlChars.DefaultSeparator)
		{
			Validate.TryValidateParam(options, nameof(options));
			Validate.TryValidateParam(count, 1, paramName: nameof(count));

			return input.Split(new[] { separator }, count, options);
		}

		/// <summary>
		/// Splits the specified input using ',' and removes empty entries.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns>IEnumerable&lt;System.String&gt;.</returns>
		/// <exception cref="ArgumentInvalidException">input string cannot be null.</exception>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(SplitRemoveEmpty), UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<string> SplitRemoveEmpty([NotNull] this string input)
		{
			return input.Trim().Split(new char[] { ControlChars.Comma }, options: StringSplitOptions.RemoveEmptyEntries);
		}

		/// <summary>
		/// Determines if the input starts with ordinal.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="valueToCompare">The value to compare.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool StartsWithOrdinal([NotNull] this string input, [NotNull] string valueToCompare)
		{
			return 0 == string.Compare(input, 0, valueToCompare, 0, valueToCompare.Length, StringComparison.Ordinal);
		}

		/// <summary>
		/// Determines if the input starts the with ordinal while ignoring case.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="valueToCompare">The value to compare.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool StartsWithOrdinalIgnoreCase([NotNull] this string input, [NotNull] string valueToCompare)
		{
			return 0 == string.Compare(input, 0, valueToCompare, 0, valueToCompare.Length, StringComparison.OrdinalIgnoreCase);
		}

		/// <summary>
		/// Substrings the trim.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="startIndex">The start index.</param>
		/// <param name="length">The length.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentOutOfRangeException">startIndex - startIndex + length must be less than or equal to  value.Length</exception>
		/// <exception cref="ArgumentOutOfRangeException">startIndex length must be less than or
		/// equal to value.Length</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string SubstringTrim([NotNull] this string input, int startIndex, int length)
		{
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
				ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(startIndex), "startIndex + length must be <= value.Length");
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

			string condition;
			condition = newLength == input.Length ? input : input.Substring(startIndex, newLength);

			return newLength == 0 ? string.Empty : condition;
		}

		/// <summary>
		/// Converts string to Base64 string.
		/// </summary>
		/// <param name="input">The value.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(ToBase64), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string ToBase64([NotNull] this string input)
		{
			return Convert.ToBase64String(new ASCIIEncoding().GetBytes(input));
		}

		/// <summary>
		/// To Brotli string as an asynchronous operation.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="level">The level.</param>
		/// <returns>Compressed stgring.</returns>
		/// <example>
		/// Original: QGhymbrMHsvbmVfQloPxv`csQ
		/// Compressed: ixgA+I+UrOGddJv/qY/gHm9RiI4kKJAKgJIkpFjhguavOMK3o2xgbX3tCQ==
		/// </example>
		[Information(nameof(ToBrotliAsync), author: "David McCarter", createdOn: "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static async Task<string> ToBrotliAsync([NotNull] this string input, CompressionLevel level = CompressionLevel.Fastest)
		{
			Validate.TryValidateParam(level, nameof(level));

			return await ToBrotliStringAsync(input, level).ConfigureAwait(false);
		}

		/// <summary>
		/// To Gzip string as an asynchronous operation.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="level">The level.</param>
		/// <returns>Compressed string.</returns>
		/// <example>
		/// Original: ^w^vaBlKJ\\bNhvspfHfNTupWG
		/// Compressed: H4sIAAAAAAAECgTBMQqAIAAAwHtbS2HgFLSIoIM0NAiSfd+77JdNxeZ1CpIqekxD1xya6PLpbrsFAAD//w==
		/// </example>
		[Information(nameof(ToGZipAsync), author: "David McCarter", createdOn: "10/24/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static async Task<string> ToGZipAsync([NotNull] this string input, CompressionLevel level = CompressionLevel.Fastest)
		{
			Validate.TryValidateParam(level, nameof(level));

			var result = await ToGZipStringAsync(input, level).ConfigureAwait(false);

			return result;
		}

		/// <summary>
		/// Converts to a string to title case.
		/// </summary>
		/// <param name="input">The source.</param>
		/// <returns>System.String.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(Extract), "David McCarter", "10/8/2020", "10/8/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string ToTitleCase([NotNull] this string input)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
		}


		/// <summary>
		/// Trims the beginning and end of a string.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns>Trimmed System.String.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(ToTrimmed), UnitTestCoverage = 100, Status = Status.Available)]
		public static string ToTrimmed([NotNull] this string input)
		{
			return input.TrimEnd().TrimStart();
		}
	}
}
