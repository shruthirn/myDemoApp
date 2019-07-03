﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myDemoApp.API.Data;

namespace myDemoApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("myDemoApp.API.Models.EmployeeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DOB");

                    b.Property<string>("Designation");

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.Property<string>("email");

                    b.HasKey("Id");

                    b.ToTable("EmployeeDatas");
                });

            modelBuilder.Entity("myDemoApp.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<int>("EmployeeDataId");

                    b.Property<bool>("IsMain");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeDataId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("myDemoApp.API.Models.PostData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("PostDatas");
                });

            modelBuilder.Entity("myDemoApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("myDemoApp.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("myDemoApp.API.Models.Photo", b =>
                {
                    b.HasOne("myDemoApp.API.Models.EmployeeData", "EmployeeData")
                        .WithMany()
                        .HasForeignKey("EmployeeDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
