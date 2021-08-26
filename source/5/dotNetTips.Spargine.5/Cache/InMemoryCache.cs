﻿// ***********************************************************************
// Assembly         : dotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-16-2021
// ***********************************************************************
// <copyright file="InMemoryCache.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>In memory cache.</summary>
// ***********************************************************************
using System;
using System.Diagnostics.CodeAnalysis;
using dotNetTips.Spargine.Core;
using Microsoft.Extensions.Caching.Memory;

//`![](3E0A21AABFC7455594710AC4CAC7CD5C.png;https://www.spargine.net )
namespace dotNetTips.Spargine.Cache
{
	/// <summary>
	/// InMemoryCache.
	/// </summary>
	/// <remarks>Expiration is set to 20 minutes.</remarks>
	public sealed class InMemoryCache
	{
		/// <summary>
		/// The timeout amount.
		/// </summary>
		private const int Timeout = 20;

		/// <summary>
		/// Prevents a default instance of the <see cref="InMemoryCache" /> class from being created.
		/// Default timeout is 20 minutes.
		/// </summary>
		private InMemoryCache() => this.Cache = CreateCache(new TimeSpan(0, Timeout, 0));

		/// <summary>
		/// Gets the count.
		/// </summary>
		/// <value>The count.</value>
		public static int Count => Instance.Cache.Count;

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>The instance.</value>
		public static InMemoryCache Instance { get; } = new();

		/// <summary>
		/// Gets or sets (private) the cache.
		/// </summary>
		/// <value>The cache.</value>
		public MemoryCache Cache { get; private set; }

		/// <summary>
		/// Adds item to the cache.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="key">The key.</param>
		/// <param name="item">The item.</param>
		/// <exception cref="ArgumentInvalidException">Key cannot be null or empty.</exception>
		/// <exception cref="ArgumentNullException">Item cannot be null.</exception>
		public void AddCacheItem<T>(string key, [NotNull] T item)
		{
			Validate.TryValidateParam(key, nameof(key));

			_ = this.Cache.Set(key, item);
		}

		/// <summary>
		/// Gets the cache item.
		/// </summary>
		/// <typeparam name="T">Generic type parameter.</typeparam>
		/// <param name="key">The key.</param>
		/// <returns>TValue.</returns>
		/// <exception cref="ArgumentInvalidException">Key cannot be null or empty.</exception>
		public T GetCacheItem<T>(string key)
		{
			Validate.TryValidateParam(key, nameof(key));

			_ = this.Cache.TryGetValue<T>(key, out var item);

			return item;
		}

		/// <summary>
		/// Creates the cache using 20 minute expiration.
		/// </summary>
		/// <param name="expiration">The expiration.</param>
		/// <returns>MemoryCache.</returns>
		private static MemoryCache CreateCache(TimeSpan expiration)
		{
			var options = new MemoryCacheOptions
			{
				ExpirationScanFrequency = expiration,
			};

			return new MemoryCache(options);
		}
	}
}
