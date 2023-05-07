using Microsoft.EntityFrameworkCore;

namespace IEatAsparagus
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AsparagusLover> AsparagusLovers { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }
    }
}