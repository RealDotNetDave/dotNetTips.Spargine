// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 08-18-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-24-2022
// ***********************************************************************
// <copyright file="LinqExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class LINQExtensions.
	/// </summary>
	[Information(nameof(LinqExtensions), "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available)]
	public static class LinqExtensions
	{
		/// <summary>
		/// Ifs the input.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="input">The query.</param>
		/// <param name="should">if set to <c>true</c> [should].</param>
		/// <param name="transforms">The transforms.</param>
		/// <returns>IQueryable&lt;T&gt;.</returns>
		[Information("Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine", "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 0)]
		public static IQueryable<T> If<T>([NotNull] this IQueryable<T> input, bool should, [NotNull] params Func<IQueryable<T>, IQueryable<T>>[] transforms)
		{
			input = input.ArgumentNotNull();
			transforms = transforms.ArgumentItemsExists();

			return should ? transforms.Aggregate(input, (current, transform) => transform.Invoke(current)) : input;
		}

		/// <summary>
		/// Ifs the input.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="input">The query.</param>
		/// <param name="should">if set to <c>true</c> [should].</param>
		/// <param name="transforms">The transforms.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		[Information("Original code from https://github.com/exceptionnotfound/ConditionalLinqQueryEngine", "David McCarter", "8/18/20", ModifiedBy = "David McCarter", Status = Status.Available, UnitTestCoverage = 0)]
		public static IEnumerable<T> If<T>([NotNull] this IEnumerable<T> input, bool should, [NotNull] params Func<IEnumerable<T>, IEnumerable<T>>[] transforms)
		{
			input = input.ArgumentNotNull();
			transforms = transforms.ArgumentItemsExists();

			return should ? transforms.Aggregate(input, (current, transform) => transform.Invoke(current)) : input;
		}
	}
}
