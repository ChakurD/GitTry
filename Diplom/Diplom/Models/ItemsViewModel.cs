using Diplom.DataAccess.Entity;

namespace Diplom.Models
{
    public class ItemsViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public IEnumerable<ResponsForItem> Respons { get; set; }
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<Storage> Storages { get; set; }
    }
}
