using Microsoft.Extensions.Caching.Memory;
using System;

namespace SimpleCaptcha.Storage
{
    internal class MemoryStorage : IStorage
    {
        private readonly IMemoryCache _memoryCache;
        public MemoryStorage(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public void Set(string key, string value, DateTimeOffset absoluteExpiration)
        {
            _memoryCache.Set(key, value, absoluteExpiration);
        }

        public string Get(string key)
        {
            return _memoryCache.Get<string>(key);
        }

        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }
    }
}
