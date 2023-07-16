using Diplom.DataAccess;
using Diplom.DataAccess.Entity;
using Diplom.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Diplom.Controllers
{
    public class EditMainEntityController : Controller
    {
        private MyDbContext _context;
        private IItemServices _itemService;
        private IUserServices _userService;
        private ICategoryServices _categoryService;
        private IStorageServices _storageService;
        public EditMainEntityController(IUserServices userService, IItemServices itemService, IStorageServices storageService, ICategoryServices categoryService, MyDbContext context)
        {
            _itemService = itemService;
            _userService = userService;
            _categoryService = categoryService;
            _storageService = storageService;
            _context = context;

        }
        [HttpGet]
        public async Task<IActionResult> EditUser(string? userLogin)
        {
            if (userLogin != null)
            {
                User? user = await _userService.GetUser(userLogin);
                if (user != null) return View(user);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            _userService.UpdateUser(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("MainPage", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> EditItem(int? itemId)
        {
            if (itemId != null)
            {
                Item? item= await _itemService.GetItem(itemId);
                if (item != null) return View(item);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditItem(Item item)
        {
            _itemService.UpdateItem(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("MainPage", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> EditStorage(int? storageId)
        {
            if (storageId != null)
            {
                Storage? storage = await _storageService.GetStorage(storageId);
                if (storage != null) return View(storage);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditStorage(Storage storage)
        {
            _storageService.UpdateStorage(storage);
            await _context.SaveChangesAsync();
            return RedirectToAction("MainPage", "Home");
        }

        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            _userService.CreateUser(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("MainPage", "Home");
        }

        public IActionResult CreateStorage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateStorage(Storage storage)
        {
            _storageService.CreateStorage(storage);
            await _context.SaveChangesAsync();
            return RedirectToAction("MainPage", "Home");
        }

        public IActionResult CreateItem()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateItem(Item item)
        {
            _itemService.CreateItem(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("MainPage", "Home");
        }


        [HttpPost]
        public async Task<IActionResult> DeleteItem(int? itemId)
        {
            if (itemId != null)
            {
                Item? item = await _itemService.GetItem(itemId);
                if (item != null)
                {
                    _context.Items.Remove(item);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("MainPage", "Home");
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string? userLogin)
        {
            if (userLogin != null)
            {
                User user = await _userService.GetUser(userLogin);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("MainPage", "Home");
                }
            }
            return NotFound();

        }
        [HttpPost]
        public async Task<IActionResult> DeleteStorage(int? storageId)
        {
            if (storageId != null)
            {
                Storage? storage = await _storageService.GetStorage(storageId);
                if (storage != null)
                {
                    _context.Storages.Remove(storage);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("MainPage", "Home");
                }
            }
            return NotFound();
        }
    }
}
