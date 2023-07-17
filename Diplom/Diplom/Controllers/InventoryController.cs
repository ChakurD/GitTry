using Microsoft.AspNetCore.Mvc;
using Diplom.Models;
using Diplom.DataAccess;
using Diplom.Services.Interfaces;
using Diplom.DataAccess.Entity;
using Microsoft.AspNetCore.Authorization;

namespace Diplom.Controllers
{
    public class InventoryController : Controller
    {
        private MyDbContext _context;
        private IItemServices _itemService;
        private IUserServices _userService;
        private ICategoryServices _categoryService;
        private IStorageServices _storageService;
        public InventoryController(IUserServices userService, IItemServices itemService, IStorageServices storageService, ICategoryServices categoryService, MyDbContext context)
        {
            _itemService = itemService;
            _userService = userService;
            _categoryService = categoryService;
            _storageService = storageService;
            _context = context;

        }
        

        [HttpPost]
        public async Task<IActionResult> StorageInventory(int? storageId)
        {
            var storageInventoryViewModel = new StorageInventoryViewModel();
            storageInventoryViewModel.Storage = await _storageService.GetStorage(storageId);
            storageInventoryViewModel.StorageItems = await _itemService.GetAllItems();
            return View(storageInventoryViewModel);
        }
    }
}
