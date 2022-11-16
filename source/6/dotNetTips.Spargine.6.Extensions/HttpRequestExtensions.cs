// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 06-01-2018
//
// Last Modified By : David McCarter
// Last Modified On : 01-06-2023
// ***********************************************************************
// <copyright file="HttpRequestExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json;
using DotNetTips.Spargine.Core;
using Microsoft.AspNetCore.Http;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions;

/// <summary>
/// Class HttpRequestExtensions.
/// </summary>
public static class HttpRequestExtensions
{
	/// <summary>
	/// Retrieves the raw body as a byte array from the <see cref="HttpRequest" /> body stream.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <param name="request">The request.</param>
	/// <returns>Task&lt;System.Byte[]&gt;.</returns>
	/// <exception cref="ArgumentNullException">request</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	public static async Task<byte[]> GetRawBodyBytesAsync([NotNull] this HttpRequest request)
	{
		request = request.ArgumentNotNull();

		using (var ms = new MemoryStream(2048))
		{
			await request.Body.CopyToAsync(ms, CancellationToken.None).ConfigureAwait(false);

			return ms.ToArray();
		}
	}

	/// <summary>
	/// Retrieve the raw body as a string from the <see cref="HttpRequest" /> body stream.
	/// Validates that <paramref name="request" /> and <paramref name="encoding" /> is not null.
	/// </summary>
	/// <param name="request">Request instance to apply to.</param>
	/// <param name="encoding">Optional - Encoding, defaults to UTF8.</param>
	/// <returns>Task&lt;System.String&gt;.</returns>
	/// <exception cref="ArgumentNullException">request</exception>
	/// <exception cref="ArgumentNullException">encoding</exception>
	/// <remarks>Make sure to call .Dispose on Task,</remarks>
	public static async Task<string> GetRawBodyStringAsync([NotNull] this HttpRequest request, [NotNull] Encoding encoding)
	{
		request = request.ArgumentNotNull();
		encoding = encoding.ArgumentNotNull();

		using (var reader = new StreamReader(request.Body, encoding))
		{
			return await reader.ReadToEndAsync().ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Tries the get <see cref="HttpRequest" /> body.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="request">The HTTPRequest object.</param>
	/// <param name="value">The return value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">request</exception>
	/// <remarks>Original code by Jerry Nixon</remarks>
	public static bool TryGetBody<T>([NotNull] this HttpRequest request, out T value)
	{
		request = request.ArgumentNotNull();

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
	/// Tries the get <see cref="HttpRequest" /> body.
	/// Validates that <paramref name="request" /> is not null.
	/// </summary>
	/// <param name="request">The HTTPRequest object.</param>
	/// <param name="value">The return value.</param>
	/// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
	/// <exception cref="ArgumentNullException">request</exception>
	/// <exception cref="ArgumentException">HttpRequest has no body.</exception>
	/// <remarks>Original code by Jerry Nixon</remarks>
	public static bool TryGetBody([NotNull] this HttpRequest request, out byte[] value)
	{
		request = request.ArgumentNotNull();

		if ((request.Body?.Length ?? 0) == 0)
		{
			ExceptionThrower.ThrowArgumentException("HttpRequest has no body.", nameof(request.Body));
		}

		value = GetBytes(request);

		return value.HasItems();

		static byte[] GetBytes(HttpRequest request)
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
