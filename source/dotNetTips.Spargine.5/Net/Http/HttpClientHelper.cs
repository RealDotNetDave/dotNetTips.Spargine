// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 01-11-2021
//
// Last Modified By : David McCarter
// Last Modified On : 01-11-2021
// ***********************************************************************
// <copyright file="HttpClientHelper.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>HttpClient Helper Methods.</summary>
// ***********************************************************************
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

//![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Net.Http
{
    /// <summary>
    /// HttpClient Helper Methods.
    /// </summary>
    public static class HttpClientHelper
    {
        /// <summary>
        /// The http client
        /// </summary>
        private static readonly HttpClient _client = new HttpClient()
        {
            Timeout = TimeSpan.FromSeconds(10),
        };

        /// <summary>
        /// Calls GetAsync for HttpClient
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>HttpResponseMessage.</returns>
        /// <exception cref="ArgumentInvalidException">Url cannot be null or empty.</exception>
        /// <remarks>Original code by: Máňa Píchová.</remarks>
        public static async Task<HttpResponseMessage> GetAsync(string url)
        {
            Encapsulation.TryValidateParam(url, nameof(url));

            var cts = new CancellationTokenSource();

            try
            {
                // Pass in the token.
                var response = await _client.GetAsync(url, cts.Token).ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                return response;
            }
            catch (TaskCanceledException ex) when (cts.IsCancellationRequested)
            {
                // If the token has been canceled, it is not a timeout.
                // Handle cancellation.
                ExceptionThrower.ThrowInvalidOperationException("The operation has been canceled.", ex);
            }
            catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
            {
                // Handle timeout.
                ExceptionThrower.ThrowInvalidOperationException("The operation has timed out.", ex);
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                // Handle 404
                ExceptionThrower.ThrowInvalidOperationException($"Resource {url} was not found.", ex);
            }

            return null;
        }

        /// <summary>
        /// Calls GetStreamAsync for HttpClient
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>Stream.</returns>
        public static async Task<Stream> GetStreamAsync(string url)
        {
            Encapsulation.TryValidateParam(url, nameof(url));

            var cts = new CancellationTokenSource();

            try
            {
                // Pass in the token.
                var response = await _client.GetStreamAsync(url, cts.Token);

                return response;
            }
            catch (TaskCanceledException ex) when (cts.IsCancellationRequested)
            {
                // If the token has been canceled, it is not a timeout.
                // Handle cancellation.
                ExceptionThrower.ThrowInvalidOperationException("The operation has been canceled.", ex);
            }
            catch (TaskCanceledException ex) when (ex.InnerException is TimeoutException)
            {
                // Handle timeout.
                ExceptionThrower.ThrowInvalidOperationException("The operation has timed out.", ex);
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                // Handle 404
                ExceptionThrower.ThrowInvalidOperationException($"Resource {url} was not found.", ex);
            }

            return null;
        }
    }
}
