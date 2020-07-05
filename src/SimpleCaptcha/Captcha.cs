using Microsoft.Extensions.Options;
using SimpleCaptcha.Storage;
using System;

namespace SimpleCaptcha
{
    internal class Captcha : ICaptcha
    {
        private readonly IOptionsMonitor<CaptchaOptions> _options;
        private readonly IStorage _storage;

        public Captcha(IOptionsMonitor<CaptchaOptions> options, IStorage storage)
        {
            _options = options;
            _storage = storage;
        }

        public CaptchaInfo Generate(string captchaId)
        {
            var code = _options.CurrentValue.CodeGenerator.Generate(_options.CurrentValue.CodeLength);
            var image = _options.CurrentValue.ImageGenerator.Generate(_options.CurrentValue.ImageWidth, _options.CurrentValue.ImageHeight, code);
            _storage.Set(captchaId, code, DateTimeOffset.UtcNow.Add(_options.CurrentValue.ExpiryTime));

            return new CaptchaInfo(captchaId, code, image);
        }

        public bool Validate(string captchaId, string code)
        {
            var val = _storage.Get(captchaId);
            var result = !string.IsNullOrWhiteSpace(val) && val == code;
            if (result)
            {
                _storage.Remove(captchaId);
            }

            return result;
        }
    }
}
