// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 11-21-2020
//
// Last Modified By : David McCarter
// Last Modified On : 11-21-2020
// ***********************************************************************
// <copyright file="EnumerableExtensions.cs" company="dotNetTips.Spargine.5.Extensions">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

namespace dotNetTips.Spargine.Extensions
{
    /// <summary>
    /// Class EnumerableExtensions.
    /// </summary>
    public static class EnumerableExtensions
    {

        /// <summary>
        /// The global random
        /// </summary>
        private static readonly Random _globalRandom = new Random();

        /// <summary>
        /// The random
        /// </summary>
        [ThreadStatic]
        private static Random _random;

        /// <summary>
        /// Gets the random.
        /// </summary>
        /// <value>The random.</value>
        private static Random Random
        {
            get
            {
                if (_random == null)
                {
                    int seed;

                    lock (_globalRandom)
                    {
                        seed = _globalRandom.Next();
                    }

                    _random = new Random(seed);
                }

                return _random;
            }
        }

        /// <summary>
        /// Determines whether the specified collection has items specified.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The source.</param>
        /// <param name="items">The items.</param>
        /// <returns><c>true</c> if the specified items has items; otherwise, <c>false</c>.</returns>
        [Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
        public static bool ContainsAny<T>(this IEnumerable<T> list, params T[] items)
        {
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
        [Information(nameof(Count), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static int Count(this IEnumerable list)
        {
            if (list.DoesNotHaveItems())
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
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if the specified source has items; otherwise, <c>false</c>.</returns>
        [Information(nameof(DoesNotHaveItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool DoesNotHaveItems(this IEnumerable source)
        {
            return source?.Count() <= 0;
        }

        /// <summary>
        /// Fasts any.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>System.Boolean.</returns>
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <exception cref="System.ArgumentNullException">predicate</exception>
        [Information(nameof(FastAny), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool FastAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Encapsulation.TryValidateParam(source, nameof(source));
            Encapsulation.TryValidateParam<ArgumentNullException>(predicate.IsNotNull(), nameof(predicate));

            return source.FirstOrDefault(predicate) != null;
        }

        /// <summary>
        /// Counts the the collection.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <exception cref="System.ArgumentNullException">predicate</exception>
        /// <exception cref="Exception">predicate</exception>
        [Information(nameof(FastCount), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static int FastCount<T>(this IEnumerable<T> list, Func<T, bool> predicate)
        {
            Encapsulation.TryValidateParam(list, nameof(list));
            Encapsulation.TryValidateParam<ArgumentNullException>(predicate.IsNotNull(), nameof(predicate));

            if (list is List<T>)
            {
                var count = 0;

                var listToCount = list as List<T>;

                for (var listCount = 0; listCount < listToCount.Count; listCount++)
                {
                    if (predicate(listToCount[listCount]))
                    {
                        count++;
                    }
                }

                return count;
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
        /// <exception cref="ArgumentNullException">alternate</exception>
        /// <remarks>Original code from efcore-master on GitHub.</remarks>
        [Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static T FirstOrDefault<T>(this IEnumerable<T> list, T alternate)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(list.IsNotNull(), nameof(list));
            Encapsulation.TryValidateParam<ArgumentNullException>(alternate.IsNotNull(), nameof(alternate));

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
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <exception cref="ArgumentNullException">alternate</exception>
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <exception cref="ArgumentNullException">alternate</exception>
        /// <exception cref="ArgumentNullException">predicate</exception>
        /// <remarks>Original code from efcore-master on GitHub.</remarks>
        [Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static T FirstOrDefault<T>(this IEnumerable<T> list, Func<T, bool> predicate, T alternate)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(list.IsNotNull(), nameof(list));
            Encapsulation.TryValidateParam<ArgumentNullException>(alternate.IsNotNull(), nameof(alternate));
            Encapsulation.TryValidateParam<ArgumentNullException>(predicate.IsNotNull(), nameof(predicate));

            return list.Where(predicate).FirstOrDefault(alternate);
        }

        /// <summary>
        /// Finds first item or returns null.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="match">The match.</param>
        /// <returns>System.Nullable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">Function cannot be null.</exception>
        [Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static T? FirstOrNull<T>(this IEnumerable<T> list, Func<T, bool> match)
            where T : struct
        {
            if (list.DoesNotHaveItems())
            {
                return null;
            }

            Encapsulation.TryValidateParam<ArgumentNullException>(match.IsNotNull(), nameof(match));

            var listToProcess = list.ToList();

            for (var listCount = 0; listCount < listToProcess.Count; listCount++)
            {
                T local = listToProcess[listCount];

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
        [Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool HasItems(this IEnumerable list)
        {
            return list?.Count() > 0;
        }

        /// <summary>
        /// Determines whether the specified count has items.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="count">The specific count.</param>
        /// <returns><c>true</c> if the specified count has items; otherwise, <c>false</c>.</returns>
        [Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool HasItems(this IEnumerable source, int count)
        {
            return source?.Count() == count;
        }

        /// <summary>
        /// Shuffles the specified count.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The items.</param>
        /// <param name="count">The count.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">list</exception>
        /// <exception cref="ArgumentOutOfRangeException">count - Count must be greater than 0</exception>
        [Information(nameof(Shuffle), "David McCarter", "8/26/2020", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 0)]
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list, int count = 1)
        {
            Encapsulation.TryValidateParam(list, nameof(list));
            Encapsulation.TryValidateParam(count, 1, int.MaxValue, nameof(count));

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
        [Information(nameof(StartsWith), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool StartsWith<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            Encapsulation.TryValidateParam(first, nameof(first));
            Encapsulation.TryValidateParam(second, nameof(second));

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
        [Information(nameof(StructuralSequenceEqual), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static bool StructuralSequenceEqual<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            Encapsulation.TryValidateParam(first, nameof(first));
            Encapsulation.TryValidateParam(second, nameof(second));

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
        /// Convert a list to a delimited string.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="delimiter">The delimiter (default is comma if not supplied).</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <exception cref="System.ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        [Information(nameof(ToDelimitedString), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static string ToDelimitedString<T>(this IEnumerable<T> list, char delimiter = ControlChars.Comma)
        {
            if (list.HasItems() == false)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            list.ToList()
                .ForEach(item =>
                {
                    sb.Append($"{item.ToString()}{delimiter.ToString(CultureInfo.CurrentCulture)}");
                });

            return sb.ToString(0, sb.ToString().Length - 1);
        }

        /// <summary>
        /// Converts an enumeration of groupings into a Dictionary of those groupings.
        /// </summary>
        /// <typeparam name="TKey">Key type of the grouping and list.</typeparam>
        /// <typeparam name="TValue">Element type of the grouping and list list.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>A list of groupings such that the key of the list is TKey type and the value is List of TValue type.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <remarks>Original code by: James Michael Hare</remarks>
        [Information(nameof(ToDictionary), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static Dictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(this IEnumerable<IGrouping<TKey, TValue>> list)
        {
            Encapsulation.TryValidateParam(list, nameof(list));

            return list.ToDictionary(group => group.Key, group => group.ToList());
        }

        /// <summary>
        /// Returns distinct collection using the specified comparer.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The source.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// <exception cref="ArgumentNullException">comparer</exception>
        /// <remarks>Original code from efcore-master on GitHub.</remarks>
        [Information(nameof(ToDistinct), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static IEnumerable<T> ToDistinct<T>(this IEnumerable<T> list, Func<T, T, bool> comparer)
            where T : class
        {
            Encapsulation.TryValidateParam(list, nameof(list));
            Encapsulation.TryValidateParam<ArgumentNullException>(comparer.IsNotNull(), nameof(comparer));

            return list.Distinct(new DynamicEqualityComparer<T>(comparer));
        }

        /// <summary>
        /// To the immutable.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The values.</param>
        /// <returns>IImmutableList&lt;T&gt;.</returns>
        [Information(nameof(ToImmutable), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static ImmutableList<T> ToImmutable<T>(this IEnumerable<T> list)
        {
            Encapsulation.TryValidateParam(list, nameof(list));

            return ImmutableList.CreateRange<T>(list);
        }

        /// <summary>
        /// Converts to a LinkedList.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The values.</param>
        /// <returns>LinkedList&lt;T&gt;.</returns>
        [Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static LinkedList<T> ToLinkedList<T>(this IEnumerable<T> list)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(list.IsNotNull(), nameof(list));

            return new LinkedList<T>(list);
        }

        /// <summary>
        /// Converts <see cref="IEnumerable" /> collection to a <see cref="List{T}" />.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The source.</param>
        /// <returns>List&lt;TSource&gt;.</returns>
        /// <remarks>Original code from efcore-master on GitHub.</remarks>
        [Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static List<T> ToList<T>(this IEnumerable list)
        {
            Encapsulation.TryValidateParam<ArgumentNullException>(list.IsNotNull(), nameof(list));

            return list.OfType<T>().ToList();
        }

        /// <summary>
        /// Creates a Generic List async.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="list">The list.</param>
        /// <returns>Task&lt;List&lt;T&gt;&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        [Information(nameof(FirstOrNull), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static Task<List<T>> ToListAsync<T>(this IEnumerable<T> list)
        {
            Encapsulation.TryValidateParam(list, nameof(list));

            return Task.Run(() => list.ToList());
        }

        /// <summary>
        /// Returns list based on function.
        /// </summary>
        /// <typeparam name="TSource">The type of the list.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>IEnumerable&lt;TSource&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <remarks>Original code by: Phil Campbell</remarks>
        [Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> list, bool condition, Func<TSource, bool> predicate)
        {
            return condition ? list.Where(predicate) : list;
        }

        /// <summary>
        /// Returns list based on function.
        /// </summary>
        /// <typeparam name="TSource">The type of the list.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="condition">if set to <c>true</c> [condition].</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>IEnumerable&lt;TSource&gt;.</returns>
        /// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
        /// <remarks>Original code by: Phil Campbell</remarks>
        [Information(nameof(FirstOrDefault), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> list, bool condition, Func<TSource, int, bool> predicate)
        {
            return condition ? list.Where(predicate) : list;
        }

        /// <summary>
        /// Disposes the collection.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="items">The items.</param>
        internal static void DisposeCollection<T>(this IEnumerable<T> items)
        {
            ProcessCollectionToDispose(items);
        }

        /// <summary>
        /// Tries to dispose collection items.
        /// </summary>
        /// <param name="items">The items.</param>
        internal static void DisposeCollection(this IEnumerable items) => ProcessCollectionToDispose(items);

        /// <summary>
        /// Processes the collection to dispose.
        /// </summary>
        /// <param name="items">The items.</param>
        internal static void ProcessCollectionToDispose(IEnumerable items)
        {
            if (items.HasItems())
            {
                foreach (var item in items)
                {
                    if (item != null && item is IDisposable disposeItem)
                    {
                        disposeItem.TryDispose();
                    }
                }
            }
        }

        /// <summary>
        /// Class DynamicEqualityComparer. This class cannot be inherited. Implements the <see cref="System.Collections.Generic.IEqualityComparer{T}" />
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <seealso cref="System.Collections.Generic.IEqualityComparer{T}" />
        /// <remarks>Original code from efcore-master on GitHub.</remarks>
        private sealed class DynamicEqualityComparer<T> : IEqualityComparer<T>
            where T : class
        {
            /// <summary>
            /// The function
            /// </summary>
            private readonly Func<T, T, bool> _func;

            /// <summary>
            /// Initializes a new instance of the <see cref="DynamicEqualityComparer{T}" /> class.
            /// </summary>
            /// <param name="func">The function.</param>
            public DynamicEqualityComparer(Func<T, T, bool> func)
            {
                this._func = func;
            }

            /// <summary>
            /// Determines whether the specified objects are equal.
            /// </summary>
            /// <param name="x">The first object of type T to compare.</param>
            /// <param name="y">The second object of type T to compare.</param>
            /// <returns>true if the specified objects are equal; otherwise, false.</returns>
            public bool Equals(T x, T y) => this._func(x, y);

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <param name="obj">The <see cref="T:System.Object"></see> for which a hash code is to be returned.</param>
            /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash
            /// table.</returns>
            public int GetHashCode(T obj) => 0;
        }
    }
}
