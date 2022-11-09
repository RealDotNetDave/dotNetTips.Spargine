// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 11-12-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2022
// ***********************************************************************
// <copyright file="Collection.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Common class for collections.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )
namespace DotNetTips.Spargine.Core.Collections.Generic;

/// <summary>
/// Custom collection with added features.
/// Implements the <see cref="List{T}" />
/// </summary>
/// <typeparam name="T"></typeparam>
/// <seealso cref="List{T}" />
[Information("Collection<T>.", "David McCarter", "11/12/2020")]
public class Collection<T> : List<T>
{
    /// <summary>
    /// Prevents a default instance of the <see cref="Collection{T}" /> class from being created.
    /// </summary>
    [Information(nameof(Collection<T>), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
    private Collection()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Collection{T}" /> class.
    /// </summary>
    /// <param name="capacity">The number of elements that the new list can initially store.</param>
    [Information(nameof(Collection<T>), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.Available)]
    private Collection(int capacity) : base(capacity)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="Collection{T}"/> class that contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.</summary>
    /// <param name="collection">The collection whose elements are copied to the new list.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="collection" /> is <see langword="null" />.</exception>
    public Collection(IEnumerable<T> collection) : base(collection)
    {
    }

    /// <summary>
    /// Adds the first.
    /// </summary>
    /// <param name="item">The item.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    [Information(nameof(AddFirst), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
    public void AddFirst([NotNull] T item)
    {
        if (item is null)
        {
            ExceptionThrower.ThrowArgumentNullException(nameof(item));
        }

        this.AddFirst(item);
    }

    /// <summary>
    /// Adds if not exists.
    /// </summary>
    /// <param name="item">The item.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    [Information(nameof(AddIfNotExists), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
    public bool AddIfNotExists([NotNull] T item)
    {
        if (item is null)
        {
            ExceptionThrower.ThrowArgumentNullException(nameof(item));
        }

        return Extensions.AddIfNotExists(this, item);
    }

    /// <summary>
    /// Adds the last.
    /// </summary>
    /// <param name="item">The item.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    [Information(nameof(AddLast), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
    public void AddLast([NotNull] T item)
    {
        if (item is null)
        {
            ExceptionThrower.ThrowArgumentNullException(nameof(item));
        }

        Extensions.AddLast(this, item);
    }

    /// <summary>
    /// Creates this instance.
    /// </summary>
    /// <returns>Collection&lt;T&gt;.</returns>
    [Information(nameof(Collection<T>), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
    public static Collection<T> Create() => new();

    /// <summary>
    /// Creates collection with the specified capacity.
    /// </summary>
    /// <param name="capacity">The capacity.</param>
    /// <returns>Collection&lt;T&gt;.</returns>
    [Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
    public static Collection<T> Create(int capacity)
    {
        capacity = capacity.ArgumentInRange(lower: 1, upper: int.MaxValue, defaultValue: 1);

        return new Collection<T>(capacity);
    }

    /// <summary>
    /// Creates the specified items.
    /// </summary>
    /// <param name="items">The items.</param>
    /// <returns>Collection&lt;T&gt;.</returns>
    [Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
    public static Collection<T> Create([NotNull] IEnumerable<T> items) => Create(items, Tristate.False);

    /// <summary>
    /// Creates the collection with the specified items.
    /// </summary>
    /// <param name="items">The items.</param>
    /// <param name="ensureUnique">if set to <c>true</c> [ensure unique].</param>
    /// <returns>Collection&lt;T&gt;.</returns>
    /// <exception cref="ArgumentNullException">Items
    /// or has no items.</exception>
    [Information(nameof(Create), "David McCarter", "11/12/2020", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
    public static Collection<T> Create([NotNull] IEnumerable<T> items, Tristate ensureUnique)
    {
        items = items.ArgumentNotNull();
        ensureUnique = ensureUnique.ArgumentDefined();

        var newItems = new Collection<T>();

        foreach (var item in items.Where(p => p is not null))
        {
            if (ensureUnique is Tristate.True or Tristate.UseDefault)
            {
                _ = newItems.AddIfNotExists(item);
            }
            else
            {
                newItems.Add(item);
            }
        }

        return newItems;
    }
}
