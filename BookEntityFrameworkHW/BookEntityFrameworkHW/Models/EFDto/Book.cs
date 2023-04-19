using Microsoft.EntityFrameworkCore;
namespace BookEntityFrameworkHW.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
    }
}
