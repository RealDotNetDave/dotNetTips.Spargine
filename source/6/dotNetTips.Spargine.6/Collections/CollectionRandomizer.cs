// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-02-2022
// ***********************************************************************
// <copyright file="CollectionRandomizer.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using DotNetTips.Spargine.Extensions;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Collections;

/// <summary>
/// Class CollectionRandomizer.
/// </summary>
/// <typeparam name="T">Generic type parameter.</typeparam>
/// <remarks>The CollectionRandomizer is designed to shuffle a collection and allow retrieving items by using GetNext().</remarks>
[Information(nameof(CollectionRandomizer<T>), author: "David McCarter and Kristine Tran", createdOn: "8/26/2020", Status = Status.Available)]
public sealed class CollectionRandomizer<T>
{
	/// <summary>
	/// The collection
	/// </summary>
	private ImmutableArray<T> _collection;

	/// <summary>
	/// The collection enumerator
	/// </summary>
	private ImmutableArray<T>.Enumerator _collectionEnumerator;

	/// <summary>
	/// The initialized
	/// </summary>
	private bool _initialized;

	/// <summary>
	/// The repeat
	/// </summary>
	private readonly bool _repeat;

	/// <summary>
	/// The thread lock
	/// </summary>
	private readonly object _threadLock = new();

	/// <summary>
	/// Initializes a new instance of the <see cref="CollectionRandomizer{T}" /> class.
	/// </summary>
	/// <param name="collection">The collection.</param>
	/// <param name="repeat">If set to <c>true</c> and when using GetNext() the collection will repeat over and over and each time re-
	/// shuffled. Be careful of getting into an endless loop, it could cause your app to crash.</param>
	/// <remarks>The collection cannot be changed after initialization.</remarks>
	[Information(nameof(CollectionRandomizer<T>), "David McCarter", "4/21/2021", Status = Status.Available, UnitTestCoverage = 0)]
	public CollectionRandomizer([NotNull] IEnumerable<T> collection, bool repeat = false)
	{
		this._collection = collection.ToImmutableArray();
		this._repeat = repeat;
	}

	/// <summary>
	/// Initializes this instance.
	/// </summary>
	/// <exception cref="InvalidValueException{ImmutableArray}">Underlying collection is null.</exception>
	/// <exception cref="InvalidValueException{TValue}">Underlying collection is null.</exception>
	private void Init()
	{
		//Ignore if initialized unless repeat is true.
		if ((this._initialized && this.HasRemainingItems) ||
			(this._initialized && this.HasRemainingItems && this._repeat is false))
		{
			return;
		}

		//Validate Collection
		if (this._collection.HasItems() is false)
		{
			ExceptionThrower.ThrowInvalidValueException("Underlying collection is null.", this._collection);
		}

		//Shuffle Collection
		this._collection = this._collection.Shuffle();

		//Setup enumerator
		this._collectionEnumerator = this._collection.GetEnumerator();

		//Move to first item
		this.HasRemainingItems = this._collectionEnumerator.MoveNext();

		this._initialized = true;
	}

	/// <summary>
	/// Gets the next item in the collection.
	/// </summary>
	/// <returns>T.</returns>
	[Information(nameof(GetNext), "David McCarter", "4/21/2021", Status = Status.Available, UnitTestCoverage = 0)]
	public T GetNext()
	{
		lock (this._threadLock)
		{
			this.Init();

			var collectionItem = this._collectionEnumerator.Current;

			this.HasRemainingItems = this._collectionEnumerator.MoveNext();

			return collectionItem;
		}
	}

	/// <summary>
	/// Gets a value indicating whether this instance has remaining items.
	/// </summary>
	/// <value><c>true</c> if this instance has remaining items; otherwise, <c>false</c>. This value will be <c>false</c>
	/// until the first time GetNext() is called and the shuffle is initialized.</value>
	[Information(nameof(HasRemainingItems), "David McCarter", "4/21/2021", Status = Status.Available, UnitTestCoverage = 0)]
	public bool HasRemainingItems { get; private set; }
}
