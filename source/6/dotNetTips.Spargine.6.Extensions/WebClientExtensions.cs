// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 07-17-2022
// ***********************************************************************
// <copyright file="WebClientExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using DotNetTips.Spargine.Core;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Extensions
{
	/// <summary>
	/// WebClient Extensions.
	/// </summary>
	public static class WebClientExtensions
	{
		/// <summary>
		/// Gets the json.
		/// Validates that <paramref name="client" /> and <paramref name="url" /> is not null.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="client">The client.</param>
		/// <param name="url">The URL.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">client</exception>
		/// <exception cref="ArgumentException">URL cannot be empty or null. - url</exception>
		/// <exception cref="ArgumentNullException">URL cannot be empty or null.</exception>
		/// <exception cref="ArgumentException">URL cannot be empty or null.</exception>
		[Information(nameof(ConvertFrom), UnitTestCoverage = 0, Status = Status.Available)]
		public static T ConvertFrom<T>([NotNull] this WebClient client, Uri url)
			where T : class
		{
			client = client.ArgumentNotNull();
			url = url.ArgumentNotNull();

			var data = client.DownloadString(url);

			if (string.IsNullOrEmpty(data))
			{
				return null;
			}

			using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
			{
				var serializer = new DataContractJsonSerializer(typeof(T));
				var obj = (T)serializer.ReadObject(stream);

				stream.FlushClose();

				return obj;
			}
		}
	}
}
