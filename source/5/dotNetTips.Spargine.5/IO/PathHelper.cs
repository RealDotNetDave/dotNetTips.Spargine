// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-12-2021
// ***********************************************************************
// <copyright file="PathHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;

namespace dotNetTips.Spargine.IO
{
	/// <summary>
	/// Class PathHelper.
	/// </summary>
	public static class PathHelper
	{
		/// <summary>
		/// Gets the invalid filter chars.
		/// </summary>
		/// <value>The invalid filter chars.</value>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<char> InvalidFilterChars => FileHelper.InvalidFileNameChars.Where(c => c is not '*' and not '|' and not '?').ToArray();

		/// <summary>
		/// Gets the invalid path name chars.
		/// </summary>
		/// <value>The invalid path name chars.</value>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<char> InvalidPathNameChars => Path.GetInvalidPathChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();

		/// <summary>
		/// Gets the path separators.
		/// </summary>
		/// <value>The path separators.</value>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<char> PathSeparators => new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };

		/// <summary>
		/// Combines the paths collection.
		/// </summary>
		/// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
		/// <param name="paths">The paths.</param>
		/// <returns>DirectoryInfo.</returns>
		[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] params string[] paths)
		{
			for (var paramCount = 0; paramCount < paths.Length; paramCount++)
			{
				paths[paramCount] = paths[paramCount].ToTrimmed();
			}

			var pathString = Path.Combine(paths);

			var di = new DirectoryInfo(pathString);

			if (createIfNotExists && di.Exists is false)
			{
				di.Create();
			}

			return di;
		}

		/// <summary>
		/// Combines the specified path strings.
		/// </summary>
		/// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
		/// <param name="path1">The path1.</param>
		/// <param name="path2">The path2.</param>
		/// <returns>DirectoryInfo.</returns>
		[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] string path1, [NotNull] string path2)
		{
			return CombinePaths(createIfNotExists, new string[] { path1, path2 });
		}

		/// <summary>
		/// Combines the paths.
		/// </summary>
		/// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
		/// <param name="path1">The path1.</param>
		/// <param name="path2">The path2.</param>
		/// <param name="path3">The path3.</param>
		/// <returns>DirectoryInfo.</returns>
		[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] string path1, [NotNull] string path2, [NotNull] string path3)
		{
			return CombinePaths(createIfNotExists, new string[] { path1, path2, path3 });
		}

		/// <summary>
		/// Combines the paths.
		/// </summary>
		/// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
		/// <param name="path1">The path1.</param>
		/// <param name="path2">The path2.</param>
		/// <param name="path3">The path3.</param>
		/// <param name="path4">The path4.</param>
		/// <returns>DirectoryInfo.</returns>
		[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] string path1, [NotNull] string path2, [NotNull] string path3, [NotNull] string path4)
		{
			var paths = new string[] { path1, path2, path3, path4 };

			return CombinePaths(createIfNotExists, paths);
		}

		/// <summary>
		/// Ensures the trailing slash.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns>System.String.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static string EnsureTrailingSlash([NotNull] string path)
		{
			return path[^1] != Path.DirectorySeparatorChar ? $"{path}{Path.DirectorySeparatorChar}" : path;
		}

		/// <summary>
		/// Determines whether [has invalid filter chars] [the specified path].
		/// </summary>
		/// <param name="filter">The path.</param>
		/// <returns><c>true</c> if [has invalid filter chars] [the specified path]; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static bool HasInvalidFilterChars([NotNull] string filter)
		{
			return filter.IndexOfAny(InvalidFilterChars.ToArray()) != -1;
		}

		/// <summary>
		/// Checks to see if path contains any wild cards.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(PathContainsWildcard), author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static bool PathContainsWildcard([NotNull] string path)
		{
			return ( path?.IndexOf('*', StringComparison.Ordinal) != -1 ) || ( path?.IndexOf('?', StringComparison.Ordinal) != -1 );
		}

		/// <summary>
		/// Determines if the path has invalid chars.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static bool PathHasInvalidChars([NotNull] string path)
		{
			return path.IndexOfAny(InvalidPathNameChars.ToArray()) != -1;
		}
	}
}
