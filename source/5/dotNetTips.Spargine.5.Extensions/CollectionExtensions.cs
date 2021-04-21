// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2021
// ***********************************************************************
// <copyright file="CollectionExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for the ICollection types.</summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
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
		/// <param name="collection">The collection.</param>
		/// <param name="item">The value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">Collection cannot be null.</exception>
		/// <exception cref="ArgumentReadOnlyException">Collection cannot be read-only.</exception>
		[Information(nameof(AddIfNotExists), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool AddIfNotExists<T>(this ICollection<T> collection, T item)
		{
			if (Validate.TryValidateNull(item))
			{
				return false;
			}

			Trace.WriteLine(CreateCollectionIfNull<T>(ref collection));

			Validate.TryValidateParam<ArgumentReadOnlyException>(collection.IsReadOnly == false, nameof(collection));

			if (collection.Contains(item))
			{
				return false;
			}

			collection.Add(item);

			return true;
		}

		/// <summary>
		/// Adds the items to the collection if it does not exist.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="items">The values.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentReadOnlyException">Collection cannot be read-only.</exception>
		[Information(nameof(AddIfNotExists), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool AddIfNotExists<T>(this ICollection<T> collection, params T[] items)
		{
			if (items.DoesNotHaveItems())
			{
				return false;
			}

			Trace.WriteLine(CreateCollectionIfNull<T>(ref collection));

			Validate.TryValidateParam<ArgumentReadOnlyException>(collection.IsReadOnly == false, nameof(collection));

			var returnValue = false;

			if (items.HasItems())
			{
				for (var index = 0; index < items.Length; index++)
				{
					if (items[index].IsNotNull())
					{
						collection.AddIfNotExists(items[index]);
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
		/// <param name="collection">The collection.</param>
		/// <param name="item">The item.</param>
		/// <param name="comparer">The comparer.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentReadOnlyException">List cannot be read-only.</exception>
		/// <exception cref="ArgumentNullException">Collection cannot be <see langword="null" />.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool AddIfNotExists<T>(this ICollection<T> collection, T item, IEqualityComparer<T> comparer)
		{
			if (Validate.TryValidateNull(item))
			{
				return false;
			}

			Trace.WriteLine(CreateCollectionIfNull<T>(ref collection));

			Validate.TryValidateParam<ArgumentReadOnlyException>(collection.IsReadOnly == false, nameof(collection));
			Validate.TryValidateNullParam(comparer, nameof(comparer));

			if (collection.Contains(item, comparer))
			{
				return false;
			}

			collection.Add(item);

			return true;

		}

		/// <summary>
		/// Adds the items to the collection.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="items">The items.</param>
		/// <param name="ensureUnique">The ensure unique.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentReadOnlyException">Collection cannot be read-only.</exception>
		[Information(nameof(AddRange), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool AddRange<T>(this ICollection<T> collection, IEnumerable<T> items, Tristate ensureUnique = Tristate.False)
		{
			if (items.HasItems() == false)
			{
				return false;
			}

			Trace.WriteLine(CreateCollectionIfNull<T>(ref collection));

			Validate.TryValidateParam<ArgumentReadOnlyException>(collection.IsReadOnly == false, nameof(collection));

			var returnValue = false;

			if (items.HasItems())
			{
				items.ToList()
					.ForEach(item =>
					{
						if (ensureUnique == Tristate.True || ensureUnique == Tristate.UseDefault)
						{
							collection.AddIfNotExists(item);
							returnValue = true;
						}
						else
						{
							collection.Add(item);
							returnValue = true;
						}
					});
			}

			return returnValue;
		}

		/// <summary>
		/// Determines whether the specified collection does not have items or is null.
		/// </summary>
		/// <param name="collection">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool DoesNotHaveItems(this ICollection collection)
		{
			return collection?.Count <= 0;
		}

		/// <summary>
		/// Determines whether the specified collection has items.
		/// </summary>
		/// <param name="collection">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems(this ICollection collection)
		{
			return collection?.Count > 0;
		}

		/// <summary>
		/// Determines whether the specified collection has items.
		/// </summary>
		/// <param name="collection">The source.</param>
		/// <param name="count">The specific count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems(this ICollection collection, int count)
		{
			return collection?.Count == count;
		}

		/// <summary>
		/// Creates the collection if null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The collection.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		private static bool CreateCollectionIfNull<T>(ref ICollection<T> collection)
		{
			if (collection is null)
			{
				//TODO: WRITE TEST FOR THIS
				collection = TypeHelper.Create<Collection<T>>();

				return true;
			}

			return false;
		}
	}
}
