// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 08-18-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-18-2021
// ***********************************************************************
// <copyright file="LINQExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class LINQExtensions.
	/// </summary>
	[Information(nameof(LINQExtensions), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 0)]
	public static class LINQExtensions
	{
		/// <summary>
		/// Ifs the specified should.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="input">The query.</param>
		/// <param name="should">if set to <c>true</c> [should].</param>
		/// <param name="transforms">The transforms.</param>
		/// <returns>IQueryable&lt;T&gt;.</returns>
		[Information("Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine", "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 0)]
		public static IQueryable<T> If<T>([NotNull] this IQueryable<T> input, bool should, [NotNull] params Func<IQueryable<T>, IQueryable<T>>[] transforms)
		{
			return should ? transforms.Aggregate(input, (current, transform) => transform.Invoke(current)) : input;
		}

		/// <summary>
		/// Ifs the specified should.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="input">The query.</param>
		/// <param name="should">if set to <c>true</c> [should].</param>
		/// <param name="transforms">The transforms.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		[Information("Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine", "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 0)]
		public static IEnumerable<T> If<T>([NotNull] this IEnumerable<T> input, bool should, [NotNull] params Func<IEnumerable<T>, IEnumerable<T>>[] transforms)
		{
			return should ? transforms.Aggregate(input, (current, transform) => transform.Invoke(current)) : input;
		}
	}
}
