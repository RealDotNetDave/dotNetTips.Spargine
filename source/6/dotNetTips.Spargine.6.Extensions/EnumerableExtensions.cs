// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-26-2022
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
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

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class EnumerableExtensions.
	/// </summary>
	public static class EnumerableExtensions
	{
		/// <summary>
		/// Adds the specified item to the <see cref="IEnumerable{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(Add), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static IEnumerable<T> Add<T>([NotNull] this IEnumerable<T> list, [NotNull] T item)
		{
			if (item is null)
			{
				return list;
			}

			list = list.ArgumentNotNull();

			return list.Append(item);
		}

		/// <summary>
		/// Pages the specified list.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="pageSize">Size of the page. Minimum page size is 1.</param>
		/// <returns>IEnumerable&lt;IEnumerable&lt;T&gt;&gt;.</returns>
		/// <exception cref="ArgumentOutOfRangeException">pageSize</exception>
		/// <exception cref="ArgumentNullException">pageSize</exception>
		/// <exception cref="ArgumentNullException">pageSize</exception>
		/// <exception cref="ArgumentOutOfRangeException">pageSize</exception>
		[Information(nameof(Page), "David McCarter", "11/21/2010", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<IEnumerable<T>> Page<T>([NotNull] this IEnumerable<T> list, int pageSize)
		{
			list = list.ArgumentNotNull();

			pageSize = pageSize.EnsureMinimum(1);

			using var enumerator = list.GetEnumerator();

			while (enumerator.MoveNext())
			{
				var currentPage = new List<T>(pageSize) { enumerator.Current };

				while (currentPage.Count < pageSize && enumerator.MoveNext())
				{
					currentPage.Add(enumerator.Current);
				}

				yield return currentPage.AsEnumerable();
			}
		}

		/// <summary>
		/// Picks a random item from a collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <returns>T.</returns>
		[Information(nameof(PickRandom), "David McCarter", "8/26/2020", "9/19/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 100)]
		public static T PickRandom<T>([NotNull] this IEnumerable<T> list)
		{
			list = list.ArgumentNotNull();

			var index = RandomNumberGenerator.GetInt32(0, list.Count() - 1);

			return list.ElementAt(index);
		}

		/// <summary>
		/// Orders <see cref="IEnumerable{T}"/> by <see cref="StringComparer.Ordinal" />
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="keySelector">The key selector.</param>
		/// <returns>IOrderedEnumerable&lt;TSource&gt;.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static IOrderedEnumerable<TSource> OrderByOrdinal<TSource>([NotNull] this IEnumerable<TSource> list, [NotNull] Func<TSource, string> keySelector)
		{
			return list.ArgumentNotNull().OrderBy(keySelector.ArgumentNotNull(), StringComparer.Ordinal);
		}

		/// <summary>
		/// Adds item to the <see cref="IEnumerable{T}" /> if the condition is met.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		[Information(nameof(AddIf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static IEnumerable<T> AddIf<T>([NotNull] this IEnumerable<T> list, [NotNull] T item, bool condition)
		{
			if (item is null)
			{
				return list;
			}

			list = list.ArgumentNotNull();

			if (condition)
			{
				list = list.Append(item);
			}

			return list;
		}

		/// <summary>
		/// Determines whether the specified  <see cref="IEnumerable{T}" /> has items specified.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="items">The items.</param>
		/// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">List is null or empty.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool ContainsAny<T>([NotNull] this IEnumerable<T> list, [NotNull] params T[] items)
		{
			if (list is null || items is null)
			{
				return false;
			}

			if (items.DoesNotHaveItems())
			{
				return false;
			}

			return list.Any(p => items.Contains(p));
		}

		/// <summary>
		/// Counts items in a <see cref="IEnumerable" />.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">list</exception>
		[Information(nameof(Count), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static int Count([NotNull] this IEnumerable list)
		{
			if (list is null)
			{
				return 0;
			}

			if (list is ICollection collection)
			{
				return collection.Count;
			}

			var count = 0;

			var enumerator = list.GetEnumerator();

			while (enumerator.MoveNext())
			{
				count++;
			}

			return count;
		}

		/// <summary>
		/// Determines whether the specified <see cref="IEnumerable" /> does not have items or is null.
		/// </summary>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool DoesNotHaveItems([NotNull] this IEnumerable list)
		{
			return list?.Count() <= 0;
		}

		/// <summary>
		/// Determines if any items exist in the <see cref="IEnumerable" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="predicate">The predicate.</param>
		/// <returns>System.Boolean.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
		[Information(nameof(FastAny), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool FastAny<T>([NotNull] this IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
		{
			return list.ArgumentNotNull().Any(predicate.ArgumentNotNull());
		}

		/// <summary>
		/// Counts items in the <see cref="IEnumerable{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="predicate">The predicate.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
		[Information(nameof(FastCount), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available)]
		public static int FastCount<T>([NotNull] this IEnumerable<T> list, [NotNull] Func<T, bool> predicate)
		{
			return list.ArgumentNotNull().Count(predicate.ArgumentNotNull());
		}

		/// <summary>
		/// Processes the <see cref="IEnumerable{T}" /> with the specified action in parallel processing.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The source.</param>
		/// <param name="action">The action.</param>
		/// <param name="maxDegreeOfParallelism">The maximum degree of parallelism.</param>
		/// <param name="ensureOrdered">if set to <c>true</c> [ensure ordered].</param>
		/// <param name="scheduler">The scheduler.</param>
		/// <returns>Task.</returns>
		/// <remarks>Original code by: Alexandru Puiu: https://medium.com/@alex.puiu/parallel-foreach-async-in-c-36756f8ebe62</remarks>
		[Information(nameof(FastParallelProcessor), author: "David McCarter", createdOn: "11/9/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.New, Documentation = "ADD APR URL")]
		public static Task FastParallelProcessor<T>([NotNull] this IEnumerable<T> list, [NotNull] Action<T> action, int maxDegreeOfParallelism = DataflowBlockOptions.Unbounded, bool ensureOrdered = false, TaskScheduler scheduler = null)
		{
			list = list.ArgumentNotNull();
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

			foreach (var item in list)
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
		/// <param name="list">The source.</param>
		/// <param name="alternate">The alternate.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">Alternate cannot be null.</exception>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static T FirstOrDefault<T>([AllowNull] this IEnumerable<T> list, [NotNull] T alternate)
		{
			return list is null ? alternate : list.DefaultIfEmpty(alternate).First();
		}

		/// <summary>
		/// Returns first item in the <see cref="IEnumerable{T}" /> or an alternate using a predicate.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="predicate">The predicate.</param>
		/// <param name="alternate">The alternate.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
		/// <exception cref="ArgumentNullException">Alternate cannot be null.</exception>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
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
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="match">The match.</param>
		/// <returns>System.Nullable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">Match cannot be null.</exception>
		[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static T? FirstOrNull<T>([NotNull] this IEnumerable<T> list, [NotNull] Func<T, bool> match)
			where T : struct
		{
			var listToProcess = list.ArgumentItemsExists().ToCollection();

			for (var listCount = 0; listCount < listToProcess.Count(); listCount++)
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
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems([NotNull] this IEnumerable list)
		{
			return list?.Count() > 0;
		}

		/// <summary>
		/// Determines whether the <see cref="IEnumerable" /> has a specified count.
		/// </summary>
		/// <param name="list">The source.</param>
		/// <param name="count">The specific count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems([NotNull] this IEnumerable list, int count)
		{
			return list?.Count() == count;
		}

		/// <summary>
		/// Returns index of item in the <see cref="IEnumerable{T}"/>.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="item">The item.</param>
		/// <returns>System.Int32.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static int IndexOf<T>([NotNull] this IEnumerable<T> list, [NotNull] T item)
		{
			return IndexOf(list.ArgumentItemsExists(), item.ArgumentNotNull(), EqualityComparer<T>.Default);
		}

		/// <summary>
		/// Returns index of an item in the collection using comparer.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="item">The item.</param>
		/// <param name="comparer">The comparer.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">item or comparer</exception>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static int IndexOf<T>([NotNull] this IEnumerable<T> list, [NotNull] T item, [NotNull] IEqualityComparer<T> comparer)
		{
			list = list.ArgumentItemsExists();
			item = item.ArgumentNotNull();
			comparer = comparer.ArgumentNotNull();

			return list.Select((x, index) => comparer.Equals(item, x) ? index : -1).FirstOrDefault(x => x != -1, -1);
		}


		/// <summary>
		/// Determines whether <see cref="IEnumerable" /> is null or empty.
		/// </summary>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if [is null or empty] [the specified source]; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsNullOrEmpty), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsNullOrEmpty([AllowNull] this IEnumerable list)
		{
			return list.IsNull() || list.GetEnumerator().MoveNext() is false;
		}

		/// <summary>
		/// Joins a collection using the specified separator.
		/// </summary>
		/// <param name="list">The source.</param>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(Join), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static string Join([NotNull] this IEnumerable<object> list, [NotNull] string separator = ControlChars.DefaultSeparator)
		{
			if (list.CheckItemsExists() is false)
			{
				return string.Empty;
			}

			return string.Join(separator.ArgumentNotNullOrEmpty(defaultValue: ControlChars.DefaultSeparator), list);
		}

		/// <summary>
		/// Orders a <see cref="IEnumerable{T}"/> based on a sort expression. Useful in object binding scenarios where the ObjectDataSource
		/// generates a dynamic sort expression (example: "Name desc") that specifies the property of the object sort
		/// on.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="sortExpression">The sort expression.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="InvalidCastException"></exception>
		/// <remarks>Original code by: C.F.Meijers</remarks>
		[Information(nameof(OrderBy), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static IEnumerable<T> OrderBy<T>([NotNull] this IEnumerable<T> list, [NotNull] string sortExpression)
		{
			list = list.ArgumentNotNull();


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

				_ = prop.CheckIsNotNull(throwException: true);

				return @descending
					? list.OrderByDescending(x => prop.GetValue(x, null))
					: list.OrderBy(x => prop.GetValue(x, null));
			}

			return list;
		}

		/// <summary>
		/// Shuffles items in a <see cref="IEnumerable{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The items.</param>
		/// <param name="count">The count.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Count must be greater than 0</exception>
		[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 100)]
		public static IEnumerable<T> Shuffle<T>([NotNull] this IEnumerable<T> list, int count = 1)
		{
			list = list.ArgumentNotNull();
			count = count.ArgumentInRange(paramName: nameof(count), lower: 1, upper: int.MaxValue, defaultValue: list.Count());

			return list.Shuffle().Take(count);
		}


		/// <summary>
		/// Determines if first <see cref="IEnumerable{T}" /> starts with the second <see cref="IEnumerable{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(StartsWith), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
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
				using var secondEnumerator = second.GetEnumerator();

				while (secondEnumerator.MoveNext())
				{
					if (!firstEnumerator.MoveNext() || !Equals(firstEnumerator.Current, secondEnumerator.Current))
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
		[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
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

			using var firstEnumerator = first.GetEnumerator();
			using var secondEnumerator = second.GetEnumerator();

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

		/// <summary>
		/// Converts a <see cref="IEnumerable{T}" /> to a BlockingCollection.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>BlockingCollection&lt;T&gt;.</returns>
		/// <remarks>The resulting collection supports IDisposable. Make sure to properly dispose!</remarks>
		[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
		[SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP015:Member should not return created and cached instance")]
		public static BlockingCollection<T> ToBlockingCollection<T>([NotNull] this IEnumerable<T> list)
		{
			list = list.ArgumentItemsExists();

			var collection = new BlockingCollection<T>(list.Count());

			foreach (var item in list)
			{
				_ = collection.TryAdd(item);
			}

			return collection;
		}

		/// <summary>
		/// Converts the <see cref="IEnumerable{T}" /> to a <see cref="Collection{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>Collection&lt;T&gt;.</returns>
		[Information(nameof(ToCollection), "David McCarter", "4/13/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static Collection<T> ToCollection<T>([NotNull] this IEnumerable<T> list)
		{
			list = list.ArgumentItemsExists();

			return Collection<T>.Create(list);
		}

		/// <summary>
		/// Convert a <see cref="IEnumerable{T}" /> to a delimited string.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
		/// <returns>System.String.</returns>
		[Information(nameof(ToDelimitedString), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static string ToDelimitedString<T>([NotNull] this IEnumerable<T> list, char delimiter = ControlChars.Comma)
		{
			if (list is null || list.Count() == 0)
			{
				return string.Empty;
			}

			var sb = new StringBuilder(list.Count() * 10);

			list.ToList()
				.ForEach(item =>
				{
					_ = sb.Append($"{item}{delimiter}".ToString(CultureInfo.CurrentCulture));
				});

			return sb.ToString(0, sb.ToString().ToTrimmed().Length - 1);
		}

		/// <summary>
		/// Converts a <see cref="IEnumerable{T}" /> to <see cref="ImmutableList{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>IImmutableList&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableList<T> ToImmutable<T>([NotNull] this IEnumerable<T> list)
		{
			list = list.ArgumentItemsExists();

			return ImmutableList.CreateRange(list);
		}

		/// <summary>
		/// Converts <see cref="IEnumerable{T}" /> to a <see cref="LinkedList{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>LinkedList&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static LinkedList<T> ToLinkedList<T>([NotNull] this IEnumerable<T> list)
		{
			list = list.ArgumentItemsExists();

			return new LinkedList<T>(list);
		}

		/// <summary>
		/// Creates a <see cref="List{T}" /> from the <see cref="IEnumerable{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		/// <remarks>Make sure to call .Dispose on Task,</remarks>
		[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static async Task<List<T>> ToListAsync<T>([NotNull] this IEnumerable<T> list)
		{
			list = list.ArgumentItemsExists();

			return await Task.Run(() => list.ToList()).ConfigureAwait(false);
		}

		/// <summary>
		/// Upserts (update or insert) the specified item to the <see cref="IEnumerable{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns>System.Collections.Generic.IEnumerable&lt;T&gt;.</returns>
		[Information(nameof(Upsert), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJun2021")]
		public static IEnumerable<T> Upsert<T>([NotNull] this IEnumerable<T> list, [NotNull] T item)
		{
			list = list.ArgumentItemsExists();

			if (item is null)
			{
				return list;
			}

			var items = list.ToList();

			if (items.Contains(item))
			{
				var index = items.IndexOf(item);

				items.RemoveAt(index);
				items.Insert(index, item);
			}
			else
			{
				items.Add(item);
			}

			return items;
		}
	}
}
