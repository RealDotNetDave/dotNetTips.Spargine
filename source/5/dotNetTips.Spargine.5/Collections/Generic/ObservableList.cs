// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 02-02-2021
// ***********************************************************************
// <copyright file="ObservableList.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Utility.Standard.Collections.Generic
{
	/// <summary>
	/// Class ObservableList.
	/// Implements the <see cref="System.Collections.Generic.ISet{T}" />
	/// Implements the <see cref="System.Collections.Generic.IReadOnlyCollection{T}" />
	/// Implements the <see cref="System.Collections.Specialized.INotifyCollectionChanged" />
	/// Implements the <see cref="System.ComponentModel.INotifyPropertyChanged" />
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="System.Collections.Generic.ISet{T}" />
	/// <seealso cref="System.Collections.Generic.IReadOnlyCollection{T}" />
	/// <seealso cref="System.Collections.Specialized.INotifyCollectionChanged" />
	/// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
	[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/31/2020", modifiedOn: "7/31/2020", UnitTestCoverage = 0, Status = Status.Available)]
	public class ObservableList<T> : ISet<T>, IReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged, INotifyPropertyChanging
	{
		/// <summary>
		/// The set
		/// </summary>
		private HashSet<T> _set;

		/// <summary>
		/// Initializes a new instance of the <see cref="ObservableList{T}" /> class
		/// that is empty and uses the default equality comparer for the set type.
		/// </summary>
		public ObservableList() : this(EqualityComparer<T>.Default)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ObservableList{T}" /> class
		/// that is empty and uses the specified equality comparer for the set type.
		/// </summary>
		/// <param name="comparer">The <see cref="IEqualityComparer{T}" /> implementation to use when
		/// comparing values in the set, or null to use the default <see cref="IEqualityComparer{T}" />
		/// implementation for the set type.</param>
		public ObservableList(IEqualityComparer<T> comparer)
		{
			this._set = new HashSet<T>(comparer);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ObservableList{T}" /> class
		/// that uses the default equality comparer for the set type, contains elements copied
		/// from the specified collection, and has sufficient capacity to accommodate the
		/// number of elements copied.
		/// </summary>
		/// <param name="collection">The collection whose elements are copied to the new set.</param>
		public ObservableList(IEnumerable<T> collection) : this(collection, EqualityComparer<T>.Default)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ObservableList{T}" /> class
		/// that uses the specified equality comparer for the set type, contains elements
		/// copied from the specified collection, and has sufficient capacity to accommodate
		/// the number of elements copied.
		/// </summary>
		/// <param name="collection">The collection whose elements are copied to the new set.</param>
		/// <param name="comparer">The <see cref="IEqualityComparer{T}" /> implementation to use when
		/// comparing values in the set, or null to use the default <see cref="IEqualityComparer{T}" />
		/// implementation for the set type.</param>
		public ObservableList(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		{
			this._set = new HashSet<T>(collection, comparer);
		}

		/// <summary>
		/// Occurs when the contents of the hash set changes.
		/// </summary>
		/// <returns></returns>
		public event NotifyCollectionChangedEventHandler CollectionChanged;

		/// <summary>
		/// Occurs when a property of this hash set (such as <see cref="Count" />) changes.
		/// </summary>
		/// <returns></returns>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Occurs when a property of this hash set (such as <see cref="Count" />) is changing.
		/// </summary>
		/// <returns></returns>
		public event PropertyChangingEventHandler PropertyChanging;

		/// <summary>
		/// Gets the <see cref="IEqualityComparer{T}" /> object that is used to determine equality for the values in the set.
		/// </summary>
		/// <value>The comparer.</value>
		public virtual IEqualityComparer<T> Comparer => this._set.Comparer;

		/// <summary>
		/// Gets the number of elements that are contained in the hash set.
		/// </summary>
		/// <value>The count.</value>
		public virtual int Count => this._set.Count;

		/// <summary>
		/// Gets a value indicating whether the hash set is read-only.
		/// </summary>
		/// <value><c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
		public virtual bool IsReadOnly => ( (ICollection<T>)this._set ).IsReadOnly;

		/// <summary>
		/// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"></see>.
		/// </summary>
		/// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"></see>.</param>
		void ICollection<T>.Add(T item) => this.Add(item);

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

		/// <inheritdoc />
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => this.GetEnumerator();

		/// <summary>
		/// Adds the specified element to the hash set.
		/// </summary>
		/// <param name="item">The element to add to the set.</param>
		/// <returns><see langword="true" /> if the element is added to the hash set; <see langword="false" /> if the element is already present.</returns>
		public virtual bool Add(T item)
		{
			if (this._set.Contains(item))
			{
				return false;
			}

			this.OnCountPropertyChanging();

			this._set.Add(item);

			this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);

			this.OnCountPropertyChanged();

			return true;
		}

		/// <summary>
		/// Removes all elements from the hash set.
		/// </summary>
		public virtual void Clear()
		{
			if (this._set.Count == 0)
			{
				return;
			}

			this.OnCountPropertyChanging();

			var removed = this.ToList();

			this._set.Clear();

			this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

			this.OnCountPropertyChanged();
		}

		/// <summary>
		/// Determines whether the hash set object contains the
		/// specified element.
		/// </summary>
		/// <param name="item">The element to locate in the hash set.</param>
		/// <returns><see langword="true" /> if the hash set contains the specified element; otherwise, <see langword="false" />.</returns>
		public virtual bool Contains(T item) => this._set.Contains(item);

		/// <summary>
		/// Copies the elements of the hash set to an array.
		/// </summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from
		/// the hash set. The array must have zero-based indexing.</param>
		public virtual void CopyTo(T[] array) => this._set.CopyTo(array);

		/// <summary>
		/// Copies the elements of the hash set to an array, starting at the specified array index.
		/// </summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from
		/// the hash set. The array must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
		public virtual void CopyTo(T[] array, int arrayIndex) => this._set.CopyTo(array, arrayIndex);

		/// <summary>
		/// Copies the specified number of elements of the hash set to an array, starting at the specified array index.
		/// </summary>
		/// <param name="array">The one-dimensional array that is the destination of the elements copied from
		/// the hash set. The array must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
		/// <param name="count">The number of elements to copy to array.</param>
		public virtual void CopyTo(T[] array, int arrayIndex, int count) => this._set.CopyTo(array, arrayIndex, count);

		/// <summary>
		/// Removes all elements in the specified collection from the hash set.
		/// </summary>
		/// <param name="other">The collection of items to remove from the current hash set.</param>
		public virtual void ExceptWith(IEnumerable<T> other)
		{
			var copy = new HashSet<T>(this._set, this._set.Comparer);

			copy.ExceptWith(other);

			if (copy.Count == this._set.Count)
			{
				return;
			}

			var removed = this._set.Where(i => !copy.Contains(i)).ToList();

			this.OnCountPropertyChanging();

			this._set = copy;

			this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

			this.OnCountPropertyChanged();
		}

		/// <summary>
		/// Returns an enumerator that iterates through the hash set.
		/// </summary>
		/// <returns>An enumerator for the hash set.</returns>
		public virtual HashSet<T>.Enumerator GetEnumerator() => this._set.GetEnumerator();

		/// <summary>
		/// Modifies the current hash set to contain only
		/// elements that are present in that object and in the specified collection.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		public virtual void IntersectWith(IEnumerable<T> other)
		{
			var copy = new HashSet<T>(this._set, this._set.Comparer);

			copy.IntersectWith(other);

			if (copy.Count == this._set.Count)
			{
				return;
			}

			var removed = this._set.Where(i => !copy.Contains(i)).ToList();

			this.OnCountPropertyChanging();

			this._set = copy;

			this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

			this.OnCountPropertyChanged();
		}

		/// <summary>
		/// Determines whether the hash set is a proper subset of the specified collection.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		/// <returns><see langword="true" /> if the hash set is a proper subset of other; otherwise, <see langword="false" />.</returns>
		public virtual bool IsProperSubsetOf(IEnumerable<T> other) => this._set.IsProperSubsetOf(other);

		/// <summary>
		/// Determines whether the hash set is a proper superset of the specified collection.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		/// <returns><see langword="true" /> if the hash set is a proper superset of other; otherwise, <see langword="false" />.</returns>
		public virtual bool IsProperSupersetOf(IEnumerable<T> other) => this._set.IsProperSupersetOf(other);

		/// <summary>
		/// Determines whether the hash set is a subset of the specified collection.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		/// <returns><see langword="true" /> if the hash set is a subset of other; otherwise, <see langword="false" />.</returns>
		public virtual bool IsSubsetOf(IEnumerable<T> other) => this._set.IsSubsetOf(other);

		/// <summary>
		/// Determines whether the hash set is a superset of the specified collection.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		/// <returns><see langword="true" /> if the hash set is a superset of other; otherwise, <see langword="false" />.</returns>
		public virtual bool IsSupersetOf(IEnumerable<T> other) => this._set.IsSupersetOf(other);

		/// <summary>
		/// Determines whether the current object and a specified collection share common elements.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		/// <returns><see langword="true" /> if the hash set and other share at least one common element; otherwise, <see langword="false" />.</returns>
		public virtual bool Overlaps(IEnumerable<T> other)
		{
			return this._set.Overlaps(other);
		}

		/// <summary>
		/// Removes the specified element from the hash set.
		/// </summary>
		/// <param name="item">The element to remove.</param>
		/// <returns><see langword="true" /> if the element is successfully found and removed; otherwise, <see langword="false" />.</returns>
		public virtual bool Remove(T item)
		{
			if (!this._set.Contains(item))
			{
				return false;
			}

			this.OnCountPropertyChanging();

			this._set.Remove(item);

			this.OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);

			this.OnCountPropertyChanged();

			return true;
		}

		/// <summary>
		/// Removes all elements that match the conditions defined by the specified predicate
		/// from the hash set.
		/// </summary>
		/// <param name="match">The <see cref="Predicate{T}" /> delegate that defines the conditions of the elements to remove.</param>
		/// <returns>The number of elements that were removed from the hash set.</returns>
		public virtual int RemoveWhere(Predicate<T> match)
		{
			var copy = new HashSet<T>(this._set, this._set.Comparer);

			var removedCount = copy.RemoveWhere(match);

			if (removedCount == 0)
			{
				return 0;
			}

			var removed = this._set.Where(i => !copy.Contains(i)).ToList();

			this.OnCountPropertyChanging();

			this._set = copy;

			this.OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

			this.OnCountPropertyChanged();

			return removedCount;
		}

		/// <summary>
		/// Determines whether the hash set and the specified collection contain the same elements.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		/// <returns><see langword="true" /> if the hash set is equal to other; otherwise, <see langword="false" />.</returns>
		public virtual bool SetEquals(IEnumerable<T> other) => this._set.SetEquals(other);

		/// <summary>
		/// Modifies the current hash set to contain only elements that are present either in that
		/// object or in the specified collection, but not both.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		public virtual void SymmetricExceptWith(IEnumerable<T> other)
		{
			var copy = new HashSet<T>(this._set, this._set.Comparer);

			copy.SymmetricExceptWith(other);

			var removed = this._set.Where(i => !copy.Contains(i)).ToList();
			var added = copy.Where(i => !this._set.Contains(i)).ToList();

			if (removed.Count == 0 && added.Count == 0)
			{
				return;
			}

			this.OnCountPropertyChanging();

			this._set = copy;

			this.OnCollectionChanged(added, removed);

			this.OnCountPropertyChanged();
		}

		/// <summary>
		/// Sets the capacity of the hash set to the actual number of elements it contains, rounded up to a nearby,
		/// implementation-specific value.
		/// </summary>
		public virtual void TrimExcess() => this._set.TrimExcess();

		/// <summary>
		/// Modifies the hash set to contain all elements that are present in itself, the specified collection, or both.
		/// </summary>
		/// <param name="other">The collection to compare to the current hash set.</param>
		public virtual void UnionWith(IEnumerable<T> other)
		{
			var copy = new HashSet<T>(this._set, this._set.Comparer);

			copy.UnionWith(other);

			if (copy.Count == this._set.Count)
			{
				return;
			}

			var added = copy.Where(i => !this._set.Contains(i)).ToList();

			this.OnCountPropertyChanging();

			this._set = copy;

			this.OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);

			this.OnCountPropertyChanged();
		}

		/// <summary>
		/// Raises the <see cref="CollectionChanged" /> event.
		/// </summary>
		/// <param name="e">Details of the change.</param>
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
			=> this.CollectionChanged?.Invoke(this, e);

		/// <summary>
		/// Raises the <see cref="PropertyChanged" /> event.
		/// </summary>
		/// <param name="e">Details of the property that changed.</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
			=> this.PropertyChanged?.Invoke(this, e);

		/// <summary>
		/// Raises the <see cref="PropertyChanging" /> event.
		/// </summary>
		/// <param name="e">Details of the property that is changing.</param>
		protected virtual void OnPropertyChanging(PropertyChangingEventArgs e)
			=> this.PropertyChanging?.Invoke(this, e);

		/// <summary>
		/// Called when [collection changed].
		/// </summary>
		/// <param name="action">The action.</param>
		/// <param name="item">The item.</param>
		private void OnCollectionChanged(NotifyCollectionChangedAction action, object item)
			=> this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item));

		/// <summary>
		/// Called when [collection changed].
		/// </summary>
		/// <param name="newItems">The new items.</param>
		/// <param name="oldItems">The old items.</param>
		private void OnCollectionChanged(IList newItems, IList oldItems)
			=> this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItems, oldItems));

		/// <summary>
		/// Called when [count property changed].
		/// </summary>
		private void OnCountPropertyChanged() => this.OnPropertyChanged(ObservableHashSetSingletons.CountPropertyChanged);

		/// <summary>
		/// Called when [count property changing].
		/// </summary>
		private void OnCountPropertyChanging() => this.OnPropertyChanging(ObservableHashSetSingletons.CountPropertyChanging);
	}

	/// <summary>
	/// ObservableHashSetSingletons.
	/// </summary>
	internal static class ObservableHashSetSingletons
	{
		/// <summary>
		/// The count property changed
		/// </summary>
		private static readonly PropertyChangedEventArgs _countPropertyChanged
			= new PropertyChangedEventArgs(propertyName: "Count");

		/// <summary>
		/// The count property changing
		/// </summary>
		private static readonly PropertyChangingEventArgs _countPropertyChanging
			= new PropertyChangingEventArgs(propertyName: "Count");

		/// <summary>
		/// The no items.
		/// </summary>
		private static readonly object[] _noItems = Array.Empty<object>();

		/// <summary>
		/// Gets the count property changed.
		/// </summary>
		/// <value>The count property changed.</value>
		internal static PropertyChangedEventArgs CountPropertyChanged => _countPropertyChanged;

		/// <summary>
		/// Gets the count property changing.
		/// </summary>
		/// <value>The count property changing.</value>
		internal static PropertyChangingEventArgs CountPropertyChanging => _countPropertyChanging;

		/// <summary>
		/// Gets the no items.
		/// </summary>
		/// <value>The no items.</value>
		internal static object[] NoItems => _noItems;
	}
}
