using Azure.Core;
using Diplom.DataAccess;
using Diplom.DataAccess.Entity;
using Diplom.Models;
using Diplom.Services.Interfaces;
using Diplom.Services.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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
        private IConfiguration _config;
        public HomeController(IUserServices userService, IItemServices itemService, IStorageServices storageService, ICategoryServices categoryService, MyDbContext context, IConfiguration config)
        {
            _itemService = itemService;
            _userService = userService;
            _categoryService = categoryService;
            _storageService = storageService;
            _context = context;
            _config = config;

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
                byte[] salt = RandomNumberGenerator.GetBytes(128 / 8); ;
                if (userValid == null && model.Password.Equals(model.ConfirmPassword))
                {
                    var user = new User
                    {
                        Login = model.Login,
                        FirstName = model.FirstName,
                        SecondName = model.SecondName,
                        HashPassword = CreateHashPassword(model.ConfirmPassword, salt),
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

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Login()
        {

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserLogin userLogin)
        {
            var user = await _userService.GetUser(userLogin.Login);
            byte[] salt = user.Salt;
            if (user != null && CreateHashPassword(userLogin.HashPassword, salt).Equals(user.HashPassword))
            {
                await Authenticate(user);
                return RedirectToAction("MainPage");
            }
            return NotFound("User Not Found!");

        }

        [AllowAnonymous]
        public async Task<IActionResult> Storages()
        {
            var storageViewModel = new StoragesViewModel();
            storageViewModel.Storages = await _storageService.GetAllStorages();
            storageViewModel.Items = await _itemService.GetAllItems();
            storageViewModel.Users = await _userService.GetAllUsers();
            storageViewModel.StorageWorkers = await _context.Set<StorageWorkers>().ToListAsync();
            return View(storageViewModel);
        }

        [AllowAnonymous]
        public IActionResult MainPage()
        {
            return View();
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdministrationItemsCategory()
        {
            var itemsViewModel = new ItemsViewModel();
            itemsViewModel.Category = await _categoryService.GetAllCategorys();
            itemsViewModel.Items = await _itemService.GetAllItems();
            itemsViewModel.Respons = await _context.Set<ResponsForItem>().ToListAsync();
            itemsViewModel.Storages = await _storageService.GetAllStorages();
            return View(itemsViewModel);
        }
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> ManagerItems()
        {
            return View();
        }
        [Authorize(Roles ="Worker")]
        public async Task<IActionResult> WorkersItems()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Users()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        static string CreateHashPassword(string password, byte[] salt) 
        {
            string hashPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password!,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8)); ;
            return hashPassword;
        }

        private async Task Authenticate(User user)
        {
            user.Role = await _context.Set<Role>().FirstOrDefaultAsync(o => o.Id.Equals(user.RoleId));
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Name )
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}