using IEatAsparagus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IEatAsparagus.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController( ApplicationContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(AsparagusLover result)   //(User result)
        {
            var asparagusEater = new AsparagusLover
            {
                Name = result.Name,
                Email = result.Email,
                CreateFormDate = DateTime.Now
            };
            db.AsparagusLovers.Add(asparagusEater);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

            public IActionResult Lenta()
        {
            var asparagus = db.AsparagusLovers.ToList();
            var sortedListAsparagusEater = asparagus.OrderBy(x => x.CreateFormDate).GroupBy(a => a.Email);
            AsparagusLoverViewModel[] lent = new AsparagusLoverViewModel[sortedListAsparagusEater.Count()];
            int i = 0;

                foreach (var item in sortedListAsparagusEater)
                {
                    AsparagusLoverViewModel modelForSet = new AsparagusLoverViewModel
                    {
                        Name = item.Last().Name,
                        OccuranceCount = item.Count(),
                        Date = item.Last().CreateFormDate
                    };
                    lent.SetValue(modelForSet,i);
                i++;
                };
            
           
            return View(lent);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}