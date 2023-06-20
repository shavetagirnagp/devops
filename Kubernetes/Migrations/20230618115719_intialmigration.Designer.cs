﻿// <auto-generated />
using Kubernetes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kubernetes.Migrations
{
    [DbContext(typeof(UsersContext))]
    [Migration("20230618115719_intialmigration")]
    partial class intialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kubernetes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Shaveta",
                            LastName = "Girdhar",
                            Phone = "4738748374",
                            Title = "Mrs."
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Aarav",
                            LastName = "Gupta",
                            Phone = "545474",
                            Title = "Mr."
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Anu",
                            LastName = "Girdhar",
                            Phone = "432111111",
                            Title = "Mrs."
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Tushar",
                            LastName = "Tuteja",
                            Phone = "13242455",
                            Title = "Mr."
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Anish",
                            LastName = "Gupta",
                            Phone = "876589039",
                            Title = "Mr."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
