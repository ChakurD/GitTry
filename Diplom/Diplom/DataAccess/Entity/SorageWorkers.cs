using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Entity
{
    public class StorageWorkers
    {
        public int StorageWorkersId { get; set; }
       public virtual ICollection<User> Users { get; set; }
        public int StorageId { get; set; }
    }
}
