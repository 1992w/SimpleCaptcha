using System;

namespace SimpleCaptcha
{
    public class CaptchaInfo
    {
        public CaptchaInfo(string captchaId, string code, byte[] byteData)
        {
            CaptchaId = captchaId;
            CaptchaCode = code;
            CaptchaByteData = byteData;
        }

        public string CaptchaId { get; }
        public string CaptchaCode { get; }
        public byte[] CaptchaByteData { get; }
        public string CaptchBase64Data => Convert.ToBase64String(CaptchaByteData);
    }
}
