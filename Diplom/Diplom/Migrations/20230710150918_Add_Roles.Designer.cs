﻿// <auto-generated />
using System;
using Diplom.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diplom.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230710150918_Add_Roles")]
    partial class Add_Roles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Diplom.DataAccess.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "В этой категории находяться мебель(диван, стул, кровать, шкафы и т.д.)",
                            Name = "Мебель"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "В этой категории находяться все предметы временного пользования(перчатки, пакеты, масла, полотенца и т.д.)",
                            Name = "Расходники"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "В этой категории находяться электроинструменты(дрель, шуруповерт, болгарка и т.д.)",
                            Name = "Электроинструмент"
                        });
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(85)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ResponsForItemId")
                        .HasColumnType("int");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StorageId")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ResponsForItemId");

                    b.HasIndex("StorageId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Brand = "Startul",
                            CategoryId = 2,
                            Count = 150,
                            Description = "Перчатки латексные с сеткой для работы на производстве",
                            Model = "Латексные с сеткой",
                            Name = "Перчатки",
                            Price = 21.9m,
                            SerialNumber = "77098462",
                            StorageId = 2
                        },
                        new
                        {
                            ItemId = 4,
                            Brand = "Startul",
                            CategoryId = 2,
                            Count = 5,
                            Description = "Перчатки латексные с сеткой для работы на производстве",
                            Model = "Латексные с сеткой",
                            Name = "Перчатки",
                            Price = 21.9m,
                            ResponsForItemId = 2,
                            SerialNumber = "77098462",
                            StorageId = 2
                        },
                        new
                        {
                            ItemId = 2,
                            Brand = "Trelt",
                            CategoryId = 3,
                            Count = 2,
                            Description = "Шуруповерт с набором битам для выполнения различных работа",
                            Model = "Sg500",
                            Name = "Шуруповерт",
                            Price = 400m,
                            SerialNumber = "15870643",
                            StorageId = 2
                        },
                        new
                        {
                            ItemId = 5,
                            Brand = "Trelt",
                            CategoryId = 3,
                            Count = 1,
                            Description = "Шуруповерт с набором битам для выполнения различных работа",
                            Model = "Sg500",
                            Name = "Шуруповерт",
                            Price = 400m,
                            ResponsForItemId = 2,
                            SerialNumber = "15870643"
                        },
                        new
                        {
                            ItemId = 3,
                            Brand = "Vital",
                            CategoryId = 1,
                            Count = 8,
                            Description = "Стул компьтерный с различными регулировками, металический",
                            Model = "ArkSteel",
                            Name = "Стул компьтерный",
                            Price = 239m,
                            ResponsForItemId = 1,
                            SerialNumber = "89Fer543",
                            StorageId = 2
                        });
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.ResponsForItem", b =>
                {
                    b.Property<int>("ResponsForItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResponsForItemId"));

                    b.HasKey("ResponsForItemId");

                    b.ToTable("ResponsForItems");

                    b.HasData(
                        new
                        {
                            ResponsForItemId = 1
                        },
                        new
                        {
                            ResponsForItemId = 2
                        });
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Manager"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Worker"
                        });
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.Storage", b =>
                {
                    b.Property<int>("StorageId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(85)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StorageId"));

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StorageWorkersId")
                        .HasColumnType("int");

                    b.HasKey("StorageId");

                    b.HasIndex("StorageWorkersId")
                        .IsUnique();

                    b.ToTable("Storages");

                    b.HasData(
                        new
                        {
                            StorageId = 1,
                            Addres = "ул.Кальваарийская д.57",
                            Name = "Склад Кальварийской",
                            StorageWorkersId = 1
                        },
                        new
                        {
                            StorageId = 2,
                            Addres = "ул.Трихомирова д.12",
                            Name = "Склад Трихомирова",
                            StorageWorkersId = 2
                        });
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.StorageWorkers", b =>
                {
                    b.Property<int>("StorageWorkersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StorageWorkersId"));

                    b.HasKey("StorageWorkersId");

                    b.ToTable("StorageWorkers");

                    b.HasData(
                        new
                        {
                            StorageWorkersId = 1
                        },
                        new
                        {
                            StorageWorkersId = 2
                        });
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashPassword")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<string>("JobTittle")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResponsForItemId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StorageWorkersId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("ResponsForItemId")
                        .IsUnique()
                        .HasFilter("[ResponsForItemId] IS NOT NULL");

                    b.HasIndex("RoleId");

                    b.HasIndex("StorageWorkersId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Виталий",
                            HashPassword = "nbUlllLFhhl8PyyAYGDLSorO3/WycSbb7G73ArERw0M=",
                            JobTittle = "Складовщик",
                            Login = "VitJob123",
                            RoleId = 3,
                            SecondName = "Позднев",
                            StorageWorkersId = 1
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "Александр",
                            HashPassword = "H78GWwgAup2M5NzshUBdIdo3r7+sjhq8xvjEX/kDQhc=",
                            JobTittle = "Заведующий складом",
                            Login = "AleksJob",
                            ResponsForItemId = 1,
                            RoleId = 2,
                            SecondName = "Довольный",
                            StorageWorkersId = 2
                        },
                        new
                        {
                            UserId = 3,
                            FirstName = "Федор",
                            HashPassword = "ZlkEnAJEaP6AdHPqO0KwI4g1es85+SIpN3ZmVRULl+4=",
                            JobTittle = "администратор",
                            Login = "admin",
                            RoleId = 1,
                            SecondName = "Кручев"
                        },
                        new
                        {
                            UserId = 4,
                            FirstName = "Григорий",
                            HashPassword = "7imSCJVHqr0h0G3uDSKRfis8cLdW16ehJ8NU2sXrgvw=",
                            JobTittle = "Электрик",
                            Login = "ElectrickGrig",
                            ResponsForItemId = 2,
                            RoleId = 3,
                            SecondName = "Морозов"
                        });
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.Item", b =>
                {
                    b.HasOne("Diplom.DataAccess.Entity.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diplom.DataAccess.Entity.ResponsForItem", "ResponsForItem")
                        .WithMany("Items")
                        .HasForeignKey("ResponsForItemId");

                    b.HasOne("Diplom.DataAccess.Entity.Storage", "Storage")
                        .WithMany("Items")
                        .HasForeignKey("StorageId");

                    b.Navigation("Category");

                    b.Navigation("ResponsForItem");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.Storage", b =>
                {
                    b.HasOne("Diplom.DataAccess.Entity.StorageWorkers", "StorageWorkers")
                        .WithOne("Storage")
                        .HasForeignKey("Diplom.DataAccess.Entity.Storage", "StorageWorkersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StorageWorkers");
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.User", b =>
                {
                    b.HasOne("Diplom.DataAccess.Entity.ResponsForItem", "ResponsForItem")
                        .WithOne("User")
                        .HasForeignKey("Diplom.DataAccess.Entity.User", "ResponsForItemId");

                    b.HasOne("Diplom.DataAccess.Entity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diplom.DataAccess.Entity.StorageWorkers", "StorageWorkers")
                        .WithMany("Users")
                        .HasForeignKey("StorageWorkersId");

                    b.Navigation("ResponsForItem");

                    b.Navigation("Role");

                    b.Navigation("StorageWorkers");
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.ResponsForItem", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.Storage", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Diplom.DataAccess.Entity.StorageWorkers", b =>
                {
                    b.Navigation("Storage")
                        .IsRequired();

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
