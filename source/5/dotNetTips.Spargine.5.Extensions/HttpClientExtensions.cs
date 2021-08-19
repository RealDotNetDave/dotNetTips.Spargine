// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions
// Author           : David McCarter
// Created          : 07-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-18-2021
// ***********************************************************************
// <copyright file="HttpClientExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using dotNetTips.Spargine.Core;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// HttpContext Extensions.
	/// </summary>
	public static class HttpClientExtensions
	{

		/// <summary>
		/// Gets the and deserialize a JSON data from endpoint.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="client">The client.</param>
		/// <param name="requestUri">The request URI.</param>
		/// <param name="options">The options.</param>
		/// <returns>T.</returns>
		[Information("Original code from: https://ardalis.com/keep-tests-short-and-dry-with-extensions", "David McCarter", "7/13/2021", UnitTestCoverage = 0, Status = Status.New)]
		public static async Task<T> GetAndDeserialize<T>([NotNull] this HttpClient client, string requestUri, [NotNull] JsonSerializerOptions options)
		{
			return await GetAndDeserialize<T>(client, new Uri(requestUri), options).ConfigureAwait(false);
		}

		/// <summary>
		/// Gets the and deserialize.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="client">The client.</param>
		/// <param name="requestUri">The request URI.</param>
		/// <param name="options">The options.</param>
		/// <returns>T.</returns>
		[Information("Original code from: https://ardalis.com/keep-tests-short-and-dry-with-extensions", "David McCarter", "7/13/2021", UnitTestCoverage = 0, Status = Status.New)]
		public static async Task<T> GetAndDeserialize<T>([NotNull] this HttpClient client, [NotNull] Uri requestUri, [NotNull] JsonSerializerOptions options)
		{
			using var response = await client.GetAsync(new Uri(requestUri.PathAndQuery)).ConfigureAwait(false);

			_ = response.EnsureSuccessStatusCode();

			var stringResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

			var result = JsonSerializer.Deserialize<T>(stringResponse, options);

			return result;
		}
	}
}
