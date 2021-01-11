// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 07-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-22-2020
// ***********************************************************************
// <copyright file="HttpResponseHeaderExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Net;
using dotNetTips.Spargine.Core;

//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class HttpResponseHeaderExtensions.
	/// </summary>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
	public static class HttpResponseHeaderExtensions
	{

		private static readonly string[] _headerNames = {
			"Cache-Control",
			"Connection",
			"Date",
			"Keep-Alive",
			"Pragma",
			"Trailer",
			"Transfer-Encoding",
			"Upgrade",
			"Via",
			"Warning",
			"Allow",
			"Content-Length",
			"Content-Type",
			"Content-Encoding",
			"Content-Language",
			"Content-Location",
			"Content-MD5",
			"Content-Range",
			"Expires",
			"Last-Modified",
			"Accept-Ranges",
			"Age",
			"ETag",
			"Location",
			"Proxy-Authenticate",
			"Retry-After",
			"Server",
			"Set-Cookie",
			"Vary",
			"WWW-Authenticate",
		};

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <param name="header">The header.</param>
		/// <returns>System.String.</returns>
		[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", modifiedOn: "7/29/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static string GetName(this HttpResponseHeader header)
		{
			return _headerNames[(int)header];
		}

	}
}
