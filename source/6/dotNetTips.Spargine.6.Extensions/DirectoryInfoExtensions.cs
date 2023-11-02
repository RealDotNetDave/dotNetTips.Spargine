// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 03-13-2023
// ***********************************************************************
// <copyright file="DirectoryInfoExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// DirectoryInfoExtensions.
/// </summary>
public static class DirectoryInfoExtensions
{

	/// <summary>
	/// Gets the total size of files in a <see cref="DirectoryInfo" />.
	/// Validates that <paramref name="path" /> and <paramref name="searchPattern" /> is not null
	/// and <paramref name="searchOption" />is defined.
	/// </summary>
	/// <param name="path">The information.</param>
	/// <param name="searchPattern">The search pattern.</param>
	/// <param name="searchOption">The search option.</param>
	/// <returns>System.Int64.</returns>
	/// <exception cref="ArgumentNullException">DirectoryInfo cannot be null.</exception>
	/// <exception cref="ArgumentNullException">Search pattern cannot be null or empty.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Search option invalid.</exception>
	[Information(nameof(GetSize), author: "David McCarter", createdOn: "10/8/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static long GetSize([NotNull] this DirectoryInfo path, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		path = path.ArgumentNotNull();
		searchPattern = searchPattern.ArgumentNotNullOrEmpty();
		searchOption = searchOption.ArgumentDefined();

		return path.GetFiles(searchPattern, searchOption).Sum(p => p.Length);
	}

}
