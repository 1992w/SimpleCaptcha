namespace SimpleCaptcha.Generator
{
    public interface ICaptchaCodeGenerator
    {
        string Generate(int length);
    }
}
