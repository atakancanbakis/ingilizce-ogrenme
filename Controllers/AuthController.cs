using IngilizceOgreniyorum.Models;
using Microsoft.AspNetCore.Mvc;

namespace IngilizceOgreniyorum.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ActionName(nameof(Login))]
        public async Task<IActionResult> Login(UserLoginArgs args)
        {
            Console.WriteLine(args.Email);
            await Console.Out.WriteLineAsync(args.Password);
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

    }
}
