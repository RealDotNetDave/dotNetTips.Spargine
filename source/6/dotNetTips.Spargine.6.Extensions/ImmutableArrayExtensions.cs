// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-17-2022
// ***********************************************************************
// <copyright file="ImmutableArrayExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ImmutableArrayExtensions.
	/// </summary>
	public static class ImmutableArrayExtensions
	{
		/// <summary>
		/// Determines whether the specified <see cref="ICollection{T}" /> has items.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>([NotNull] this ImmutableArray<T> list)
		{
			if (list.IsEmpty)
			{
				return false;
			}
			else
			{
				return list.Count() > 0;
			}
		}

		/// <summary>
		/// Determines whether the specified list has items.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="action">The action.</param>
		/// <returns>bool.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(HasItems), author: "David McCarter", createdOn: "6/15/2022", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD URL")]
		public static bool HasItems<T>([NotNull] this ImmutableArray<T> list, [NotNull] Func<T, bool> action)
		{
			if (list.IsEmpty || action is null)
			{
				return false;
			}
			else
			{
				return list.Any(action);
			}
		}

		/// <summary>
		/// Determines whether the specified <see cref="ICollection{T}" /> has items.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The source.</param>
		/// <param name="count">The specific count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>([NotNull] this ImmutableArray<T> list, int count)
		{
			if (list.IsEmpty)
			{
				return false;
			}
			else
			{
				return list.Count() == count;
			}
		}
		/// <summary>
		/// Shuffles the specified items.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The items.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">list</exception>
		[Information(nameof(Shuffle), "David McCarter", "8/27/2020", "1/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 0)]
		public static ImmutableArray<T> Shuffle<T>([NotNull] this ImmutableArray<T> list)
		{
			return list.DoesNotHaveItems() ? list : list.OrderBy(i => RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue)).ToImmutableArray();
		}
	}
}
