// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions
// Author           : David McCarter
// Created          : 07-13-2021
//
// Last Modified By : David McCarter
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="HttpClientExtensions.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// HttpContext Extensions.
	/// </summary>
	public static class HttpClientExtensions
	{
		/// <summary>
		/// Gets and deserializes the <see cref="HttpClient" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="client">The client.</param>
		/// <param name="url">The URL.</param>
		/// <param name="options">The options.</param>
		/// <returns>T.</returns>
		/// <remarks>Make sure to call .Dispose on Task,</remarks>
		[Information("Original code from: https://ardalis.com/keep-tests-short-and-dry-with-extensions", "David McCarter", "7/13/2021", UnitTestCoverage = 0, Status = Status.Available)]
		public static async Task<T> GetAndDeserializeAsync<T>([NotNull] this HttpClient client, [NotNull] Uri url, [NotNull] JsonSerializerOptions options)
		{
			client = client.ArgumentNotNull();
			url = url.ArgumentNotNull();
			options = options.ArgumentNotNull();

			using (var response = await client.GetAsync(new Uri(url.PathAndQuery)).ConfigureAwait(false))
			{
				_ = response.EnsureSuccessStatusCode();

				var stringResponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

				return JsonSerializer.Deserialize<T>(stringResponse, options);
			}
		}
	}
}
