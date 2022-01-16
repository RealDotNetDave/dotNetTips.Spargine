// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 01-10-2022
//
// Last Modified By : David McCarter
// Last Modified On : 01-10-2022
// ***********************************************************************
// <copyright file="RangeExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;

namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class RangeExtensions.
	/// </summary>
	[Information("Extension methods for the Range type.", author: "David McCarter", createdOn: "1/10/2022", Status = Status.New)]
	public static class RangeExtensions
	{
		/// <summary>
		/// Gets the enumerator.
		/// </summary>
		/// <param name="range">The range.</param>
		/// <returns>IEnumerator&lt;System.Int32&gt;.</returns>
		/// <remarks>Original code by: https://twitter.com/mikehadlow </remarks>
		[Information(nameof(GetEnumerator), author: "David McCarter", createdOn: "1/10/2022", UnitTestCoverage = 0, Status = Status.New)]
		public static IEnumerator<int> GetEnumerator([NotNull] this Range range)
		{
			for (var count = range.Start.Value; count <= range.End.Value; count++)
			{
				yield return count;
			}
		}
	}
}
