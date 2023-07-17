namespace Diplom.Models
{
    public class ItemInventoryResult
    {
        public int ItemId { get; set; }

        public int? CurrentAmount { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
