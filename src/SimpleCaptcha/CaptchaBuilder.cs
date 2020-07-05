using Microsoft.Extensions.DependencyInjection;

namespace SimpleCaptcha
{
    internal class CaptchaBuilder : ICaptchaBuilder
    {
        public CaptchaBuilder(IServiceCollection services)
        {
            Services = services;
        }
        public IServiceCollection Services { get; }
    }
}
