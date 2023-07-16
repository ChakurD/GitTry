using Diplom.DataAccess.Entity;

namespace Diplom.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        public Storage Storage { get; set; }
        public ResponsForItem Respons { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public Role Role { get; set; }

    }
}
