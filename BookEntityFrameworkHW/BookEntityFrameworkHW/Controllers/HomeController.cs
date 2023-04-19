using BookEntityFrameworkHW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookEntityFrameworkHW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var books = db.Books.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book result)
        {
            db.Books.Add(result);
            db.SaveChanges();
            return RedirectToAction("Privacy");
        }
        public IActionResult Edit(int? id)
        {
            Book book = db.Books.FirstOrDefault(p => p.Id == id);
            if (book != null)
                return View(book);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Book user)
        {
            db.Books.Update(user);
            db.SaveChanges();
            return RedirectToAction("Privacy");
        }

        public IActionResult Delete(int? id)
        {
            Book book = db.Books.FirstOrDefault(p => p.Id == id);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                return RedirectToAction("Privacy");
            }
            return NotFound();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}