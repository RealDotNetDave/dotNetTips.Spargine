// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 05-24-2022
// ***********************************************************************
// <copyright file="ListExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions for different List collection types.</summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension methods for <see cref="List{T}" />.
	/// </summary>
	public static class ListExtensions
	{
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
		/// Adds the item as the first item in the <see cref="List{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">list or item</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool AddFirst<T>([NotNull] this IList<T> list, [NotNull] T item)
		{
			list = list.ArgumentNotReadOnly();

			if (item is null)
			{
				return false;
			}

			list.Insert(0, item);

			return true;
		}

		/// <summary>
		/// Adds item as the last item in the <see cref="List{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">list or item</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool AddLast<T>([NotNull] this IList<T> list, [NotNull] T item)
		{
			list = list.ArgumentNotReadOnly();

			if (item is null)
			{
				return false;
			}

			list.Insert(list.Count, item);

			return true;
		}

		/// <summary>
		/// Determins that the two <see cref="List{T}" />s are equal.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The input.</param>
		/// <param name="listToCheck">The list to check.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static bool AreEqual<T>([NotNull] this IList<T> list, [NotNull] IList<T> listToCheck)
		{
			if (list is null || listToCheck is null)
			{
				return false;
			}

			if (list.FastCount() != listToCheck.FastCount())
			{
				return false;
			}

			var areSame = true;

			for (var listIndex = 0; listIndex < list.FastCount(); listIndex++)
			{
				areSame &= list[listIndex].Equals(listToCheck[listIndex]);
			}

			return areSame;
		}

		/// <summary>
		/// Clears the null items from the <see cref="List{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(ClearNulls), author: "David McCarter", createdOn: "8/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool ClearNulls<T>([NotNull] this List<T> list)
		{
			if (list is null)
			{
				return false;
			}

			return list.DoesNotHaveItems() ? false : list.RemoveAll(p => p is null) > 0;
		}

		/// <summary>
		/// Copies the <see cref="List{T}" /> to a <see cref="System.Collections.ObjectModel.Collection{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <returns>List&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">source</exception>
		[Information(nameof(CopyToCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static System.Collections.ObjectModel.Collection<T> CopyToCollection<T>([NotNull] this List<T> list)
		{
			if (list is null)
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(list));
			}

			return new System.Collections.ObjectModel.Collection<T>(list);
		}

		/// <summary>
		/// Generates hash code for the <see cref="List{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list to use to generate hash code.</param>
		/// <returns>Hash code as System.Int32.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static int GenerateHashCode<T>([NotNull] this IList<T> list)
		{
			list = list.ArgumentNotNull();

			var comparer = EqualityComparer<T>.Default;

			var hash = list.Where(t => t is not null)
				.Aggregate(6551, (accumulator, t) =>
				{
					return accumulator ^= ( accumulator << 5 ) ^ comparer.GetHashCode(t);
				});

			return hash;
		}

		/// <summary>
		/// Determines whether the specified <see cref="List{T}" /> has items.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns><c>true</c> if the specified list has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "8/27/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>([NotNull] this List<T> list)
		{
			if (list is null)
			{
				return false;
			}

			return list.LongCount() > 0;
		}

		/// <summary>
		/// Determines whether the specified <see cref="List{T}" /> has items based on the Predicate.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="action">The action.</param>
		/// <returns><c>true</c> if the specified action has items; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">action</exception>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>([NotNull] this List<T> list, [NotNull] Predicate<T> action)
		{
			if (list.CheckIsNotNull() is false || action.CheckIsNotNull() is false)
			{
				return false;
			}

			return list.TrueForAll(action.ArgumentNotNull());
		}

		/// <summary>
		/// Determines whether the <see cref="List{T}" /> has a specified count.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The source.</param>
		/// <param name="count">The specific count.</param>
		/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
		[Information(nameof(HasItems), "David McCarter", "8/27/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>([NotNull] this List<T> list, int count)
		{
			if (list is null)
			{
				return false;
			}
			else
			{
				return list.LongCount() == count;
			}
		}

		/// <summary>
		/// Groups the elements of a <see cref="List{T}" /> sequence according to a specified firstKey selector function and rotates the unique
		/// values from the secondKey selector function into multiple values in the output, and performs aggregations.
		/// </summary>
		/// <typeparam name="TSource">The type of the t list.</typeparam>
		/// <typeparam name="TFirstKey">The type of the t first key.</typeparam>
		/// <typeparam name="TSecondKey">The type of the t second key.</typeparam>
		/// <typeparam name="TValue">The type of the t value.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="firstKeySelector">The first key selector.</param>
		/// <param name="secondKeySelector">The second key selector.</param>
		/// <param name="aggregate">The aggregate.</param>
		/// <returns>Dictionary&lt;TFirstKey, Dictionary&lt;TSecondKey, TValue&gt;&gt;.</returns>
		/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value. or list - Aggregate cannot be null. or firstKeySelector -
		/// First key selector cannot be null. or secondKeySelector - Second key selector cannot be null.</exception>
		[Information(nameof(Pivot), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot<TSource, TFirstKey, TSecondKey, TValue>([NotNull] this IEnumerable<TSource> list, [NotNull] Func<TSource, TFirstKey> firstKeySelector, [NotNull] Func<TSource, TSecondKey> secondKeySelector, [NotNull] Func<IEnumerable<TSource>, TValue> aggregate)
		{
			list = list.ArgumentNotNull();
			firstKeySelector = firstKeySelector.ArgumentNotNull();
			secondKeySelector = secondKeySelector.ArgumentNotNull();
			aggregate = aggregate.ArgumentNotNull();

			var returnValue = new Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>();

			var lookup = list.ToLookup(firstKeySelector).ToList();

			lookup.ForEach(item =>
			{
				var collection = new Dictionary<TSecondKey, TValue>();

				returnValue.Add(item.Key, collection);

				var secondLookup = item.ToLookup(secondKeySelector).ToList();

				secondLookup.ForEach(subitem =>
				{
					collection.Add(subitem.Key, aggregate.Invoke(subitem));
				});
			});

			return returnValue;
		}

		/// <summary>
		/// Shuffles the specified <see cref="List{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The items.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">list</exception>
		[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "8/26/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 100)]
		public static IEnumerable<T> Shuffle<T>([NotNull] this IEnumerable<T> list)
		{
			return list.ArgumentItemsExists().OrderBy(i => GenerateRandomNumber());
		}

		/// <summary>
		/// Converts to <see cref="List{T}" /> to a <see cref="Core.Collections.Generic.Collection{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>Core.Collections.Generic.Collection&lt;T&gt;.</returns>
		[Information(nameof(ToCollection), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static Core.Collections.Generic.Collection<T> ToCollection<T>([NotNull] this IList<T> list)
		{
			return Core.Collections.Generic.Collection<T>.Create(list.ArgumentItemsExists());
		}

		/// <summary>
		/// Converts <see cref="List{T}" /> to a <see cref=" DistinctBlockingCollection{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <param name="completeAdding">Set to true if no more items will be acced
		/// to this collection.</param>
		/// <returns>DistinctBlockingCollection&lt;T&gt;.</returns>
		/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
		/// to remove from memory.</remarks>
		[Information(nameof(ToDistinctBlockingCollection), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static DistinctBlockingCollection<T> ToDistinctBlockingCollection<T>([NotNull] this IList<T> list, bool completeAdding = false)
		{
			var result = new DistinctBlockingCollection<T>(list.ArgumentItemsExists());

			if (completeAdding)
			{
				result.CompleteAdding();
			}

			return result;
		}

		/// <summary>
		/// Converts <see cref="List{T}" /> to a <see cref="DistinctConcurrentBag{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>DistinctConcurrentBag&lt;T&gt;.</returns>
		[Information(nameof(ToDistinctConcurrentBag), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static DistinctConcurrentBag<T> ToDistinctConcurrentBag<T>([NotNull] this IList<T> list)
		{
			return new DistinctConcurrentBag<T>(list.ArgumentItemsExists());
		}

		/// <summary>
		/// Converts a <see cref="List{T}" /> to the Spargine <see cref="FastSortedList{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>FastSortedList&lt;T&gt;.</returns>
		[Information(nameof(ToFastSortedList), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static FastSortedList<T> ToFastSortedList<T>([NotNull] this IList<T> list)
		{
			return new FastSortedList<T>(list.ArgumentItemsExists());
		}

		/// <summary>
		/// Converts <see cref="List{T}" /> to an <see cref="ImmutableArray{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>ImmutableArray&lt;T&gt;.</returns>
		[Information(nameof(ToCollection), "David McCarter", "12/3/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static ImmutableArray<T> ToImmutableArray<T>([NotNull] this IList<T> list)
		{
			return ImmutableArray.Create(list.ArgumentItemsExists().ToArray());
		}

		/// <summary>
		/// Converts the <see cref="IAsyncEnumerable{T}" /> to a <see cref="List{T}" /> in an asynchronous operation.
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <returns>List&lt;TSource&gt;.</returns>
		/// <remarks>Make sure to call .Dispose on Task,</remarks>
		public static async Task<List<TSource>> ToListAsync<TSource>([NotNull] this IAsyncEnumerable<TSource> list, CancellationToken cancellationToken = default)
		{
			list = list.ArgumentNotNull();

			var returnList = new List<TSource>();

			await foreach (var element in list.WithCancellation(cancellationToken))
			{
				returnList.Add(element);
			}

			return returnList;
		}

		/// <summary>
		/// Converts <see cref="List{T}" /> to a <see cref="ObservableCollection{T}" />.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <returns>ObservableCollection.</returns>
		[Information(nameof(ToObservableCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static ObservableCollection<T> ToObservableCollection<T>([NotNull] this IList<T> list)
		{
			return new ObservableCollection<T>(list.ArgumentItemsExists());
		}

		/// <summary>
		/// Converts the <see cref="List{T}" /> to a <see cref="ObservableList{T}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list.</param>
		/// <returns>ObservableList&lt;T&gt;.</returns>
		[Information(nameof(ToObservableList), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
		public static ObservableList<T> ToObservableList<T>([NotNull] this IList<T> list)
		{
			return new ObservableList<T>(list.ArgumentItemsExists());
		}

		/// <summary>
		/// Converts the <see cref="List{T}" /> to a <see cref="ReadOnlyCollection{T}" />
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The <see cref="List{T}" /> to convert.</param>
		/// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
		[Information(nameof(ToReadOnlyCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static ReadOnlyCollection<T> ToReadOnlyCollection<T>([NotNull] this IList<T> list)
		{
			return new ReadOnlyCollection<T>(list.ArgumentItemsExists());
		}

		/// <summary>
		/// Converts the <see cref="List{T}" /> to <see cref="IReadOnlyList{T}" />/&gt;.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The <see cref="List{T}" /> to convert.</param>
		/// <returns>IReadOnlyList&lt;T&gt;.</returns>
		[Information(nameof(ToReadOnlyList), "David McCarter", "4/10/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.New)]
		public static IReadOnlyList<T> ToReadOnlyList<T>([NotNull] this IList<T> list)
		{
			return (IReadOnlyList<T>)list.ArgumentItemsExists();
		}
	}
}
