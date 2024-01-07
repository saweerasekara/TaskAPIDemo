﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.Data;

#nullable disable

namespace TaskAPI.Data.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240107044040_AuthorExtended")]
    partial class AuthorExtended
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "10",
                            City = "city1",
                            FullName = "Name 1",
                            Street = "street1"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "10",
                            City = "city2",
                            FullName = "Name 2",
                            Street = "street2"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "10",
                            City = "city3",
                            FullName = "Name 3",
                            Street = "street3"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "10",
                            City = "city4",
                            FullName = "Name 4",
                            Street = "street4"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2024, 1, 7, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5089),
                            Description = "Test",
                            Due = new DateTime(2024, 1, 9, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5103),
                            Status = 0,
                            Title = "Db record 1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Created = new DateTime(2024, 1, 7, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5108),
                            Description = "Test2",
                            Due = new DateTime(2024, 1, 9, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5109),
                            Status = 0,
                            Title = "Db record 2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Created = new DateTime(2024, 1, 7, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5110),
                            Description = "Test3",
                            Due = new DateTime(2024, 1, 9, 10, 10, 40, 47, DateTimeKind.Local).AddTicks(5110),
                            Status = 0,
                            Title = "Db record 3"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
