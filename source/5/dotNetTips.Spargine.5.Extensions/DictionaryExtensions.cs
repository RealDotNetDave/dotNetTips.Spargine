// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-24-2020
// ***********************************************************************
// <copyright file="DictionaryExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

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
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool AddIfNotExists<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(dictionary != null, nameof(dictionary));
            Encapsulation.TryValidateParam<ArgumentReadOnlyException>(dictionary.IsReadOnly == false, nameof(dictionary));
            Encapsulation.TryValidateParam<ArgumentNullException>(key != null, nameof(key));
            Encapsulation.TryValidateParam<ArgumentNullException>(value != null, nameof(value));

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

            Encapsulation.TryValidateParam<ArgumentNullException>(list != null, nameof(list));
            Encapsulation.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));
            Encapsulation.TryValidateParam<ArgumentNullException>(key != null, nameof(key));
            Encapsulation.TryValidateParam<ArgumentNullException>(value != null, nameof(value));

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
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> list, TKey key, TValue value)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(list != null, nameof(list));
            Encapsulation.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));
            Encapsulation.TryValidateParam<ArgumentNullException>(key != null, nameof(key));
            Encapsulation.TryValidateParam<ArgumentNullException>(value != null, nameof(value));

            if (list.TryGetValue(key, out TValue item) == false)
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
        [Information(nameof(ToDelimitedString), "David McCarter", "11/03/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, UnitTestCoverage = 0)]
        public static string ToDelimitedString(this IDictionary list, char delimiter = ControlChars.Comma)
        {
            if (delimiter.IsNull())
            {
                ExceptionThrower.ThrowArgumentNullException(nameof(delimiter));
            }

            if (list.HasItems() == false)
            {
                return string.Empty;
            }


            var sb = new StringBuilder();

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
        [Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static ImmutableDictionary<TKey, TValue> ToImmutable<TKey, TValue>(this Dictionary<TKey, TValue> list)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(list != null, nameof(list));

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
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static TValue Upsert<TKey, TValue>(this Dictionary<TKey, TValue> list, TKey key, TValue value)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(list != null, nameof(list));
            Encapsulation.TryValidateParam<ArgumentNullException>(key != null, nameof(key));
            Encapsulation.TryValidateParam<ArgumentNullException>(value != null, nameof(value));


            if (list.TryGetValue(key, out TValue item) == false)
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
