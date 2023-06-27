using Diplom.DataAccess.Entity;

namespace Diplom.Services.Interfaces
{
    public interface IItemServices
    {
        Task<Item> CreateItem(Item item);
        Task<Item> GetItem(string name);
        Task UpdateItem(Item item);
        Task<IList<Item>> GetAllItems();
    }
}
