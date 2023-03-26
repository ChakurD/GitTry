namespace StorageLogIn.Models
{
    public class StorageItemsModel
    {
        public string ItemName { get; set; }
        public string ItemType { get; set; }

        public int ItemCount { get; set; }
        public int ItemCountShoudBe { get; set; } = 0;
        public int ItemCode { get; set; }
        public StorageItemsModel() { }
        public StorageItemsModel(string itemName, string itemType,int itemCode, int itemCount) 
        {
            ItemName = itemName;
            ItemType = itemType;
            ItemCount = itemCount;
            ItemCode = itemCode;
        }

    }
}