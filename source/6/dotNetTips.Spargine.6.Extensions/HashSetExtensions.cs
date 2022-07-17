// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="HashSetExtensions.cs" company="dotNetTips.Spargine.6.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for the HashSet type.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class HashSetExtensions.
	/// </summary>
	public static class HashSetExtensions
	{
		/// <summary>
		/// Adds item to the <see cref="HashSet{T}" /> if condition is meet.
		/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The list.</param>
		/// <param name="item">The item.</param>
		/// <param name="condition">The condition.</param>
		[Information(nameof(AddIf), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void AddIf<T>([NotNull] this HashSet<T> collection, [NotNull] T item, bool condition)
		{
			collection = collection.ArgumentNotNull();
			item = item.ArgumentNotNull();

			if (condition)
			{
				_ = collection.Add(item);
			}
		}

		/// <summary>
		/// Converts <see cref="HashSet{T}" /> to <see cref="ConcurrentHashSet{T}" />.
		/// Validates that <paramref name="collection" /> is not null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The list.</param>
		/// <returns>ConcurrentHashSet&lt;T&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "12/3/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static ConcurrentHashSet<T> ToConcurrentHashSet<T>([NotNull] this HashSet<T> collection)
		{
			return new ConcurrentHashSet<T>(collection.ArgumentNotNull());
		}

		/// <summary>
		/// Converts to <see cref="HashSet{T}" /> to <see cref="ImmutableHashSet{T}" />.
		/// Validates that <paramref name="collection" /> is not null.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="collection">The values.</param>
		/// <returns>ImmutableHashSet<typeparamref name="T" />&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableHashSet<T> ToImmutable<T>([NotNull] this HashSet<T> collection)
		{
			return ImmutableHashSet.CreateRange(collection.ArgumentNotNull());
		}

		/// <summary>
		/// Upserts the specified item into the <see cref="HashSet{T}" />.
		/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The list.</param>
		/// <param name="item">The item.</param>
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Upsert<T>([NotNull] this HashSet<T> collection, [NotNull] T item)
		{
			collection = collection.ArgumentNotNull();
			item = item.ArgumentNotNull();

			if (collection.Contains(item))
			{
				_ = collection.Remove(item);
			}

			_ = collection.Add(item);
		}
	}
}
