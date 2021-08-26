// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-19-2021
// ***********************************************************************
// <copyright file="SortedDictionaryExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
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
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableSortedDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this SortedDictionary<TKey, TValue> list)
		{
			return ImmutableSortedDictionary.CreateRange(list);
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
			if (dictionary.TryGetValue(key, out var item) == false)
			{
				dictionary.Add(key, value);
				item = value;
			}

			return item;
		}
	}
}
