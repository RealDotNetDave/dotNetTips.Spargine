// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 03-02-2021
//
// Last Modified By : David McCarter
// Last Modified On : 09-25-2022
// ***********************************************************************
// <copyright file="PathHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.IO;

/// <summary>
/// Class PathHelper.
/// </summary>
public static class PathHelper
{
	/// <summary>
	/// The invalid file name chars
	/// </summary>
	private static readonly char[] _invalidFileNameChars = FileHelper.InvalidFileNameChars.Where(c => c is not '*' and not '|' and not '?').ToArray();

	/// <summary>
	/// The invalid path chars
	/// </summary>
	private static readonly char[] _invalidPathChars = Path.GetInvalidPathChars().Where(c => c != Path.DirectorySeparatorChar && c != Path.AltDirectorySeparatorChar).ToArray();

	/// <summary>
	/// Combines the paths collection.
	/// </summary>
	/// <param name="createIfNotExists">if set to <c>true</c> [create path if it does not exists].</param>
	/// <param name="paths">The paths.</param>
	/// <returns>DirectoryInfo.</returns>
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, [NotNull] params string[] paths)
	{
		paths = paths.ArgumentItemsExists(nameof(paths));

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
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, string path1, string path2)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();

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
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, string path1, string path2, string path3)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();
		path3 = path3.ArgumentNotNullOrEmpty();

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
	[Information(nameof(CombinePaths), author: "David McCarter", createdOn: "8/10/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static DirectoryInfo CombinePaths(bool createIfNotExists, string path1, string path2, string path3, string path4)
	{
		path1 = path1.ArgumentNotNullOrEmpty();
		path2 = path2.ArgumentNotNullOrEmpty();
		path3 = path3.ArgumentNotNullOrEmpty();
		path4 = path4.ArgumentNotNullOrEmpty();

		var paths = new string[] { path1, path2, path3, path4 };

		return CombinePaths(createIfNotExists, paths);
	}

	/// <summary>
	/// Ensures the trailing slash.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <returns>System.String.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static string EnsureTrailingSlash(string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		return path[^1] != Path.DirectorySeparatorChar ? $"{path}{Path.DirectorySeparatorChar}" : path;
	}

	/// <summary>
	/// Determines whether [has invalid filter chars] [the specified path].
	/// </summary>
	/// <param name="filter">The path.</param>
	/// <returns><c>true</c> if [has invalid filter chars] [the specified path]; otherwise, <c>false</c>.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static bool HasInvalidFilterChars(string filter)
	{
		filter = filter.ArgumentNotNullOrEmpty();

		return filter.IndexOfAny(InvalidFilterChars().ToArray()) != -1;
	}

	/// <summary>
	/// Checks to see if path contains any wild cards.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(PathContainsWildcard), author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static bool PathContainsWildcard(string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		return ( path?.IndexOf('*', StringComparison.Ordinal) != -1 ) || ( path?.IndexOf('?', StringComparison.Ordinal) != -1 );
	}

	/// <summary>
	/// Determines if the path has invalid chars.
	/// </summary>
	/// <param name="path">The path.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static bool PathHasInvalidChars(string path)
	{
		path = path.ArgumentNotNullOrEmpty();

		return path.IndexOfAny(InvalidPathNameChars().ToArray()) != -1;
	}

	/// <summary>
	/// Gets the invalid filter chars.
	/// </summary>
	/// <returns>IEnumerable&lt;System.Char&gt;.</returns>
	/// <value>The invalid filter chars.</value>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
	public static IReadOnlyList<char> InvalidFilterChars()
	{
		return _invalidFileNameChars;
	}

	/// <summary>
	/// Gets the invalid path name chars.
	/// </summary>
	/// <returns>IEnumerable&lt;System.Char&gt;.</returns>
	/// <value>The invalid path name chars.</value>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static IReadOnlyList<char> InvalidPathNameChars()
	{
		return _invalidPathChars;
	}

	/// <summary>
	/// Gets the path separators.
	/// </summary>
	/// <value>The path separators.</value>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, Status = Status.Available)]
	public static IReadOnlyList<char> PathSeparators => new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };
}
