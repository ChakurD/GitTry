using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using WebLesson15._1.Models.EFDto;
using WebLesson15._1.Models.UserViewModel;

namespace WebLesson15._1.Models
{
    public class ApplicationContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }

        public DbSet<ManufactureCreditCard> Cards { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)  : base(options)
        { 
        //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacture>().HasData(
                new Manufacture { Id = 1, Name = "Google", CountOfMembers = 500 },
                new Manufacture { Id = 2, Name = "Roskosmos", CountOfMembers = 1500 },
                new Manufacture { Id = 3, Name = "Nasa", CountOfMembers = 5000 }
                );

            modelBuilder.Entity<ManufactureCreditCard>().HasData(
                new ManufactureCreditCard { Id = 1, Name = "Alfa" },
                new ManufactureCreditCard { Id = 2, Name = "Russia" },
                new ManufactureCreditCard { Id = 3, Name = "World" }
                );
            //modelBuilder.Entity<User>().HasData(
            //new User { Id = 1, Name = "Kolya", LastName = "Gorlov", Age = 34, Addres = "Filipinova 12" },
            //new User { Id = 2, Name = "Alex", LastName = "Hvorostov", Age = 23, Addres = "Hromova 15" },
            //new User { Id = 3, Name = "Vitya", LastName = "Pnev", Age = 19, Addres = "Fadeeva 24" },
            //new User { Id = 4, Name = "Sveta", LastName = "Teterev", Age = 26, Addres = "Veteranova 36" },
            //new User { Id = 5, Name = "Valya", LastName = "Bobishev", Age = 41, Addres = "Novaya 76" }
            //);
        }
    }
}