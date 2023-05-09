using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLesson15._1.DTO;
using WebLesson15._1.Models;

namespace WebLesson15._1.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public RegistrationController(ILogger<HomeController> logger)
        {


            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public string Registration(RegistrationModel registr)
        {
            if (ModelState.IsValid)
            {
                return $"You'r Name:{registr.Name} Surname: {registr.Surname} Country: {registr.Country} Email: {registr.Email}+@world.com Age:{registr.Age}";
            }
            else return "Registration failed";
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

