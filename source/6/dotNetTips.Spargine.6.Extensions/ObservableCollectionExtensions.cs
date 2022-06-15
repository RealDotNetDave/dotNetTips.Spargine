// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 06-15-2022
// ***********************************************************************
// <copyright file="ObservableCollectionExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class ObservableCollectionExtensions.
	/// </summary>
	public static class ObservableCollectionExtensions
	{
		/// <summary>
		/// Determines whether the specified source does not have items or is null.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static bool DoesNotHaveItems<T>(this ObservableCollection<T> list)
		{
			return list?.FastCount() <= 0;
		}

		/// <summary>
		/// Determines whether the specified source has items.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="source">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>(this ObservableCollection<T> source)
		{
			if (source is null)
			{
				return false;
			}
			else
			{
				return source?.FastCount() > 0;
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
		public static bool HasItems<T>([NotNull] this ObservableCollection<T> list, [NotNull] Func<T, bool> action)
		{
			if (list is null || action is null)
			{
				return false;
			}
			else
			{
				return list.Any(action);
			}
		}

		/// <summary>
		/// Determines whether the specified count has items.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="count">The specific count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>(this ObservableCollection<T> source, int count)
		{
			if (source is null)
			{
				return false;
			}
			else
			{
				return source.FastCount() == count;
			}
		}
	}
}
