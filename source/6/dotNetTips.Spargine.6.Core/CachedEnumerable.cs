// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 12-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2022
// ***********************************************************************
// <copyright file="CachedEnumerable.cs" company="McCarter Consulting">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Original code by: Gérald Barré</summary>
// ***********************************************************************
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core;

/// <summary>
/// Class CachedEnumerable.
/// </summary>
[Information(nameof(CachedEnumerable), BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available, Documentation = "https:www.meziantou.net/caching-an-ienumerable-t-instance.htm")]
public static class CachedEnumerable
{
	/// <summary>
	/// Creates the specified enumerable.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="enumerable">The enumerable.</param>
	/// <returns>CachedEnumerable&lt;T&gt;.</returns>
	public static CachedEnumerable<T> Create<T>([NotNull] IEnumerable<T> enumerable) => new(enumerable);
}

/// <summary>
/// Class CachedEnumerable. This class cannot be inherited.
/// Implements the <see cref="IEnumerable{T}" />
/// Implements the <see cref="IDisposable" />
/// </summary>
/// <typeparam name="T"></typeparam>
/// <seealso cref="IEnumerable{T}" />
/// <seealso cref="IDisposable" />
/// <remarks>This type implements IDisposable. Make sure to call .Dispose() or use the 'using' statement
/// to remove from memory.</remarks>
[Information(nameof(CachedEnumerable<T>), BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
public sealed class CachedEnumerable<T> : IEnumerable<T>, IDisposable
{
	/// <summary>
	/// The cache
	/// </summary>
	private readonly List<T> _cache = new();

	/// <summary>
	/// The disposed value
	/// </summary>
	private bool _disposed;

	/// <summary>
	/// The enumerable
	/// </summary>
	private readonly IEnumerable<T> _enumerable;

	/// <summary>
	/// The enumerated
	/// </summary>
	private bool _enumerated;

	/// <summary>
	/// The enumerator
	/// </summary>
	private IEnumerator<T> _enumerator;

	/// <summary>
	/// Initializes a new instance of the <see cref="CachedEnumerable{T}" /> class.
	/// </summary>
	/// <param name="enumerable">The enumerable.</param>
	public CachedEnumerable(IEnumerable<T> enumerable) => this._enumerable = enumerable;

	/// <summary>
	/// Finalizes an instance of the <see cref="CachedEnumerable{T}" /> class.
	/// </summary>
	~CachedEnumerable() => this.Dispose(false);

	/// <summary>
	/// Returns an enumerator that iterates through a collection.
	/// </summary>
	/// <returns>An <see cref="IEnumerator" /> object that can be used to iterate through the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	/// <summary>
	/// Checks the enumerable.
	/// </summary>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void CheckEnumerable()
	{
		_ = this._enumerable.CheckIsNotNull(true);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	private void Dispose(bool disposing)
	{
		if (!this._disposed)
		{
			if (disposing && this._enumerator is not null)
			{
				this._enumerator.Dispose();
				this._enumerator = null;
			}

			this._disposed = true;
		}
	}

	/// <summary>
	/// Tries the get item.
	/// </summary>
	/// <param name="index">The index.</param>
	/// <param name="result">The result.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	private bool TryGetItem(int index, out T result)
	{
		this.CheckEnumerable();

		// if the item is in the cache, use it
		if (index < this._cache.FastCount())
		{
			result = this._cache[index];
			return true;
		}

		lock (this._cache)
		{
			if (this._enumerator is null && !this._enumerated)
			{
				this._enumerator = this._enumerable.GetEnumerator();
			}

			// Another thread may have get the item while we were acquiring the lock
			if (index < this._cache.FastCount())
			{
				result = this._cache[index];
				return true;
			}

			// If we have already enumerate the whole stream, there is nothing else to do
			if (this._enumerated)
			{
				result = default;
				return false;
			}

			// Get the next item and store it to the cache
			if (this._enumerator.MoveNext())
			{
				result = this._enumerator.Current;
				this._cache.Add(result);
				return true;
			}
			else
			{
				// There are no more items, we can dispose the underlying enumerator
				this._enumerator.Dispose();
				this._enumerator = null;
				this._enumerated = true;
				result = default;
				return false;
			}
		}
	}

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		this.Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>An enumerator that can be used to iterate through the collection.</returns>
	public IEnumerator<T> GetEnumerator()
	{
		this.CheckEnumerable();

		var index = 0;

		while (true)
		{
			if (this.TryGetItem(index, out var result))
			{
				yield return result;
				index++;
			}
			else
			{
				// There are no more items
				yield break;
			}
		}
	}
}
