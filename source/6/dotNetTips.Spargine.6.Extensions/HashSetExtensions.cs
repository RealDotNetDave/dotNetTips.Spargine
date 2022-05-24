// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-24-2022
// ***********************************************************************
// <copyright file="HashSetExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
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
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <param name="condition">The condition.</param>
		[Information(nameof(AddIf), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void AddIf<T>([NotNull] this HashSet<T> list, [NotNull] T item, in bool condition)
		{
			list = list.ArgumentNotNull();
			item = item.ArgumentNotNull();

			if (condition)
			{
				_ = list.Add(item);
			}
		}

		/// <summary>
		/// Converts <see cref="HashSet{T}" /> to <see cref="ConcurrentHashSet{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>ConcurrentHashSet&lt;T&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "12/3/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static ConcurrentHashSet<T> ToConcurrentHashSet<T>([NotNull] this HashSet<T> list)
		{
			return new ConcurrentHashSet<T>(list.ArgumentNotNull());
		}

		/// <summary>
		/// Converts to <see cref="HashSet{T}" /> to <see cref="ImmutableHashSet{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>ImmutableHashSet<typeparamref name="T" />&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableHashSet<T> ToImmutable<T>([NotNull] this HashSet<T> list)
		{
			return ImmutableHashSet.CreateRange(list.ArgumentNotNull());
		}

		/// <summary>
		/// Upserts the specified item into the <see cref="HashSet{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Upsert<T>([NotNull] this HashSet<T> list, [NotNull] T item)
		{
			list = list.ArgumentNotNull();
			item = item.ArgumentNotNull();

			if (list.Contains(item))
			{
				_ = list.Remove(item);
			}

			_ = list.Add(item);
		}
	}
}
