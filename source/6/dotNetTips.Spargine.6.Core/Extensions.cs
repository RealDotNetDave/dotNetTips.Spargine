// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 11-10-2020
//
// Last Modified By : David McCarter
// Last Modified On : 01-26-2023
// ***********************************************************************
// <copyright file="Extensions.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using DotNetTips.Spargine.Core.Properties;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Extension methods.
/// </summary>
internal static class Extensions
{

	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<System.Text.StringBuilder> _stringBuilderPool =
new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Adds the item as the first item in array.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="list">The list.</param>
	/// <param name="item">The item.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">list or item</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	internal static void AddFirst<T>(this IList<T> list, [NotNull] T item)
	{
		list.ArgumentNotReadOnly().Insert(index: 0, item);
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
	internal static bool AddIfNotExists<T>(this ICollection<T> list, [NotNull] T item)
	{
		list = list.ArgumentNotReadOnly();

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
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	internal static void AddLast<T>(this IList<T> list, [NotNull] T item)
	{
		list.ArgumentNotReadOnly().Insert(list.Count, item);
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
	/// Indicate whether the number falls in the specified range.
	/// </summary>
	/// <param name="value">Number to process</param>
	/// <param name="lower">Lower bound</param>
	/// <param name="upper">Upper bound</param>
	/// <returns>True/False</returns>
	internal static bool CheckIsInRange(this int value, int lower, int upper)
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
	internal static bool CheckIsInRange(this byte value, byte lower, byte upper)
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
	internal static bool CheckIsInRange(this long value, long lower, long upper)
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
	internal static bool CheckIsInRange(this double value, double lower, double upper)
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
	internal static bool CheckIsInRange(this decimal value, decimal lower, decimal upper)
	{
		return value >= lower && value <= upper;
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
	/// Counts the number of items in a collection.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="list">The list.</param>
	/// <returns>System.Int64.</returns>
	internal static long FastCount<T>([NotNull] this IEnumerable<T> list)
	{
		return list.ArgumentNotNull().LongCount();
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
	[Information("Original Code from: https://github.com/dotnet/BenchmarkDotNet.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available)]
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
	internal static bool HasValue(this string input)
	{
		return string.IsNullOrEmpty(input) is false;
	}

	/// <summary>
	/// Determines whether the specified length has value.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="length">Checks for specific length of the string.</param>
	/// <returns><c>true</c> if the specified length has value; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentOutOfRangeException">length - Minimum length must be greater than 0.</exception>
	internal static bool HasValue(this string input, int length)
	{
		input = input.ArgumentInRange(lower: 0, upper: int.MaxValue);
		length = length.ArgumentInRange(lower: 1);

		return input is not null && (input.Trim().Length == length);
	}

	/// <summary>
	/// Determines whether the specified value has value.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="value">Checks for a specific value.</param>
	/// <returns><c>true</c> if the specified value has value; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentException">value</exception>
	internal static bool HasValue(this string input, string value)
	{
		return string.Equals(
			input.ArgumentNotNullOrEmpty(),
			value.ArgumentNotNullOrEmpty(),
			StringComparison.Ordinal);
	}

	/// <summary>
	/// Determines whether the specified expression has value based on a regular expression.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <param name="expression">The expression.</param>
	/// <param name="options">The options.</param>
	/// <returns><c>true</c> if the specified expression has value; otherwise, <c>false</c>.</returns>
	internal static bool HasValue(this string input, [NotNull] string expression, [NotNull] RegexOptions options)
	{
		input = input.ArgumentNotNullOrEmpty();

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
	internal static bool HasValue(this string input, int minLength, int maxLength)
	{
		input = input.ArgumentNotNullOrEmpty();
		minLength = minLength.ArgumentInRange(lower: 1);
		maxLength = maxLength.ArgumentInRange(lower: minLength);

		return input is not null && input.Length.CheckIsInRange(minLength, maxLength);
	}

	/// <summary>
	/// Determines whether [is email address] [the specified input].
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if [is email address] [the specified input]; otherwise, <c>false</c>.</returns>
	internal static bool IsEmailAddress(this string input)
	{
		return input.ArgumentNotNullOrEmpty().HasValue(Resources.RegexEmail, RegexOptions.IgnoreCase);
	}

	/// <summary>
	/// Determines whether the specified input is an URL.
	/// </summary>
	/// <param name="input">The input.</param>
	/// <returns><c>true</c> if the specified input is URL; otherwise, <c>false</c>.</returns>
	internal static bool IsUrl(this string input)
	{
		input = input.ArgumentNotNullOrEmpty();

		return input.HasValue(Resources.RegexUrl, RegexOptions.IgnoreCase);
	}
	/// <summary>
	/// Converts IDictionary to delimited string using <see cref="ObjectPool&lt;StringBuilder&gt;"/> to improve performance.
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

		var sb = _stringBuilderPool.Get();

		try
		{
			foreach (DictionaryEntry item in list)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item.Key}: {item.Value}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Convert a list to a delimited string  using <see cref="ObjectPool&lt;StringBuilder&gt;"/> to improve performance.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="list">The list.</param>
	/// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
	/// <returns>System.String.</returns>
	/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
	/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
	internal static string ToDelimitedString<T>([NotNull] this IEnumerable<T> list, char delimiter = ControlChars.Comma)
	{
		if (list.FastCount() == 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			foreach (var item in list)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// To the immutable dictionary.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="values">The values.</param>
	/// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
	internal static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this Dictionary<TKey, TValue> values)
	{
		return ImmutableDictionary.CreateRange(values);
	}

}
