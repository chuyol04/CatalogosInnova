using Excercise1_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Excercise1_API.Datos
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<CatalogItem> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogItem>().HasData(
                new CatalogItem()
                {
                    Id = 1,
                    Name = "Gold",
                    Description = "Expensive.",
                    Price = 300,
                    PictureFileName = "",
                    PictureUri = "",
                    CatalogTypeId = 1,
                    CatalogBrandId = 1,
                    AvailableStock = 30,
                    RestockThreshold = 20,
                    MaxStockThreshold = 10,
                    OnReorder = true
                },
                   new CatalogItem()
                   {
                       Id = 2,
                       Name = "Gold",
                       Description = "Expensive.",
                       Price = 300,
                       PictureFileName = "",
                       PictureUri = "",
                       CatalogTypeId = 1,
                       CatalogBrandId = 1,
                       AvailableStock = 30,
                       RestockThreshold = 20,
                       MaxStockThreshold = 10,
                       OnReorder = true
                   }
            );
        }

    }
}
