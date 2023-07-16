using Diplom.DataAccess.Entity;

namespace Diplom.Services.Interfaces
{
    public interface IItemServices
    {
        Task<Item> CreateItem(Item item);
        Task<Item> GetItem(int? itemId);
        Task UpdateItem(Item item);
        Task<IList<Item>> GetAllItems();
    }
}
