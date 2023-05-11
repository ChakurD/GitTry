using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebLesson15._1.DTO;
using WebLesson15._1.Models;
using WebLesson15._1.Models.EFDto;
using WebLesson15._1.Models.UserViewModel;

namespace WebLesson15._1.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< Updated upstream
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
=======
        private ApplicationContext db;

        public HomeController( ApplicationContext context)
        {
>>>>>>> Stashed changes
            db = context;
        }


        public IActionResult Index()
        {
            //ViewData["ViewDataTestMessage"] = "This is view data";
            //ViewData["Number"] = 15;
            //ViewData["Bool"] = false;
            ViewBag.SomeText = "how you can see thi is ViewBag";
            ViewBag.Array =new int[] {13,25,74 };
            return View();
        }

<<<<<<< Updated upstream
        //public IActionResult Privacy()
        //{
        //    var httpContext = ControllerContext.HttpContext;
        //    var Volodya = new Person("Volodya", 32);
        //    //return Json(Volodya);
        //    //return Content("Heellooo");
        //    //return View();
        //    //return Redirect("~/Menu/StatusCode");
        //    //return NotFound();
        //    //return Unauthorized();
        //    //return BadRequest("Bad Request Good Luck Next Time");
        //    //return Ok("All Fine");
        //    //return Ok();
        //    //return View();

        //    //return Redirect("~/Menu/Road");
        //    //var objects = new int[] { 13, 15, 178 };
        //    //return View(objects);
        //    return View();
        //}
=======
        
>>>>>>> Stashed changes

        public IActionResult Road()
        {
            ViewData["ViewDataTestMessage"] = "This is view data";
            ViewData["Number"] = 15;
            ViewData["Bool"] = false;
            return View();
<<<<<<< Updated upstream
            //return Content("My name Path Road");
=======
>>>>>>> Stashed changes
        }

        [HttpGet]
        public IActionResult Form() => View();
        [HttpPost]
        public string Form(string name, string password, int age, string info)
        {
            return $"User: {name} Password: {password} Age: {age} Info:{info}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Privacy()
        {
<<<<<<< Updated upstream
            //var users  = db.Users.ToList();
=======
>>>>>>> Stashed changes
            var users = db.Users.Include(m => m.Manufacture).ThenInclude(n => n.Card).ToList();
            return View(users);
        }

        public IActionResult Create()
        {
            var manufactures = db.Manufactures.ToList();
            IEnumerable<SelectListItem> manufactureItems = manufactures.Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Name
            });
            ViewBag.Manufacture = manufactureItems;
<<<<<<< Updated upstream
            //ViewBag.Manufacture = manufactures;

            return View();
            //return View();
=======

            return View();
>>>>>>> Stashed changes
        }

        [HttpPost]
        public IActionResult Create(UserViewModel result)   //(User result)
        {
            var manufacture = db.Manufactures.FirstOrDefault(m => m.Id == result.ManufactureId);
            var user = new User
            {
                Name = result.Name,
                LastName = result.LastName,
                Addres = result.Address,
                Manufacture = manufacture,
                Age = result.Age
            };
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index");
                
<<<<<<< Updated upstream
            //db.Users.Add(result);
            //db.SaveChanges();
            //return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
=======
        }
        public IActionResult EditUser(int? id)
>>>>>>> Stashed changes
        {
            User user = db.Users.FirstOrDefault(p => p.Id == id);
            if (user != null)
                return View(user);

            return NotFound();
        }

        [HttpPost]
<<<<<<< Updated upstream
        public IActionResult Edit(User user)
=======
        public IActionResult EditUser(User user)
>>>>>>> Stashed changes
        {
            db.Users.Update(user);
            db.SaveChanges();
            return RedirectToAction("Privacy");
        }

        public async Task<IActionResult> Manufactures()
        {
<<<<<<< Updated upstream
            //var users  = db.Users.ToList();
=======
>>>>>>> Stashed changes
            var manufactures = db.Manufactures.Include(m=>m.Card).ToList();
            return View(manufactures);
        }

        public IActionResult EditManufacture(int? id)
        {
            var cards = db.Cards.ToList();
            IEnumerable<SelectListItem> cardsItem = cards.Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Name
            });
            ViewBag.Cards = cardsItem;

            Manufacture manufacture = db.Manufactures.FirstOrDefault(p => p.Id == id);
            if (manufacture != null)
                return View(manufacture);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditManufacture(Manufacture manufacture)
        {
            db.Manufactures.Update(manufacture);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            User user = db.Users.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                return RedirectToAction("Privacy");
            }
            return NotFound();
        }


    }
}