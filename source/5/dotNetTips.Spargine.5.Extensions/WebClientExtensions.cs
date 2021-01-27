// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5.Extensions **
// Author           : David McCarter
// Created          : 09-15-2017
//
// Last Modified By : David McCarter
// Last Modified On : 01-21-2021
// ***********************************************************************
// <copyright file="WebClientExtensions.cs" company="David McCarter - dotNetTips.com">
//     David McCarter - dotNetTips.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using dotNetTips.Spargine.Core;
using dotNetTips.Spargine.Core.OOP;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://github.com/RealDotNetDave/dotNetTips.Spargine )
namespace dotNetTips.Spargine.Extensions
{
	/// <summary>
	/// WebClient Extensions.
	/// </summary>
	public static class WebClientExtensions
	{
		/// <summary>
		/// Gets the json.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="client">The client.</param>
		/// <param name="url">The URL.</param>
		/// <returns>T.</returns>
		/// <exception cref="ArgumentNullException">client</exception>
		/// <exception cref="ArgumentException">URL cannot be empty or null. - url</exception>
		/// <exception cref="System.ArgumentNullException">URL cannot be empty or null.</exception>
		/// <exception cref="System.ArgumentException">URL cannot be empty or null.</exception>
		[Information(nameof(ConvertFrom), UnitTestCoverage = 0, Status = Status.Available)]
		public static T ConvertFrom<T>(this WebClient client, string url)
			where T : class
		{
			Encapsulation.TryValidateNullParam(client, nameof(client));
			Encapsulation.TryValidateParam(url, nameof(url));

			var data = client.DownloadString(url);

			if (string.IsNullOrEmpty(data))
			{
				return null;
			}

			using var stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
			var serializer = new DataContractJsonSerializer(typeof(T));
			var obj = (T)serializer.ReadObject(stream);

			stream.FlushClose();

			return obj;
		}
	}
}
