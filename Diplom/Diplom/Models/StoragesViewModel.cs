using Diplom.DataAccess.Entity;

namespace Diplom.Models
{
    public class StoragesViewModel
    {
        public IEnumerable<Storage> Storages { get; set; }
        public IEnumerable<Item> Items { get; set; } 
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<StorageWorkers> StorageWorkers { get; set; }
    }
}
