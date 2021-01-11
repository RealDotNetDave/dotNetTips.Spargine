using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

namespace dotNetTips.Spargine.Net.Http
{
    public static class HttpClientHelper
    {
        private static readonly HttpClient _client = new HttpClient()
        {
            Timeout = TimeSpan.FromSeconds(10)
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
                var response = await _client.GetAsync(url, cts.Token);

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
    }
}
