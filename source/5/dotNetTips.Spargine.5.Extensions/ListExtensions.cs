﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 02-14-2018
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2021
// ***********************************************************************
// <copyright file="ListExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary>Extensions for different collection types.</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extension methods for collections.
	/// </summary>
	public static class ListExtensions
	{
		/// <summary>
		/// The global random
		/// </summary>
		private static readonly Random _globalRandom = new Random((int)DateTime.Now.Ticks);

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
		/// Adds the item as the first item in array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">list or item</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool AddFirst<T>(this IList<T> list, T item)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));

			if (Validate.TryValidateNull(item))
			{
				return false;
			}

			list.Insert(0, item);

			return true;
		}

		/// <summary>
		/// Adds item the last item in the array.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="item">The item.</param>
		/// <returns>T[].</returns>
		/// <exception cref="ArgumentNullException">list or item</exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool AddLast<T>(this IList<T> list, T item)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateParam<ArgumentReadOnlyException>(list.IsReadOnly == false, nameof(list));

			if (item == null)
			{
				return false;
			}

			list.Insert(list.Count, item);

			return true;
		}

		/// <summary>
		/// Ares the equal.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The input.</param>
		/// <param name="listToCheck">The list to check.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static bool AreEqual<T>(this IList<T> list, IList<T> listToCheck)
		{
			if (Validate.TryValidateNull(list) && Validate.TryValidateNull(listToCheck))
			{
				return true;
			}

			if (( Validate.TryValidateNull(list) && Validate.TryValidateNull(listToCheck) ) || list.Count != listToCheck.Count)
			{
				return false;
			}

			var areSame = true;

			for (var i = 0; i < list.Count; i++)
			{
				areSame &= list[i].Equals(listToCheck[i]);
			}

			return areSame;
		}

		/// <summary>
		/// Clears the null items from the collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(ClearNulls), author: "David McCarter", createdOn: "8/12/2020", modifiedOn: "11/21/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool ClearNulls<T>(this List<T> list)
		{
			if (list.DoesNotHaveItems())
			{
				return false;
			}

			return list.RemoveAll(p => p is null) > 0;
		}

		/// <summary>
		/// Copies the collection to a generic List.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <returns>List&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">source</exception>
		[Information(nameof(CopyToList), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static List<T> CopyToList<T>(this List<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return new List<T>(list);
		}

		/// <summary>
		/// Determines whether the specified collection has items based on the Predicate.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="action">The action.</param>
		/// <returns><c>true</c> if the specified action has items; otherwise, <c>false</c>.</returns>
		/// <exception cref="ArgumentNullException">action</exception>
		/// <exception cref="System.ArgumentNullException">action</exception>
		[Information(nameof(HasItems), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static bool HasItems<T>(this List<T> list, Predicate<T> action)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateNullParam(action, nameof(action));

			return list.TrueForAll(action);
		}

		/// <summary>
		/// Returns index of item in the collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="item">The item.</param>
		/// <returns>System.Int32.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(IndexOf), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static int IndexOf<T>(this IEnumerable<T> list, T item)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateNullParam(item, nameof(item));

			return IndexOf(list, item, EqualityComparer<T>.Default);
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
		public static int IndexOf<T>(this IEnumerable<T> list, T item, IEqualityComparer<T> comparer)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateNullParam(item, nameof(item));
			Validate.TryValidateNullParam(comparer, nameof(comparer));

			return list.Select((x, index) => comparer.Equals(item, x) ? index : -1).FirstOrDefault(x => x != -1, -1);
		}

		/// <summary>
		/// Joins a collection using the specified separator.
		/// </summary>
		/// <param name="list">The source.</param>
		/// <param name="separator">The separator.</param>
		/// <returns>System.String.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(Join), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static string Join(this IEnumerable<object> list, string separator = ControlChars.DefaultSeparator)
		{
			Validate.TryValidateParam(list, nameof(list));

			return string.Join(separator, list);
		}

		/// <summary>
		/// Generates hash code for the collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list to use to generate hash code.</param>
		/// <returns>Hash code as System.Int32.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static int ListHashCode<T>(this ReadOnlyCollection<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			var comparer = EqualityComparer<T>.Default;
			var hash = list.Where(t => t != null)
				.Aggregate(6551, (accumulator, t) => accumulator ^= ( accumulator << 5 ) ^ comparer.GetHashCode(t));

			return hash;
		}

		/// <summary>
		/// Generates hash code for the collection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list to use to generate hash code.</param>
		/// <returns>Hash code as System.Int32.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static int ListHashCode<T>(this IList<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			var comparer = EqualityComparer<T>.Default;

			var hash = list.Where(t => t != null)
				.Aggregate(6551, (accumulator, t) => accumulator ^= ( accumulator << 5 ) ^ comparer.GetHashCode(t));

			return hash;
		}

		/// <summary>
		/// Orders a list based on a sort expression. Useful in object binding scenarios where the ObjectDataSource
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
		public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> list, string sortExpression)
		{
			Validate.TryValidateParam(list, nameof(list));

			if (sortExpression.HasValue() == false)
			{
				return null;
			}

			sortExpression += string.Empty;
			var parts = sortExpression.Split(Convert.ToChar(" ", CultureInfo.InvariantCulture));
			var descending = false;
			var property = string.Empty;

			if (parts.Length > 0 && !string.IsNullOrEmpty(parts[0]))
			{
				property = parts[0];

				if (parts.Length > 1)
				{
					@descending = CultureInfo.InvariantCulture.TextInfo.ToLower(parts[1]).Contains("esc");
				}

				var prop = typeof(T).GetRuntimeProperty(property);

				if (Validate.TryValidateNull(prop))
				{
					ExceptionThrower.ThrowInvalidCastException($"{string.Format(CultureInfo.InvariantCulture, "{0}{1}", Convert.ToString("No property '", CultureInfo.InvariantCulture), property)}' in + {typeof(T).Name}'", "Property");
				}

				return @descending
					? list.OrderByDescending(x => prop.GetValue(x, null))
					: list.OrderBy(x => prop.GetValue(x, null));
			}

			return list;
		}

		/// <summary>
		/// Orders collection by <see cref="StringComparer.Ordinal" />
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="list">The source.</param>
		/// <param name="keySelector">The key selector.</param>
		/// <returns>IOrderedEnumerable&lt;TSource&gt;.</returns>
		/// <remarks>Original code from efcore-master on GitHub.</remarks>
		[Information(nameof(OrderByOrdinal), "David McCarter", "11/21/2020", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 0, Status = Status.Available)]
		public static IOrderedEnumerable<TSource> OrderByOrdinal<TSource>(this IEnumerable<TSource> list, Func<TSource, string> keySelector)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateNullParam(keySelector, nameof(keySelector));

			return list.OrderBy(keySelector, StringComparer.Ordinal);
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
		/// <exception cref="System.ArgumentNullException">pageSize</exception>
		/// <exception cref="System.ArgumentOutOfRangeException">pageSize</exception>
		[Information(nameof(Page), "David McCarter", "11/21/2010", BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static IEnumerable<IEnumerable<T>> Page<T>(this IEnumerable<T> list, int pageSize)
		{
			Validate.TryValidateParam(list, nameof(list));

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
		public static T PickRandom<T>(this IEnumerable<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			var index = new Random().Next(0, list.Count() - 1);

			return list.ElementAt(index);
		}


		/// <summary>
		/// Groups the elements of a sequence according to a specified firstKey selector function and rotates the unique
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
		public static Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>> Pivot<TSource, TFirstKey, TSecondKey, TValue>(this IEnumerable<TSource> list, Func<TSource, TFirstKey> firstKeySelector, Func<TSource, TSecondKey> secondKeySelector, Func<IEnumerable<TSource>, TValue> aggregate)
		{
			Validate.TryValidateParam(list, nameof(list));
			Validate.TryValidateNullParam(firstKeySelector, nameof(firstKeySelector));
			Validate.TryValidateNullParam(secondKeySelector, nameof(secondKeySelector));

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
		/// Shuffles the specified items.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The items.</param>
		/// <returns>IEnumerable&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">list</exception>
		[Information(nameof(Shuffle), "David McCarter", "8/26/2020", "8/26/2020", BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, UnitTestCoverage = 99)]
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return list.OrderBy(i => Random.Next());
		}

		/// <summary>
		/// Converts to List in an asynchronous operation.
		/// </summary>
		/// <typeparam name="TSource">The type of the t source.</typeparam>
		/// <param name="list">The list.</param>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <returns>List&lt;TSource&gt;.</returns>
		public static async Task<List<TSource>> ToListAsync<TSource>(
			this IAsyncEnumerable<TSource> list, CancellationToken cancellationToken = default)
		{
			if (Validate.TryValidateNull(list))
			{
				ExceptionThrower.ThrowArgumentNullException(nameof(list));
			}

			var returnList = new List<TSource>();

			await foreach (var element in list.WithCancellation(cancellationToken))
			{
				returnList.Add(element);
			}

			return returnList;
		}


		/// <summary>
		/// Converts List to ObservableCollection.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <returns>ObservableCollection.</returns>
		[Information(nameof(ToObservableCollection), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ObservableCollection<T> ToObservableCollection<T>(this IList<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return new ObservableCollection<T>(list);
		}

		/// <summary>
		/// Creates a read only list.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="list">The list.</param>
		/// <returns>ReadOnlyCollection&lt;T&gt;.</returns>
		/// <exception cref="ArgumentNullException">list - Source cannot be null or have a 0 value.</exception>
		[Information(nameof(ToReadOnlyCollection), "David McCarter", "11/21/2020", BenchMarkStatus = 0, UnitTestCoverage = 100, Status = Status.Available)]
		public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IList<T> list)
		{
			Validate.TryValidateParam(list, nameof(list));

			return new ReadOnlyCollection<T>(list);
		}


	}
}
