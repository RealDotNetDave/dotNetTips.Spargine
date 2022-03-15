// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="ArrayExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extensions methods for the Array type.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extensions methods for the Array type.
	/// </summary>
	public static class ArrayExtensions
	{

		//TODO: SEE IF THIS CAN BE MADE FASTER. IT'S SLOWER THAN A NORMAL FOR.

		///// <summary>
		///// Processes the collection with the specified action.
		///// </summary>
		///// <typeparam name="T"></typeparam>
		///// <param name="list">The list.</param>
		///// <param name="action">The action.</param>
		//[Information(nameof(FastProcessor), author: "David McCarter", createdOn: "11/8/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD APR URL")]
		//public static void FastProcessor<T>([NotNull] this T[] list, [NotNull] Action<T> action)
		//{
		//	var collection = new ReadOnlySpan<T>(list);

		//	for (var itemIndex = 0; itemIndex < collection.Length; itemIndex++)
		//	{
		//		action(collection[itemIndex]);
		//	}
		//}

		/// <summary>
		/// Adds the specified item to the array, to the last position.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">The array.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		[Information(nameof(Add), author: "David McCarter", createdOn: "4/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static T[] Add<T>([NotNull] this T[] array, [NotNull] T item)
		{
			Validate.TryValidateParam<ArgumentReadOnlyException>(array.IsReadOnly == false, nameof(array));

			var result = new T[array.Length + 1];
			result[result.Length - 1] = item;

			array.CopyTo(result, index: 0);

			return result;
		}
		/// <summary>
		/// Adds a single item to the beginning of the array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="array">The array.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentReadOnlyException">The array is read-only.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static T[] AddFirst<T>([NotNull] this T[] array, T item)
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
		/// Adds item to the array if the condition is meet.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">The array.</param>
		/// <param name="item">The item.</param>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <returns>T[].</returns>
		[Information(nameof(AddIf), author: "David McCarter", createdOn: "4/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static T[] AddIf<T>([NotNull] this T[] array, T item, bool condition)
		{
			if (Validate.TryValidateNull(item))
			{
				return array;
			}

			Validate.TryValidateParam<ArgumentReadOnlyException>(array.IsReadOnly == false, nameof(array));

			return condition ? array.Add(item) : array;
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
		public static T[] AddIfNotExists<T>([NotNull] this T[] list, params T[] items)
		{
			if (items.HasItems() == false)
			{
				return list;
			}

			Validate.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));

			var returnCollection = list.ToList();

			for (var itemCount = 0; itemCount < items.FastCount(); itemCount++)
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
		public static T[] AddLast<T>([NotNull] this T[] array, T item)
		{
			if (item is null)
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

			var hash = array.Where(t => t is not null).Aggregate(6551, (accumulator, t) => accumulator ^= ( accumulator << 5 ) ^ EqualityComparer<T>.Default.GetHashCode(t));

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

			var sb = new StringBuilder();

			for (var byteCount = 0; byteCount < array.Length; byteCount++)
			{
				_ = sb.Append(array[byteCount].ToString("x2", CultureInfo.InvariantCulture));
			}

			return sb.ToString();
		}

		/// <summary>
		/// Converts byte array to a string.
		/// </summary>
		/// <param name="array">The array.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(BytesToString), "David McCarter", "6/24/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static string BytesToString(this ReadOnlySpan<byte> array)
		{
			Validate.TryValidateParam(array, nameof(array));

			var sb = new StringBuilder();

			for (var byteCount = 0; byteCount < array.Length; byteCount++)
			{
				_ = sb.Append(array[byteCount].ToString("x2", CultureInfo.InvariantCulture));
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
			if (Validate.TryValidateNull(array) || items.FastCount() == 0)
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

		/// <summary>
		/// Upserts (add or insert) the specified item.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">The array.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		[Information(nameof(Upsert), author: "David McCarter", createdOn: "4/28/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static T[] Upsert<T>(this T[] array, T item)
		{
			if (Validate.TryValidateNull(item))
			{
				return array;
			}

			Validate.TryValidateParam<ArgumentReadOnlyException>(array.IsReadOnly == false, nameof(array));

			if (array.Contains(item))
			{
				array[array.IndexOf(item)] = item;

				return array;
			}
			else
			{
				return array.Add(item);
			}
		}

		/// <summary>
		/// Upserts the specified array.
		/// </summary>
		/// <param name="records">The array.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		[Information(nameof(Upsert), author: "David McCarter", createdOn: "5/2/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Updated, Documentation = "https://bit.ly/SpargineJun2021")]
		public static IDataRecord[] Upsert(this IDataRecord[] records, IDataRecord item)
		{
			if (Validate.TryValidateNull(item))
			{
				return records;
			}

			Validate.TryValidateParam<ArgumentReadOnlyException>(records.IsReadOnly == false, nameof(records));

			_ = records.SingleOrDefault(p => p.Id.Equals(item.Id, StringComparison.Ordinal));

			var currentItem = records.FirstOrDefault(p => p.Id.Equals(item.Id, StringComparison.Ordinal));

			if (currentItem is not null)
			{
				currentItem = item;
			}
			else
			{
				_ = records.Add(item);
			}

			return records;
		}

	}
}
