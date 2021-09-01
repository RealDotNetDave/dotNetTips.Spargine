// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 01-11-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-23-2021
// ***********************************************************************
// <copyright file="HttpClientHelper.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>HttpClient Helper Methods.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Net.Http
{
	/// <summary>
	/// HttpClient Helper Methods.
	/// Features 20 second timeout.
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
		/// get HTTP response as an asynchronous operation.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns>HttpResponseMessage.</returns>
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = 0, Status = Status.Available)]
		public static async Task<HttpResponseMessage> GetHttpResponseAsync([NotNull] string url)
		{
			return await GetHttpResponseAsync(new Uri(url)).ConfigureAwait(false);
		}

		/// <summary>
		/// get HTTP response as an asynchronous operation.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <returns>HttpResponseMessage.</returns>
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = 0, Status = Status.Available)]
		public static async Task<HttpResponseMessage> GetHttpResponseAsync([NotNull] Uri url)
		{
			Validate.TryValidateParam(url, nameof(url));

			using var cts = new CancellationTokenSource();

			return await GetHttpResponseAsync(url.PathAndQuery, cts).ConfigureAwait(continueOnCapturedContext: false);
		}

		/// <summary>
		/// Calls GetAsync for HttpClient
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>HttpResponseMessage.</returns>
		/// <exception cref="ArgumentInvalidException">Url cannot be null or empty.</exception>
		/// <remarks>Original code by: Máňa Píchová.</remarks>
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = 0, Status = Status.Available)]
		public static async Task<HttpResponseMessage> GetHttpResponseAsync([NotNull] string url, CancellationTokenSource cancellationToken)
		{
			try
			{
				// Pass in the token.
				var response = await _client.GetAsync(new Uri(url), cancellationToken.Token).ConfigureAwait(continueOnCapturedContext: false);

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
		[Information(nameof(GetHttpResponseAsync), UnitTestCoverage = 0, BenchMarkStatus = 0, Status = Status.Available)]
		public static async Task<Stream> GetStreamAsync([NotNull] string url)
		{
			using (var cts = new CancellationTokenSource())
			{
				try
				{
					// Pass in the token.
					var response = await _client.GetStreamAsync(new Uri(url), cts.Token).ConfigureAwait(continueOnCapturedContext: false);

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
