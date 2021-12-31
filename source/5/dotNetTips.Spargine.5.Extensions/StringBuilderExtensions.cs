// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 09-01-2021
// ***********************************************************************
// <copyright file="StringBuilderExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>StringBuilder Extensions.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// StringBuilder Extensions.
	/// </summary>
	[Information(nameof(StringBuilderExtensions), "David McCarter", "5/26/2020", "7/29/2020", Status = Status.Available)]
	public static class StringBuilderExtensions
	{
		/// <summary>
		/// The special characters
		/// </summary>
		private static readonly char[] _specialCharacters = new[] { '"', '\\' };

		/// <summary>
		/// Appends the bytes.
		/// </summary>
		/// <param name="sb">The builder.</param>
		/// <param name="bytes">The bytes.</param>
		/// <exception cref="ArgumentNullException">StringBuilder cannot be null.</exception>
		/// <exception cref="ArgumentNullException">Byte collection is null or empty.</exception>
		/// <example>
		///   <code>
		/// var sb = new StringBuilder();
		/// var byteArray = RandomData.GenerateByteArray(5);
		/// sb.AppendBytes(byteArray)
		/// </code>
		/// </example>
		[Information("Original code from efcore-master on GitHub", author: "David McCarter", createdOn: "5/26/2020", modifiedOn: "11/17/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static void AppendBytes([NotNull] this StringBuilder sb, [NotNull] byte[] bytes)
		{
			_ = sb.Append("'0x");

			for (var i = 0; i < bytes.Length; i++)
			{
				_ = sb.Append(bytes[i].ToString("X2", CultureInfo.InvariantCulture));
			}

			_ = sb.Append('\'');
		}

		/// <summary>
		/// Appends the key value.
		/// </summary>
		/// <param name="sb">The sb.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <param name="includeQuotes">if set to <c>true</c> [include quotes].</param>
		/// <param name="includeComma">if set to <c>true</c> [include comma].</param>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentException">key</exception>
		/// <exception cref="ArgumentException">value</exception>
		/// <exception cref="ArgumentException">sb</exception>
		[Information("FROM .NET CORE SOURCE", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 99, Status = Status.Available)]
		public static void AppendKeyValue([NotNull] this StringBuilder sb, [NotNull] string key, [NotNull] string value, Tristate includeQuotes = Tristate.True, Tristate includeComma = Tristate.True)
		{
			_ = sb.Append(key);
			_ = sb.Append(ControlChars.Equal);

			if (includeQuotes is Tristate.True or Tristate.UseDefault)
			{
				_ = sb.Append(ControlChars.Quote);
				var lastSpecialIndex = 0;
				int specialIndex;

				while (true)
				{
					specialIndex = value.IndexOfAny(_specialCharacters, lastSpecialIndex);

					if (specialIndex >= 0)
					{
						//TODO: THIS CONDITION NOT BEING TESTED FOR APPEND
						_ = sb.Append(value, lastSpecialIndex, specialIndex - lastSpecialIndex);
						_ = sb.Append(ControlChars.Backslash);
						_ = sb.Append(value[specialIndex]);
						lastSpecialIndex = specialIndex + 1;
					}
					else
					{
						_ = sb.Append(value, lastSpecialIndex, value.Length - lastSpecialIndex);
						break;
					}
				}
				_ = sb.Append(ControlChars.Quote);
			}
			else
			{
				//TODO: THIS CONDITION NOT BEING TESTED
				_ = sb.Append(value);
			}

			if (includeComma is Tristate.True or Tristate.UseDefault)
			{
				_ = sb.Append(ControlChars.DefaultSeparator);
			}
		}

		/// <summary>
		/// Appends the values.
		/// </summary>
		/// <param name="sb">The string builder.</param>
		/// <param name="separator">The separator.</param>
		/// <param name="values">The values.</param>
		/// <returns>StringBuilder.</returns>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentNullException">values</exception>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <example>
		///   <code>
		/// var sb = new StringBuilder();
		/// var values = RandomData.GenerateWords(5, 5, 7);
		/// sb.AppendValues(",", values);
		/// </code>
		/// </example>
		[Information("Original code from efcore-master on GitHub.", author: "David McCarter", createdOn: "7/1/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static void AppendValues([NotNull] this StringBuilder sb, [NotNull] string separator, [NotNull] IEnumerable<string> values)
		{
			separator = SetSeparator(separator);

			sb.AppendValues(separator, values, (value) => sb.Append(value));
		}

		/// <summary>
		/// Appends the values.
		/// </summary>
		/// <param name="sb">The string builder.</param>
		/// <param name="separator">The separator.</param>
		/// <param name="values">The values.</param>
		/// <returns>StringBuilder.</returns>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentException">values</exception>
		[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static void AppendValues([NotNull] this StringBuilder sb, string separator, [NotNull] params string[] values)
		{
			Validate.TryValidateParam(values, nameof(values));

			separator = SetSeparator(separator);

			sb.AppendValues(separator, values, (value) => sb.Append(value));
		}

		/// <summary>
		/// Appends the values
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="sb">The string builder.</param>
		/// <param name="separator">The separator.</param>
		/// <param name="values">The values.</param>
		/// <param name="joinAction">The join action.</param>
		/// <returns>StringBuilder.</returns>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentNullException">values</exception>
		/// <exception cref="ArgumentNullException">joinAction</exception>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentNullException">values</exception>
		[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static void AppendValues<T>([NotNull] this StringBuilder sb, string separator, IEnumerable<T> values, [NotNull] Action<T> joinAction)
		{
			Validate.TryValidateParam(values, nameof(values));

			separator = SetSeparator(separator);

			var appended = false;

			foreach (var value in values)
			{
				joinAction(value);
				_ = sb.Append(separator);
				appended = true;
			}

			if (appended)
			{
				sb.Length -= separator.Length;
			}
		}

		/// <summary>
		/// Appends the values.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <typeparam name="TParam">The type of the t parameter.</typeparam>
		/// <param name="sb">The string builder.</param>
		/// <param name="separator">The separator.</param>
		/// <param name="values">The values.</param>
		/// <param name="param">The parameter.</param>
		/// <param name="joinAction">The join action.</param>
		/// <returns>StringBuilder.</returns>
		[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.NotUsed)]
		public static void AppendValues<T, TParam>([NotNull] this StringBuilder sb, string separator, [NotNull] IEnumerable<T> values, [NotNull] TParam param, [NotNull] Action<T, TParam> joinAction)
		{
			separator = SetSeparator(separator);

			var appended = false;

			foreach (var value in values)
			{
				joinAction(value, param);
				_ = sb.Append(separator);
				appended = true;
			}

			if (appended)
			{
				sb.Length -= separator.Length;
			}
		}

		/// <summary>
		/// Appends the values.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <typeparam name="TParam1">The type of the t param1.</typeparam>
		/// <typeparam name="TParam2">The type of the t param2.</typeparam>
		/// <param name="sb">The string builder.</param>
		/// <param name="separator">The separator.</param>
		/// <param name="values">The values.</param>
		/// <param name="param1">The param1.</param>
		/// <param name="param2">The param2.</param>
		/// <param name="joinAction">The join action.</param>
		/// <returns>StringBuilder.</returns>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentNullException">values</exception>
		/// <exception cref="ArgumentNullException">param1</exception>
		/// <exception cref="ArgumentNullException">param2</exception>
		/// <exception cref="ArgumentNullException">joinAction</exception>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentNullException">values</exception>
		/// <exception cref="ArgumentNullException">param1</exception>
		/// <exception cref="ArgumentNullException">param2</exception>
		[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.NotUsed)]
		public static void AppendValues<T, TParam1, TParam2>([NotNull] this StringBuilder sb, string separator, [NotNull] IEnumerable<T> values, [NotNull] TParam1 param1, [NotNull] TParam2 param2, [NotNull] Action<StringBuilder, T, TParam1, TParam2> joinAction)
		{
			separator = SetSeparator(separator);

			var appended = false;

			foreach (var value in values)
			{
				joinAction(sb, value, param1, param2);
				_ = sb.Append(separator);
				appended = true;
			}

			if (appended)
			{
				sb.Length -= separator.Length;
			}
		}



		/// <summary>
		/// Sets the separator.
		/// </summary>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String.</returns>
		private static string SetSeparator(string separator)
		{
			if (separator.HasValue() == false)
			{
				//TODO: THIS CONDITION NOT BEING TESTED
				separator = ControlChars.DefaultSeparator;
			}

			return separator;
		}
	}
}
