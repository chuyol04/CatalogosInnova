﻿// <auto-generated />
using Excercise1_API.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Excercise1_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Excercise1_API.Modelos.CatalogBrand", b =>
                {
                    b.Property<int>("CatalogBrandId")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatalogBrandId");

                    b.ToTable("CatalogBrand");
                });

            modelBuilder.Entity("Excercise1_API.Modelos.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableStock")
                        .HasColumnType("int");

                    b.Property<int>("CatalogBrandId")
                        .HasColumnType("int");

                    b.Property<int>("CatalogTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxStockThreshold")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnReorder")
                        .HasColumnType("bit");

                    b.Property<string>("PictureFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RestockThreshold")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogBrandId");

                    b.HasIndex("CatalogTypeId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableStock = 30,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Expensive.",
                            MaxStockThreshold = 10,
                            Name = "Gold",
                            OnReorder = true,
                            PictureFileName = "",
                            PictureUri = "",
                            Price = 300.0,
                            RestockThreshold = 20
                        },
                        new
                        {
                            Id = 2,
                            AvailableStock = 30,
                            CatalogBrandId = 1,
                            CatalogTypeId = 1,
                            Description = "Expensive.",
                            MaxStockThreshold = 10,
                            Name = "Gold",
                            OnReorder = true,
                            PictureFileName = "",
                            PictureUri = "",
                            Price = 300.0,
                            RestockThreshold = 20
                        });
                });

            modelBuilder.Entity("Excercise1_API.Modelos.CatalogType", b =>
                {
                    b.Property<int>("CatalogtypeId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatalogtypeId");

                    b.ToTable("CatalogType");
                });

            modelBuilder.Entity("Excercise1_API.Modelos.CatalogItem", b =>
                {
                    b.HasOne("Excercise1_API.Modelos.CatalogBrand", "CatalogBrand")
                        .WithMany()
                        .HasForeignKey("CatalogBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Excercise1_API.Modelos.CatalogType", "CatalogType")
                        .WithMany()
                        .HasForeignKey("CatalogTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogBrand");

                    b.Navigation("CatalogType");
                });
#pragma warning restore 612, 618
        }
    }
}
