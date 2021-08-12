// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-24-2021
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
using System.Text;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
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

			if (Validate.TryValidateNull(key) && Validate.TryValidateNull(value))
			{
				return false;
			}

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
		/// <param name="dictionary">The list.</param>
		/// <param name="items">The items.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">Dictionary cannot be null. or key - Key cannot be null.</exception>
		/// <remarks>Code by: Lucas</remarks>
		[Information(nameof(AddRange), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static bool AddRange<T, TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IEnumerable<T> items, Func<T, TKey> key, Func<T, TValue> value)
		{
			Validate.TryValidateNullParam(dictionary, nameof(dictionary));
			Validate.TryValidateParam<ArgumentReadOnlyException>(dictionary.IsReadOnly == false, nameof(dictionary));

			if (items.DoesNotHaveItems() || ( Validate.TryValidateNull(key) && Validate.TryValidateNull(value) ))
			{
				return false;
			}

			var returnValue = false;

			items.ToList()
				.ForEach(item =>
				{
					dictionary.Add(key(item), value(item));
					returnValue = true;
				});

			return returnValue;
		}

		/// <summary>
		/// Disposes the collection.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The items.</param>
		[Information(nameof(DisposeCollection), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static void DisposeCollection<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
		{
			ProcessCollectionToDispose(dictionary.Select(p => p.Value));
		}

		/// <summary>
		/// Gets a value or adds it to the Dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns>TValue.</returns>
		/// <exception cref="ArgumentNullException">Dictionary cannot be null.</exception>
		/// <exception cref="ArgumentNullException">Key cannot be null.</exception>
		/// <exception cref="ArgumentNullException">Value cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			Validate.TryValidateNullParam(dictionary, nameof(dictionary));
			Validate.TryValidateParam<ArgumentReadOnlyException>(dictionary.IsReadOnly == false, nameof(dictionary));
			Validate.TryValidateNullParam(key, nameof(key));
			Validate.TryValidateNullParam(value, nameof(value));

			if (dictionary.TryGetValue(key, out var item) == false)
			{
				dictionary.Add(key, value);
				item = value;
			}

			return item;
		}

		/// <summary>
		/// Converts IDictionary to delimited string.
		/// </summary>
		/// <param name="dictionary">The list.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String.</returns>
		/// <example>Output:
		/// pfCfZQFGPWYXBlUvVHNb]ZjBO_LTbQBSCYb: pfCfZQFGPWYXBlUvVHNb]ZjBO_LTbQBSCYb,
		/// Dnadh[d`FP^SjNeChCvVuBXuEl^yVFUbKXsaacsCpJuxAscU: Dnadh[d`FP^SjNeChCvVuBXuEl^yVFUbKXsaacsCpJuxAscU.
		/// </example>
		[Information(nameof(ToDelimitedString), "David McCarter", "11/03/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 99, Documentation = "http://bit.ly/SpargineFeb2021")]
		public static string ToDelimitedString(this IDictionary dictionary, char delimiter = ControlChars.Comma)
		{
			// TODO: ADD LINK TO ARTICLE FOR THIS METHOD.
			if (dictionary.DoesNotHaveItems())
			{
				return string.Empty;
			}

			var sb = new StringBuilder();

			foreach (DictionaryEntry item in dictionary)
			{
				_ = sb.Append($"{item.Key}:{item.Value}{delimiter.ToString(CultureInfo.CurrentCulture)}");
			}

			return sb.ToString(0, sb.Length - 1);
		}

		/// <summary>
		/// To the immutable dictionary.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The values.</param>
		/// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
		{
			Validate.TryValidateNullParam(dictionary, nameof(dictionary));

			return ImmutableDictionary.CreateRange<TKey, TValue>(dictionary);
		}


		/// <summary>
		/// Upserts the specified item.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="item">The item.</param>
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Upsert<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue item) where TValue : IDataModel<TValue, TKey>
		{
			Validate.TryValidateNullParam(dictionary, nameof(dictionary));
			Validate.TryValidateNullParam(item, nameof(item));

			_ = dictionary.Remove(item.Id);

			dictionary.Add(item.Id, item);

		}

		/// <summary>
		/// Adds the or update.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns>TValue.</returns>
		/// <exception cref="ArgumentNullException">dictionary</exception>
		/// <exception cref="ArgumentNullException">key</exception>
		/// <exception cref="ArgumentNullException">value</exception>
		/// <exception cref="ArgumentNullException">Input cannot be null or have no items in the collection.</exception>
		/// <exception cref="ArgumentNullException">Key cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static void Upsert<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			Validate.TryValidateNullParam(dictionary, nameof(dictionary));
			Validate.TryValidateNullParam(key, nameof(key));
			Validate.TryValidateNullParam(value, nameof(value));

			_ = dictionary.Remove(key);

			dictionary.Add(key, value);
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
					if (item is not null and IDisposable disposeItem)
					{
						disposeItem.TryDispose();
					}
				}
			}
		}
	}
}
