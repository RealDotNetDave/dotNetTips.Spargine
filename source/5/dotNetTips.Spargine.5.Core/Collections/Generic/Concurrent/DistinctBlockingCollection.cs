// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-27-2021
// ***********************************************************************
// <copyright file="DistinctBlockingCollection.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png; https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Collections.Generic.Concurrent
{
	/// <summary>
	/// DistinctBlockingCollection.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <seealso cref="BlockingCollection{T}" />
	/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
	/// to remove from memory.</remarks>
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
		public DistinctBlockingCollection([NotNull] IEnumerable<T> collection)
		{
			if (collection?.LongCount() > 0)
			{
				foreach (var _ in collection.Where(p => p is not null).Where(item => this.TryAdd(item) is false).Select(item => new { }))
				{
					ExceptionThrower.ThrowArgumentInvalidException("There was an issue adding an item in the collection", nameof(collection));
				}
			}
		}

		/// <summary>
		/// Adds the item to the <see cref="DistinctBlockingCollection{T}" />.
		/// </summary>
		/// <param name="item">The item to be added to the collection. The value can be a null reference.</param>
		/// <param name="cancellationToken">A cancellation token to observe.</param>
		public new void Add([NotNull] T item, CancellationToken cancellationToken = default)
		{
			if (this.ItemNotInCollection(item))
			{
				base.Add(item, cancellationToken);
			}
		}

		/// <summary>
		/// Cones this instance.
		/// </summary>
		/// <returns>T.</returns>
		/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
		/// to remove from memory.</remarks>
		public T Cone() => (T)this.MemberwiseClone();

		/// <summary>
		/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />.
		/// </summary>
		/// <param name="item">The item to be added to the collection.</param>
		/// <returns><see langword="true" /> if <paramref name="item" /> could be added; otherwise, <see langword="false" />. If the item is a duplicate, and the underlying collection does not accept duplicate items, then an <see cref="InvalidOperationException" /> is thrown.</returns>
		public new bool TryAdd([NotNull] T item)
		{
			return base.TryAdd(item);

		}

		/// <summary>
		/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />
		/// within the specified time period.
		/// </summary>
		/// <param name="item">The item to be added to the collection.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or infinite (-1) to wait
		/// indefinitely.</param>
		/// <returns><see langword="true" /> if the <paramref name="item" /> could be added to the collection within the specified time; otherwise, false. If the item is a duplicate, and the underlying collection does not accept duplicate items, then an <see cref="InvalidOperationException" /> is thrown.</returns>
		public new bool TryAdd([NotNull] T item, int millisecondsTimeout)
		{
			return this.ItemNotInCollection(item) && base.TryAdd(item, millisecondsTimeout);
		}

		/// <summary>
		/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />.
		/// </summary>
		/// <param name="item">The item to be added to the collection.</param>
		/// <param name="timeout">A <see cref="TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
		/// <returns>true if the <paramref name="item" /> could be added to the collection within the specified time span;
		/// otherwise, false.</returns>
		public new bool TryAdd([NotNull] T item, TimeSpan timeout)
		{
			return this.ItemNotInCollection(item) && base.TryAdd(item, timeout);
		}

		/// <summary>
		/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />
		/// within the specified time period, while observing a cancellation token.
		/// </summary>
		/// <param name="item">The item to be added to the collection.</param>
		/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="Timeout.Infinite" /> (-1) to wait
		/// indefinitely.</param>
		/// <param name="cancellationToken">A cancellation token to observe.</param>
		/// <returns>true if the <paramref name="item" /> could be added to the collection within the specified time; otherwise,
		/// false. If the item is a duplicate, and the underlying collection does not accept duplicate items, then an
		/// <see cref="InvalidOperationException" /> is thrown.</returns>
		public new bool TryAdd([NotNull] T item, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return this.ItemNotInCollection(item) && base.TryAdd(item, millisecondsTimeout, cancellationToken);
		}

		/// <summary>
		/// Item the not in collection.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		private bool ItemNotInCollection(T item) => item is null && this.Contains(item) == false;
	}
}
