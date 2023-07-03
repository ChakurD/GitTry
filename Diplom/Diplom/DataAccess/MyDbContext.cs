using Diplom.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using Diplom.Controllers;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace Diplom.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ResponsForItem> ResponsForItems { get; set;}
        public DbSet<StorageWorkers> StorageWorkers { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   CategoryId = 1,
                   Name = "Мебель",
                   Description = "В этой категории находяться мебель(диван, стул, кровать, шкафы и т.д.)",
               }
               );
            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   CategoryId = 2,
                   Name = "Расходники",
                   Description = "В этой категории находяться все предметы временного пользования(перчатки, пакеты, масла, полотенца и т.д.)",
               }
               );
            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   CategoryId = 3,
                   Name = "Электроинструмент",
                   Description = "В этой категории находяться электроинструменты(дрель, шуруповерт, болгарка и т.д.)",
               }
               );
            modelBuilder.Entity<StorageWorkers>().HasData(
               new StorageWorkers
               {
                   StorageWorkersId = 1,
               }
               );
            modelBuilder.Entity<StorageWorkers>().HasData(
                new StorageWorkers
                {
                    StorageWorkersId = 2,
                }
                );
            modelBuilder.Entity<ResponsForItem>().HasData(
              new ResponsForItem
              {
                  ResponsForItemId = 1,
              }
              );
            modelBuilder.Entity<ResponsForItem>().HasData(
                new ResponsForItem
                {
                    ResponsForItemId = 2,
                }
                );
            modelBuilder.Entity<Storage>().HasData(
               new Storage
               {
                   StorageId = 1,
                   Name = "Склад Кальварийской",
                   Addres = "ул.Кальваарийская д.57",
                   StorageWorkersId = 1,
               }
               );
            modelBuilder.Entity<Storage>().HasData(
                new Storage
                {
                    StorageId = 2,
                    Name = "Склад Трихомирова",
                    Addres = "ул.Трихомирова д.12",
                    StorageWorkersId = 2,
                }
                );
            
            modelBuilder.Entity<User>().HasData(
            new User
            {

                UserId = 1,
                FirstName = "Виталий",
                SecondName = "Позднев",
                HashPassword = CreateHashPassword("123jobpas"),
                Login = "VitJob123",
                JobTittle = "Складовщик",
                StorageWorkersId = 1,
            }
            );
            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 2,
                FirstName = "Александр",
                SecondName = "Довольный",
                HashPassword = CreateHashPassword("jobAstat"),
                Login = "AleksJob",
                JobTittle = "Заведующий складом",
                StorageWorkersId = 2,
                ResponsForItemId = 1,
            }
            );
            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 3,
                FirstName = "Федор",
                SecondName = "Кручев",
                HashPassword = CreateHashPassword("admin"),
                Login = "admin",
                JobTittle = "администратор",
            }
            );
            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 4,
                FirstName = "Григорий",
                SecondName = "Морозов",
                HashPassword = CreateHashPassword("jobScan"),
                Login = "ElectrickGrig",
                JobTittle = "Электрик",
                ResponsForItemId = 2,
            }
            );

            modelBuilder.Entity<Item>().HasData(
              new Item
              {
                  ItemId = 1,
                  Name = "Перчатки",
                  Model = "Латексные с сеткой",
                  Brand = "Startul",
                  SerialNumber = "77098462",
                  Description = "Перчатки латексные с сеткой для работы на производстве",
                  Count = 150,
                  Price = 21.9M,
                  StorageId = 2,
                  CategoryId = 2,
              }
              );


            modelBuilder.Entity<Item>().HasData(
           new Item
           {
               ItemId = 4,
               Name = "Перчатки",
               Model = "Латексные с сеткой",
               Brand = "Startul",
               SerialNumber = "77098462",
               Description = "Перчатки латексные с сеткой для работы на производстве",
               Count = 5,
               Price = 21.9M,
               StorageId = 2,
               CategoryId = 2,
               ResponsForItemId = 2,
           }
                );
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ItemId = 2,
                    Name = "Шуруповерт",
                    Model = "Sg500",
                    Brand = "Trelt",
                    SerialNumber = "15870643",
                    Description = "Шуруповерт с набором битам для выполнения различных работа",
                    Count = 2,
                    Price = 400,
                    StorageId = 2,
                    CategoryId = 3,
                }
                );
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ItemId = 5,
                    Name = "Шуруповерт",
                    Model = "Sg500",
                    Brand = "Trelt",
                    SerialNumber = "15870643",
                    Description = "Шуруповерт с набором битам для выполнения различных работа",
                    Count = 1,
                    Price = 400,
                    CategoryId = 3,
                    ResponsForItemId = 2,
                }
                );
            modelBuilder.Entity<Item>().HasData(
               new Item
               {
                   ItemId = 3,
                   Name = "Стул компьтерный",
                   Model = "ArkSteel",
                   Brand = "Vital",
                   SerialNumber = "89Fer543",
                   Description = "Стул компьтерный с различными регулировками, металический",
                   Count = 8,
                   Price = 239,
                   StorageId = 2,
                   CategoryId = 1,
                   ResponsForItemId = 1,
               }
               );

          

        }
        static string CreateHashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);
            string hashPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password!,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8)); ;
            return hashPassword;
        }
    }
}
