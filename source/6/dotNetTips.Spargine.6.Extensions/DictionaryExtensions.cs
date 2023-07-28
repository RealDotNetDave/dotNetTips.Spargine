// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-06-2023
// ***********************************************************************
// <copyright file="DictionaryExtensions.cs" company="dotNetTips.Spargine.6.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for IDictionary types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class DictionaryExtensions.
/// </summary>
public static class DictionaryExtensions
{
	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool =
	new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Processes the collection to dispose.
	/// </summary>
	/// <param name="items">The items.</param>
	internal static void ProcessCollectionToDispose(this IEnumerable items)
	{
		if (items.HasItems())
		{
			foreach (var item in items)
			{
				if (item is IDisposable disposeItem)
				{
					disposeItem.TryDispose();
				}
			}
		}
	}

	/// <summary>
	/// Tries the add the item to <see cref="IDictionary{TKey, TValue}" /> if it does not exist.
	/// Validates that <paramref name="collection" /> and <paramref name="key" /> is not null.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The dictionary.</param>
	/// <param name="key">The key.</param>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">key or value</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool AddIfNotExists<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> collection, [NotNull] TKey key, [NotNull] TValue value)
	{
		if (value is null)
		{
			return false;
		}

		key = key.ArgumentNotNull();
		collection = collection.ArgumentNotNull();

		if (collection.ContainsKey(key) is false)
		{
			collection.Add(key, value);
			return true;
		}

		return false;
	}

