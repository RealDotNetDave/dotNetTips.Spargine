// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 08-19-2021
// ***********************************************************************
// <copyright file="StreamExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extensions methods for Stream.
	/// </summary>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
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
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static ValueTask<int> ReadAsync([NotNull] this Stream stream, [NotNull] Memory<byte> destination, CancellationToken cancellationToken = default)
		{
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
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static ValueTask WriteAsync([NotNull] this Stream stream, [NotNull] ReadOnlyMemory<byte> source, CancellationToken cancellationToken = default)
		{
			if (MemoryMarshal.TryGetArray(source, out var array))
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
