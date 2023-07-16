using Diplom.DataAccess.Entity;

namespace Diplom.Models
{
    public class ItemViewModel
    {
        public Item Item { get; set; }
        public ResponsForItem Respons { get; set; }
        public Storage Storage { get; set; }
        public User User { get; set; }
           
    }
}
