namespace WebLesson15._1.Models
{
    public class StorageViewModel
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "";
        public int Count { get; set; }
        public string Country { get; set; }
        public Enum Category { get; set; }

        public StorageViewModel() { }

<<<<<<< Updated upstream
        public StorageViewModel(int id, string name, int count, string country, Enum category)
        {
            Id = id;
            Name = name;
            Count = count;
            Country = country;
            Category = category;
        }
=======
>>>>>>> Stashed changes
    }
}