// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-27-2022
// ***********************************************************************
// <copyright file="CollectionExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for the ICollection types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension methods for the <see cref="ICollection" /> Collection type.
	/// </summary>
	public static class CollectionExtensions
	{

		/// <summary>
		/// Creates a <see cref="ICollection{T}" /> if null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The collection.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		private static bool CreateCollectionIfNull<T>(ref ICollection<T> collection)
		{
			if (collection is null)
			{
				collection = TypeHelper.Create<Collection<T>>();

				return true;
			}

			return false;
		}

		/// <summary>
		/// Adds item to the <see cref="ICollection{T}" /> if the condition is meet.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="item">The item.</param>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(AddIf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void AddIf<T>([NotNull] this ICollection<T> collection, [NotNull] T item, bool condition)
		{
			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
			item = item.ArgumentNotNull();

			Trace.WriteLine(CreateCollectionIfNull(ref collection));

			if (condition)
			{
				collection.Add(item);
			}
		}

		/// <summary>
		/// Adds the item to the <see cref="ICollection{T}" /> if it does not exist.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="item">The value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">Collection cannot be null.</exception>
		/// <exception cref="ArgumentReadOnlyException">Collection cannot be read-only.</exception>
		[Information(nameof(AddIfNotExists), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool AddIfNotExists<T>([NotNull] this ICollection<T> collection, [NotNull] T item)
		{
			if (item is null)
			{
				return false;
			}

			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

			Trace.WriteLine(CreateCollectionIfNull(ref collection));

			if (collection.Contains(item))
			{
				return false;
			}

			collection.Add(item);

			return true;
		}

		/// <summary>
		/// Adds the items to the <see cref="ICollection{T}" /> if they do not exist.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="items">The values.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentReadOnlyException">Collection cannot be read-only.</exception>
		[Information(nameof(AddIfNotExists), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool AddIfNotExists<T>([NotNull] this ICollection<T> collection, [NotNull] params T[] items)
		{
			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
			items = items.ArgumentNotNull();

			Trace.WriteLine(CreateCollectionIfNull(ref collection));

			var returnValue = false;

			if (items.HasItems())
			{
				for (var index = 0; index < items.Length; index++)
				{
					if (items[index].IsNotNull())
					{
						_ = collection.AddIfNotExists(items[index]);
						returnValue = true;
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Adds the item to the <see cref="ICollection{T}" /> if it does not exist.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="item">The item.</param>
		/// <param name="comparer">The comparer.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentReadOnlyException">List cannot be read-only.</exception>
		/// <exception cref="ArgumentNullException">Collection cannot be <see langword="null" />.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool AddIfNotExists<T>([NotNull] this ICollection<T> collection, [NotNull] T item, [NotNull] IEqualityComparer<T> comparer)
		{
			if (item is null)
			{
				return false;
			}

			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
			comparer = comparer.ArgumentNotNull();

			Trace.WriteLine(CreateCollectionIfNull(ref collection));

			if (collection.Contains(item, comparer))
			{
				return false;
			}

			collection.Add(item);

			return true;

		}

		/// <summary>
		/// Adds the items to the <see cref="ICollection{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="items">The items.</param>
		/// <param name="ensureUnique">The ensure unique.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentReadOnlyException">Collection cannot be read-only.</exception>
		[Information(nameof(AddRange), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool AddRange<T>([NotNull] this ICollection<T> collection, [NotNull] IEnumerable<T> items, Tristate ensureUnique = Tristate.False)
		{
			collection = collection.ArgumentNotNull().ArgumentNotReadOnly();
			items = items.ArgumentNotNull();

			Trace.WriteLine(CreateCollectionIfNull(ref collection));

			var returnValue = false;

			if (items.HasItems())
			{
				items.ToList()
					.ForEach(item =>
					{
						if (ensureUnique is Tristate.True or Tristate.UseDefault)
						{
							_ = collection.AddIfNotExists(item);
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
		/// Determines whether the specified <see cref="ICollection{T}" /> does not have items or is null.
		/// </summary>
		/// <param name="collection">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool DoesNotHaveItems([NotNull] this ICollection collection)
		{
			return collection?.Count <= 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="ICollection{T}" /> has items.
		/// </summary>
		/// <param name="collection">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems([NotNull] this ICollection collection)
		{
			return collection?.Count > 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="ICollection{T}" /> has items.
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
		/// Upserts (add or insert) the specified item to a <see cref="ICollection{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(Upsert), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Upsert<T>([NotNull] this ICollection<T> collection, [NotNull] T item)
		{
			collection = collection.ArgumentNotReadOnly().ArgumentNotReadOnly();
			item = item.ArgumentNotNull();

			_ = collection.Remove(item);

			collection.Add(item);
		}

		/// <summary>
		/// Upserts (add or insert) the specified item to a <see cref="ICollection{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TKey">The type of the t key.</typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="item">The item.</param>
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Upsert<T, TKey>([NotNull] this ICollection<T> collection, [NotNull] T item) where T : IDataModel<T, TKey>
		{
			collection = collection.ArgumentNotReadOnly(nameof(collection));
			item = item.ArgumentNotNull();

			_ = collection.Remove(item);

			collection.Add(item);
		}

		/// <summary>
		/// Upserts (add or insert) the specified item to a <see cref="ICollection{T}" />.
		/// </summary>
		/// <param name="collection">The collection.</param>
		/// <param name="item">The item.</param>
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Upsert([NotNull] this ICollection<IDataRecord> collection, [NotNull] IDataRecord item)
		{
			collection = collection.ArgumentNotReadOnly();
			item = item.ArgumentNotNull();

			var currentItem = collection.FirstOrDefault(p => p.Id.Equals(item.Id, StringComparison.Ordinal));

			if (currentItem is not null)
			{
				_ = collection.Remove(currentItem);
			}

			collection.Add(item);
		}
	}
}
