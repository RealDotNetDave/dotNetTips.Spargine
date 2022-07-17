// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 07-22-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="SocketExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Extensions for Socket.
	/// </summary>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", Status = Status.Available)]
	public static class SocketExtensions
	{
		/// <summary>
		/// Binds to an IP address and OS-assigned port. Returns the chosen port.
		/// Validates that <paramref name="socket" /> and <paramref name="address" /> is not null.
		/// </summary>
		/// <param name="socket">The socket.</param>
		/// <param name="address">The address.</param>
		/// <returns>System.Int32.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static int BindToAnonymousPort([NotNull] this Socket socket, [NotNull] IPAddress address)
		{
			socket.ArgumentNotNull().Bind(new IPEndPoint(address.ArgumentNotNull(), 0));

			return ( (IPEndPoint)socket.LocalEndPoint ).Port;
		}

		/// <summary>
		/// On non-Windows platforms, once non-blocking is turned on (either explicitly or by performing an async
		/// operation), always stay in non-blocking mode.
		/// Validates that <paramref name="socket" /> is not null.
		/// </summary>
		/// <param name="socket">The socket.</param>
		/// <param name="force">if set to <c>true</c> [force].</param>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static void ForceNonBlocking([NotNull] this Socket socket, bool force)
		{
			if (socket.CheckIsNotNull())
			{
				socket.Blocking = force;
			}
		}

		/// <summary>
		/// Tries to connect within the provided timeout interval Useful to speed up "cannot connect" assertions on
		/// Windows.
		/// Validates that <paramref name="socket" /> and <paramref name="remoteEndpoint" /> is not null.
		/// </summary>
		/// <param name="socket">The socket.</param>
		/// <param name="remoteEndpoint">The remote endpoint.</param>
		/// <param name="millisecondsTimeout">The milliseconds timeout.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="System.PlatformNotSupportedException"></exception>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static bool TryConnect([NotNull] this Socket socket, [NotNull] EndPoint remoteEndpoint, int millisecondsTimeout)
		{
			socket = socket.ArgumentNotNull();
			remoteEndpoint = remoteEndpoint.ArgumentNotNull();

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				using (var mre = new ManualResetEventSlim(false))
				{
					using (var sea = new SocketAsyncEventArgs() { RemoteEndPoint = remoteEndpoint, UserToken = mre })
					{
						sea.Completed += (s, e) => ( (ManualResetEventSlim)e.UserToken ).Set();

						var pending = socket.ConnectAsync(sea);

						if (!pending || mre.Wait(millisecondsTimeout))
						{
							return sea.SocketError == SocketError.Success;
						}

						Socket.CancelConnectAsync(sea); // this will close the socket!

						// In case of time-out, ManualResetEventSlim is left un-disposed to avoid race conditions,
						// letting SafeHandle's finalizer to do the cleanup.
						return false;
					}
				}
			}
			else
			{
				throw new PlatformNotSupportedException();
			}
		}
	}
}
