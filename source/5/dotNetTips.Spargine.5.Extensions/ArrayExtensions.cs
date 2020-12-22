// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-21-2020
// ***********************************************************************
// <copyright file="ArrayExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extensions methods for the Array type.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Extensions methods for the Array type.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Adds a single item to the beginning of the array.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="item">The item.</param>
        /// <returns>T[].</returns>
        /// <exception cref="ArgumentReadOnlyException">The array is read-only.</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static T[] AddFirst<T>(this T[] array, T item)
        {
            if (item is null)
            {
                return array;
            }

            Encapsulation.TryValidateParam<ArgumentReadOnlyException>(array.IsReadOnly == false, nameof(array));

            var result = new T[array.Length + 1];
            result[0] = item;

            array.CopyTo(result, index: 1);

            return result;
        }

        /// <summary>
        /// Adds item to the end of the array.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="array">The array.</param>
        /// <param name="item">The item.</param>
        /// <returns>T[].</returns>
        /// <exception cref="ArgumentNullException">item - Item cannot be null.</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static T[] AddLast<T>(this T[] array, T item)
        {
            if (item == null)
            {
                return array;
            }
            Encapsulation.TryValidateParam<ArgumentReadOnlyException>(array.IsReadOnly == false, nameof(array));

            var result = new T[array.Length + 1];
            array.CopyTo(result, 0);
            result[array.Length] = item;

            return result;
        }

        /// <summary>
        /// Checks if the two arrays are equal. 
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="input">The input.</param>
        /// <param name="arrayToCheck">The array to check.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static bool AreEqual<T>(this T[] input, T[] arrayToCheck)
        {
            if (input is null && arrayToCheck is null)
            {
                return true;
            }

            if (input is null || arrayToCheck is null || input.Length != arrayToCheck.Length)
            {
                return false;
            }

            var areSame = true;

            for (var i = 0; i < input.Length; i++)
            {
                areSame &= input[i].Equals(arrayToCheck[i]);
            }

            return areSame;
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>A <see cref="string" /> that represents this instance.</returns>
        /// <exception cref="ArgumentNullException">Input cannot be null or be empty.</exception>
        [Information(nameof(BytesToString), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
        public static string BytesToString(this byte[] bytes)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(bytes.HasItems(), nameof(bytes));

            var builder = new StringBuilder();

            for (var byteCount = 0; byteCount < bytes.Length; byteCount++)
            {
                builder.Append(bytes[byteCount].ToString("x2", CultureInfo.InvariantCulture));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Clones the specified array.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="input">The input.</param>
        /// <returns>T[].</returns>
        /// <exception cref="ArgumentNullException">Input cannot be null or has a length of 0.</exception>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static T[] Clone<T>(this T[] input)
        {
            if (input is null || input.Length == 0)
            {
                ExceptionThrower.ThrowArgumentNullException("Input cannot be null or has a length of 0.", nameof(input));
            }

            var copy = new T[input.Length];
            Array.Copy(sourceArray: input, sourceIndex: 0, destinationArray: copy, destinationIndex: 0, length: input.Length);

            return copy;
        }

        /// <summary>
        /// Determines whether the specified array has items specified.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="items">The items.</param>
        /// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 99, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool ContainsAny<T>(this T[] source, params T[] items)
        {
            if (items.DoesNotHaveItems())
            {
                return false;
            }

            var itemsList = items.ToReadOnlyCollection();

            return itemsList.HasItems() && source.ToReadOnlyCollection().Any(p => itemsList.Contains(p));

        }

        /// <summary>
        /// Removes the duplicate values.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns>System.Int32().</returns>
        /// <remarks>Code by: Kevin S Gallagher</remarks>
        [Information(nameof(RemoveDuplicates), UnitTestCoverage = 0, Status = Status.Available)]
        public static IEnumerable<int> RemoveDuplicates(this int[] values) => values.Distinct().AsEnumerable();
        /// <summary>
        /// Returns the array without duplicates.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>System.String[].</returns>
        [Information(nameof(ToDistinct), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
        public static string[] ToDistinct(this string[] list)
        {
            Encapsulation.TryValidateParam(list, nameof(list));

            return list.Distinct().ToArray();
        }
    }
}
