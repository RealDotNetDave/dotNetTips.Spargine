// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-02-2023
// ***********************************************************************
// <copyright file="CollectionExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extension methods for the ICollection types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;
using Microsoft.VisualBasic;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extension methods for the <see cref="ICollection" /> Collection type.
/// </summary>
public static class CollectionExtensions
{

	/// <summary>
	/// Adds item to the <see cref="ICollection{T}" /> if the condition is meet.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="item">The item.</param>
	/// <param name="condition">if set to <c>true</c> [condition].</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(AddIf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void AddIf<T>([NotNull] this ICollection<T> collection, [NotNull] T item, bool condition)
	{
		item = item.ArgumentNotNull();
		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		if (condition)
		{
			collection.Add(item);
		}
	}

	/// <summary>
	/// Adds the item to the <see cref="ICollection{T}" /> if it does not exist.
	/// Validates that <paramref name="collection" /> is not null and not readonly.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="item">The value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">Collection cannot be null.</exception>
	/// <exception cref="ArgumentReadOnlyException">Collection cannot be read-only.</exception>
	[Information(nameof(AddIfNotExists), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static bool AddIfNotExists<T>([NotNull] this ICollection<T> collection, [AllowNull] T item)
	{
		if (item is null)
		{
			return false;
		}

		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		if (collection.Contains<T>(item))
		{
			return false;
		}

		collection.Add(item);

		return true;
	}

	/// <summary>
	/// Adds the item to the <see cref="ICollection{T}" /> if it does not exist.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null
	/// and <paramref name="collection" /> is not readonly.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="item">The item.</param>
	/// <param name="comparer">The comparer.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentReadOnlyException">List cannot be read-only.</exception>
	/// <exception cref="ArgumentNullException">Collection cannot be <see langword="null" />.</exception>
	/// <example>
	///   <code>
	/// people.AddIfNotExists(person, comparer)
	/// </code>
	/// </example>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static bool AddIfNotExists<T>([NotNull] this ICollection<T> collection, [AllowNull] T item, [NotNull] IEqualityComparer<T> comparer)
	{
		if (item is null)
		{
			return false;
		}

		item = item.ArgumentNotNull();
		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		if (collection.Contains(item, comparer))
		{
			return false;
		}

		collection.Add(item);

		return true;
	}

	/// <summary>
	/// Adds the items to the <see cref="ICollection{T}" />. Validates that <paramref name="collection" /> and <paramref name="items" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="items">The items.</param>
	/// <param name="ensureUnique">The ensure unique.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	public static bool AddRange<T>([NotNull] this ICollection<T> collection, [NotNull] IEnumerable<T> items, Tristate ensureUnique = Tristate.False)
	{
		items = items.ArgumentNotNull();
		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		if (ensureUnique is Tristate.False)
		{
			foreach (var item in items)
			{
				collection.Add(item);
			}

			return true;
		}

		var result = false;

		foreach (var item in items.Distinct().Where(item => collection.Contains(item) is false))
		{
			collection.Add(item);
			result = true;
		}

		return result;
	}

	/// <summary>
	/// Determines whether the specified <see cref="ICollection{T}" /> does not have items.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems([NotNull] this ICollection collection)
	{
		return collection?.Count <= 0;
	}

	/// <summary>
	/// Determines whether the specified <see cref="ICollection{T}" /> has items.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems([AllowNull] this ICollection collection)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.Count > 0;
		}
	}

	/// <summary>
	/// Determines whether the specified <see cref="ICollection{T}" /> has a specific count.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <param name="count">The specific count.</param>
	/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems([AllowNull] this ICollection collection, int count)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.Count == count;
		}
	}

	/// <summary>
	/// Upserts (add or insert) the specified item to a <see cref="ICollection{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null
	/// and <paramref name="collection" /> is not readonly.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="item">The item.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(Upsert), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void Upsert<T>([NotNull] this ICollection<T> collection, [NotNull] T item)
	{
		item = item.ArgumentNotNull();
		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		_ = collection.Remove(item);

		collection.Add(item);
	}

	/// <summary>
	/// Upserts (add or insert) the specified item to a <see cref="ICollection{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null
	/// and <paramref name="collection" /> is not readonly.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TKey">The type of the t key.</typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="item">The item.</param>
	[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void Upsert<T, TKey>([NotNull] this ICollection<T> collection, [NotNull] T item) where T : IDataModel<T, TKey>
	{
		item = item.ArgumentNotNull();
		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		_ = collection.Remove(item);

		collection.Add(item);
	}

	/// <summary>
	/// Upserts (add or insert) the specified item to a <see cref="ICollection{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null
	/// and <paramref name="collection" /> is not readonly.
	/// </summary>
	/// <param name="collection">The collection.</param>
	/// <param name="item">The item.</param>
	[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static void Upsert([NotNull] this ICollection<IDataRecord> collection, [NotNull] IDataRecord item)
	{
		item = item.ArgumentNotNull();
		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		var currentItem = collection.FirstOrDefault(p => p.Id.Equals(item.Id, StringComparison.Ordinal));

		if (currentItem is not null)
		{
			_ = collection.Remove(currentItem);
		}

		collection.Add(item);
	}

}
