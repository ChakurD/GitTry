using System.ComponentModel.DataAnnotations;

namespace Diplom.DataAccess.Entity
{
    public class User 
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public byte[] Salt { get; set; }
        [Required]
        [MaxLength(85)]
        public string HashPassword { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        [MaxLength(45)]
        [Required]
        public string JobTittle { get; set; }
        public int? StorageWorkersId { get; set; }
        public StorageWorkers StorageWorkers { get; set; }
        public int? ResponsForItemId { get; set; }
        public ResponsForItem ResponsForItem { get; set; }
    }
}
