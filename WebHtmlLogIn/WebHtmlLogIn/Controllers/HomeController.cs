using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebHtmlLogIn.Models;

namespace WebHtmlLogIn.Controllers
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
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult LogInError()
        {
            return NotFound("Неверный имя или пароль");
        }

        [HttpPost]
        public RedirectResult LogIn(string userName, string userPassword)
        {
            string userSavedName = "Zalog";
            string userSavedPassword = "5590Vid";
            if (userSavedName.Equals(userName) && userSavedPassword.Equals(userPassword))
            {
                return Redirect("~/Home/Index");
            }
            else return Redirect("~/Home/LogInError");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}