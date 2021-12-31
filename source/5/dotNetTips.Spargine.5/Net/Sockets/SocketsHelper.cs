// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 01-11-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-27-2021
// ***********************************************************************
// <copyright file="SocketsHelper.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>Socket helper methods.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Net.Sockets
{
	/// <summary>
	/// Socket helper methods.
	/// </summary>
	public static class SocketsHelper
	{
		/// <summary>
		/// connect TCP as an asynchronous operation.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <returns>Stream.</returns>
		/// <remarks>Original code by: Máňa Píchová.</remarks>
		public static async ValueTask<Stream> ConnectTcpAsync([NotNull] SocketsHttpConnectionContext context, CancellationToken cancellationToken)
		{
			// The following socket constructor will create a dual-mode socket on systems where IPV6 is available.
			using var socket = new Socket(SocketType.Stream, ProtocolType.Tcp)
			{
				/* Turn off Nagle's algorithm since it degrades performance in most HttpClient scenarios.*/
				NoDelay = true,
				DualMode = true,
			};

			await socket.ConnectAsync(context.DnsEndPoint, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);

			// The stream should take the ownership of the underlying socket,
			// closing it when it's disposed.
			return new NetworkStream(socket, ownsSocket: true);
		}
	}
}
