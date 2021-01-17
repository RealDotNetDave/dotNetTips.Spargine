// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 12-23-2020
// ***********************************************************************
// <copyright file="SortedSetExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Collections.Immutable;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class SortedSetExtensions.
	/// </summary>
	public static class SortedSetExtensions
	{
		/// <summary>
		/// Converts to immutable SortedSet.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>ImmutableSortedSet&lt;T&gt;.</returns>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableSortedSet<T> ToImmutable<T>(this SortedSet<T> list)
		{
			Encapsulation.TryValidateParam(list, nameof(list));

			return ImmutableSortedSet.CreateRange<T>(list);
		}
	}
}
