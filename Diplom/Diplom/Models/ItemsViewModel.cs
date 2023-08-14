using Diplom.DataAccess.Entity;

namespace Diplom.Models
{
    public class ItemsViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public Category Category { get; set; }
    }
}
