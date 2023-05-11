using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLesson15._1.DTO;
using WebLesson15._1.Models;

namespace WebLesson15._1.Controllers
{
    public class StorageController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StorageController(ILogger<HomeController> logger)
        {
            StorageViewModel[] products;
            products = new StorageViewModel[]
            {
<<<<<<< Updated upstream
            new StorageViewModel(1,"Orange",50,"Italy",product.fruits),
            new StorageViewModel(2,"Beaf steak",20,"Belarus",product.meat),
            new StorageViewModel(3,"cheese",38,"Poland",product.dairy)
=======
            new StorageViewModel{Id = 1,Name = "Orange",Count = 50,Country = "Italy",Category = product.fruits },
            new StorageViewModel{Id = 2,Name ="Beaf steak",Count = 20,Country = "Belarus",Category = product.meat },
            new StorageViewModel{Id = 3,Name ="cheese",Count = 38,Country = "Poland",Category = product.dairy }
>>>>>>> Stashed changes
                };
            _logger = logger;
        }
       
            
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Storage()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
enum product
{
    fruits = 1,
    meat = 2,
    fish = 3,
    vegetables = 4,
    dairy = 5
}
