namespace WebLesson15._1.Models.EFDto
{
    public class Manufacture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfMembers { get; set; }
        public int? CardId { get; set; }
        public virtual  ManufactureCreditCard? Card { get; set; }

    }
}
