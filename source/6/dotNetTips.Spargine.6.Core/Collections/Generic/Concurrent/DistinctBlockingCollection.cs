// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 10-22-2023
// ***********************************************************************
// <copyright file="DistinctBlockingCollection.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Custom thread-safe collection type of <T> designed for
// multi-threading tasks, guaranteeing uniqueness for all items in
// the collection.
// </summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core.Properties;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// DistinctBlockingCollection ensures that duplicate items are not added to the collection.
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
/// <seealso cref="BlockingCollection{T}" />
/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
/// to remove from memory.</remarks>
public sealed class DistinctBlockingCollection<T> : BlockingCollection<T>, ICloneable<T>, ICollection<T>
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
		if (collection?.FastCount() > 0)
		{
			foreach (var _ in collection.Where(p => p is not null).Where(item => this.TryAdd(item) is false).Select(_ => new { }))
			{
				ExceptionThrower.ThrowArgumentInvalidException(Resources.ThereWasAnIssueAddingAnItemInTheCollection, nameof(collection));
			}
		}
	}

	/// <summary>
	/// Cones this instance.
	/// </summary>
	/// <returns>T.</returns>
	/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
	/// to remove from memory.</remarks>
	T ICloneable<T>.Clone() => (T)this.MemberwiseClone();

	/// <summary>
	/// Item the not in collection.
	/// </summary>
	/// <param name="item">The item.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	private bool IsNotInCollection(T item) => item is null && this.Contains(item) is false;

	/// <summary>
	/// Adds the item to the <see cref="DistinctBlockingCollection{T}" />.
	/// </summary>
	/// <param name="item">The item to be added to the collection. The value can be a null reference.</param>
	/// <param name="cancellationToken">A cancellation token to observe.</param>
	public new void Add([NotNull] T item, CancellationToken cancellationToken = default)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		if (this.IsNotInCollection(item))
		{
			base.Add(item, cancellationToken);
		}
	}

	/// <summary>
	/// Removes all items from the collection.
	/// </summary>
	public void Clear()
	{
		while (this.TryTake(out _))
		{
			// DO NOTHING
		}
	}

	/// <summary>
	/// Determines whether the collection contains a specific value.
	/// </summary>
	/// <param name="item">The object to locate in the collection.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> is found in the collection; otherwise, <see langword="false" />.</returns>
	public bool Contains(T item) => this.Contains<T>(item);

	/// <summary>
	/// Removes the first occurrence of a specific object from the collection.
	/// </summary>
	/// <param name="item">The object to remove from the collection.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> was successfully removed from the collection; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original collection.</returns>
	/// <exception cref="NotImplementedException"></exception>
	public bool Remove(T item) => this.TryTake(out _);

	/// <summary>
	/// Tries to add the specified item to the <see cref="DistinctBlockingCollection{T}" />.
	/// </summary>
	/// <param name="item">The item to be added to the collection.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> could be added; otherwise, <see langword="false" />. If the item is a duplicate, and the underlying collection does not accept duplicate items, then an <see cref="InvalidOperationException" /> is thrown.</returns>
	public new bool TryAdd([NotNull] T item)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

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
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		return this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout);
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
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		return this.IsNotInCollection(item) && base.TryAdd(item, timeout);
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
	public new bool TryAdd([AllowNull] T item, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		if (item is null)
		{
			return false;
		}

		return this.IsNotInCollection(item) && base.TryAdd(item, millisecondsTimeout, cancellationToken);
	}

	/// <summary>
	/// Gets a value indicating whether the collection is read-only.
	/// </summary>
	/// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
	public bool IsReadOnly => this.IsAddingCompleted;

}
