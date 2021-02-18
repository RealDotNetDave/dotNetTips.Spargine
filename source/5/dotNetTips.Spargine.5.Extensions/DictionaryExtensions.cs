// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="DictionaryExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for IDictionary types.</summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class DictionaryExtensions.
	/// </summary>
	public static class DictionaryExtensions
	{

		/// <summary>
		/// Tries the add the item if it does not exist.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">key or value</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool AddIfNotExists<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			Validate.TryValidateNullParam(dictionary, nameof(dictionary));
			Validate.TryValidateParam<ArgumentReadOnlyException>(dictionary.IsReadOnly == false, nameof(dictionary));
			Validate.TryValidateNullParam(key, nameof(key));
			Validate.TryValidateNullParam(value, nameof(value));

			if (dictionary.ContainsKey(key) == false)
			{
				dictionary.Add(key, value);
				return true;
			}

			return false;
		}

		/// <summary>
		/// Adds the range.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <typeparam name="TKey">Generic type of the key.</typeparam>
		/// <typeparam name="TValue">Generic type of the value.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="items">The items.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">Dictionary cannot be null. or key - Key cannot be null.</exception>
		/// <remarks>Code by: Lucas</remarks>
		[Information(nameof(AddRange), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static bool AddRange<T, TKey, TValue>(this IDictionary<TKey, TValue> list, IEnumerable<T> items, Func<T, TKey> key, Func<T, TValue> value)
		{
			if (items.DoesNotHaveItems())
			{
				return false;
			}

			Validate.TryValidateNullParam(list, nameof(list));
			Validate.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));
			Validate.TryValidateNullParam(key, nameof(key));
			Validate.TryValidateNullParam(value, nameof(value));

			var returnValue = false;

			items.ToList()
				.ForEach(item =>
				{
					list.Add(key(item), value(item));
					returnValue = true;
				});

			return returnValue;
		}

		/// <summary>
		/// Disposes the collection.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="items">The items.</param>
		[Information(nameof(DisposeCollection), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static void DisposeCollection<TKey, TValue>(this IDictionary<TKey, TValue> items)
		{
			ProcessCollectionToDispose(items.Select(p => p.Value));
		}

		/// <summary>
		/// Gets a value or adds it to the Dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="list">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns>TValue.</returns>
		/// <exception cref="ArgumentNullException">Dictionary cannot be null.</exception>
		/// <exception cref="ArgumentNullException">Key cannot be null.</exception>
		/// <exception cref="ArgumentNullException">Value cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> list, TKey key, TValue value)
		{
			Validate.TryValidateNullParam(list, nameof(list));
			Validate.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));
			Validate.TryValidateNullParam(key, nameof(key));
			Validate.TryValidateNullParam(value, nameof(value));

			if (list.TryGetValue(key, out var item) == false)
			{
				list.Add(key, value);
				item = value;
			}

			return item;
		}

		/// <summary>
		/// Converts IDictionary to delimited string.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String.</returns>
		/// <example>Output:
		/// pfCfZQFGPWYXBlUvVHNb]ZjBO_LTbQBSCYb: pfCfZQFGPWYXBlUvVHNb]ZjBO_LTbQBSCYb,
		/// Dnadh[d`FP^SjNeChCvVuBXuEl^yVFUbKXsaacsCpJuxAscU: Dnadh[d`FP^SjNeChCvVuBXuEl^yVFUbKXsaacsCpJuxAscU.
		/// </example>
		[Information(nameof(ToDelimitedString), "David McCarter", "11/03/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 99, Documentation = "https://dotnettips.wordpress.com/2021/02/12/coding-faster-with-the-dotnettips-utility-february-2021-update/")]
		public static string ToDelimitedString(this IDictionary list, char delimiter = ControlChars.Comma)
		{
			// TODO: ADD LINK TO ARTICLE FOR THIS METHOD.
			if (list.HasItems() == false)
			{
				return string.Empty;
			}

			var sb = TypeHelper.CreateStringBuilder();

			foreach (DictionaryEntry item in list)
			{
				sb.Append($"{item.Key}:{item.Value}{delimiter.ToString(CultureInfo.CurrentCulture)}");
			}

			return sb.ToString(0, sb.Length - 1);
		}

		/// <summary>
		/// To the immutable dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>(this Dictionary<TKey, TValue> list)
		{
			Validate.TryValidateNullParam(list, nameof(list));

			return ImmutableDictionary.CreateRange<TKey, TValue>(list);
		}

		/// <summary>
		/// Adds the or update.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="list">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns>TValue.</returns>
		/// <exception cref="ArgumentNullException">dictionary</exception>
		/// <exception cref="ArgumentNullException">key</exception>
		/// <exception cref="ArgumentNullException">value</exception>
		/// <exception cref="ArgumentNullException">Input cannot be null or have no items in the collection.</exception>
		/// <exception cref="ArgumentNullException">Key cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static TValue Upsert<TKey, TValue>(this Dictionary<TKey, TValue> list, TKey key, TValue value)
		{
			Validate.TryValidateNullParam(list, nameof(list));
			Validate.TryValidateNullParam(key, nameof(key));
			Validate.TryValidateNullParam(value, nameof(value));


			if (list.TryGetValue(key, out var item) == false)
			{
				list.Add(key, value);
				item = value;
			}

			return item;
		}

		/// <summary>
		/// Processes the collection to dispose.
		/// </summary>
		/// <param name="items">The items.</param>
		internal static void ProcessCollectionToDispose(IEnumerable items)
		{
			if (items.HasItems())
			{
				foreach (var item in items)
				{
					if (item != null && item is IDisposable disposeItem)
					{
						disposeItem.TryDispose();
					}
				}
			}
		}
	}
}
