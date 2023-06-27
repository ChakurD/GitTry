using Diplom.DataAccess.DbPatterns.Interfaces;
using Diplom.DataAccess.DbPatterns;
using Diplom.DataAccess.Entity;
using Diplom.Services.Interfaces;

namespace Diplom.Services.Service
{
    public class ItemService : ServiceConstructor, IItemServices
    {
        public ItemService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public async Task<Item> CreateItem(Item item)
        {
            return await UnitOfWork.Items.Create(item);
        }

        public async Task<Item> GetItem(string name)
        {
            IList<Item> items = await UnitOfWork.Items.GetAll();
            return items.FirstOrDefault(x => x.Name == name);
        }

        public async Task UpdateItem(Item item)
        {
            await UnitOfWork.Items.Update(item);
        }

        public async Task<IList<Item>> GetAllItems()
        {
            IList<Item> items = await UnitOfWork.Items.GetAll();
            return items;
        }
    }
}
