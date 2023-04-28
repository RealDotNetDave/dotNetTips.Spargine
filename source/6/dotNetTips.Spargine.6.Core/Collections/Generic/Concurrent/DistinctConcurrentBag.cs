// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 03-29-2023
// ***********************************************************************
// <copyright file="DistinctConcurrentBag.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Collections.Generic.Concurrent;

/// <summary>
/// DistinctConcurrentBag ensures that duplicate items are not added to the bag.
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
/// <seealso cref="ConcurrentBag{T}" />
public sealed class DistinctConcurrentBag<T> : ConcurrentBag<T>, ICollection<T>
{
	/// <summary>
	/// The hash codes
	/// </summary>
	private readonly HashSet<int> _hashCodes = new();

	/// <summary>
	/// The lock
	/// </summary>
	private readonly object _lock = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}" /> class.
	/// </summary>
	public DistinctConcurrentBag()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="DistinctConcurrentBag{T}" /> class.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the <see cref="DistinctConcurrentBag{T}" />.</param>
	public DistinctConcurrentBag([NotNull] IEnumerable<T> collection)
	{
		collection?.ToList().ForEach(this.Add);
	}

	/// <summary>
	/// Determines whether the collection contains a specific value.
	/// </summary>
	/// <param name="item">The object to locate in the collection.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> is found in the collection; otherwise, <see langword="false" />.</returns>
	bool ICollection<T>.Contains(T item)
	{
		if (item is null)
		{
			return false;
		}

		return this.Contains(item);
	}

	/// <summary>
	/// Removes the first occurrence of a specific object from the collection.
	/// </summary>
	/// <param name="item">The object to remove from the collection.</param>
	/// <returns><see langword="true" /> if <paramref name="item" /> was successfully removed from the collection; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="item" /> is not found in the original collection.</returns>
	/// <exception cref="NotImplementedException"></exception>
	bool ICollection<T>.Remove(T item)
	{
		throw new NotImplementedException();
	}

	/// <summary>
	/// Gets a value indicating whether the collection is read-only.
	/// </summary>
	/// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
	/// <exception cref="NotImplementedException"></exception>
	bool ICollection<T>.IsReadOnly => throw new NotImplementedException();

	/// <summary>
	/// Adds an object to the list.
	/// </summary>
	/// <param name="item">The object to be added to the list. The value can be a null reference (Nothing in Visual Basic) for reference types.</param>
	void ICollection<T>.Add([NotNull] T item)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		var hashCode = item.GetHashCode();

		lock (this._lock)
		{
			if (this._hashCodes.Contains(hashCode) is false)
			{
				base.Add(item);
				_ = this._hashCodes.Add(hashCode);
			}
		}
	}

	/// <summary>
	/// Attempts to remove and return an object from the <see cref="DistinctConcurrentBag{T}" />.
	/// </summary>
	/// <param name="result">When this method returns, result contains the object removed from the <see cref="DistinctConcurrentBag{T}" /> or the default value of T if the bag is empty.</param>
	/// <returns>true if an object was removed successfully; otherwise, false.</returns>
	public new bool TryTake(out T result)
	{
		lock (this._lock)
		{
			if (base.TryTake(out result))
			{
				_ = this._hashCodes.Remove(result.GetHashCode());
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
