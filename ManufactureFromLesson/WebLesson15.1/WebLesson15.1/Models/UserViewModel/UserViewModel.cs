using WebLesson15._1.Models.EFDto;

namespace WebLesson15._1.Models.UserViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int ManufactureId { get; set; }
        public int CardId { get; set; }
    }
}
