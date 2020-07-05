namespace SimpleCaptcha.Generator
{
    public interface ICaptchaImageGenerator
    {
        byte[] Generate(int width, int height, string captchaCode);
    }
}
