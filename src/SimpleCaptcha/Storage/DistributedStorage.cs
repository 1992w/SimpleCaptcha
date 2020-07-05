using Microsoft.Extensions.Caching.Distributed;
using System;

namespace SimpleCaptcha.Storage
{
    internal class DistributedStorage : IStorage
    {
        private readonly IDistributedCache _cache;

        public DistributedStorage(IDistributedCache cache)
        {
            _cache = cache;
        }

        public string Get(string key)
        {
            return _cache.GetString(key);
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void Set(string key, string value, DateTimeOffset absoluteExpiration)
        {
            _cache.SetString(key, value, new DistributedCacheEntryOptions
            {
                AbsoluteExpiration = absoluteExpiration
            });
        }
    }
}
