using System;
using System.Text;

namespace SimpleCaptcha.Generator
{
    internal class DefaultCaptchaCodeGenerator : ICaptchaCodeGenerator
    {
        const string Letters = "012346789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public string Generate(int length)
        {
            Random rand = new Random();
            int maxRand = Letters.Length - 1;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = rand.Next(maxRand);
                sb.Append(Letters[index]);
            }

            return sb.ToString();
        }
    }
}
