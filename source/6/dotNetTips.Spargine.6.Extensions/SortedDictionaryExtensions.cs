// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="SortedDictionaryExtensions.cs" company="dotNetTips.Spargine.6.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class SortedDictionaryExtensions.
	/// </summary>
	public static class SortedDictionaryExtensions
	{
		/// <summary>
		/// Checks dictionary for null and insurese there are items in the dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="collection">The list.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New, Documentation = "ADD URL")]
		public static bool DoesNotHaveItems<TKey, TValue>([AllowNull] this SortedDictionary<TKey, TValue> collection)
		{
			if (collection is null)
			{
				return true;
			}
			else
			{
				return collection.Count() <= 0;
			}
		}

		/// <summary>
		/// Determines whether the specified dictionary has items.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="collection">The dictionary.</param>
		/// <returns><c>true</c> if the specified dictionary has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New, Documentation = "ADD URL")]
		public static bool HasItems<TKey, TValue>([AllowNull] this SortedDictionary<TKey, TValue> collection)
		{
			if (collection is null)
			{
				return false;
			}
			else
			{
				return collection.Count() > 0;
			}
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
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New, Documentation = "ADD URL")]
		public static bool HasItems<TKey, TValue>([AllowNull] this SortedDictionary<TKey, TValue> collection, [NotNull] Func<KeyValuePair<TKey, TValue>, bool> action)
		{
			if (collection is null || action is null)
			{
				return true;
			}
			else
			{
				return collection.Any(action);
			}
		}

		/// <summary>
		/// Determines whether the specified count has items.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="collection">The dictionary.</param>
		/// <param name="count">The count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.New, Documentation = "ADD URL")]
		public static bool HasItems<TKey, TValue>([AllowNull] this SortedDictionary<TKey, TValue> collection, int count)
		{
			if (collection is null)
			{
				return false;
			}
			else
			{
				return collection.Count() == count;
			}
		}

		/// <summary>
		/// Converts to immutable Dictionary.
		/// Validates that <paramref name="collection" /> is not null.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="collection">The values.</param>
		/// <returns>ImmutableSortedDictionary&lt;TKey, TValue&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableSortedDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> collection)
		{
			return ImmutableSortedDictionary.CreateRange(collection.ArgumentNotNull());
		}

		/// <summary>
		/// Upserts the by the specified key.
		/// Validates that <paramref name="collection" />, <paramref name="key" /> and <paramref name="value" /> is not null.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="collection">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns>TValue.</returns>
		[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static TValue Upsert<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> collection, [NotNull] TKey key, [NotNull] TValue value)
		{
			value = value.ArgumentNotNull();

			if (collection.ArgumentNotNull().TryGetValue(key.ArgumentNotNull(), out TValue item) is false)
			{
				collection.Add(key, value);
				item = value;
			}

			return item;
		}
	}
}
