using Microsoft.EntityFrameworkCore;

namespace IEatAsparagus
{
    public class AsparagusLoverViewModel 
    {
        public DateTime? Date { get; set; }
        public string Name { get; set; }
        public int OccuranceCount { get; set; }
    }
}