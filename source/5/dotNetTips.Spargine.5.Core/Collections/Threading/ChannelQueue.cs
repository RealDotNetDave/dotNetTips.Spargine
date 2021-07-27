// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 11-12-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-26-2021
// ***********************************************************************
// <copyright file="Collection.cs" company="dotNetTips.Spargine.5.Core">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Common class for collections.</summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Collections
{
	/// <summary>
	/// Thread-Safe queue.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[Information("Queue using Channel<T>.", "David McCarter", "7/26/2021")]
	public class ChannelQueue<T>
	{
		/// <summary>
		/// The channel
		/// </summary>
		private readonly Channel<T> _channel;

		/// <summary>
		/// Prevents a default instance of the <see cref="ChannelQueue{T}" /> class from being created.
		/// </summary>
		[Information(nameof(ChannelQueue<T>), "David McCarter", "7/26/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public ChannelQueue()
		{
			this._channel = Channel.CreateUnbounded<T>();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ChannelQueue{T}" /> class.
		/// </summary>
		/// <param name="capacity">The capacity.</param>
		[Information(nameof(ChannelQueue<T>), "David McCarter", "7/26/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public ChannelQueue(int capacity)
		{
			this._channel = Channel.CreateBounded<T>(capacity);
		}

		/// <summary>
		/// Gets the count.
		/// </summary>
		/// <value>The count.</value>
		[Information(nameof(Count), "David McCarter", "7/26/2021", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public int Count
		{
			get
			{
				return this._channel.Reader.CanCount ? this._channel.Reader.Count : -1;
			}
		}

		/// <summary>
		/// Reads all items from the Channel as an asynchronous operation.
		/// Call Lock() to complete this method.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <returns>IAsyncEnumerable&lt;T&gt;.</returns>
		[Information(nameof(ListenAsync), "David McCarter", "7/26/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public async IAsyncEnumerable<T> ListenAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
		{
			await foreach (var item in this._channel.Reader.ReadAllAsync(cancellationToken).ConfigureAwait(false))
			{
				yield return item;
			}
		}

		/// <summary>
		/// Locks the Channel so more items cannot be added. This is not reversable.
		/// </summary>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		[Information(nameof(Lock), "David McCarter", "7/26/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public bool Lock()
		{
			return this._channel.Writer.TryComplete();
		}

		/// <summary>
		/// Read an item from the Channel as an asynchronous operation.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <returns>T.</returns>
		[Information(nameof(ReadAsync), "David McCarter", "7/26/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public async Task<T> ReadAsync(CancellationToken cancellationToken = default)
		{
			Validate.TryValidateNullParam(cancellationToken, nameof(cancellationToken));

			return await this._channel.Reader.ReadAsync(cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Write to the Channel as an asynchronous operation.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		[Information(nameof(WriteAsync), "David McCarter", "7/26/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public async Task WriteAsync(T item, CancellationToken cancellationToken = default)
		{
			Validate.TryValidateNullParam(item, nameof(item));
			Validate.TryValidateNullParam(cancellationToken, nameof(cancellationToken));

			await this._channel.Writer.WriteAsync(item, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Write a collection to the Channel as an asynchronous operation.
		/// </summary>
		/// <param name="items">The items.</param>
		/// <param name="lockQueue">if set to <c>true</c> [lock queue].</param>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		[Information(nameof(WriteAsync), "David McCarter", "7/26/2021", UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired, Status = Status.New)]
		public async Task WriteAsync(IEnumerable<T> items, bool lockQueue = false, CancellationToken cancellationToken = default)
		{
			Validate.TryValidateParam(items, nameof(items));
			Validate.TryValidateNullParam(cancellationToken, nameof(cancellationToken));

			foreach (var item in items.Where(p => p is not null))
			{
				await this._channel.Writer.WriteAsync(item, cancellationToken).ConfigureAwait(false);
			}

			if (lockQueue)
			{
				this.Lock();
			}
		}
	}
}
