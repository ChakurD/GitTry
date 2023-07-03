using Diplom.DataAccess;
using Diplom.DataAccess.Entity;
using Diplom.Models;
using Diplom.Services.Interfaces;
using Diplom.Services.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Diplom.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext _context;
        private IItemServices _itemService;
        private IUserServices _userService;
        private ICategoryServices _categoryService;
        private IStorageServices _storageService;
        public HomeController(IUserServices userService, IItemServices itemService,IStorageServices storageService, ICategoryServices categoryService, MyDbContext context)
        {
            _itemService = itemService;
            _userService = userService;
            _categoryService = categoryService;
            _storageService = storageService;
            _context = context;

        }
        [HttpGet]
        public async Task<IActionResult> Registration()
        {
            var registrModel = new RegistrationViewModel();
            registrModel.StorageWorkers = await _context.Set<StorageWorkers>().ToListAsync();
            registrModel.Storages = await _storageService.GetAllStorages();
            return View(registrModel);
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
                        HashPassword = CreateHashPassword(model.ConfirmPassword),
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

        public IActionResult Storages()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        static string CreateHashPassword(string password) 
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8); 
            string hashPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password!,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8)); ;
            return hashPassword;
        }
    }
}