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

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login()
        {

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Login(UserLogin userLogin)
        {
            var user = await _userService.GetUser(userLogin.Login);
            if (user != null && CreateHashPassword(userLogin.HashPassword).Equals(user.HashPassword))
            {
                var token = Generate(user);
                return Ok(token);
            }
            return NotFound("User Not Found!");

        }
        [AllowAnonymous]

        [HttpPost]
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
        public async Task<IActionResult> MainPaige()
        {
            return View();
        }
        [Authorize("Admin")]
        public async Task<IActionResult> AdministrationItems()
        {
            var itemsViewModel = new ItemsViewModel();
            itemsViewModel.Category = await _categoryService.GetAllCategorys();
            return View();
        }
        [Authorize("Manager")]
        public async Task<IActionResult> ManagerItems()
        {
            return View();
        }
        [Authorize("Worker")]
        public async Task<IActionResult> WorkersItems()
        {
            return View();
        }
        [Authorize("Admin")]
        public async Task<IActionResult> Users()
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
        private string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Login),
                new Claim(ClaimTypes.Role, user.Role.RoleName),
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Surname, user.SecondName)
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt;Audience"],
                claims,
                expires:DateTime.Now.AddMinutes(15),
                signingCredentials:credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private async Task<User> GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClaims = identity.Claims;
                var user = await _userService.GetUser(userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value);
                return user;
            }
            return null;
        }
    }
}