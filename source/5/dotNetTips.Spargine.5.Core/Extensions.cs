﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="Extensions.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using dotNetTips.Spargine.Core.Properties;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Extension methods.
	/// </summary>
	internal static class Extensions
	{
		/// <summary>
		/// Adds the item as the first item in array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">list or item</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static void AddFirst<T>([NotNull] this IList<T> list, [NotNull] T item)
		{
			if (list.IsReadOnly)
			{
				ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
			}

			list.Insert(index: 0, item);
		}

		/// <summary>
		/// Adds if not exists.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">list - List cannot be null. or value - Value cannot be null.</exception>
		/// <exception cref="ArgumentException">list - List cannot be null. or value - Value cannot be null.</exception>
		/// <exception cref="ArgumentNullException">list - List cannot be read-only.</exception>
		/// <exception cref="ArgumentException">list - List cannot be null. or value - Value cannot be null.</exception>
		public static bool AddIfNotExists<T>([NotNull] this ICollection<T> list, [NotNull] T item)
		{
			if (list.IsReadOnly)
			{
				ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
			}

			if (list.Contains(item))
			{
				return false;
			}

			list.Add(item);
			return true;
		}

		/// <summary>
		/// Adds item the last item in the array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">list or item</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static void AddLast<T>([NotNull] this IList<T> list, [NotNull] T item)
		{
			if (list.IsReadOnly)
			{
				ExceptionThrower.ThrowArgumentReadOnlyCollectionException(nameof(list));
			}

			list.Insert(list.Count, item);
		}

		/// <summary>
		/// As the specified value.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj">The value.</param>
		/// <returns>T.</returns>
		internal static T As<T>([NotNull] this object obj)
		{
			return (T)obj;
		}

		/// <summary>
		/// Counts the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">list</exception>
		internal static int Count([NotNull] this IEnumerable list)
		{
			if (list is ICollection collection)
			{
				return collection.Count;
			}

			var count = 0;

			var enumerator = list.GetEnumerator();

			while (enumerator.MoveNext())
			{
				count++;
			}

			return count;
		}

		/// <summary>
		/// Hierarchy.
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="nextItem">The next item.</param>
		/// <returns>IEnumerable&lt;TSource&gt;.</returns>
		internal static IEnumerable<TSource> FromHierarchy<TSource>([NotNull] this TSource source, [NotNull] Func<TSource, TSource> nextItem) where TSource : Exception
		{
			return FromHierarchy(source, nextItem, s => s is not null);
		}

		/// <summary>
		/// Hierarchy.
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="nextItem">The next item.</param>
		/// <param name="canContinue">The can continue.</param>
		/// <returns>IEnumerable&lt;TSource&gt;.</returns>
		/// <exception cref="ArgumentNullException">canContinue</exception>
		/// <exception cref="ArgumentNullException">nextItem</exception>
		/// <exception cref="ArgumentNullException">canContinue or nextItem</exception>
		internal static IEnumerable<TSource> FromHierarchy<TSource>([NotNull] this TSource source, [NotNull] Func<TSource, TSource> nextItem, [NotNull] Func<TSource, bool> canContinue)
			where TSource : Exception
		{
			for (var current = source; canContinue(current); current = nextItem(current))
			{
				yield return current;
			}
		}

		/// <summary>
		/// Gets all Exception messages.
		/// </summary>
		/// <param name="exception">The exception.</param>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">exception</exception>
		internal static string GetAllMessages([NotNull] this Exception exception, char separator = ControlChars.Comma)
		{
			var messages = exception.FromHierarchy(ex => ex.InnerException).Select(ex => ex.Message);

			return string.Join(separator, messages);
		}

		/// <summary>
		/// Gets all properties.
		/// </summary>
		/// <param name="type">The type.</param>
		/// <returns>IEnumerable&lt;PropertyInfo&gt;.</returns>
		[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020")]
		internal static IEnumerable<PropertyInfo> GetAllProperties([NotNull] this Type type)
		{
			var typeInfo = type.GetTypeInfo();

			while (typeInfo is not null)
			{
				foreach (var propertyInfo in typeInfo.DeclaredProperties)
				{
					yield return propertyInfo;
				}

				typeInfo = typeInfo.BaseType?.GetTypeInfo();
			}
		}

		/// <summary>
		/// Determines whether the specified input has value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input has value; otherwise, <c>false</c>.</returns>
		internal static bool HasValue([NotNull] this string input) => input.Trim().Length > 0;

		/// <summary>
		/// Determines whether the specified length has value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="length">Checks for specific length of the string.</param>
		/// <returns><c>true</c> if the specified length has value; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentOutOfRangeException">length - Minimum length must be greater than 0.</exception>
		internal static bool HasValue([NotNull] this string input, int length)
		{
			Validate.TryValidateParam(input, minimumLength: 0, maximumLength: int.MaxValue, paramName: nameof(input));
			Validate.TryValidateParam(length, minimumValue: 1, paramName: nameof(length));

			return input is not null && ( input.Trim().Length == length );
		}

		/// <summary>
		/// Determines whether the specified value has value.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="value">Checks for a specific value.</param>
		/// <returns><c>true</c> if the specified value has value; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentException">value</exception>
		internal static bool HasValue([NotNull] this string input, [NotNull] string value)
		{
			return string.Equals(input.Trim(), value.Trim(), StringComparison.Ordinal);
		}

		/// <summary>
		/// Determines whether the specified expression has value based on a regular expression.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="expression">The expression.</param>
		/// <param name="options">The options.</param>
		/// <returns><c>true</c> if the specified expression has value; otherwise, <c>false</c>.</returns>
		internal static bool HasValue([NotNull] this string input, [NotNull] string expression, [NotNull] RegexOptions options)
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
		/// <exception cref="ArgumentOutOfRangeException">Min Length  or Max Length must be greater than 0.</exception>
		internal static bool HasValue([NotNull] this string input, int minLength, int maxLength)
		{
			Validate.TryValidateParam(minLength, minimumValue: 1, paramName: nameof(maxLength));
			Validate.TryValidateParam(maxLength, minimumValue: minLength, paramName: nameof(maxLength));

			return input is not null && input.Length.IsInRange(minLength, maxLength);
		}

		/// <summary>
		/// Determines whether [is email address] [the specified input].
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if [is email address] [the specified input]; otherwise, <c>false</c>.</returns>
		internal static bool IsEmailAddress([NotNull] this string input) => input.HasValue(Resources.RegexEmail, RegexOptions.IgnoreCase);

		/// <summary>
		/// Indicate whether the number falls in the specified range.
		/// </summary>
		/// <param name="value">Number to process</param>
		/// <param name="lower">Lower bound</param>
		/// <param name="upper">Upper bound</param>
		/// <returns>True/False</returns>
		internal static bool IsInRange(this int value, int lower, int upper) => value >= lower && value <= upper;

		/// <summary>
		/// Determines whether [is in range] [the specified lower].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="lower">The lower.</param>
		/// <param name="upper">The upper.</param>
		/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
		internal static bool IsInRange(this byte value, byte lower, byte upper) => value >= lower && value <= upper;

		/// <summary>
		/// Determines whether [is in range] [the specified lower].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="lower">The lower.</param>
		/// <param name="upper">The upper.</param>
		/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
		internal static bool IsInRange(this long value, long lower, long upper) => value >= lower && value <= upper;

		/// <summary>
		/// Determines whether [is in range] [the specified lower].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="lower">The lower.</param>
		/// <param name="upper">The upper.</param>
		/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
		internal static bool IsInRange(this double value, double lower, double upper) => value >= lower && value <= upper;

		/// <summary>
		/// Determines whether [is in range] [the specified lower].
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="lower">The lower.</param>
		/// <param name="upper">The upper.</param>
		/// <returns><c>true</c> if [is in range] [the specified lower]; otherwise, <c>false</c>.</returns>
		internal static bool IsInRange(this decimal value, decimal lower, decimal upper) => value >= lower && value <= upper;
		/// <summary>
		/// Determines whether the specified input is an URL.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <returns><c>true</c> if the specified input is URL; otherwise, <c>false</c>.</returns>
		internal static bool IsUrl([NotNull] this string input) => input.HasValue(Resources.RegexUrl, RegexOptions.IgnoreCase);
		/// <summary>
		/// Converts IDictionary to delimited string.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String.</returns>
		internal static string ToDelimitedString([NotNull] this IDictionary list, char delimiter = ',')
		{
			if (string.IsNullOrEmpty(delimiter.ToString()))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(delimiter));
			}

			if (list.Count() == 0)
			{
				return string.Empty;
			}

			var sb = new StringBuilder();

			foreach (DictionaryEntry item in list)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item.Key}: {item.Value}");
			}

			return sb.ToString();
		}

		/// <summary>
		/// Convert a list to a delimited string.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
		/// <returns>System.String.</returns>
		/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
		/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
		internal static string ToDelimitedString<T>([NotNull] this IEnumerable<T> list, char delimiter = ControlChars.Comma)
		{
			if (list.Count() == 0)
			{
				return string.Empty;
			}

			var sb = new StringBuilder();

			list.ToList()
				.ForEach(item =>
				{
					if (sb.Length > 0)
					{
						_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
					}

					_ = sb.Append(item.ToString());
				});

			return sb.ToString();
		}

		/// <summary>
		/// To the immutable dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="values">The values.</param>
		/// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
		internal static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this Dictionary<TKey, TValue> values) => ImmutableDictionary.CreateRange(values);
	}
}
