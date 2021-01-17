using System;
using System.Linq;
using dotNetTips.Spargine.Extensions;
using Microsoft.Extensions.Caching.Memory;


namespace dotNetTips.Spargine.Cache
{
	public sealed class AutoCacher
	{
		private readonly MemoryCache _cache;

		public AutoCacher() : this(new TimeSpan(0, 20, 0))
		{ }

		public AutoCacher(TimeSpan expirationScanFrequency)
		{
			var options = new MemoryCacheOptions { ExpirationScanFrequency = expirationScanFrequency };
			this._cache = new MemoryCache(options);
		}


		public T CacheRetrieve<T>(Func<T> callback, CacheItemPolicy cachePolicy = null)
		{
			var cacheKey = $"{callback.Method.Name}{callback.GetFieldHash()}";
			var b = callback.Target.GetType().GetFields().Select(x => x.GetValue(callback.Target));

			if (this._cache.TryGetValue(cacheKey, out T result))
			{
				return result;
			}

			this._cache.Set(
			  new CacheItem(
				cacheKey,
				callback()),
				cachePolicy ?? Constants.DefaultCacheItemPolicy
			);

			return (T)MemoryCache.Default[cacheKey];
		}
	}
}
