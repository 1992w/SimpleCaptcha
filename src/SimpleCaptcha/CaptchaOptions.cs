using SimpleCaptcha.Generator;
using System;

namespace SimpleCaptcha
{
    public class CaptchaOptions
    {
        public ICaptchaCodeGenerator CodeGenerator { get; set; } = new DefaultCaptchaCodeGenerator();

        public ICaptchaImageGenerator ImageGenerator { get; set; } = new DefaultCaptchaImageGenerator();

        public int CodeLength { get; set; } = 4;

        public int ImageWidth { get; set; } = 100;

        public int ImageHeight { get; set; } = 36;

        public TimeSpan ExpiryTime { get; set; } = TimeSpan.FromMinutes(5);
    }
}
