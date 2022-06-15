// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-15-2022
// ***********************************************************************
// <copyright file="DictionaryExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for IDictionary types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class DictionaryExtensions.
	/// </summary>
	public static class DictionaryExtensions
	{


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
					if (item is IDisposable disposeItem)
					{
						disposeItem.TryDispose();
					}
				}
			}
		}

		/// <summary>
		/// Tries the add the item to <see cref="IDictionary{TKey, TValue}" /> if it does not exist.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="key">The key.</param>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">key or value</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool AddIfNotExists<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, [NotNull] TKey key, [NotNull] TValue value)
		{
			if (value is null)
			{
				return false;
			}

			dictionary = dictionary.ArgumentNotNull();

			if (dictionary.IsReadOnly)
			{
				ExceptionThrower.ThrowArgumentReadOnlyCollectionException(Resources.CannotAddItemsToAReadOnlyDictionary, nameof(dictionary));
			}

			key = key.ArgumentMeetsCondition(key is not null, errorMessage: "Key is missing.");

			if (dictionary.ContainsKey(key) is false)
			{
				dictionary.Add(key, value);
				return true;
			}

			return false;
		}

		/// <summary>
		/// Adds the range to <see cref="IDictionary{TKey, TValue}" />.
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
		[Information(nameof(AddRange), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static bool AddRange<T, TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, IEnumerable<T> items, [NotNull] Func<T, TKey> key, [NotNull] Func<T, TValue> value)
		{
			dictionary = dictionary.ArgumentNotNull();
			key = key.ArgumentNotNull();
			value = value.ArgumentNotNull();

			if (items.DoesNotHaveItems())
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
		/// Disposes items in <see cref="IDictionary{TKey, TValue}" />.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The items.</param>
		[Information(nameof(DisposeCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static void DisposeCollection<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary)
		{
			ProcessCollectionToDispose(dictionary.Select(p => p.Value));
		}

		/// <summary>
		/// Gets a value or adds it to the <see cref="IDictionary{TKey, TValue}" />.
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
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static TValue GetOrAdd<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, [NotNull] TKey key, [NotNull] TValue value)
		{
			dictionary = dictionary.ArgumentNotNull();
			key = key.ArgumentMeetsCondition(key is not null, errorMessage: "Key is missing.");
			value = value.ArgumentMeetsCondition(value is not null, errorMessage: "Value cannot be null.");

			if (dictionary.TryGetValue(key, out var item) is false)
			{
				dictionary.Add(key, value);
				item = value;
			}

			return item;
		}

		/// <summary>
		/// Determines whether the specified action has items.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="action">The action.</param>
		/// <returns><c>true</c> if the specified action has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD URL")]
		public static bool HasItems<TKey, TValue>([AllowNull] this IDictionary<TKey, TValue> dictionary, [NotNull] Func<KeyValuePair<TKey, TValue>, bool> action)
		{
			if (dictionary is null || action is null)
			{
				return true;
			}
			else
			{
				return dictionary.Any(action);
			}
		}

		/// <summary>
		/// Converts <see cref="IDictionary" /> to delimited string.
		/// </summary>
		/// <param name="dictionary">The list.</param>
		/// <param name="delimiter">The delimiter.</param>
		/// <returns>System.String.</returns>
		/// <example>Output:
		/// pfCfZQFGPWYXBlUvVHNb]ZjBO_LTbQBSCYb: pfCfZQFGPWYXBlUvVHNb]ZjBO_LTbQBSCYb,
		/// Dnadh[d`FP^SjNeChCvVuBXuEl^yVFUbKXsaacsCpJuxAscU: Dnadh[d`FP^SjNeChCvVuBXuEl^yVFUbKXsaacsCpJuxAscU.
		/// </example>
		[Information(nameof(ToDelimitedString), "David McCarter", "11/03/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 99, Documentation = "http://bit.ly/SpargineFeb2021")]
		public static string ToDelimitedString([NotNull] this IDictionary dictionary, char delimiter = ControlChars.Comma)
		{
			if (dictionary.DoesNotHaveItems())
			{
				return string.Empty;
			}

			var sb = new StringBuilder();

			foreach (DictionaryEntry item in dictionary)
			{
				_ = sb.Append($"{item.Key}:{item.Value}{delimiter}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString(0, sb.Length - 1);
		}

		/// <summary>
		/// Converts <see cref="IDictionary{TKey, TValue}" /> to <see cref="ImmutableDictionary{TKey, TValue}" />.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The values.</param>
		/// <returns>IImmutableDictionary&lt;TKey, TValue&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>([NotNull] this Dictionary<TKey, TValue> dictionary)
		{
			return ImmutableDictionary.CreateRange(dictionary.ArgumentNotNull());
		}

		/// <summary>
		/// Upserts the specified item into the <see cref="IDictionary{TKey, TValue}" />.
		/// </summary>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="dictionary">The dictionary.</param>
		/// <param name="item">The item.</param>
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Upsert<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, [NotNull] TValue item) where TValue : IDataModel<TValue, TKey>
		{
			dictionary = dictionary.ArgumentNotNull();
			item = item.ArgumentMeetsCondition(item is not null, errorMessage: "Item cannot be null.");

			if (dictionary.ContainsKey(item.Id))
			{
				_ = dictionary.Remove(item.Id);
			}

			dictionary.Add(item.Id, item);

		}

		/// <summary>
		/// Inserts or updates the item into a <see cref="IDictionary{TKey, TValue}" />.
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
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static void Upsert<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> dictionary, [NotNull] TKey key, [NotNull] TValue value)
		{
			dictionary = dictionary.ArgumentNotNull();
			key = key.ArgumentNotNull();
			value = value.ArgumentNotNull();

			if (dictionary.ContainsKey(key))
			{
				_ = dictionary.Remove(key);
			}

			dictionary.Add(key, value);
		}
	}
}
