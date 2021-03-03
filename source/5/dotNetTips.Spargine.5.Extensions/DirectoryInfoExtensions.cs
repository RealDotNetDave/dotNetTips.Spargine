// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 10-08-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="DirectoryInfoExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Linq;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// DirectoryInfoExtensions.
	/// </summary>
	public static class DirectoryInfoExtensions
	{
		/// <summary>
		/// Gets the total size of a directory.
		/// </summary>
		/// <param name="info">The information.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="searchOption">The search option.</param>
		/// <returns>System.Int64.</returns>
		/// <exception cref="ArgumentNullException">DirectoryInfo cannot be null.</exception>
		/// <exception cref="ArgumentNullException">Search pattern cannot be null or empty.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Search option invalid.</exception>
		[Information(nameof(GetSize), author: "David McCarter", createdOn: "10/8/2020", modifiedOn: "10/20/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static long GetSize(this DirectoryInfo info, string searchPattern = "*.*", SearchOption searchOption = SearchOption.TopDirectoryOnly)
		{
			Validate.TryValidateNullParam(info, nameof(info));
			Validate.TryValidateParam(searchPattern, nameof(searchPattern));
			Validate.TryValidateParam(searchOption, nameof(searchOption));

			var size = info.GetFiles(searchPattern, searchOption).Sum(p => p.Length);

			return size;
		}
	}
}
