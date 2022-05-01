// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 01-11-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-12-2022
// ***********************************************************************
// <copyright file="HttpClientHelper.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>HttpClient Helper Methods.</summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Net.Http
{
	/// <summary>
	/// HttpClient Helper Methods.
	/// Uses 20 second timeout.
	/// </summary>
	public static class HttpClientHelper
	{
		/// <summary>
		/// The http client
		/// </summary>
		private static readonly HttpClient _client = new()
		{
			Timeout = TimeSpan.FromSeconds(value: 20),
		};

		/// <summary>
		/// Get HTTP response as an asynchronous operation.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns>A Task&lt;HttpResponseMessage&gt; representing the asynchronous operation.</returns>
		/// <remarks>Make sure to call .Dispose on Task,</remarks>
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static async Task<HttpResponseMessage> GetHttpResponseAsync(string url)
		{
			url = url.ArgumentNotNullOrEmpty();

			using (var cts = new CancellationTokenSource())
			{
				return await GetHttpResponseAsync(new Uri(url), cts).ConfigureAwait(false);
			}
		}

		/// <summary>
		/// Get HTTP response as an asynchronous operation.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns>A Task&lt;HttpResponseMessage&gt; representing the asynchronous operation.</returns>
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static async Task<HttpResponseMessage> GetHttpResponseAsync(Uri url)
		{
			url = url.ArgumentNotNull<Uri>();

			using (var cts = new CancellationTokenSource())
			{
				return await GetHttpResponseAsync(url, cts).ConfigureAwait(false);
			}
		}

		/// <summary>
		/// Calls GetAsync for HttpClient
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>HttpResponseMessage.</returns>
		/// <exception cref="ArgumentInvalidException">Url cannot be null or empty.</exception>
		/// <remarks>Original code by: Máňa Píchová.</remarks>
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static async Task<HttpResponseMessage> GetHttpResponseAsync(Uri url, [NotNull] CancellationTokenSource cancellationToken)
		{
			url = url.ArgumentNotNull<Uri>();

			try
			{
				// Pass in the token.
				var response = await _client.GetAsync(url, cancellationToken.Token).ConfigureAwait(continueOnCapturedContext: false);

				_ = response.EnsureSuccessStatusCode();

				return response;
			}
			catch (TaskCanceledException ex) when (cancellationToken.IsCancellationRequested)
			{
				// If the token has been canceled, it is not a timeout.
				// Handle cancellation.
				ExceptionThrower.ThrowInvalidOperationException(message: "The operation has been canceled.", ex);
			}
			catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
			{
				// Handle timeout.
				ExceptionThrower.ThrowInvalidOperationException(message: "The operation has timed out.", ex);
			}
			catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
			{
				// Handle 404
				ExceptionThrower.ThrowInvalidOperationException(message: $"Resource {url} was not found.", ex);
			}

			return null;
		}

		/// <summary>
		/// Calls GetStreamAsync for HttpClient
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns>Stream.</returns>
		/// <remarks>Make sure to call .Dispose on Task,</remarks>
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static async Task<Stream> GetStreamAsync(string url)
		{
			url = url.ArgumentNotNullOrEmpty();

			return await GetStreamAsync(new Uri(url)).ConfigureAwait(false);
		}

		/// <summary>
		/// Calls GetStreamAsync for HttpClient
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns>Stream.</returns>
		/// <remarks>Make sure to call .Dispose on Task,</remarks>
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static async Task<Stream> GetStreamAsync(Uri url)
		{
			url = url.ArgumentNotNull<Uri>();

			using (var cts = new CancellationTokenSource())
			{
				try
				{
					// Pass in the token.
					var response = await _client.GetStreamAsync(url, cts.Token).ConfigureAwait(continueOnCapturedContext: false);

					return response;
				}
				catch (TaskCanceledException ex) when (cts.IsCancellationRequested)
				{
					// If the token has been canceled, it is not a timeout.
					// Handle cancellation.
					ExceptionThrower.ThrowInvalidOperationException(message: "The operation has been canceled.", ex);
				}
				catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
				{
					// Handle timeout.
					ExceptionThrower.ThrowInvalidOperationException(message: "The operation has timed out.", ex);
				}
				catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
				{
					// Handle 404
					ExceptionThrower.ThrowInvalidOperationException(message: $"Resource {url} was not found.", ex);
				}
			}

			return null;
		}
	}
}
