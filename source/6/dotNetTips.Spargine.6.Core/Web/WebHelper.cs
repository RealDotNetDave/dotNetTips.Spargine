// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Core
// Author           : David McCarter
// Created          : 02-07-2021
//
// Last Modified By : David McCarter
// Last Modified On : 04-15-2022
// ***********************************************************************
// <copyright file="WebHelper.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Microsoft.AspNetCore.Http;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.Web
{
	/// <summary>
	/// Class WebHelper.
	/// </summary>
	[Information("From dotNetTips.Utility", Status = Status.Available)]
	public static class WebHelper
	{

		/// <summary>
		/// The HTTP client
		/// </summary>
		private static readonly HttpClient _httpClient = new();

		/// <summary>
		/// Downloads the string.
		/// </summary>
		/// <param name="address">The address.</param>
		/// <param name="clientId">The client identifier.</param>
		/// <returns>System.String.</returns>
		/// <remarks>Make sure to call .Dispose on Task,</remarks>
		[Information(nameof(DownloadStringAsync), BenchMarkStatus = BenchMarkStatus.None, UnitTestCoverage = 100, Status = Status.Updated)]
		public static async Task<string> DownloadStringAsync(Uri address, string clientId = "NONE")
		{
			address = address.ArgumentNotNull();

			if (clientId.HasValue())
			{
				_httpClient.DefaultRequestHeaders.Add("CLIENTID", clientId);
			}

			// Download the data
			using (HttpResponseMessage response = await _httpClient.GetAsync(address).ConfigureAwait(false))
			{
				return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
			}
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
		/// Determines whether the Uri is from the local server.
		/// </summary>
		/// <param name="path">The Uri.</param>
		/// <param name="request">The context.</param>
		/// <returns><c>true</c> if [is local Uri] [the specified Uri]; otherwise, <c>false</c>.</returns>
		/// <remarks>If you are using .NET 4 or above or .NET Core, this check is not needed unless you have turned
		/// off validation in the config file or in classes.</remarks>
		[Information(nameof(IsLocalUri), author: "David McCarter", createdOn: "9/12/2020", UnitTestCoverage = 0, BenchMarkStatus = BenchMarkStatus.None, Status = Status.Available)]
		public static bool IsLocalUri([NotNull] string path, [NotNull] HttpRequest request)
		{
			path = path.ArgumentNotNullOrEmpty(true);
			request = request.ArgumentNotNull();

			if (Uri.TryCreate(path, UriKind.Absolute, out Uri absoluteUri))
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

		/// <summary>
		/// Gets the HTTP header names.
		/// </summary>
		/// <returns>System.String[].</returns>
		/// <value>The HTTP header names.</value>
		[Information(nameof(HttpHeaderNames), "David McCarter", "9/2/2020", "9/2/2020", Status = Status.Available, UnitTestCoverage = 100, BenchMarkStatus = BenchMarkStatus.NotRequired)]
		public static string[] HttpHeaderNames()
		{
			return Enum.GetNames(typeof(HttpRequestHeader));
		}
	}
}
