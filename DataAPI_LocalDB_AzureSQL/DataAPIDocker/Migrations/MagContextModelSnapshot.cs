﻿// <auto-generated />
using DataAPIDocker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataApiDocker.Migrations
{
    [DbContext(typeof(MagContext))]
    partial class MagContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataApi.Magazine", b =>
                {
                    b.Property<int>("MagazineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("MagazineId");

                    b.ToTable("Magazine");

                    b.HasData(
                        new
                        {
                            MagazineId = 1,
                            Name = "MSDN Magazine"
                        },
                        new
                        {
                            MagazineId = 2,
                            Name = "Docker Magazine"
                        },
                        new
                        {
                            MagazineId = 3,
                            Name = "EFCore Magazine"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
