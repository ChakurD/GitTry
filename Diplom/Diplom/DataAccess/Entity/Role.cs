using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Diplom.DataAccess.Entity
{
    public class Role
    {
        [Required]
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
