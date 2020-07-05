namespace SimpleCaptcha
{
    public interface ICaptcha
    {
        CaptchaInfo Generate(string captchaId);

        bool Validate(string captchaId, string code);
    }
}
