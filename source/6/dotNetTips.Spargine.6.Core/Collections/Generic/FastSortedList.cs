// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-01-2023
// ***********************************************************************
// <copyright file="FastSortedList.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Custom Collection Class of <T>. Items in this collection
// are sorted only when requested.
// </summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// FastSortedList sorts the collection only when the collection is retrieved. Saves a lot on performance.
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
/// <seealso cref="List{T}" />
[Serializable]
public class FastSortedList<T> : List<T>
{
	/// <summary>
	/// True or False if the list has been sorted.
	/// </summary>
	private bool _sorted;

	/// <summary>
	/// Initializes a new instance of the <see cref="SortedList{TKey, TValue}" /> class.
	/// </summary>
	public FastSortedList()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="FastSortedList{T}" /> class.
	/// </summary>
	/// <param name="collection">Creates class and copies in items from collection.</param>
	public FastSortedList([NotNull] IEnumerable<T> collection) : base(collection)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="FastSortedList{T}" /> class that is empty and has the specified initial capacity.
	/// </summary>
	/// <param name="capacity">The number of elements that the new list can initially store.</param>
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="capacity" /> is less than 0.</exception>
	public FastSortedList(int capacity) : base(capacity)
	{
	}

	/// <summary>
	/// Sorts the items in the collection.
	/// </summary>
	private void SortCollection()
	{
		if (this._sorted is false)
		{
			this.Sort();

			this._sorted = true;
		}
	}

	/// <summary>
	/// Adds an object to the end of the list.
	/// </summary>
	/// <param name="item">The object to be added to the end of the list. The value can be <see langword="null" /> for reference types.</param>
	public new void Add([NotNull] T item)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		base.Add(item);

		this._sorted = false;
	}

	/// <summary>
	/// Adds the items to the end of the list.
	/// </summary>
	/// <param name="items">The items.</param>
	public new void AddRange([NotNull] IEnumerable<T> items)
	{
		base.AddRange(items.ArgumentNotNull());

		this._sorted = false;
	}

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>A enumerator for the <see cref="List{T}" />.</returns>
	public new Enumerator GetEnumerator()
	{
		this.SortCollection();
		return base.GetEnumerator();
	}

	/// <summary>
	/// Copies the elements of the list to a new array.
	/// </summary>
	/// <returns>An array containing copies of the elements of the <see cref="List{T}" />.</returns>
	public new T[] ToArray()
	{
		this.SortCollection();

		return base.ToArray();
	}

	/// <summary>
	/// To the immutable list.
	/// </summary>
	/// <returns>System.Collections.Immutable.IImmutableList&lt;T&gt;.</returns>
	public IImmutableList<T> ToImmutableList()
	{
		this.SortCollection();

		return ImmutableList.CreateRange(this);
	}

	/// <summary>
	/// Returns a new collection based on the current collection.
	/// </summary>
	/// <returns>List&lt;T&gt;.</returns>
	public IList<T> ToList()
	{
		this.SortCollection();

		return new List<T>(base.ToArray());
	}
}
