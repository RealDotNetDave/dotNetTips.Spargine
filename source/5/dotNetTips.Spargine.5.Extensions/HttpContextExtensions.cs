﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 09-04-2020
//
// Last Modified By : David McCarter
// Last Modified On : 02-01-2021
// ***********************************************************************
// <copyright file="HttpContextExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Spargine.Core;
using Microsoft.AspNetCore.Http;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
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
		[Information("Original code from: https://edi.wang/post/2017/10/16/get-client-ip-aspnet-20", "David McCarter", "9/04/2017", "9/04/2020", UnitTestCoverage = 0, Status = Status.Available)]
		public static string GetRemoteIPAddress(this HttpContext context)
		{
			Validate.TryValidateNullParam(context, nameof(context));

			return context.Connection.RemoteIpAddress.ToString();
		}
	}
}
