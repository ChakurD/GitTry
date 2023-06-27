using Diplom.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

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
            modelBuilder.Entity<Storage>().HasData(
               new Storage
               {
                   StorageId = 1,
                   Name = "Склад Кальварийской",
                   Addres = "ул.Кальваарийская д.57"
               }
               );
            modelBuilder.Entity<Storage>().HasData(
                new Storage
                {
                    StorageId = 2,
                    Name = "Склад Трихомирова",
                    Addres = "ул.Трихомирова д.12"
                }
                );
            modelBuilder.Entity<StorageWorkers>().HasData(
               new StorageWorkers
               {
                   StorageWorkersId = 1,
                   StorageId = 1,
               }
               );
            modelBuilder.Entity<StorageWorkers>().HasData(
                new StorageWorkers
                {
                    StorageWorkersId = 2,
                    StorageId = 2,
                }
                );
            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                FirstName = "Виталий",
                SecondName = "Позднев",
                HashPassword = "123jobpas",
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
                HashPassword = "jobpastut",
                Login = "AleksJob",
                JobTittle = "Заведующий складом",
                StorageWorkersId = 2,
            }
            );
            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 3,
                FirstName = "Федор",
                SecondName = "Кручев",
                HashPassword = "admin",
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
                HashPassword = "jobScan",
                Login = "ElectrickGrig",
                JobTittle = "Электрик",
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
                  StoregeId = 2,
                  CatregoryId = 2,
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
               StoregeId = 2,
               CatregoryId = 2,
               ResponsForItemId = 3,
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
                    StoregeId = 2,
                    CatregoryId = 3,
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
                    CatregoryId = 3,
                    ResponsForItemId = 3,
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
                   StoregeId = 2,
                   CatregoryId = 1,
                   ResponsForItemId = 2,
               }
               );

            modelBuilder.Entity<ResponsForItem>().HasData(
                new ResponsForItem
                {
                    ResponsForItemId = 1,
                    UserId = 1,
                }
                );
            modelBuilder.Entity<ResponsForItem>().HasData(
                new ResponsForItem
                {
                    ResponsForItemId = 2,
                    UserId = 2,
                }
                );
            modelBuilder.Entity<ResponsForItem>().HasData(
                new ResponsForItem
                {
                    ResponsForItemId = 3,
                    UserId = 4,
                }
                );
          
        }
    }
}
