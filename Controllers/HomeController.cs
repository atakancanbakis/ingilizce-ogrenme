using IngilizceOgreniyorum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IngilizceOgreniyorum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Icerik()
        {
            return View();
        }
        public IActionResult Kayitol()
        {
            return View();
        }

        public IActionResult English_Grammar()
        {
            return View();
        }

        public IActionResult English_Stories()
        {
            return View();
        }

        public IActionResult English_Idioms()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}