// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="DistinctBlockingCollection.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Collections
{
	/// <summary>
	/// DistinctBlockingCollection.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <seealso cref="System.Collections.Concurrent.BlockingCollection{T}" />
	public class DistinctBlockingCollection<T> : BlockingCollection<T>, ICloneable<T>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DistinctBlockingCollection{T}" /> class.
		/// </summary>
		public DistinctBlockingCollection()
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="DistinctBlockingCollection{T}" /> class.
		/// </summary>
		/// <param name="collection">The collection.</param>
		public DistinctBlockingCollection(IEnumerable<T> collection)
		{
			if (collection.HasItems())
			{
				collection.ToList()
					.ForEach(item =>
					{
						this.Add(item);
					});
			}
		}

		/// <summary>
		/// Adds the item to the <see cref="T:System.Collections.Concurrent.BlockingCollection" />.
		/// </summary>
		/// <param name="item">The item to be added to the collection. The value can be a null reference.</param>
		public new void Add(T item)
		{
			Validate.TryValidateNullParam(item, nameof(item), "Item is required.");

			if (this.ItemNotInCollection(item))
			{
				base.Add(item);
			}
		}

		/// <summary>
		/// Adds the item to the <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.
		/// </summary>
		/// <param name="item">The item to be added to the collection. The value can be a null reference.</param>
		/// <param name="cancellationToken">A cancellation token to observe.</param>
		public new void Add(T item, CancellationToken cancellationToken)
		{
			Validate.TryValidateNullParam(item, nameof(item), "Item is required.");

			if (this.ItemNotInCollection(item))
			{
				base.Add(item, cancellationToken);
			}
		}

		/// <summary>
		/// Cones this instance.
		/// </summary>
		/// <returns>T.</returns>
		public T Cone() { return (T)this.MemberwiseClone(); }

		/// <summary>
		/// Removes all.
		/// </summary>
		/// <param name="match">The match.</param>
		/// <returns>System.Int32.</returns>
		public int RemoveAll(Predicate<T> match)
		{
			Validate.TryValidateNullParam(match, nameof(match), message: "Match is required.");

			return this.RemoveAll(match);
		}

		/// <summary>
		/// Tries to add the specified item to the <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.
		/// </summary>
		/// <param name="item">The item to be added to the collection.</param>
		/// <returns>true if <paramref name="item" /> could be added; otherwise false. If the item is a duplicate, and the
		/// underlying collection does not accept duplicate items, then an <see cref="T:System.InvalidOperationException" /> is thrown.</returns>
		public new bool TryAdd(T item)
		{
			if (item is null)
			{
				return false;
			}

			return this.ItemNotInCollection(item) && base.TryAdd(item);
		}

		/// <summary>
		/// Tries to add the specified item to the <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />
		/// within the specified time period.
		/// </summary>
		/// <param name="item">The item to be added to the collection.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait
		/// indefinitely.</param>
		/// <returns>true if the <paramref name="item" /> could be added to the collection within the specified time; otherwise,
		/// false. If the item is a duplicate, and the underlying collection does not accept duplicate items, then an
		/// <see cref="T:System.InvalidOperationException" /> is thrown.</returns>
		public new bool TryAdd(T item, int millisecondsTimeout)
		{
			if (item is null)
			{
				return false;
			}

			return this.ItemNotInCollection(item) && base.TryAdd(item, millisecondsTimeout);
		}

		/// <summary>
		/// Tries to add the specified item to the <see cref="T:System.Collections.Concurrent.BlockingCollection`1" />.
		/// </summary>
		/// <param name="item">The item to be added to the collection.</param>
		/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>true if the <paramref name="item" /> could be added to the collection within the specified time span;
		/// otherwise, false.</returns>
		public new bool TryAdd(T item, TimeSpan timeout)
		{
			if (item is null)
			{
				return false;
			}

			return this.ItemNotInCollection(item) && base.TryAdd(item, timeout);
		}

		/// <summary>
		/// Tries to add the specified item to the <see cref="T:System.Collections.Concurrent.BlockingCollection" />
		/// within the specified time period, while observing a cancellation token.
		/// </summary>
		/// <param name="item">The item to be added to the collection.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="System.Threading.Timeout.Infinite" /> (-1) to wait
		/// indefinitely.</param>
		/// <param name="cancellationToken">A cancellation token to observe.</param>
		/// <returns>true if the <paramref name="item" /> could be added to the collection within the specified time; otherwise,
		/// false. If the item is a duplicate, and the underlying collection does not accept duplicate items, then an
		/// <see cref="System.InvalidOperationException" /> is thrown.</returns>
		public new bool TryAdd(T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			if (item is null)
			{
				return false;
			}

			return this.ItemNotInCollection(item) && base.TryAdd(item, millisecondsTimeout, cancellationToken);
		}

		/// <summary>
		/// Item the not in collection.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		private bool ItemNotInCollection(T item) { return item == null && this.Contains(item) == false; }
	}
}