	/// <summary>
	/// Adds the range to <see cref="IDictionary{TKey, TValue}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="key" /> is not null
	/// and <paramref name="items" /> has items in it.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <typeparam name="TKey">Generic type of the key.</typeparam>
	/// <typeparam name="TValue">Generic type of the value.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="items">The items.</param>
	/// <param name="key">The key.</param>
	/// <param name="value">The value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">Dictionary cannot be null. or key - Key cannot be null.</exception>
	/// <remarks>Code by: Lucas</remarks>
	[Information(nameof(AddRange), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
	public static bool AddRange<T, TKey, TValue>([NotNull] this IDictionary<TKey, TValue> collection, IEnumerable<T> items, [NotNull] Func<T, TKey> key, [NotNull] Func<T, TValue> value)
	{
		if (value is null)
		{
			return false;
		}

		key = key.ArgumentNotNull();
		items = items.ArgumentItemsExists();
		collection = collection.ArgumentNotNull();

		var returnValue = false;

		items.ToList()
			.ForEach(item =>
			{
				collection.Add(key(item), value(item));
				returnValue = true;
			});

		return returnValue;
	}

	/// <summary>
	/// Disposes items in <see cref="IDictionary{TKey, TValue}" />.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The items.</param>
	[Information(nameof(DisposeCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
	public static void DisposeCollection<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> collection)
	{
		if (collection.HasItems())
		{
			ProcessCollectionToDispose(collection.Select(p => p.Value));
		}
	}

	/// <summary>
	/// Gets a value or adds it to the <see cref="IDictionary{TKey, TValue}" />.
	/// Validates that <paramref name="collection" />, <paramref name="key" /> and
	/// <paramref name="value" /> is not null.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The dictionary.</param>
	/// <param name="key">The key.</param>
	/// <param name="value">The value.</param>
	/// <returns>TValue.</returns>
	/// <exception cref="ArgumentNullException">Dictionary cannot be null.</exception>
	/// <exception cref="ArgumentNullException">Key cannot be null.</exception>
	/// <exception cref="ArgumentNullException">Value cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static TValue GetOrAdd<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> collection, [NotNull] TKey key, [NotNull] TValue value)
	{
		value = value.ArgumentNotNull();
		key = key.ArgumentNotNull();
		collection = collection.ArgumentNotNull();

		if (collection.TryGetValue(key, out var item) is false)
		{
			collection.Add(key, value);
			item = value;
		}

		return item;
	}

	/// <summary>
	/// Determines whether the specified action has items.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The dictionary.</param>
	/// <param name="action">The action.</param>
	/// <returns><c>true</c> if the specified action has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<TKey, TValue>([AllowNull] this IDictionary<TKey, TValue> collection, [NotNull] Func<KeyValuePair<TKey, TValue>, bool> action)
	{
		return collection is not null && action is not null && collection.Any(action);
	}

	/// <summary>
	/// Converts to a <see cref="Dictionary{TKey, TValue}" /> to a <see cref="ConcurrentDictionary{TKey, TValue}" />.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>ConcurrentDictionary&lt;TKey, TValue&gt;.</returns>
	[Information(nameof(ToSortedDictionary), "David McCarter", "7/23/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static ConcurrentDictionary<TKey, TValue> ToConcurrentDictionary<TKey, TValue>([NotNull] this Dictionary<TKey, TValue> collection)
	{
		return new ConcurrentDictionary<TKey, TValue>(collection.ArgumentNotNull());
	}

	/// <summary>
	/// Converts <see cref="IDictionary" /> to delimited string using <see cref="ObjectPool&lt;StringBuilder&gt;" /> to improve performance.
	/// </summary>
	/// <param name="collection">The list.</param>
	/// <param name="delimiter">The delimiter.</param>
	/// <returns>System.String.</returns>
	/// <example>Output:
	/// pfCfZQFGPWYXBlUvVHNb]ZjBO_LTbQBSCYb: pfCfZQFGPWYXBlUvVHNb]ZjBO_LTbQBSCYb,
	/// Dnadh[d`FP^SjNeChCvVuBXuEl^yVFUbKXsaacsCpJuxAscU: Dnadh[d`FP^SjNeChCvVuBXuEl^yVFUbKXsaacsCpJuxAscU.
	/// </example>
	[Information(nameof(ToDelimitedString), "David McCarter", "11/03/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 99, Documentation = "http://bit.ly/SpargineFeb2021")]
	public static string ToDelimitedString([NotNull] this IDictionary collection, char delimiter = ControlChars.Comma)
	{
		if (collection.DoesNotHaveItems())
		{
			return string.Empty;
		}
		var sb = _stringBuilderPool.Get();

		try
		{
			foreach (DictionaryEntry item in collection)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item.Key}: {item.Value}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Converts <see cref="IDictionary{TKey, TValue}" /> to <see cref="ImmutableDictionary{TKey, TValue}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The values.</param>
	/// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
	[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this Dictionary<TKey, TValue> collection)
	{
		return ImmutableDictionary.CreateRange(collection.ArgumentNotNull());
	}

	/// <summary>
	/// Converts a <see cref="Dictionary{TKey, TValue}" /> to a <see cref="SortedDictionary{TKey, TValue}" />./&gt;
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The dictionary.</param>
	/// <returns>SortedDictionary&lt;TKey, TValue&gt;.</returns>
	[Information(nameof(ToSortedDictionary), "David McCarter", "6/27/2022", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>([NotNull] this Dictionary<TKey, TValue> collection)
	{
		return new SortedDictionary<TKey, TValue>(collection.ArgumentNotNull());
	}

	/// <summary>
	/// Upserts the specified item into the <see cref="IDictionary{TKey, TValue}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The dictionary.</param>
	/// <param name="item">The item.</param>
	[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void Upsert<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> collection, [NotNull] TValue item) where TValue : IDataModel<TValue, TKey>
	{
		item = item.ArgumentNotNull();
		collection = collection.ArgumentNotNull();

		if (collection.ContainsKey(item.Id))
		{
			_ = collection.Remove(item.Id);
		}

		collection.Add(item.Id, item);
	}

	/// <summary>
	/// Inserts or updates the item into a <see cref="IDictionary{TKey, TValue}" />.
	/// Validates that <paramref name="collection" />, <paramref name="key" /> and
	/// <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The dictionary.</param>
	/// <param name="key">The key.</param>
	/// <param name="item">The value.</param>
	/// <returns>TValue.</returns>
	/// <exception cref="ArgumentNullException">dictionary</exception>
	/// <exception cref="ArgumentNullException">key</exception>
	/// <exception cref="ArgumentNullException">value</exception>
	/// <exception cref="ArgumentNullException">Input cannot be null or have no items in the collection.</exception>
	/// <exception cref="ArgumentNullException">Key cannot be null.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static void Upsert<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> collection, [NotNull] TKey key, [NotNull] TValue item)
	{
		item = item.ArgumentNotNull();
		key = key.ArgumentNotNull();
		collection = collection.ArgumentNotNull();

		if (collection.ContainsKey(key))
		{
			_ = collection.Remove(key);
		}

		collection.Add(key, item);
	}
}
