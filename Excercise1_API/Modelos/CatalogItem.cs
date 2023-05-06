using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Excercise1_API.Modelos
{
    public class CatalogItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PictureFileName { get; set; }
        public string PictureUri { get; set; }


        [Required]
        public int CatalogTypeId { get; set; }
        [ForeignKey("CatalogTypeId")]
        public CatalogType CatalogType { get; set; }

        [Required]
        public int CatalogBrandId { get; set; }
        [ForeignKey("CatalogBrandId")]
        public CatalogBrand CatalogBrand { get; set; }
        //foreign keys

        public int AvailableStock { get; set; }
        public int RestockThreshold { get; set; }
        public int MaxStockThreshold { get; set; }
        public bool OnReorder { get; set; }
    }
}
