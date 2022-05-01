// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 09-04-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-16-2022
// ***********************************************************************
// <copyright file="HttpContextExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using Microsoft.AspNetCore.Http;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// HttpContext Extensions.
	/// </summary>
	public static class HttpContextExtensions
	{
		/// <summary>
		/// Gets the remote IP address.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <returns>System.String.</returns>
		[Information("Original code from: https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20", "David McCarter", "9/04/2017", UnitTestCoverage = 0, Status = Status.Available)]
		public static string GetRemoteIPAddress([NotNull] this HttpContext context)
		{
			return context.ArgumentNotNull().Connection.RemoteIpAddress.ToString();
		}
	}
}
