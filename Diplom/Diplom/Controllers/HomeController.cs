using Azure.Core;
using Diplom.DataAccess;
using Diplom.DataAccess.Entity;
using Diplom.Models;
using Diplom.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Diplom.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext _context;
        private IItemServices _itemService;
        private IUserServices _userService;
        private ICategoryServices _categoryService;
        private IStorageServices _storageService;
        public HomeController(IUserServices userService, IItemServices itemService, IStorageServices storageService, ICategoryServices categoryService, MyDbContext context)
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
            registrModel.Roles = await _context.Set<Role>().ToListAsync();
            return View(registrModel);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {


                var userValid = await _userService.GetUser(model.Login);
                var rolesUpdate = await _context.Set<Role>().ToListAsync();
                var role = rolesUpdate.FirstOrDefault(i => i.Id.Equals(model.RoleId));
                var storageWorkers = await _context.Set<StorageWorkers>().ToListAsync();
                var storageWorker = storageWorkers.FirstOrDefault(i => i.StorageWorkersId.Equals(model.StorageWorkersId));
                byte[] salt = RandomNumberGenerator.GetBytes(128 / 8); ;
                if (userValid == null && model.Password.Equals(model.ConfirmPassword))
                {
                    var user = new User
                    {
                        Login = model.Login,
                        FirstName = model.FirstName,
                        SecondName = model.SecondName,
                        HashPassword = CreateHashPassword(model.ConfirmPassword, salt),
                        Salt = salt,
                        JobTittle = model.JobTittle,
                    };
                    role.Users.Add(user);
                    UpdateRoles(role);
                    storageWorker.Users.Add(user);
                    UpdateStorageWorkers(storageWorker);
                    await _userService.CreateUser(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("MainPage");
                } else
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
        public async Task<IActionResult> Login(UserLoginViewModel userLogin)
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


        [Authorize]
        public async Task<IActionResult> Categorys()
        {
            var categoryViewModel = new CategoryViewModel();
            categoryViewModel.Categorys = await _categoryService.GetAllCategorys();
            categoryViewModel.Items = await _itemService.GetAllItems();
            return View(categoryViewModel);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ItemsFromCategory(int categoryId)
        {
            var itemsViewModel = new ItemsViewModel();
            itemsViewModel.Items = await _itemService.GetAllItems();
            itemsViewModel.Category = await _categoryService.GetCategory(categoryId);
            return View(itemsViewModel);
        }
        [Authorize]
        public async Task<IActionResult> Item(int itemId)
        {
            var itemViewModel = new ItemViewModel();
            itemViewModel.Item = await _itemService.GetItem(itemId);
            itemViewModel.Storage = await _storageService.GetStorage(itemViewModel.Item.StorageId);
            itemViewModel.Respons = await _context.Set<ResponsForItem>().FirstOrDefaultAsync(i => i.ResponsForItemId.Equals(itemViewModel.Item.ResponsForItemId));
            itemViewModel.User = await _context.Set<User>().FirstOrDefaultAsync(u => u.ResponsForItemId.Equals(itemViewModel.Item.ResponsForItemId));
            return View(itemViewModel);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Users()
        {
            var usersViewModel = new UsersViewModel();
            usersViewModel.Users = await _userService.GetAllUsers();
            usersViewModel.Storages = await _storageService.GetAllStorages();
            usersViewModel.StorageWorkers = await _context.Set<StorageWorkers>().ToListAsync();
            return View(usersViewModel);
        }
        [Authorize]
        public async Task<IActionResult> User(string? userLogin)
        {
            var userViewModel = new UserViewModel();
            userViewModel.User = await _userService.GetUser(userLogin);
            if (userViewModel.User.StorageWorkersId != null)
            {
                userViewModel.Storage = await _context.Set<Storage>().FirstOrDefaultAsync(i => i.StorageWorkersId.Equals(userViewModel.User.StorageWorkersId)); ;
            }
            userViewModel.Role = await _context.FindAsync<Role>(userViewModel.User.RoleId);
            if (userViewModel.User.ResponsForItemId != null)
            {
                userViewModel.Respons = await _context.FindAsync<ResponsForItem>(userViewModel.User.ResponsForItemId);
                userViewModel.Items = await _itemService.GetAllItems();
            }
            return View(userViewModel);

        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("MainPage");
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
        private async Task UpdateRoles(Role role)
        {
            _context.Set<Role>().Update(role);
            await _context.SaveChangesAsync();
        }

        private async Task UpdateStorageWorkers(StorageWorkers storageWorker)
        {
            _context.Set<StorageWorkers>().Update(storageWorker);
            await _context.SaveChangesAsync();
        }
    }
}