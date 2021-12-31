// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 12-05-2021
// ***********************************************************************
// <copyright file="WebHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Microsoft.AspNetCore.Http;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Core.Web
{
	/// <summary>
	/// Class WebHelper.
	/// </summary>
	[Information("From dotNetTips.Utility", Status = Status.Available)]
	public static class WebHelper
	{
		/// <summary>
		/// Gets the HTTP header names.
		/// </summary>
		/// <value>The HTTP header names.</value>
		[Information(nameof(HttpHeaderNames), "David McCarter", "9/2/2020", "9/2/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired)]
		public static string[] HttpHeaderNames { get; } = Enum.GetNames(typeof(HttpRequestHeader));

		/// <summary>
		/// Downloads the string.
		/// </summary>
		/// <param name="address">The address.</param>
		/// <param name="clientId">The client identifier.</param>
		/// <returns>System.String.</returns>
		[Information(nameof(DownloadString), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Available)]
		public static string DownloadString([NotNull] Uri address, string clientId = "NONE")
		{
			using var client = new WebClient();

			if (clientId.HasValue())
			{
				client.Headers.Add("CLIENTID", clientId);
			}

			// Download the data
			return client.DownloadString(address);
		}

		/// <summary>
		/// download string as an asynchronous operation.
		/// </summary>
		/// <param name="address">The address.</param>
		/// <param name="clientId">The client identifier.</param>
		/// <returns>System.String.</returns>
		[Information("From dotNetTips.Utility", "David McCarter", "9/2/2020", "9/2/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.None)]
		public static async Task<string> DownloadStringAsync([NotNull] Uri address, string clientId = "NONE")
		{
			using var client = new WebClient();

			if (clientId.HasValue())
			{
				client.Headers.Add("CLIENTID", clientId);
			}

			// Download the data
			return await client.DownloadStringTaskAsync(address).ConfigureAwait(false);
		}

		// public static async Task<TResult> PostAsync<TResult>(Uri address, HttpContent content)
		// {
		//    Encapsulation.TryValidateParam(address, nameof(address));
		//    Encapsulation.TryValidateParam<ArgumentNullException>(content is not null, nameof(content));

		// using (var client = new HttpClient())
		//    {
		//        var result = await client.PostAsync(address, content).ConfigureAwait(false);

		// if (result.IsSuccessStatusCode)
		//        {
		//            var resultResponse = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

		// return JsonSerializer.Deserialize<TResult>(resultResponse);
		//        }
		//    }
		// }

		/// <summary>
		/// Determines whether the url is from the local server.
		/// </summary>
		/// <param name="path">The URL.</param>
		/// <param name="request">The context.</param>
		/// <returns><c>true</c> if [is local URL] [the specified URL]; otherwise, <c>false</c>.</returns>
		/// <remarks>If you are using .NET 4 or above or .NET Core, this check is not needed unless you have turned
		/// off validation in the config file or in classes.</remarks>
		[Information(nameof(IsLocalUrl), author: "David McCarter", createdOn: "9/12/2020", modifiedOn: "9/14/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool IsLocalUrl([NotNull] string path, [NotNull] HttpRequest request)
		{
			if (Uri.TryCreate(path, UriKind.Absolute, out var absoluteUri))
			{
				var validHostName = string.Equals(request.Host.ToUriComponent(), absoluteUri.Host, StringComparison.OrdinalIgnoreCase);

				return validHostName;
			}
			else
			{
				var isLocal = !path.StartsWith("http:", StringComparison.OrdinalIgnoreCase) &&
					!path.StartsWith("https:", StringComparison.OrdinalIgnoreCase) &&
					Uri.IsWellFormedUriString(path, UriKind.Relative);

				return isLocal;
			}
		}
	}
}
