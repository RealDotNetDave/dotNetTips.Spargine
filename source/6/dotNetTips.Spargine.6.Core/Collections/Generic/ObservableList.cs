// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-11-2022
// ***********************************************************************
// <copyright file="ObservableList.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// ObservableList throws events when items are added, removed etc.
/// Implements the <see cref="ISet{T}" />
/// Implements the <see cref="IReadOnlyCollection{T}" />
/// Implements the <see cref="INotifyCollectionChanged" />
/// Implements the <see cref="INotifyPropertyChanged" />
/// </summary>
/// <typeparam name="T"></typeparam>
/// <seealso cref="ISet{T}" />
/// <seealso cref="IReadOnlyCollection{T}" />
/// <seealso cref="INotifyCollectionChanged" />
/// <seealso cref="INotifyPropertyChanged" />
[Information("From .NET EF Core source.", author: "David McCarter", createdOn: "7/31/2020", Status = Status.Available)]
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
	public ObservableList([NotNull] IEqualityComparer<T> comparer) => this._set = new HashSet<T>(comparer);

	/// <summary>
	/// Initializes a new instance of the <see cref="ObservableList{T}" /> class
	/// that uses the default equality comparer for the set type, contains elements copied
	/// from the specified collection, and has sufficient capacity to accommodate the
	/// number of elements copied.
	/// </summary>
	/// <param name="collection">The collection whose elements are copied to the new set.</param>
	public ObservableList([NotNull] IEnumerable<T> collection) : this(collection, EqualityComparer<T>.Default)
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
	public ObservableList([NotNull] IEnumerable<T> collection, [NotNull] IEqualityComparer<T> comparer) => this._set = new HashSet<T>(collection, comparer);

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
	/// Adds an item to the <see cref="ObservableList{T}" />.
	/// </summary>
	/// <param name="item">The object to add to the collection.</param>
	void ICollection<T>.Add([NotNull] T item) => this.Add(item);

	/// <inheritdoc />
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <inheritdoc />
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => this.GetEnumerator();

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
	/// Adds the specified element to the hash set.
	/// </summary>
	/// <param name="item">The element to add to the set.</param>
	/// <returns><see langword="true" /> if the element is added to the hash set; <see langword="false" /> if the element is already present.</returns>
	public virtual bool Add([AllowNull] T item)
	{
		if (item is null)
		{
			return false;
		}

		if (this._set.Contains(item))
		{
			return false;
		}

		this.OnCountPropertyChanging();

		_ = this._set.Add(item);

		this.OnCollectionChanged(NotifyCollectionChangedAction.Add, item);

		this.OnCountPropertyChanged();

		return true;
	}

	/// <summary>
	/// Removes all elements from the hash set.
	/// </summary>
	public virtual void Clear()
	{
		if (this._set.FastCount() == 0)
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
	public virtual bool Contains([AllowNull] T item)
	{
		if (item is null)
		{
			return false;
		}

		return this._set.Contains(item);
	}

	/// <summary>
	/// Copies the elements of the hash set to an array.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the hash set. The array must have zero-based indexing.</param>
	public virtual void CopyTo([NotNull] T[] array)
	{
		this._set.CopyTo(array.ArgumentNotNull());
	}

	/// <summary>
	/// Copies the elements of the hash set to an array, starting at the specified array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the hash set. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
	public virtual void CopyTo([NotNull] T[] array, int arrayIndex)
	{
		this._set.CopyTo(array.ArgumentNotNull(), arrayIndex);
	}

	/// <summary>
	/// Copies the specified number of elements of the hash set to an array, starting at the specified array index.
	/// </summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from
	/// the hash set. The array must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
	/// <param name="count">The number of elements to copy to array.</param>
	public virtual void CopyTo([NotNull] T[] array, int arrayIndex, int count)
	{
		this._set.CopyTo(array.ArgumentNotNull(), arrayIndex, count);
	}

	/// <summary>
	/// Removes all elements in the specified collection from the hash set.
	/// </summary>
	/// <param name="other">The collection of items to remove from the current hash set.</param>
	public virtual void ExceptWith([NotNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.ExceptWith(other);

		if (copy.FastCount() == this._set.FastCount())
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
	public virtual void IntersectWith([NotNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.IntersectWith(other);

		if (copy.FastCount() == this._set.FastCount())
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
	public virtual bool IsProperSubsetOf([NotNull] IEnumerable<T> other)
	{
		return this._set.IsProperSubsetOf(other.ArgumentNotNull());
	}

	/// <summary>
	/// Determines whether the hash set is a proper superset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current hash set.</param>
	/// <returns><see langword="true" /> if the hash set is a proper superset of other; otherwise, <see langword="false" />.</returns>
	public virtual bool IsProperSupersetOf([NotNull] IEnumerable<T> other)
	{
		return this._set.IsProperSupersetOf(other.ArgumentNotNull());
	}

	/// <summary>
	/// Determines whether the hash set is a subset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current hash set.</param>
	/// <returns><see langword="true" /> if the hash set is a subset of other; otherwise, <see langword="false" />.</returns>
	public virtual bool IsSubsetOf([NotNull] IEnumerable<T> other)
	{
		return this._set.IsSubsetOf(other.ArgumentNotNull());
	}

	/// <summary>
	/// Determines whether the hash set is a superset of the specified collection.
	/// </summary>
	/// <param name="other">The collection to compare to the current hash set.</param>
	/// <returns><see langword="true" /> if the hash set is a superset of other; otherwise, <see langword="false" />.</returns>
	public virtual bool IsSupersetOf([NotNull] IEnumerable<T> other)
	{
		return this._set.IsSupersetOf(other.ArgumentNotNull());
	}

	/// <summary>
	/// Determines whether the current object and a specified collection share common elements.
	/// </summary>
	/// <param name="other">The collection to compare to the current hash set.</param>
	/// <returns><see langword="true" /> if the hash set and other share at least one common element; otherwise, <see langword="false" />.</returns>
	public virtual bool Overlaps([NotNull] IEnumerable<T> other)
	{
		return this._set.Overlaps(other.ArgumentNotNull());
	}

	/// <summary>
	/// Removes the specified element from the hash set.
	/// </summary>
	/// <param name="item">The element to remove.</param>
	/// <returns><see langword="true" /> if the element is successfully found and removed; otherwise, <see langword="false" />.</returns>
	public virtual bool Remove([NotNull] T item)
	{
		if (item is null)
		{
			ExceptionThrower.ThrowArgumentNullException(nameof(item));
		}

		if (!this._set.Contains(item))
		{
			return false;
		}

		this.OnCountPropertyChanging();

		_ = this._set.Remove(item);

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
	public virtual int RemoveWhere([NotNull] Predicate<T> match)
	{
		match = match.ArgumentNotNull();

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
	public virtual bool SetEquals([NotNull] IEnumerable<T> other)
	{
		return this._set.SetEquals(other.ArgumentNotNull());
	}

	/// <summary>
	/// Modifies the current hash set to contain only elements that are present either in that
	/// object or in the specified collection, but not both.
	/// </summary>
	/// <param name="other">The collection to compare to the current hash set.</param>
	public virtual void SymmetricExceptWith([NotNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.SymmetricExceptWith(other);

		var removed = this._set.Where(i => !copy.Contains(i)).ToList();
		var added = copy.Where(i => !this._set.Contains(i)).ToList();

		if (removed.FastCount() == 0 && added.FastCount() == 0)
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
	public virtual void UnionWith([NotNull] IEnumerable<T> other)
	{
		other = other.ArgumentNotNull();

		var copy = new HashSet<T>(this._set, this._set.Comparer);

		copy.UnionWith(other);

		if (copy.FastCount() == this._set.FastCount())
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
	public virtual bool IsReadOnly => ((ICollection<T>)this._set).IsReadOnly;
}
