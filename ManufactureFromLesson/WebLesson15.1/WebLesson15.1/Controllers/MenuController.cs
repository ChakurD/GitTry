using Microsoft.AspNetCore.Mvc;

namespace WebLesson15._1.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Road()
        {
            //return Content("My name Path Road");
            return View();
        }

        public IActionResult StatusCode()
        {
            return StatusCode(303);
        }
    }
}
