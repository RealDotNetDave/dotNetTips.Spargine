// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 12-08-2023
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
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Core.Collections.Generic;
using DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Extension methods for <see cref="List{T}" />.
/// </summary>
public static class ListExtensions
{

	/// <summary>
	/// Adds the item as the first item in the <see cref="List{T}" />.
	/// Validates that <paramref name="collection" /> is not null and not read-only.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">list or item</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static bool AddFirst<T>([NotNull] this IList<T> collection, [AllowNull] T item)
	{
		if (item is null)
		{
			return false;
		}

		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		collection.Insert(0, item);

		return true;
	}

	/// <summary>
	/// Adds item as the last item in the <see cref="List{T}" />.
	/// Validates that <paramref name="collection" /> and <paramref name="item" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="item">The item.</param>
	/// <returns>T[].</returns>
	/// <exception cref="ArgumentNullException">list or item</exception>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
	public static bool AddLast<T>([NotNull] this IList<T> collection, [AllowNull] T item)
	{
		if (item is null)
		{
			return false;
		}

		collection = collection.ArgumentNotNull().ArgumentNotReadOnly();

		collection.Insert(collection.Count, item);

		return true;
	}

	/// <summary>
	/// Determins that the two <see cref="List{T}" />s are equal.
	/// Returns false if <paramref name="collection" /> or <paramref name="listToCheck" />
	/// is null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The input.</param>
	/// <param name="listToCheck">The list to check.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[Obsolete("This method will be removed at the end of 2023. Use IsEqualTo() instead. ")]
	public static bool AreEqual<T>([NotNull] this IList<T> collection, [NotNull] IList<T> listToCheck)
	{
		if (collection is null || listToCheck is null)
		{
			return false;
		}

		if (collection.FastCount() != listToCheck.FastCount())
		{
			return false;
		}

		var areSame = true;

		for (var listIndex = 0; listIndex < collection.FastCount(); listIndex++)
		{
			areSame &= collection[listIndex].Equals(listToCheck[listIndex]);
		}

		return areSame;
	}

	/// <summary>
	/// Creates a new <see cref="Span{T}" /> over an input <see cref="List{T}" /> instance.
	/// </summary>
	/// <typeparam name="T">The type of elements in the input <see cref="List{T}" /> instance.</typeparam>
	/// <param name="list">The input <see cref="List{T}" /> instance.</param>
	/// <returns>A <see cref="Span{T}" /> instance with the values of <paramref name="list" />.</returns>
	/// <remarks>Note that the returned <see cref="Span{T}" /> is only guaranteed to be valid as long as the items within
	/// <paramref name="list" /> are not modified. Doing so might cause the <see cref="List{T}" /> to swap its
	/// internal buffer, causing the returned <see cref="Span{T}" /> to become out of date. That means that in this
	/// scenario, the <see cref="Span{T}" /> would end up wrapping an array no longer in use. Always make sure to use
	/// the returned <see cref="Span{T}" /> while the target <see cref="List{T}" /> is not modified.
	/// Orginal code from:
	/// https://github.com/CommunityToolkit/dotnet/blob/main/CommunityToolkit.HighPerformance/Extensions/ListExtensions.cs</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(AsSpan), "David McCarter", "8/3/2022", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineNov2022")]
	public static Span<T> AsSpan<T>(this List<T> list) => CollectionsMarshal.AsSpan(list.ArgumentNotNull());

	/// <summary>
	/// Clears the null items from the <see cref="List{T}" />.
	/// Returns false if <paramref name="collection" /> is null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(ClearNulls), author: "David McCarter", createdOn: "8/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static bool ClearNulls<T>([NotNull] this List<T> collection)
	{
		if (collection is null)
		{
			return false;
		}

		return collection.DoesNotHaveItems() ? false : collection.RemoveAll(p => p is null) > 0;
	}

