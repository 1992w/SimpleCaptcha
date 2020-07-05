using Microsoft.Extensions.DependencyInjection.Extensions;
using SimpleCaptcha;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CaptchaServiceCollectionExtensions
    {
        public static IServiceCollection AddSimpleCaptcha(this IServiceCollection services, Action<ICaptchaBuilder> configure)
        {
            if (services == null)
            {
                throw new ArgumentException(nameof(services));
            }

            services.TryAdd(ServiceDescriptor.Scoped<ICaptcha, Captcha>());

            configure(new CaptchaBuilder(services));
            return services;
        }
    }
}
