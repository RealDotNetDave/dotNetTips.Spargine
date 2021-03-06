﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 06-01-2018
//
// Last Modified By : David McCarter
// Last Modified On : 02-13-2021
// ***********************************************************************
// <copyright file="HttpRequestExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using Microsoft.AspNetCore.Http;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// Class HttpRequestExtensions.
	/// </summary>
	public static class HttpRequestExtensions
	{

		/// <summary>
		/// Retrieves the raw body as a byte array from the Request.Body stream.
		/// </summary>
		/// <param name="request">The request.</param>
		/// <returns>Task&lt;System.Byte[]&gt;.</returns>
		/// <exception cref="ArgumentNullException">request</exception>
		public static async Task<byte[]> GetRawBodyBytesAsync(this HttpRequest request)
		{
			Validate.TryValidateNullParam(request, nameof(request));

			using var ms = new MemoryStream(2048);
			await request.Body.CopyToAsync(ms).ConfigureAwait(true);

			return ms.ToArray();
		}

		/// <summary>
		/// Retrieve the raw body as a string from the Request.Body stream.
		/// </summary>
		/// <param name="request">Request instance to apply to.</param>
		/// <param name="encoding">Optional - Encoding, defaults to UTF8.</param>
		/// <returns>Task&lt;System.String&gt;.</returns>
		/// <exception cref="ArgumentNullException">request</exception>
		/// <exception cref="System.ArgumentNullException">request</exception>
		public static async Task<string> GetRawBodyStringAsync(this HttpRequest request, Encoding encoding)
		{
			Validate.TryValidateNullParam(request, nameof(request));

			if (Validate.TryValidateNull(encoding))
			{
				encoding = Encoding.UTF8;
			}

			using var reader = new StreamReader(request.Body, encoding);

			return await reader.ReadToEndAsync().ConfigureAwait(true);
		}

		/// <summary>
		/// Tries the get HttpRequest body.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="request">The HTTPRequest object.</param>
		/// <param name="value">The return value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">request</exception>
		/// <remarks>Original code by Jerry Nixon</remarks>
		public static bool TryGetBody<T>(this HttpRequest request, out T value)
		{
			Validate.TryValidateNullParam(request, nameof(request));

			if (!request.TryGetBody(out var bytes))
			{
				value = default;
				return false;
			}

			try
			{

				value = JsonSerializer.Deserialize<T>(BitConverter.ToString(bytes));

				return true;
			}
			catch (ArgumentNullException)
			{
				value = default;
				return false;
			}
		}

		/// <summary>
		/// Tries the get HTTPRequest body.
		/// </summary>
		/// <param name="request">The HTTPRequest object.</param>
		/// <param name="value">The return value.</param>
		/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
		/// <exception cref="ArgumentNullException">request</exception>
		/// <exception cref="ArgumentException">HttpRequest has no body.</exception>
		/// <exception cref="Exception">HttpRequest has no body.</exception>
		/// <remarks>Original code by Jerry Nixon</remarks>
		public static bool TryGetBody(this HttpRequest request, out byte[] value)
		{
			Validate.TryValidateNullParam(request, nameof(request));

			try
			{
				if (( request.Body?.Length ?? 0 ) == 0)
				{
					ExceptionThrower.ThrowArgumentException("HttpRequest has no body.", nameof(request.Body));
				}

				value = GetBytes();

				return true;
			}
			catch
			{
				value = default;
				return false;
			}

			byte[] GetBytes()
			{
				byte[] bytes;

				using (var ms = new MemoryStream())
				{
					request.Body.CopyTo(ms);
					bytes = ms.ToArray();
				}

				return bytes;
			}
		}

	}
}
