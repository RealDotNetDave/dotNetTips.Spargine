// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-15-2022
// ***********************************************************************
// <copyright file="StreamExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extensions methods for Stream.
	/// </summary>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available)]
	public static class StreamExtensions
	{
		/// <summary>
		/// Flushes and closes the Stream.
		/// </summary>
		/// <param name="stream">The stream.</param>
		public static void FlushClose([NotNull] this Stream stream)
		{
			stream.Flush();
			stream.Close();
		}

		/// <summary>
		/// Reads from the Stream asynchronously.
		/// </summary>
		/// <param name="stream">The stream.</param>
		/// <param name="destination">The destination.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>ValueTask&lt;System.Int32&gt;.</returns>
		/// <remarks>Make sure to call .Dispose on Task,</remarks>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static ValueTask<int> ReadAsync([NotNull] this Stream stream, [NotNull] Memory<byte> destination, CancellationToken cancellationToken = default)
		{
			stream = stream.ArgumentNotNull();

			if (MemoryMarshal.TryGetArray(destination, out ArraySegment<byte> array))
			{
				return new ValueTask<int>(stream.ReadAsync(array.Array, array.Offset, array.Count, cancellationToken));
			}
			else
			{
				var buffer = ArrayPool<byte>.Shared.Rent(destination.Length);

				return new ValueTask<int>(FinishReadAsync(stream.ReadAsync(buffer, 0, destination.Length, cancellationToken), buffer, destination));

				static async Task<int> FinishReadAsync(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination)
				{
					try
					{
						var result = await readTask.ConfigureAwait(false);
						new Span<byte>(localBuffer, 0, result).CopyTo(localDestination.Span);
						return result;
					}
					finally
					{
						ArrayPool<byte>.Shared.Return(localBuffer);
					}
				}
			}
		}

		/// <summary>
		/// Writes to the Stream asynchronously.
		/// </summary>
		/// <param name="stream">The stream.</param>
		/// <param name="source">The source.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>ValueTask.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static ValueTask WriteAsync([NotNull] this Stream stream, [NotNull] ReadOnlyMemory<byte> source, CancellationToken cancellationToken = default)
		{
			stream = stream.ArgumentNotNull();

			if (MemoryMarshal.TryGetArray(source.ArgumentNotNull(), out var array))
			{
				return new ValueTask(stream.WriteAsync(array.Array, array.Offset, array.Count, cancellationToken));
			}
			else
			{
				var buffer = ArrayPool<byte>.Shared.Rent(source.Length);
				source.Span.CopyTo(buffer);

				return new ValueTask(FinishWriteAsync(stream.WriteAsync(buffer, 0, source.Length, cancellationToken), buffer));

				static async Task FinishWriteAsync(Task writeTask, byte[] localBuffer)
				{
					try
					{
						await writeTask.ConfigureAwait(false);
					}
					finally
					{
						ArrayPool<byte>.Shared.Return(localBuffer);
					}
				}
			}
		}
	}
}
