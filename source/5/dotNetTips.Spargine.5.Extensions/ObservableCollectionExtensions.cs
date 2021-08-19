// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 12-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-01-2021
// ***********************************************************************
// <copyright file="ObservableCollectionExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.ObjectModel;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
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
		[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static bool DoesNotHaveItems<T>(this ObservableCollection<T> list) => list?.Count <= 0;

		/// <summary>
		/// Determines whether the specified source has items.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="source">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>(this ObservableCollection<T> source) => source?.Count > 0;

		/// <summary>
		/// Determines whether the specified count has items.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="source">The source.</param>
		/// <param name="count">The specific count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>(this ObservableCollection<T> source, int count) => source?.Count == count;
	}
}
