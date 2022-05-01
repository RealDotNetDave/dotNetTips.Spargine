// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-15-2022
// ***********************************************************************
// <copyright file="SortedDictionaryExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
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
		/// Converts to immutable Dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>ImmutableSortedDictionary&lt;TKey, TValue&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableSortedDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> list)
		{
			return ImmutableSortedDictionary.CreateRange(list.ArgumentItemsExists());
		}

		/// <summary>
		/// Upserts the by the specified key.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns>TValue.</returns>
		[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static TValue Upsert<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> dictionary, [NotNull] TKey key, [NotNull] TValue value)
		{
			value = value.ArgumentNotNull();

			if (dictionary.ArgumentNotNull().TryGetValue(key.ArgumentNotNull(), out var item) is false)
			{
				dictionary.Add(key, value);
				item = value;
			}

			return item;
		}
	}
}
