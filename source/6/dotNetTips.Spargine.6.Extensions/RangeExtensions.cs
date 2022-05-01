// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 01-10-2022
//
// Last Modified By : David McCarter
// Last Modified On : 04-15-2022
// ***********************************************************************
// <copyright file="RangeExtensions.cs" company="David McCarter - dotNetTips.com">
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
		/// <remarks>Original code by: https://twitter.com/mikehadlow</remarks>
		[Information(nameof(GetEnumerator), author: "David McCarter", createdOn: "1/10/2022", UnitTestCoverage = 0, Status = Status.New)]
		public static IEnumerator<int> GetEnumerator([NotNull] this Range range)
		{
			range = range.ArgumentNotNull();

			for (var rangeIndex = range.Start.Value; rangeIndex <= range.End.Value; rangeIndex++)
			{
				yield return rangeIndex;
			}
		}
	}
}
