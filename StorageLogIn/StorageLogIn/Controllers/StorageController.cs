using Microsoft.AspNetCore.Mvc;
using StorageLogIn.Models;
using System.Diagnostics;

namespace StorageLogIn.Controllers
{
    public class StorageController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        string login = "admin";
        string password = "admin";
        StorageItemsModel[] items;

        public StorageController(ILogger<HomeController> logger)
        {
            items = new StorageItemsModel[]
            {
            new StorageItemsModel("Дверь","Мебель",3,150),
            new StorageItemsModel("Диван", "Мебель", 2, 60),
            new StorageItemsModel("Стул", "Мебель", 2, 110),
            new StorageItemsModel("Стол", "Мебель", 2, 85),
            new StorageItemsModel("Шкаф", "Мебель", 2, 30)
            };
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StorageItemCount()
        {
            return View(items);
        }
        [HttpPost]
        public ViewResult StorageItemCount(StorageItemsModel[] items)
         {
            return View("AccountingStorage", items);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult LogIn(string userLogin, string userPassword) 
        {
            if (login.Equals(userLogin) && password.Equals(userPassword)) return RedirectToAction("StorageItemCount");
            else return RedirectToAction("ErrorLogIn");
        }
        public IActionResult ErrorLogIn()
        {
            return NotFound("Wrong login or password");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}