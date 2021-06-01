
// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 05-31-2021
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Extension methods for IEnumerable types.</summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.Collections;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class EnumerableExtensions.
	/// </summary>
	public static class EnumerableExtensions
	{

		/// <summary>
		/// Adds the specified item to the list.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(Add), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD JUNE 21 URL")]
		public static IEnumerable<T> Add<T>(this IEnumerable<T> list, T item)
		{
			Validate.TryValidateNullParam(list, nameof(list));
			Validate.TryValidateNullParam(item, nameof(item));

			var result = list.ToList();
			result.Add(item);

			return result.AsEnumerable();
		}

		/// <summary>
		/// Adds item to the list if the condition is met.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <param name="condition">if set to <c>true</c> [condition].</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		[Information(nameof(AddIf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD JUNE 21 URL")]
		public static IEnumerable<T> AddIf<T>(this IEnumerable<T> list, T item, bool condition)
		{
			Validate.TryValidateNullParam(list, nameof(list));
			Validate.TryValidateNullParam(item, nameof(item));

			if (condition)
			{
				return list.Add(item);
			}
			else
			{
				return list;
			}
		}
		/// <summary>
		/// Determines whether the specified collection has items specified.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="items">The items.</param>
		/// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">List is null or empty.</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "2/9/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool ContainsAny<T>(this IEnumerable<T> list, params T[] items)
		{
			Validate.TryValidateParam(list, nameof(list));

			if (items.DoesNotHaveItems())
			{
				return false;
			}

			var itemsList = items.ToReadOnlyCollection();

			return itemsList.HasItems() && list.ToList().Any(p => itemsList.Contains(p));
		}

		/// <summary>
		/// Counts the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="ArgumentNullException">list</exception>
		[Information(nameof(Count), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static int Count(this IEnumerable list)
		{
			if (Validate.TryValidateNull(list))
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
		/// Determines whether the specified source does not have items or is null.
		/// </summary>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool DoesNotHaveItems(this IEnumerable list)
		{
			return list?.Count() <= 0;
		}

		/// <summary>
		/// Fasts any.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="predicate">The predicate.</param>
		/// <returns>System.Boolean.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		/// <exception cref="System.ArgumentNullException">Predicate cannot be null.</exception>
		[Information(nameof(FastAny), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool FastAny<T>(this IEnumerable<T> list, Func<T, bool> predicate)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateParam<ArgumentNullException>(predicate.IsNotNull(), nameof(predicate));

			return list.FirstOrDefault(predicate) is not null;
		}

		/// <summary>
		/// Counts the the collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="predicate">The predicate.</param>
		/// <returns>System.Int32.</returns>
		/// <exception cref="System.ArgumentNullException">Predicate cannot be null.</exception>
		[Information(nameof(FastCount), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available)]
		public static int FastCount<T>(this IEnumerable<T> list, Func<T, bool> predicate)
		{
			Validate.TryValidateNullParam(predicate, nameof(predicate));

			if (Validate.TryValidateNull(list))
			{
				return 0;
			}

			if (list is List<T>)
			{
				return ( list as List<T> ).Count(predicate);
			}

			return list.Count(predicate);

		}

		/// <summary>
		/// Returns first item in the collection or an alternate.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="alternate">The alternate.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">Alternate cannot be null.</exception>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static T FirstOrDefault<T>(this IEnumerable<T> list, T alternate)
		{
			Validate.TryValidateNullParam(alternate, nameof(alternate));

			if (list is null)
			{
				return alternate;
			}

			return list.DefaultIfEmpty(alternate).First();
		}


		/// <summary>
		/// Returns first item in the collection or an alternate using a predicate.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="predicate">The predicate.</param>
		/// <param name="alternate">The alternate.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">Predicate cannot be null.</exception>
		/// <exception cref="ArgumentNullException">Alternate cannot be null.</exception>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static T FirstOrDefault<T>(this IEnumerable<T> list, Func<T, bool> predicate, T alternate)
		{
			Validate.TryValidateNullParam(alternate, nameof(alternate));
			Validate.TryValidateNullParam(predicate, nameof(predicate));

			if (list is null)
			{
				return alternate;
			}

			var filteredList = list.Where(predicate).AsEnumerable();

			if (filteredList.HasItems())
			{
				return filteredList.FirstOrDefault(alternate);
			}
			else
			{
				return alternate;
			}
		}

		/// <summary>
		/// Finds first item or returns null.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="match">The match.</param>
		/// <returns>System.Nullable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">Match cannot be null.</exception>
		[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static T? FirstOrNull<T>(this IEnumerable<T> list, Func<T, bool> match)
			where T : struct
		{
			if (list is null)
			{
				return null;
			}

			Validate.TryValidateNullParam(match, nameof(match));

			var listToProcess = list.ToList();

			for (var listCount = 0; listCount < listToProcess.Count; listCount++)
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
		/// Determines whether the specified source has items or is null.
		/// </summary>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems(this IEnumerable list)
		{
			return list?.Count() > 0;
		}

		/// <summary>
		/// Determines whether the specified count has items.
		/// </summary>
		/// <param name="list">The source.</param>
		/// <param name="count">The specific count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems(this IEnumerable list, int count)
		{
			return list?.Count() == count;
		}

		/// <summary>
		/// Determines whether [is null or empty] [the specified source].
		/// </summary>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if [is null or empty] [the specified source]; otherwise, <c>false</c>.</returns>
		[Information(nameof(IsNullOrEmpty), "David McCarter", "1/7/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool IsNullOrEmpty(this IEnumerable list)
		{
			return list is null || list.GetEnumerator().MoveNext() == false;
		}

		/// <summary>
		/// Shuffles the specified count.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The items.</param>
		/// <param name="count">The count.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Count must be greater than 0</exception>
		[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 100)]
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list, int count = 1)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateParam(count, 1, int.MaxValue, nameof(count));

			return list.Shuffle().Take(count);
		}

		/// <summary>
		/// Determines if first collection starts with the second collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(StartsWith), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
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
		/// Determines if two collection sequences are equal.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="first">The first.</param>
		/// <param name="second">The second.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">second</exception>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
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
		/// Converts a collection to a BlockingCollection.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>BlockingCollection&lt;T&gt;.</returns>
		/// <remarks>The resulting collection supports IDisposable. Make sure to properly dispose!</remarks>
		[Information(nameof(ToBlockingCollection), "David McCarter", "4/13/2021", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available, Documentation = "http://bit.ly/SpargineMarch2021")]
		public static BlockingCollection<T> ToBlockingCollection<T>(this IEnumerable<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			var collection = new BlockingCollection<T>(list.Count());

			var taskResult = Task.Factory.StartNew(() =>
			  {
				  foreach (var item in list)
				  {
					  collection.TryAdd(item);
				  }

				  collection.CompleteAdding();
			  });

			taskResult.Wait();

			return collection;
		}

		/// <summary>
		/// Converts to Collection.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>Collection&lt;T&gt;.</returns>
		[Information(nameof(ToCollection), "David McCarter", "4/13/2021", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static Collection<T> ToCollection<T>(this IEnumerable<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return Collection<T>.Create(list);
		}

		/// <summary>
		/// Convert a list to a delimited string.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
		/// <returns>System.String.</returns>
		[Information(nameof(ToDelimitedString), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static string ToDelimitedString<T>(this IEnumerable<T> list, char delimiter = ControlChars.Comma)
		{
			if (list?.Count() == 0)
			{
				return string.Empty;
			}

			var sb = new StringBuilder(list.Count() * 10);

			list.ToList()
				.ForEach(item =>
				{
					sb.Append($"{item}{delimiter.ToString(CultureInfo.CurrentCulture)}");
				});

			return sb.ToString(0, sb.ToString().ToTrimmed().Length - 1);
		}

		/// <summary>
		/// Converts an enumeration of groupings into a Dictionary of those groupings.
		/// </summary>
		/// <typeparam name="TKey">Key type of the grouping and list.</typeparam>
		/// <typeparam name="TValue">Element type of the grouping and list list.</typeparam>
		/// <param name="list">The list.</param>
		/// <returns>A list of groupings such that the key of the list is TKey type and the value is List of TValue type.</returns>
		/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		/// <remarks>Original code by: James Michael Hare</remarks>
		[Information(nameof(ToDictionary), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static Dictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(this IEnumerable<IGrouping<TKey, TValue>> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return list.ToDictionary(group => group.Key, group => group.ToList());
		}

		/// <summary>
		/// To the immutable.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>IImmutableList&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		[Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ImmutableList<T> ToImmutable<T>(this IEnumerable<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return ImmutableList.CreateRange<T>(list);
		}

		/// <summary>
		/// Converts to a LinkedList.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The values.</param>
		/// <returns>LinkedList&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		[Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return new LinkedList<T>(list);
		}

		/// <summary>
		/// Creates a Generic List async.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
		/// <exception cref="ArgumentNullException">List cannot be null or empty.</exception>
		[Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
		public static async Task<List<T>> ToListAsync<T>(this IEnumerable<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return await Task.Run(() => list.ToList()).ConfigureAwait(false);
		}

		/// <summary>
		/// Upserts (update or insert) the specified item.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns>System.Collections.Generic.IEnumerable&lt;T&gt;.</returns>
		[Information(nameof(Upsert), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.New, Documentation = "ADD JUNE 21 URL")]
		public static IEnumerable<T> Upsert<T>(this IEnumerable<T> list, T item)
		{
			Validate.TryValidateNullParam(list, nameof(list));
			Validate.TryValidateNullParam(item, nameof(item));

			if (list.Contains(item))
			{
				var indexItem = list.ElementAt(list.IndexOf(item));

				indexItem = item;

				return list;
			}
			else
			{
				return list.Add(item);
			}
		}
	}
}
