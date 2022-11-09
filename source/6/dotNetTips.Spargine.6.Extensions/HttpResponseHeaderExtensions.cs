// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 07-17-2020
//
// Last Modified By : David McCarter
// Last Modified On : 04-28-2022
// ***********************************************************************
// <copyright file="HttpResponseHeaderExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class HttpResponseHeaderExtensions.
/// </summary>
[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
public static class HttpResponseHeaderExtensions
{
	/// <summary>
	/// The header names
	/// </summary>
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
	/// Gets the <see cref="HttpRequestHeader" /> name.
	/// </summary>
	/// <param name="header">The header.</param>
	/// <returns>System.String.</returns>
	[Information("From .NET Core source.", author: "David McCarter", createdOn: "7/15/2020", UnitTestCoverage = 0, Status = Status.Available)]
	public static string GetName([NotNull] this HttpResponseHeader header)
	{
		header = header.ArgumentDefined(nameof(header));

		return _headerNames[(int)header];
	}
}
