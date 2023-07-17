using Diplom.DataAccess.Entity;

namespace Diplom.Models
{
    public class StorageInventoryViewModel
    {
       public Storage Storage { get; set; }
        public IEnumerable<Item> StorageItems { get; set; }
        public IEnumerable<ItemInventoryResult>? ItemInventoryResults { get; set; }
    }
}