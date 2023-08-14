using Diplom.DataAccess.Entity;

namespace Diplom.Models
{
    public class CategoryViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public IEnumerable<Category> Categorys { get; set;}
    }
}
