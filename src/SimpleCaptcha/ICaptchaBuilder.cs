using Microsoft.Extensions.DependencyInjection;

namespace SimpleCaptcha
{
    public interface ICaptchaBuilder
    {
        IServiceCollection Services { get; }
    }
}
