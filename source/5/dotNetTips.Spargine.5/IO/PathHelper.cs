// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-15-2021
// ***********************************************************************
// <copyright file="PathHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
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
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static char[] InvalidFilterChars => FileHelper.InvalidFileNameChars.Where(c => c != '*' && c != '|' && c != '?').ToArray();

		/// <summary>
		/// Gets the invalid path name chars.
		/// </summary>
		/// <value>The invalid path name chars.</value>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static char[] InvalidPathNameChars => Path.GetInvalidPathChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();

		/// <summary>
		/// Gets the path separators.
		/// </summary>
		/// <value>The path separators.</value>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static char[] PathSeparators => new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };

		/// <summary>
		/// Combines the paths.
		/// </summary>
		/// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
		/// <param name="paths">The paths.</param>
		/// <returns>DirectoryInfo.</returns>
		[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static DirectoryInfo CombinePaths(bool createIfNotExists, params string[] paths)
		{
			Validate.TryValidateParam(paths, nameof(paths));

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
		[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static DirectoryInfo CombinePaths(bool createIfNotExists, string path1, string path2)
		{
			Validate.TryValidateParam(path1, nameof(path1));
			Validate.TryValidateParam(path2, nameof(path2));

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
		[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static DirectoryInfo CombinePaths(bool createIfNotExists, string path1, string path2, string path3)
		{
			Validate.TryValidateParam(path1, nameof(path1));
			Validate.TryValidateParam(path2, nameof(path2));
			Validate.TryValidateParam(path3, nameof(path3));

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
		[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static DirectoryInfo CombinePaths(bool createIfNotExists, string path1, string path2, string path3, string path4)
		{
			Validate.TryValidateParam(path1, nameof(path1));
			Validate.TryValidateParam(path2, nameof(path2));
			Validate.TryValidateParam(path3, nameof(path3));
			Validate.TryValidateParam(path4, nameof(path4));

			var paths = new string[] { path1, path2, path3, path4 };

			return CombinePaths(createIfNotExists, paths);
		}

		/// <summary>
		/// Ensures the trailing slash.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns>System.String.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static string EnsureTrailingSlash(string path)
		{
			Validate.TryValidateParam(path, nameof(path));

			return path[path.Length - 1] != Path.DirectorySeparatorChar ? path + Path.DirectorySeparatorChar : path;
		}

		/// <summary>
		/// Determines whether [has invalid filter chars] [the specified path].
		/// </summary>
		/// <param name="filter">The path.</param>
		/// <returns><c>true</c> if [has invalid filter chars] [the specified path]; otherwise, <c>false</c>.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool HasInvalidFilterChars(string filter)
		{
			Validate.TryValidateParam(filter, nameof(filter));

			return filter.IndexOfAny(InvalidFilterChars) != -1;
		}

		/// <summary>
		/// Checks to see if path contains any wild cards.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(PathContainsWildcard), author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool PathContainsWildcard(string path)
		{
			Validate.TryValidateParam(path, nameof(path));

			return ( path?.IndexOf('*') != -1 ) || ( path?.IndexOf('?') != -1 );
		}

		/// <summary>
		/// Determines if the path has invalid chars.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
		public static bool PathHasInvalidChars(string path)
		{
			Validate.TryValidateParam(path, nameof(path));

			return path.IndexOfAny(InvalidPathNameChars) != -1;
		}
	}
}
