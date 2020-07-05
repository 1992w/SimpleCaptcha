using System;

namespace SimpleCaptcha.Storage
{
    internal interface IStorage
    {
        void Set(string key, string value, DateTimeOffset absoluteExpiration);
        string Get(string key);
        void Remove(string key);
    }
}
