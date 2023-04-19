using Microsoft.EntityFrameworkCore;
namespace BookEntityFrameworkHW.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Algebra", CreatedDate = DateTime.Parse("12 Jan 2007"), AuthorName = "Matews", Description = "Description 1" },
                new Book { Id = 2, Title = "Jupiter", CreatedDate = DateTime.Parse("25 Jul 2097"), AuthorName = "Gromov", Description = "Description 2" },
                new Book { Id = 3, Title = "Countrys", CreatedDate = DateTime.Parse("7 Feb 2008"), AuthorName = "Petrov", Description = "Description 3" },
                new Book { Id = 4, Title = "Stroy of New World", CreatedDate = DateTime.Parse("23 Sep 2013"), AuthorName = "Cicirov", Description = "Description 4" },
                new Book { Id = 5, Title = "Yourself", CreatedDate = DateTime.Parse("30 Nov 2024"), AuthorName = "Jonathan", Description = "Description 5" }
                );
        }
    }
}