	/// <summary>
	/// Copies the <see cref="List{T}" /> to a <see cref="System.Collections.ObjectModel.Collection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <returns>List&lt;T&gt;.</returns>
	/// <exception cref="ArgumentNullException">source</exception>
	[Information(nameof(CopyToCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available)]
	public static System.Collections.ObjectModel.Collection<T> CopyToCollection<T>([NotNull] this IList<T> collection)
	{
		collection = collection.ArgumentItemsExists();

		return new System.Collections.ObjectModel.Collection<T>(collection);
	}

	/// <summary>
	/// Checks list for null and ensures there are items in the list.
	/// Returns true if <paramref name="collection" /> is null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	[Information(nameof(DoesNotHaveItems), author: "David McCarter", createdOn: "6/17/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool DoesNotHaveItems<T>([AllowNull] this List<T> collection)
	{
		if (collection is null)
		{
			return true;
		}
		else
		{
			return collection.Count() <= 0;
		}
	}

	/// <summary>
	/// Generates hash code for the <see cref="List{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list to use to generate hash code.</param>
	/// <returns>Hash code as System.Int32.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	public static int GenerateHashCode<T>([NotNull] this IList<T> collection)
	{
		collection = collection.ArgumentNotNull();

		var hash = collection.Where(t => t is not null)
			.Aggregate(6551, (accumulator, t) => accumulator ^= (accumulator << 5) ^ EqualityComparer<T>.Default.GetHashCode(t));

		return hash;
	}
	/// <summary>
	/// Determines whether the specified <see cref="List{T}" /> has items.
	/// Returns false if <paramref name="collection" /> is null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns><c>true</c> if the specified list has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasItems), "David McCarter", "8/27/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([AllowNull] this List<T> collection)
	{
		if (collection is null)
		{
			return false;
		}

		return collection.LongCount() > 0;
	}
	/// <summary>
	/// Determines whether the specified <see cref="List{T}" /> has items based on the Predicate.
	/// Returns false if <paramref name="action" /> or <paramref name="collection" /> is null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="action">The action.</param>
	/// <returns><c>true</c> if the specified action has items; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">action</exception>
	[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([AllowNull] this List<T> collection, [NotNull] Predicate<T> action)
	{
		if (collection.CheckIsNotNull() is false || action.CheckIsNotNull() is false)
		{
			return false;
		}

		return collection.TrueForAll(action.ArgumentNotNull());
	}
	/// <summary>
	/// Determines whether the <see cref="List{T}" /> has a specified count.
	/// Returns false if <paramref name="collection" /> is null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The source.</param>
	/// <param name="count">The specific count.</param>
	/// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
	[Information(nameof(HasItems), "David McCarter", "8/27/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineAug2022")]
	public static bool HasItems<T>([AllowNull] this List<T> collection, int count)
	{
		if (collection is null)
		{
			return false;
		}
		else
		{
			return collection.LongCount() == count;
		}
	}

	/// <summary>
	/// Finds index that avoids multiple enumerations.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="index">The index.</param>
	/// <returns>T.</returns>
	/// <exception cref="ArgumentNullException">collection</exception>
	/// <remarks>Orginal code by: @TheOtherBoz</remarks>
	[Information(nameof(IndexAtLooped), author: "David McCarter", createdOn: "7/17/2022", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.Completed, Status = Status.Available)]
	public static T IndexAtLooped<T>([NotNull] this IList<T> collection, int index)
	{
		if (collection is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(collection));
		}

		var count = collection.Count;
		var indexWrap = (int)(index - (count * Math.Floor((double)index / count)));

		return collection[indexWrap];
	}

	/// <summary>
	/// Determines whether the specified list to check is equal.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <param name="collectionToCheck">The list to check.</param>
	/// <returns><c>true</c> if the specified list to check is equal; otherwise, <c>false</c>.</returns>
	/// <exception cref="ArgumentNullException">collection</exception>
	/// <exception cref="ArgumentNullException">collectionToCheck</exception>
	[Information(nameof(IsEqualTo), author: "David McCarter", createdOn: "3/22/2023", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsEqualTo<T>(this IList<T> collection, IList<T> collectionToCheck)
	{
		if (collection == null)
		{
			throw new ArgumentNullException(nameof(collection));
		}

		if (collectionToCheck == null)
		{
			throw new ArgumentNullException(nameof(collectionToCheck));
		}

		return collection.SequenceEqual(collectionToCheck);
	}

	/// <summary>
	/// Performs the action for the items in the <see cref="List{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="values">The values.</param>
	/// <param name="action">The action.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Information(nameof(PerformAction), "David McCarter", "1/4/2023", Status = Status.Available, BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static void PerformAction<T>(this List<T> values, [NotNull] Action<T> action)
	{
		action = action.ArgumentNotNull();

		if (values.IsNullOrEmpty())
		{
			return;
		}

		foreach (var item in CollectionsMarshal.AsSpan(values))
		{
			action(item);
		}
	}

	/// <summary>
	/// Groups the elements of a <see cref="List{T}" /> sequence according to a specified firstKey selector function and rotates the unique
	/// values from the secondKey selector function into multiple values in the output, and performs aggregations.
	/// Validates that <paramref name="collection" />, <paramref name="firstKeySelector" />,
	/// <paramref name="secondKeySelector" />, <paramref name="aggregate" /> is not null.
	/// </summary>
	/// <typeparam name="TSource">The type of the t list.</typeparam>
	/// <typeparam name="TFirstKey">The type of the t first key.</typeparam>
	/// <typeparam name="TSecondKey">The type of the t second key.</typeparam>
	/// <typeparam name="TValue">The type of the t value.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="firstKeySelector">The first key selector.</param>
	/// <param name="secondKeySelector">The second key selector.</param>
	/// <param name="aggregate">The aggregate.</param>
	/// <returns>Dictionary&lt;TFirstKey, Dictionary&lt;TSecondKey, TValue&gt;&gt;.</returns>
	/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value. or list - Aggregate cannot be null. or firstKeySelector -
	/// First key selector cannot be null. or secondKeySelector - Second key selector cannot be null.</exception>
	[Information(nameof(Pivot), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
	public static Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot<TSource, TFirstKey, TSecondKey, TValue>([NotNull] this IEnumerable<TSource> collection, [NotNull] Func<TSource, TFirstKey> firstKeySelector, [NotNull] Func<TSource, TSecondKey> secondKeySelector, [NotNull] Func<IEnumerable<TSource>, TValue> aggregate)
	{
		collection = collection.ArgumentNotNull();
		firstKeySelector = firstKeySelector.ArgumentNotNull();
		secondKeySelector = secondKeySelector.ArgumentNotNull();
		aggregate = aggregate.ArgumentNotNull();

		var returnValue = new Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>();

		var lookup = collection.ToLookup(firstKeySelector).ToList();

		lookup.ForEach(item =>
		{
			var collection = new Dictionary<TSecondKey, TValue>();

			returnValue.Add(item.Key, collection);

			var secondLookup = item.ToLookup(secondKeySelector).ToList();

			secondLookup.ForEach(subitem => collection.Add(subitem.Key, aggregate.Invoke(subitem)));
		});

		return returnValue;
	}

	/// <summary>
	/// Converts to <see cref="List{T}" /> to a <see cref="Core.Collections.Generic.Collection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>Core.Collections.Generic.Collection&lt;T&gt;.</returns>
	[Information(nameof(ToCollection), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static Core.Collections.Generic.Collection<T> ToCollection<T>([NotNull] this IList<T> collection) => Core.Collections.Generic.Collection<T>.Create(collection.ArgumentItemsExists());

	/// <summary>
	/// Converts <see cref="List{T}" /> to a <see cref=" DistinctBlockingCollection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="completeAdding">Set to true if no more items will be acced
	/// to this collection.</param>
	/// <returns>DistinctBlockingCollection&lt;T&gt;.</returns>
	/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
	/// to remove from memory.</remarks>
	[Information(nameof(ToDistinctBlockingCollection), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static DistinctBlockingCollection<T> ToDistinctBlockingCollection<T>([NotNull] this IList<T> collection, bool completeAdding = false)
	{
		var result = new DistinctBlockingCollection<T>(collection.ArgumentItemsExists());

		if (completeAdding)
		{
			result.CompleteAdding();
		}

		return result;
	}

	/// <summary>
	/// Converts <see cref="List{T}" /> to a <see cref="DistinctConcurrentBag{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>DistinctConcurrentBag&lt;T&gt;.</returns>
	[Information(nameof(ToDistinctConcurrentBag), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static DistinctConcurrentBag<T> ToDistinctConcurrentBag<T>([NotNull] this IList<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts a <see cref="List{T}" /> to the Spargine <see cref="FastSortedList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>FastSortedList&lt;T&gt;.</returns>
	[Information(nameof(ToFastSortedList), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static FastSortedList<T> ToFastSortedList<T>([NotNull] this IList<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts <see cref="List{T}" /> to an <see cref="ImmutableArray{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>ImmutableArray&lt;T&gt;.</returns>
	[Information(nameof(ToCollection), "David McCarter", "12/3/2021", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ImmutableArray<T> ToImmutableArray<T>([NotNull] this IList<T> collection) => ImmutableArray.Create(collection.ArgumentNotNull().ToArray());

	/// <summary>
	/// Converts the <see cref="IAsyncEnumerable{T}" /> to a <see cref="List{T}" /> in an asynchronous operation.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="TSource">The type of the t source.</typeparam>
	/// <param name="collection">The list.</param>
	/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>List&lt;T&gt;.</returns>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	public static async Task<List<TSource>> ToListAsync<TSource>([NotNull] this IAsyncEnumerable<TSource> collection, CancellationToken cancellationToken = default)
	{
		collection = collection.ArgumentNotNull();

		var returnList = new List<TSource>();

		await foreach (var element in collection.WithCancellation(cancellationToken))
		{
			returnList.Add(element);
		}

		return returnList;
	}

	/// <summary>
	/// Converts <see cref="List{T}" /> to a <see cref="ObservableCollection{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>ObservableCollection.</returns>
	[Information(nameof(ToObservableCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static ObservableCollection<T> ToObservableCollection<T>([NotNull] this IList<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts the <see cref="List{T}" /> to a <see cref="ObservableList{T}" />.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The list.</param>
	/// <returns>ObservableList&lt;T&gt;.</returns>
	[Information(nameof(ToObservableList), "David McCarter", "10/21/2021", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineJan2022")]
	public static ObservableList<T> ToObservableList<T>([NotNull] this IList<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts the <see cref="List{T}" /> to a <see cref="ReadOnlyCollection{T}" />
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="collection">The <see cref="List{T}" /> to convert.</param>
	/// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
	[Information(nameof(ToReadOnlyCollection), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static ReadOnlyCollection<T> ToReadOnlyCollection<T>([NotNull] this IList<T> collection) => new(collection.ArgumentNotNull());

	/// <summary>
	/// Converts the <see cref="List{T}" /> to <see cref="IReadOnlyList{T}" />/&gt;.
	/// Validates that <paramref name="collection" /> is not null.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The <see cref="List{T}" /> to convert.</param>
	/// <returns>IReadOnlyList&lt;T&gt;.</returns>
	[Information(nameof(ToReadOnlyList), "David McCarter", "4/10/2022", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
	public static IReadOnlyList<T> ToReadOnlyList<T>([NotNull] this IList<T> collection) => (IReadOnlyList<T>)collection.ArgumentNotNull();

	/// <summary>
	/// Converts to <see cref="ReadOnlyObservableCollection{T}" />.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="collection">The collection.</param>
	/// <returns>ReadOnlyObservableCollection&lt;T&gt;.</returns>
	[Information(nameof(ToObservableCollection), "David McCarter", "11/26/2022", BenchMarkStatus = BenchMarkStatus.Completed, UnitTestCoverage = 100, Status = Status.Available, Documentation = "https://bit.ly/SpargineFeb2023")]
	public static ReadOnlyObservableCollection<T> ToReadOnlyObservableCollection<T>([NotNull] this IList<T> collection) => new(collection.ArgumentNotNull().ToObservableCollection());

}
