using Diplom.DataAccess.Entity;

namespace Diplom.Models
{
    public class UsersViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Storage> Storages { get; set; }
        public IEnumerable<StorageWorkers> StorageWorkers { get; set; }
    }
}
