// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-16-2022
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="dotNetTips.Spargine.6.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for IEnumerable types.</summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks.Dataflow;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic;
using Microsoft.Extensions.ObjectPool;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class EnumerableExtensions.
/// </summary>
public static class EnumerableExtensions
{
	/// <summary>
	/// The string builder pool
	/// </summary>
	private static readonly ObjectPool<StringBuilder> _stringBuilderPool = new DefaultObjectPoolProvider().CreateStringBuilderPool();

	/// <summary>
	/// Gets the random.
	/// </summary>
	/// <returns>System.Int32.</returns>
	/// <value>The random.</value>
	private static int GenerateRandomNumber()
	{
		return RandomNumberGenerator.GetInt32(int.MaxValue);
	}

	/// <summary>
	/// Adds the specified item to the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(Add), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IEnumerable<T> Add<T>([NotNull] this IEnumerable<T> collection, [AllowNull] T item)
	{
		//TODO: REMOVE METHOD IN V8. CREATE ADDFIRST() & ADDLAST() LIKE ARRAYEXTENSIONS.

		if (item is null)
		{
			return collection;
		}

		collection = collection.ArgumentNotNull();

		return collection.Append(item);
	}

	/// <summary>
	/// Adds item to the <see cref="IEnumerable{T}" /> if the condition is met.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <param name="condition">if set to <c>true</c> [condition].</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	[Information(nameof(AddIf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IEnumerable<T> AddIf<T>([NotNull] this IEnumerable<T> collection, [AllowNull] T item, bool condition)
	{
		if (item is null)
		{
			return collection;
		}

		collection = collection.ArgumentNotNull();

		if (condition)
		{
			collection = collection.Add(item);
		}

		return collection;
	}

