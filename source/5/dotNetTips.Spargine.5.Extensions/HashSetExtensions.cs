// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-31-2021
// ***********************************************************************
// <copyright file="HashSetExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for the HashSet type.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.Collections.Generic.Concurrent;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class HashSetExtensions.
	/// </summary>
	public static class HashSetExtensions
	{

		/// <summary>
		/// Adds item if condition is meet.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <param name="condition">The condition.</param>
		[Information(nameof(AddIf), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void AddIf<T>([NotNull] this HashSet<T> list, [NotNull] T item, bool condition)
		{
			if (condition)
			{
				_ = list.Add(item);
			}
		}

		/// <summary>
		/// Converts collection to <see cref="ConcurrentHashSet{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>ConcurrentHashSet&lt;T&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "12/3/2021", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available, Documentation = "ADD JAN URL")]
		public static ConcurrentHashSet<T> ToConcurrentHashSet<T>([NotNull] this HashSet<T> list)
		{
			return new ConcurrentHashSet<T>(list);
		}

		/// <summary>
		/// Converts to ImmutableHashSet<typeparamref name="T" />&gt;.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>ImmutableHashSet<typeparamref name="T" />&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableHashSet<T> ToImmutable<T>([NotNull] this HashSet<T> list)
		{
			return ImmutableHashSet.CreateRange(list);
		}

		/// <summary>
		/// Upserts the specified item into the collection.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		[Information(nameof(Upsert), "David McCarter", "5/2/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static void Upsert<T>([NotNull] this HashSet<T> list, [NotNull] T item)
		{
			_ = list.Remove(item);
			_ = list.Add(item);
		}
	}
}
