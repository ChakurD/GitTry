using System.ComponentModel.DataAnnotations;

namespace Diplom.DataAccess.Entity
{
    public class Storage
    {
        [MaxLength(85)]
        public int StorageId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Addres { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public StorageWorkers StorageWorkers { get; set; }
        public int StorageWorkersId { get; set; }

    }
}