	/// <summary>
	/// Ensures the items in the collection are unique.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	[Information(nameof(Add), "David McCarter", "11/8/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IEnumerable<T> EnsureUnique<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		return collection.Distinct();
	}

	/// <summary>
	/// Determines whether the specified  <see cref="IEnumerable{T}" /> has items specified.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="items">The items.</param>
	/// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">List is null or empty.</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineSep2022")]
	public static bool ContainsAny<T>([NotNull] this IEnumerable<T> collection, [NotNull] params T[] items)
	{
		if (collection is null || items is null)
		{
			return false;
		}

		if (items.DoesNotHaveItems())
		{
			return false;
		}

		return collection.FastAny(p => items.Contains(p));
	}

	/// <summary>
	/// Counts items in a <see cref="IEnumerable" />.
	/// </summary>
	/// <param name="collection">The list.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentNullException">list</exception>
	[Information(nameof(Count), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static int Count([NotNull] this IEnumerable collection)
	{
		if (collection is null)
		{
			return 0;
		}

		var count = 0;

		var enumerator = collection.GetEnumerator();

		while (enumerator.MoveNext())
		{
			count++;
		}

		return count;
	}

	/// <summary>
	/// Determines whether the specified <see cref="IEnumerable" /> does not have items or is null.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems([NotNull] this IEnumerable collection)
	{
		return collection?.Count() <= 0;
	}

	/// <summary>
	/// Determines if any items exist in the <see cref="IEnumerable" />.
	/// Validates that <paramref name="collection" /> and <paramref name="predicate" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="predicate">The predicate.</param>
	/// <returns>System.Boolean.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
	/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
	[Information(nameof(FastAny), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool FastAny<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> predicate)
	{
		return collection.ArgumentNotNull().Any(predicate.ArgumentNotNull());
	}

	/// <summary>
	/// Counts items in the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>System.Int64.</returns>
	[Information(nameof(FastCount), "David McCarter", "5/21/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static long FastCount<T>([NotNull] this IEnumerable<T> collection)
	{
		return collection.ArgumentNotNull().Count();
	}

	/// <summary>
	/// Counts items in the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="predicate" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="predicate">The predicate.</param>
	/// <returns>System.Int64.</returns>
	/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
	[Information(nameof(FastCount), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static long FastCount<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> predicate)
	{
		return collection.ArgumentNotNull().Count(predicate.ArgumentNotNull());
	}

	/// <summary>
	/// Processes the <see cref="IEnumerable{T}" /> with the specified action in parallel processing.
	/// </summary>
	/// <typeparam name="T">Generic type</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="action">The action to perform.</param>
	/// <param name="maxDegreeOfParallelism">The maximum degree of parallelism.</param>
	/// <param name="ensureOrdered">if set to <c>true</c> [ensure ordered].</param>
	/// <param name="scheduler">The scheduler.</param>
	/// <returns>Task.</returns>
	/// <exception cref="ArgumentInvalidException">collection cannot be null.</exception>
	/// <exception cref="ArgumentInvalidException">action cannot be null.</exception>
	/// <example>
	///   <code>
	/// var task = people.FastParallelProcessor((Person person) =&gt;
	/// {
	/// person.Address2 = "TEST DATA";
	/// }, App.MaxDegreeOfParallelism());
	/// </code>
	/// </example>
	/// <remarks>Original code by: Alexandru Puiu: https://medium.com/@alex.puiu/parallel-foreach-async-in-c-36756f8ebe62</remarks>
	[Information(nameof(FastParallelProcessor), author: "David McCarter", createdOn: "11/9/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineApril2022")]
	public static Task FastParallelProcessor<T>([NotNull] this IEnumerable<T> collection, [NotNull] Action<T> action, int maxDegreeOfParallelism = DataflowBlockOptions.Unbounded, bool ensureOrdered = false, TaskScheduler scheduler = null)
	{
		collection = collection.ArgumentNotNull();
		action = action.ArgumentNotNull();

		var options = new ExecutionDataflowBlockOptions
		{
			MaxDegreeOfParallelism = maxDegreeOfParallelism,
			EnsureOrdered = ensureOrdered
		};

		if (scheduler != null)
		{
			options.TaskScheduler = scheduler;
		}

		var block = new ActionBlock<T>(action, options);

		foreach (var item in collection)
		{
			_ = block.Post(item);
		}

		block.Complete();

		return block.Completion;
	}

	/// <summary>
	/// Returns first item in the <see cref="IEnumerable{T}" /> or an alternate.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="alternate">The alternate.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">Alternate cannot be null.</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T FirstOrDefault<T>([AllowNull] this IEnumerable<T> collection, [NotNull] T alternate)
	{
		return collection is null ? alternate : collection.DefaultIfEmpty(alternate).First();
	}

	/// <summary>
	/// Returns first item in the <see cref="IEnumerable{T}" /> or an alternate using a predicate.
	/// Validates that <paramref name="alternate" /> and <paramref name="predicate" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="list">The source.</param>
	/// <param name="predicate">The predicate.</param>
	/// <param name="alternate">The alternate.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
	/// <exception cref="ArgumentNullException">Alternate cannot be null.</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T FirstOrDefault<T>(this IEnumerable<T> list, [NotNull] Func<T, bool> predicate, [NotNull] T alternate)
	{
		alternate = alternate.ArgumentNotNull();

		if (list is null)
		{
			return alternate;
		}

		predicate = predicate.ArgumentNotNull();

		var filteredList = list.Where(predicate).AsEnumerable();

		return filteredList.HasItems() ? filteredList.FirstOrDefault(alternate) : alternate;
	}

	/// <summary>
	/// Finds first item in the <see cref="IEnumerable{T}" /> or returns null.
	/// Validates that <paramref name="collection" /> contains items.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="match">The match.</param>
	/// <returns>System.Nullable&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">Match cannot be null.</exception>
	[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T? FirstOrNull<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, bool> match)
		where T : struct
	{
		var listToProcess = collection.ArgumentItemsExists().ToCollection();

		for (var listCount = 0; listCount < listToProcess.FastCount(); listCount++)
		{
			var local = listToProcess[listCount];

			if (match?.Invoke(local) ?? default)
			{
				return new T?(local);
			}
		}

		return null;
	}

	/// <summary>
	/// Determines whether the specified <see cref="IEnumerable" /> has items or is null.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems([AllowNull] this IEnumerable collection)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.Count() > 0;
		}
	}

	/// <summary>
	/// Determines whether the <see cref="IEnumerable" /> has a specified count.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <param name="count">The specific count.</param>
	/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems([AllowNull] this IEnumerable collection, int count)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.Count() == count;
		}
	}

	/// <summary>
	/// Returns index of item in the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="item">The item.</param>
	/// <returns>System.Int32.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static int IndexOf<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item)
	{
		return IndexOf(collection.ArgumentItemsExists(), item.ArgumentNotNull(), EqualityComparer<T>.Default);
	}

	/// <summary>
	/// Returns index of an item in the collection using comparer.
	/// Validates that <paramref name="collection" />, <paramref name="item" /> and <paramref name="comparer" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="item">The item.</param>
	/// <param name="comparer">The comparer.</param>
	/// <returns>System.Int32.</returns>
	/// <exception cref="ArgumentNullException">item or comparer</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static int IndexOf<T>([NotNull] this IEnumerable<T> collection, [NotNull] T item, [NotNull] IEqualityComparer<T> comparer)
	{
		collection = collection.ArgumentItemsExists();
		item = item.ArgumentNotNull();
		comparer = comparer.ArgumentNotNull();

		return collection.Select((x, index) => comparer.Equals(item, x) ? index : -1).FirstOrDefault(x => x != -1, -1);
	}

	/// <summary>
	/// Determines whether <see cref="IEnumerable" /> is null or empty.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if [is null or empty] [the specified source]; otherwise, <c>false</c>.</returns>
	[Information(nameof(IsNullOrEmpty), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool IsNullOrEmpty([AllowNull] this IEnumerable collection)
	{
		return collection.IsNull() || collection.GetEnumerator().MoveNext() is false;
	}

	/// <summary>
	/// Joins a collection using the specified separator.
	/// Validates that <paramref name="collection" /> contains items.
	/// </summary>
	/// <param name="collection">The source.</param>
	/// <param name="separator">The separator.</param>
	/// <returns>System.String.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(Join), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static string Join([NotNull] this IEnumerable<object> collection, [NotNull] string separator = ControlChars.DefaultSeparator)
	{
		if (collection.CheckItemsExists() is false)
		{
			return string.Empty;
		}

		return string.Join(separator.ArgumentNotNullOrEmpty(defaultValue: ControlChars.DefaultSeparator), collection);
	}

	/// <summary>
	/// Orders a <see cref="IEnumerable{T}" /> based on a sort expression. Useful in object binding scenarios where the ObjectDataSource
	/// generates a dynamic sort expression (example: "Name desc") that specifies the property of the object sort
	/// on.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="sortExpression">The sort expression.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <exception cref="InvalidCastException"></exception>
	/// <remarks>Original code by: C.F.Meijers</remarks>
	[Information(nameof(OrderBy), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IEnumerable<T> OrderBy<T>([NotNull] this IEnumerable<T> collection, [NotNull] string sortExpression)
	{
		collection = collection.ArgumentNotNull();

		sortExpression += string.Empty;

		var parts = sortExpression.Split(Convert.ToChar(" ", CultureInfo.InvariantCulture));
		var descending = false;
		var property = string.Empty;

		if (parts.Length > 0 && !string.IsNullOrEmpty(parts[0]))
		{
			property = parts[0];

			if (parts.Length > 1)
			{
				@descending = CultureInfo.InvariantCulture.TextInfo.ToLower(parts[1]).Contains("esc", StringComparison.OrdinalIgnoreCase);
			}

			var prop = typeof(T).GetRuntimeProperty(property);

			if (prop.CheckIsNotNull(throwException: true))
			{
				return @descending
					? collection.OrderByDescending(x => prop.GetValue(x, null))
					: collection.OrderBy(x => prop.GetValue(x, null));
			}
		}

		return collection;
	}

	/// <summary>
	/// Orders <see cref="IEnumerable{T}" /> by <see cref="StringComparer.Ordinal" />
	/// Validates that <paramref name="collection" /> and <paramref name="keySelector" /> is not null.
	/// </summary>
	/// <typeparam name="T">The type of the t source.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="keySelector">The key selector.</param>
	/// <returns>IOrderedEnumerable&lt;T&gt;.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IOrderedEnumerable<T> OrderByOrdinal<T>([NotNull] this IEnumerable<T> collection, [NotNull] Func<T, string> keySelector)
	{
		return collection.ArgumentNotNull().OrderBy(keySelector.ArgumentNotNull(), StringComparer.Ordinal);
	}

	/// <summary>
	/// Converts a collection into separate collections based on page size.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="pageSize">Size of the page. Minimum page size is 1.</param>
	/// <returns>IEnumerable&lt;IEnumerable&lt;T&gt;&gt;.</returns>
	/// <exception cref="ArgumentOutOfRangeException">pageSize</exception>
	/// <exception cref="ArgumentNullException">pageSize</exception>
	/// <exception cref="ArgumentNullException">pageSize</exception>
	/// <exception cref="ArgumentOutOfRangeException">pageSize</exception>
	[Information(nameof(Page), "David McCarter", "11/21/2010", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static IEnumerable<IEnumerable<T>> Page<T>([NotNull] this IEnumerable<T> collection, int pageSize)
	{
		collection = collection.ArgumentNotNull();

		pageSize = pageSize.EnsureMinimum(1);

		using (var enumerator = collection.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				var currentPage = new List<T>(pageSize) { enumerator.Current };

				while (currentPage.FastCount() < pageSize && enumerator.MoveNext())
				{
					currentPage.Add(enumerator.Current);
				}

				yield return currentPage.AsEnumerable();
			}
		}
	}

	/// <summary>
	/// Picks a random item from a collection.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>T.</returns>
	[Information(nameof(PickRandom), "David McCarter", "8/26/2020", "9/19/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineNov2022")]
	public static T PickRandom<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentNotNull();

		var index = RandomNumberGenerator.GetInt32(0, collection.Count() - 1);

		return collection.ElementAt(index);
	}

	/// <summary>
	/// Shuffles the specified <see cref="List{T}" />.
	/// Validates that <paramref name="collection" /> contains items.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The items.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">list</exception>
	[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "8/26/2020", BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineSep2020")]
	public static IEnumerable<T> Shuffle<T>([NotNull] this IEnumerable<T> collection)
	{
		return collection.ArgumentItemsExists().OrderBy(_ => GenerateRandomNumber());
	}

	/// <summary>
	/// Shuffles items in a <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The items.</param>
	/// <param name="count">The count.</param>
	/// <returns>IEnumerable&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null.</exception>
	/// <exception cref="ArgumentOutOfRangeException">Count must be greater than 0</exception>
	[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineSep2020")]
	public static IEnumerable<T> Shuffle<T>([NotNull] this IEnumerable<T> collection, int count)
	{
		collection = collection.ArgumentNotNull();
		count = Math.Max(1, count);

		return collection.Shuffle().Take(count);
	}

	/// <summary>
	/// Determines if first <see cref="IEnumerable{T}" /> starts with the second <see cref="IEnumerable{T}" />.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="first">The first.</param>
	/// <param name="second">The second.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(StartsWith), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool StartsWith<T>(this IEnumerable<T> first, IEnumerable<T> second)
	{
		if (first is null || second is null)
		{
			return false;
		}

		if (ReferenceEquals(first, second))
		{
			return true;
		}

		using (var firstEnumerator = first.GetEnumerator())
		{
			foreach (var item in second)
			{
				if (!firstEnumerator.MoveNext() || !Equals(firstEnumerator.Current, item))
				{
					return false;
				}
			}
		}

		return true;
	}

	/// <summary>
	/// Determines if two <see cref="IEnumerable{T}" /> sequences are equal.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="first">The first.</param>
	/// <param name="second">The second.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">second</exception>
	/// <remarks>Original code from efcore-master on GitHub.</remarks>
	[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static bool StructuralSequenceEqual<T>(this IEnumerable<T> first, IEnumerable<T> second)
	{
		if (first is null || second is null)
		{
			return false;
		}

		if (ReferenceEquals(first, second))
		{
			return true;
		}

		using (var firstEnumerator = first.GetEnumerator())
		{
			using (var secondEnumerator = second.GetEnumerator())
			{
				while (firstEnumerator.MoveNext())
				{
					if (!secondEnumerator.MoveNext() ||
						!StructuralComparisons.StructuralEqualityComparer
							.Equals(firstEnumerator.Current, secondEnumerator.Current))
					{
						return false;
					}
				}

				return !secondEnumerator.MoveNext();
			}
		}
	}

	/// <summary>
	/// Converts a <see cref="IEnumerable{T}" /> to a BlockingCollection.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>BlockingCollection&lt;T&gt;.</returns>
	/// <remarks>The resulting collection supports IDisposable. Make sure to properly dispose!</remarks>
	[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
	public static BlockingCollection<T> ToBlockingCollection<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		var returnValue = new BlockingCollection<T>(collection.Count());

		foreach (var item in collection)
		{
			_ = returnValue.TryAdd(item);
		}

		return returnValue;
	}

	/// <summary>
	/// Converts the <see cref="IEnumerable{T}" /> to a <see cref="Collection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>Collection&lt;T&gt;.</returns>
	[Information(nameof(ToCollection), "David McCarter", "4/13/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static Collection<T> ToCollection<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return Collection<T>.Create(collection);
	}

	/// <summary>
	/// Convert a <see cref="IEnumerable{T}" /> to a delimited string.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
	/// <returns>System.String.</returns>
	[Information(nameof(ToDelimitedString), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb21")]
	public static string ToDelimitedString<T>([NotNull] this IEnumerable<T> collection, char delimiter = ControlChars.Comma)
	{
		if (collection is null || collection.FastCount() == 0)
		{
			return string.Empty;
		}

		var sb = _stringBuilderPool.Get();

		try
		{
			foreach (var item in collection)
			{
				if (sb.Length > 0)
				{
					_ = sb.Append(delimiter.ToString(CultureInfo.CurrentCulture));
				}

				_ = sb.Append($"{item}".ToString(CultureInfo.CurrentCulture));
			}

			return sb.ToString().Trim();
		}
		finally
		{
			_stringBuilderPool.Return(sb);
		}
	}

	/// <summary>
	/// Converts a <see cref="IEnumerable{T}" /> to <see cref="ImmutableList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The values.</param>
	/// <returns>IImmutableList&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
	[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static ImmutableList<T> ToImmutable<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return ImmutableList.CreateRange(collection);
	}

	/// <summary>
	/// Converts <see cref="IEnumerable{T}" /> to a <see cref="LinkedList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The values.</param>
	/// <returns>LinkedList&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
	[Information(nameof(ToLinkedList), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static LinkedList<T> ToLinkedList<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return new LinkedList<T>(collection);
	}

	/// <summary>
	/// Creates a <see cref="List{T}" /> from the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
	/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	[Information(nameof(ToListAsync), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static async Task<List<T>> ToListAsync<T>([NotNull] this IEnumerable<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return await Task.Run(() => collection.ToList(), CancellationToken.None).ConfigureAwait(false);
	}

	/// <summary>
	/// Upserts (update or insert) the specified item to the <see cref="IEnumerable{T}" />.
	/// Validates that <paramref name="collection" />  is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <returns>System.Collections.Generic.IEnumerable&lt;T&gt;.</returns>
	[Information(nameof(Upsert), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
	public static IEnumerable<T> Upsert<T>([NotNull] this IEnumerable<T> collection, [AllowNull] T item)
	{
		collection = collection.ArgumentItemsExists();

		if (item is null)
		{
			return collection;
		}

		var items = collection.ToList();

		if (items.Contains(item))
		{
			items.Remove(item);
			items.Add(item);
		}
		else
		{
			items.Add(item);
		}

		return items;
	}
}
