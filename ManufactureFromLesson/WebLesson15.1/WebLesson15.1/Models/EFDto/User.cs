namespace WebLesson15._1.Models.EFDto
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Addres { get; set; }
        public int? ManufactureId { get; set; }
        public virtual Manufacture? Manufacture { get; set; }
    }
}
