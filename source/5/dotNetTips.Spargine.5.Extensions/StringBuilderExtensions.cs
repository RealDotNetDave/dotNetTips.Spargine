// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 05-11-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-21-2021
// ***********************************************************************
// <copyright file="StringBuilderExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>StringBuilder Extensions.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// StringBuilder Extensions.
	/// </summary>
	[Information(nameof(StringBuilderExtensions), "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
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
		public static void AppendBytes(this StringBuilder sb, byte[] bytes)
		{
			Validate.TryValidateNullParam(sb, nameof(sb));
			Validate.TryValidateParam(bytes, nameof(bytes));

			sb.Append("'0x");

			for (var i = 0; i < bytes.Length; i++)
			{
				sb.Append(bytes[i].ToString("X2", CultureInfo.InvariantCulture));
			}

			sb.Append('\'');
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
		public static void AppendKeyValue(this StringBuilder sb, string key, string value, Tristate includeQuotes = Tristate.True, Tristate includeComma = Tristate.True)
		{
			Validate.TryValidateNullParam(sb, nameof(sb));
			Validate.TryValidateParam(key, nameof(key));
			Validate.TryValidateParam(value, nameof(value));

			sb.Append(key);
			sb.Append(ControlChars.Equal);

			if (includeQuotes == Tristate.True || includeQuotes == Tristate.UseDefault)
			{
				sb.Append(ControlChars.Quote);
				var lastSpecialIndex = 0;
				int specialIndex;

				while (true)
				{
					specialIndex = value.IndexOfAny(_specialCharacters, lastSpecialIndex);

					if (specialIndex >= 0)
					{
						//TODO: THIS CONDITION NOT BEING TESTED FOR APPEND
						sb.Append(value, lastSpecialIndex, specialIndex - lastSpecialIndex);
						sb.Append(ControlChars.Backslash);
						sb.Append(value[specialIndex]);
						lastSpecialIndex = specialIndex + 1;
					}
					else
					{
						sb.Append(value, lastSpecialIndex, value.Length - lastSpecialIndex);
						break;
					}
				}
				sb.Append(ControlChars.Quote);
			}
			else
			{
				//TODO: THIS CONDITION NOT BEING TESTED
				sb.Append(value);
			}

			if (includeComma == Tristate.True || includeComma == Tristate.UseDefault)
			{
				sb.Append(ControlChars.DefaultSeparator);
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
		public static void AppendValues(this StringBuilder sb, string separator, IEnumerable<string> values)
		{
			Validate.TryValidateNullParam(sb, nameof(sb));
			Validate.TryValidateParam(values, nameof(values));

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
		[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static void AppendValues(this StringBuilder sb, string separator, params string[] values)
		{
			Validate.TryValidateNullParam(sb, nameof(sb));
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
		public static void AppendValues<T>(this StringBuilder sb, string separator, IEnumerable<T> values, Action<T> joinAction)
		{
			Validate.TryValidateNullParam(sb, nameof(sb));
			Validate.TryValidateParam(values, nameof(values));
			Validate.TryValidateNullParam(joinAction, nameof(joinAction));

			separator = SetSeparator(separator);

			var appended = false;

			foreach (var value in values)
			{
				joinAction(value);
				sb.Append(separator);
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
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentNullException">values</exception>
		/// <exception cref="ArgumentNullException">param</exception>
		/// <exception cref="ArgumentNullException">joinAction</exception>
		/// <exception cref="ArgumentNullException">sb</exception>
		/// <exception cref="ArgumentNullException">values</exception>
		/// <exception cref="ArgumentNullException">param</exception>
		[Information("Original code from efcore-master on GitHub", "David McCarter", "5/26/2020", "7/29/2020", UnitTestCoverage = 0, Status = Status.NotUsed)]
		public static void AppendValues<T, TParam>(this StringBuilder sb, string separator, IEnumerable<T> values, TParam param, Action<T, TParam> joinAction)
		{
			Validate.TryValidateNullParam(sb, nameof(sb));
			Validate.TryValidateParam(values, nameof(values));
			Validate.TryValidateNullParam(param, nameof(param));
			Validate.TryValidateNullParam(joinAction, nameof(joinAction));

			separator = SetSeparator(separator);

			var appended = false;

			foreach (var value in values)
			{
				joinAction(value, param);
				sb.Append(separator);
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
		public static void AppendValues<T, TParam1, TParam2>(this StringBuilder sb, string separator, IEnumerable<T> values, TParam1 param1, TParam2 param2, Action<StringBuilder, T, TParam1, TParam2> joinAction)
		{
			Validate.TryValidateNullParam(sb, nameof(sb));
			Validate.TryValidateParam(values, nameof(values));
			Validate.TryValidateNullParam(param1, nameof(param1));
			Validate.TryValidateNullParam(param2, nameof(param2));
			Validate.TryValidateNullParam(joinAction, nameof(joinAction));

			separator = SetSeparator(separator);

			var appended = false;

			foreach (var value in values)
			{
				joinAction(sb, value, param1, param2);
				sb.Append(separator);
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
