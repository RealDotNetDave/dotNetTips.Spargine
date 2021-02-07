// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="FastSortedList.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Extensions;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Utility.Standard.Collections.Generic
{
	/// <summary>
	/// Class SortedList.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <seealso cref="System.Collections.Generic.List{T}" />
	[DebuggerDisplay("Count = {Count}"), Serializable]
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
		public FastSortedList(IEnumerable<T> collection) : base(collection)
		{
		}

		/// <summary>
		/// Adds an object to the end of <see cref="T:System.Collections.Generic.List">.</see>.
		/// </summary>
		/// <param name="item">The object to be added to the end of the <see cref="T:System.Collections.Generic.List"></see>. The value can be null for reference types.</param>
		public new void Add(T item)
		{
			Validate.TryValidateNullParam(item, nameof(item));

			base.Add(item);

			this._sorted = false;
		}

		/// <summary>
		/// Adds the items to the end of the list.
		/// </summary>
		/// <param name="items">The items.</param>
		public new void AddRange(IEnumerable<T> items)
		{
			Validate.TryValidateParam(items, nameof(items));

			base.AddRange(items);

			this._sorted = false;
		}

		/// <summary>
		/// Returns an enumerator that iterates through the <see cref="T:System.Collections.Generic.List`1"></see>.
		/// </summary>
		/// <returns>A <see cref="T:System.Collections.Generic.List`1.Enumerator"></see> for the <see cref="T:System.Collections.Generic.List`1"></see>.</returns>
		public new Enumerator GetEnumerator()
		{
			this.SortCollection();
			return base.GetEnumerator();
		}


		/// <summary>
		/// Copies the elements of the list to a new array.
		/// </summary>
		/// <returns>An array containing copies of the elements of the <see cref="T:System.Collections.Generic.List`1"></see>.</returns>
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
			return this.ToImmutable();
		}

		/// <summary>
		/// Returns a new collection based on the current collection.
		/// </summary>
		/// <returns>List&lt;T&gt;.</returns>
		public List<T> ToList()
		{
			this.SortCollection();
			return new List<T>(base.ToArray());
		}

		/// <summary>
		/// Sorts the items in the collection.
		/// </summary>
		private void SortCollection()
		{
			if (this._sorted == false)
			{
				base.Sort();

				this._sorted = true;
			}
		}
	}
}
