// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-07-2021
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
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
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
			if (Validate.TryValidateNull(item))
			{
				return array;
			}

			Validate.TryValidateParam<ArgumentReadOnlyException>(array.IsReadOnly == false, nameof(array));

			var result = new T[array.Length + 1];
			result[0] = item;

			array.CopyTo(result, index: 1);

			return result;
		}
		/// <summary>
		/// Adds items to an array if they do not exists.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="items">The items.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">List cannot be null.</exception>
		/// <exception cref="ArgumentReadOnlyException">The array is read-only.</exception>
		[Information(nameof(AddIfNotExists), author: "David McCarter", createdOn: "8/12/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static T[] AddIfNotExists<T>(this T[] list, params T[] items)
		{
			if (items.HasItems() == false)
			{
				return list;
			}

			Validate.TryValidateNullParam(list, nameof(list));
			Validate.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));

			var returnCollection = list.ToList();

			for (var itemCount = 0; itemCount < items.Count(); itemCount++)
			{
				var item = items[itemCount];

				if (list.Contains(item) == false)
				{
					returnCollection.Add(item);
				}
			}

			return returnCollection.ToArray();
		}

		/// <summary>
		/// Adds item to the end of the array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="array">The array.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentReadOnlyException">item - Item cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static T[] AddLast<T>(this T[] array, T item)
		{
			if (item == null)
			{
				return array;
			}

			Validate.TryValidateParam<ArgumentReadOnlyException>(array.IsReadOnly == false, nameof(array));

			var result = new T[array.Length + 1];
			array.CopyTo(result, 0);
			result[array.Length] = item;

			return result;
		}

		/// <summary>
		/// Checks if the two arrays are equal.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="array">The input.</param>
		/// <param name="arrayToCheck">The array to check.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static bool AreEqual<T>(this T[] array, T[] arrayToCheck)
		{
			if (Validate.TryValidateNull(array) && Validate.TryValidateNull(arrayToCheck))
			{
				return true;
			}

			if (( Validate.TryValidateNull(array) && Validate.TryValidateNull(arrayToCheck) ) || array?.Length != arrayToCheck?.Length)
			{
				return false;
			}

			var areSame = true;

			for (var i = 0; i < array.Length; i++)
			{
				areSame &= array[i].Equals(arrayToCheck[i]);
			}

			return areSame;
		}

		/// <summary>
		/// Generates hash code for the collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="array">The list to use to generate hash code.</param>
		/// <returns>Hash code as System.Int32.</returns>
		/// <exception cref="ArgumentNullException">Array cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static int ArrayHashCode<T>(this T[] array)
		{
			Validate.TryValidateParam(array, nameof(array));

			var hash = array.Where(t => t != null).Aggregate(6551, (accumulator, t) => accumulator ^= ( accumulator << 5 ) ^ EqualityComparer<T>.Default.GetHashCode(t));

			return hash;
		}

		/// <summary>
		/// Returns a <see cref="string" /> that represents this instance.
		/// </summary>
		/// <param name="array">The bytes.</param>
		/// <returns>A <see cref="string" /> that represents this instance.</returns>
		/// <exception cref="ArgumentNullException">Array cannot be null.</exception>
		[Information(nameof(BytesToString), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static string BytesToString(this byte[] array)
		{
			Validate.TryValidateParam(array, nameof(array));

			var sb = TypeHelper.CreateStringBuilder();

			for (var byteCount = 0; byteCount < array.Length; byteCount++)
			{
				sb.Append(array[byteCount].ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}

		/// <summary>
		/// Clones the specified array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="array">The input.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">Array cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/30/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static T[] Clone<T>(this T[] array)
		{
			Validate.TryValidateParam(array, nameof(array));

			var copy = new T[array.Length];
			Array.Copy(sourceArray: array, sourceIndex: 0, destinationArray: copy, destinationIndex: 0, length: array.Length);

			return copy;
		}

		/// <summary>
		/// Determines whether the specified array has items specified.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="array">The source.</param>
		/// <param name="items">The items.</param>
		/// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool ContainsAny<T>(this T[] array, params T[] items)
		{
			if (Validate.TryValidateNull(array) || items.Count() == 0)
			{
				return false;
			}

			var itemsList = items.ToReadOnlyCollection();

			return itemsList.HasItems() && array.ToReadOnlyCollection().Any(p => itemsList.Contains(p));

		}

		/// <summary>
		/// Removes the duplicate values.
		/// </summary>
		/// <param name="array">The values.</param>
		/// <returns>System.Int32().</returns>
		/// <remarks>Code by: Kevin S Gallagher</remarks>
		[Information(nameof(RemoveDuplicates), UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<int> RemoveDuplicates(this int[] array) => array.Distinct().AsEnumerable();

		/// <summary>
		/// Removes the first item in the array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="array">The array.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">Array cannot be null or empty.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static T[] RemoveFirst<T>(this T[] array)
		{
			Validate.TryValidateParam(array, nameof(array));

			var result = new T[array.Length - 1];

			Array.Copy(array, 1, result, 0, result.Length);

			return result;
		}

		/// <summary>
		/// Removes the last.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="array">The array.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">Array cannot be null.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static T[] RemoveLast<T>(this T[] array)
		{
			Validate.TryValidateParam(array, nameof(array));

			var result = new T[array.Length - 1];
			Array.Copy(array, result, result.Length);

			return result;
		}

		/// <summary>
		/// Returns the array without duplicates.
		/// </summary>
		/// <param name="array">The list.</param>
		/// <returns>System.String[].</returns>
		/// <exception cref="ArgumentNullException">Array cannot be null.</exception>
		[Information(nameof(ToDistinct), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static string[] ToDistinct(this string[] array)
		{
			Validate.TryValidateParam(array, nameof(array));

			return array.Distinct().ToArray();
		}
	}
}
