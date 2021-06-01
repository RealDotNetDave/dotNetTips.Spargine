// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 12-28-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-28-2021
// ***********************************************************************
// <copyright file="CachedEnumerable.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Original code by: Gérald Barré</summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core
{
	/// <summary>
	/// Class CachedEnumerable.
	/// </summary>
	[Information(nameof(CachedEnumerable), BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available, Documentation = "https:www.meziantou.net/caching-an-ienumerable-t-instance.htm")]
	public static class CachedEnumerable
	{
		/// <summary>
		/// Creates the specified enumerable.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="enumerable">The enumerable.</param>
		/// <returns>CachedEnumerable&lt;T&gt;.</returns>
		public static CachedEnumerable<T> Create<T>(IEnumerable<T> enumerable)
		{
			return new CachedEnumerable<T>(enumerable);
		}
	}

	/// <summary>
	/// Class CachedEnumerable. This class cannot be inherited.
	/// Implements the <see cref="System.Collections.Generic.IEnumerable{T}" />
	/// Implements the <see cref="System.IDisposable" />
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
	/// <seealso cref="System.IDisposable" />
	[Information(nameof(CachedEnumerable<T>), BenchMarkStatus = 0, UnitTestCoverage = 0, Status = Status.Available)]
	public sealed class CachedEnumerable<T> : IEnumerable<T>, IDisposable
	{
		/// <summary>
		/// The cache
		/// </summary>
		private readonly List<T> _cache = new();

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
		/// The disposed value
		/// </summary>
		private bool disposedValue;

		/// <summary>
		/// Initializes a new instance of the <see cref="CachedEnumerable{T}" /> class.
		/// </summary>
		/// <param name="enumerable">The enumerable.</param>
		public CachedEnumerable(IEnumerable<T> enumerable)
		{
			this._enumerable = enumerable;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		void IDisposable.Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			this.Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

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

		/// <summary>
		/// Checks the enumerable.
		/// </summary>
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckEnumerable()
		{
			Validate.TryValidateParam<ArgumentNullException>(this._enumerable is not null, paramName: "enumerable");
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		private void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
				if (disposing)
				{
					if (this._enumerator is not null)
					{
						this._enumerator.Dispose();
						this._enumerator = null;
					}
				}

				this.disposedValue = true;
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
			if (index < this._cache.Count)
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
				if (index < this._cache.Count)
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
	}
}
