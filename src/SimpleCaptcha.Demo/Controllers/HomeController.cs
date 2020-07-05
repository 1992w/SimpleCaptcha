using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleCaptcha.Demo.Models;

namespace SimpleCaptcha.Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICaptcha _captcha;

        public HomeController(ILogger<HomeController> logger, ICaptcha captcha)
        {
            _logger = logger;
            _captcha = captcha;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Captcha(string id)
        {
            var info = _captcha.Generate(id);
            var stream = new MemoryStream(info.CaptchaByteData);
            return File(stream, "image/png");
        }

        public IActionResult Validate(string id, string code)
        {
            var result = _captcha.Validate(id, code);
            return Json(new { success = result });
        }
    }
}
