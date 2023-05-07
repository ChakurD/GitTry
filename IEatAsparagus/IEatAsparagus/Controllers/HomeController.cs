using IEatAsparagus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace IEatAsparagus.Controllers
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
            var orderBy = asparagus.OrderBy(x => x.CreateFormDate);
            var groupBy = orderBy.GroupBy(a => a.Email);
            var size = groupBy.Count();
            AsparagusLoverViewModel[] lent = new AsparagusLoverViewModel[size];
            int i = 0;

                foreach (var item in groupBy)
                {

                    var lastRegistrAsparagus = item.Last();
                    var countRegistr = item.Count();
                    AsparagusLoverViewModel modelForSet = new AsparagusLoverViewModel
                    {
                        Name = lastRegistrAsparagus.Name,
                        OccuranceCount = countRegistr,
                        Date = lastRegistrAsparagus.CreateFormDate
                    };
                    lent.SetValue(modelForSet,i);
                i++;
                };
            
                //var groupList = orderList.MaxBy(a => a.Where(o => o.Email.Equals(asparagus[0].Email)));
                //var convert = groupBy.Select(u => new AsparagusLoverViewModel
                //{
                //    Name = u.ElementAt(),
                //    //OccuranceCount = 
                //    //Date = u.CreateFormDate.Equals(asparagus.Where(a => a.CreateFormDate))

                //}).ToList();
           
            return View(lent);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}