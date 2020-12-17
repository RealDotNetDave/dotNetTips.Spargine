﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-24-2020
// ***********************************************************************
// <copyright file="CollectionExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for the Collection type.</summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Extension methods for the <see cref="ICollection" /> Collection type.
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Adds the item to the collection if it does not exist.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The value.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">list - List cannot be null. or value - Value cannot be null.</exception>
        /// <exception cref="ArgumentException">list - List cannot be null. or value - Value cannot be null.</exception>
        /// <exception cref="System.ArgumentNullException">list - List cannot be read-only.</exception>
        /// <exception cref="System.ArgumentException">list - List cannot be null. or value - Value cannot be null.</exception>
        [Information(nameof(AddIfNotExists), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool AddIfNotExists<T>(this ICollection<T> list, T item)
        {
            if (item is null)
            {
                return false;
            }

            if (CreateCollectionIfNull(list) == false)
            {
                Encapsulation.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));

                if (list.Contains(item))
                {
                    return false;
                }
            }

            list.Add(item);

            return true;
        }

        /// <summary>
        /// Adds the items to the collection if it does not exist.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="items">The values.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentException">list - List cannot be read-only.</exception>
        /// <exception cref="ArgumentNullException">list - List cannot be read-only.</exception>
        [Information(nameof(AddIfNotExists), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool AddIfNotExists<T>(this ICollection<T> list, params T[] items)
        {
            if (items.DoesNotHaveItems())
            {
                return false;
            }

            if (CreateCollectionIfNull(list) == false)
            {
                Encapsulation.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));
            }

            var returnValue = false;

            if (items.HasItems())
            {
                for (var index = 0; index < items.Length; index++)
                {
                    if (items[index].IsNotNull())
                    {
                        list.AddIfNotExists(items[index]);
                        returnValue = true;
                    }
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Adds the item to the collection if it does not exist.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The item.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentException">List cannot be read-only. - list</exception>
        /// <exception cref="ArgumentNullException">List cannot be read-only. - list</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool AddIfNotExists<T>(this ICollection<T> list, T item, IEqualityComparer<T> comparer)
        {
            if (item == null)
            {
                return false;
            }

            Encapsulation.TryValidateParam<ArgumentNullException>(comparer != null, nameof(comparer));

            if (CreateCollectionIfNull(list) == false)
            {
                Encapsulation.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));

                if (list.Contains(item, comparer))
                {
                    return false;
                }
            }

            list.Add(item);
            return true;

        }

        /// <summary>
        /// Adds the items to the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="items">The items.</param>
        /// <param name="ensureUnique">The ensure unique.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentException">items</exception>
        /// <exception cref="ArgumentNullException">items</exception>
        [Information(nameof(AddRange), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool AddRange<T>(this ICollection<T> list, IEnumerable<T> items, Tristate ensureUnique = Tristate.False)
        {
            if (items.HasItems() == false)
            {
                return false;
            }

            if (CreateCollectionIfNull(list) == false)
            {
                Encapsulation.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));
            }

            var returnValue = false;

            if (items.HasItems())
            {
                items.ToList()
                    .ForEach(item =>
                    {
                        if (ensureUnique == Tristate.True || ensureUnique == Tristate.UseDefault)
                        {
                            list.AddIfNotExists(item);
                            returnValue = true;
                        }
                        else
                        {
                            list.Add(item);
                            returnValue = true;
                        }
                    });
            }

            return returnValue;
        }

        /// <summary>
        /// Determines whether the specified source does not have items or is null.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        [Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool DoesNotHaveItems(this ICollection source)
        {
            return source?.Count <= 0;
        }

        /// <summary>
        /// Determines whether the specified source has items.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        [Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool HasItems(this ICollection source)
        {
            return source?.Count > 0;
        }

        /// <summary>
        /// Determines whether the specified count has items.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="count">The specific count.</param>
        /// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
        [Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool HasItems(this ICollection source, int count)
        {
            return source?.Count == count;
        }

        /// <summary>
        /// Creates the collection if null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private static bool CreateCollectionIfNull<T>(ICollection<T> list)
        {
            if (list == null)
            {
                list = TypeHelper.Create<ICollection<T>>();

                return true;
            }

            return false;
        }
    }
}
