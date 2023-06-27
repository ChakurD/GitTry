using System.ComponentModel.DataAnnotations;

namespace Diplom.DataAccess.Entity
{
    public class Item
    {
        [MaxLength(85)]
        public int ItemId { get; set; }
        [Required]
        public  string Name { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Price { get; set; }
        public Storage Storage { get; set; }
        public int StoregeId { get; set; }
        public Category Category { get; set; }
        public int CatregoryId { get; set; }
        public ResponsForItem ResponsForItem { get; set; }
        public int ResponsForItemId { get; set; }
    }
}
