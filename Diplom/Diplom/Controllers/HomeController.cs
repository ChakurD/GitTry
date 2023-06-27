using Diplom.DataAccess.Entity;
using Diplom.Models;
using Diplom.Services.Interfaces;
using Diplom.Services.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace Diplom.Controllers
{
    public class HomeController : Controller
    {
        private IItemServices _itemService;
        private IUserServices _userService;
        private ICategoryServices _categoryService;
        private IStorageServices _storageService;
        public HomeController(IUserServices userService, IItemServices itemService,IStorageServices storageService, ICategoryServices categoryService)
        {
            _itemService = itemService;
            _userService = userService;
            _categoryService = categoryService;
            _storageService = storageService;

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {


                var userValid = await _userService.GetUser(model.Login);
                if (userValid == null && model.Password.Equals(model.ConfirmPassword))
                {
                    var user = new User
                    {
                        Login = model.Login,
                        FirstName = model.FirstName,
                        SecondName = model.SecondName,
                        HashPassword = model.ConfirmPassword,
                        JobTittle = model.JobTittle,
                    };
                    await _userService.CreateUser(user);
                    return Ok();
                }
                else
                {
                    return BadRequest("User is already registered");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}