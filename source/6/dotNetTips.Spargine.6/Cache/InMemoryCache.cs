// ***********************************************************************
// Assembly         : DotNetTips.Spargine.6
// Author           : David McCarter
// Created          : 01-12-2021
//
// Last Modified By : David McCarter
// Last Modified On : 08-02-2023
// ***********************************************************************
// <copyright file="InMemoryCache.cs" company="dotNetTips.Spargine.5">
//     Copyright (c) David McCarter - dotNetTips.com. All rights reserved.
// </copyright>
// <summary>
// Caches objects for 20 minutes. Designed to function as a singleton
// pattern.
// </summary>
// ***********************************************************************
using System.Diagnostics.CodeAnalysis;
using DotNetTips.Spargine.Core;
using Microsoft.Extensions.Caching.Memory;

//`![Spargine 6 Rocks Your Code](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Cache;

/// <summary>
/// InMemoryCache.
/// </summary>
/// <remarks>Expiration is set to 20 minutes.</remarks>
public sealed class InMemoryCache
{
	/// <summary>
	/// The timeout amount.
	/// </summary>
	private const int TimeoutMinutes = 20;

	/// <summary>
	/// Prevents a default instance of the <see cref="InMemoryCache" /> class from being created.
	/// Default timeout is 20 minutes.
	/// </summary>
	private InMemoryCache() => this.Cache = CreateCache(new TimeSpan(0, TimeoutMinutes, 0));

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

	/// <summary>
	/// Adds item to the cache.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="key">The key.</param>
	/// <param name="item">The item.</param>
	/// <exception cref="ArgumentInvalidException">Key cannot be null or empty.</exception>
	/// <exception cref="ArgumentNullException">Item cannot be null.</exception>
	[Information(nameof(AddCacheItem), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public void AddCacheItem<T>(string key, [NotNull] T item)
	{
		key = key.ArgumentNotNullOrEmpty();

		_ = this.Cache.Set(key, item);
	}

	/// <summary>
	/// Gets the cache item.
	/// </summary>
	/// <typeparam name="T">Generic type parameter.</typeparam>
	/// <param name="key">The key.</param>
	/// <returns>TValue.</returns>
	/// <exception cref="ArgumentInvalidException">Key cannot be null or empty.</exception>
	[Information(nameof(GetCacheItem), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public T GetCacheItem<T>(string key)
	{
		key = key.ArgumentNotNullOrEmpty();

		_ = this.Cache.TryGetValue(key, out T item);

		return item;
	}

	/// <summary>
	/// Gets or sets (private) the cache.
	/// </summary>
	/// <value>The cache.</value>
	[Information(nameof(Cache), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public MemoryCache Cache { get; }

	/// <summary>
	/// Gets the count.
	/// </summary>
	/// <value>The count.</value>
	[Information(nameof(Count), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public static int Count => Instance.Cache.Count;

	/// <summary>
	/// Gets the instance.
	/// </summary>
	/// <value>The instance.</value>
	[Information(nameof(Instance), "David McCarter", "1/16/2021", Status = Status.Available, UnitTestCoverage = 100)]
	public static InMemoryCache Instance { get; } = new();
}
