using Microsoft.EntityFrameworkCore;

namespace IEatAsparagus
{
    public class AsparagusLover
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateFormDate { get; set; }

    }
}