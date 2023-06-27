using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Entity
{
    public class ResponsForItem
    {

        public int ResponsForItemId { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
