using System.ComponentModel.DataAnnotations;

namespace Excercise1_API.Modelos.Dto
{
    public class CatalogItemUpdateDto
    {
        //el dto es basicamente una copia del modelo catalogitem pero solo muestro aqui lo que quiero enseñar en el front
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public string PictureFileName { get; set; }
        public string PictureUri { get; set; }
        [Required]
        public int CatalogTypeId { get; set; }
        [Required]
        public int CatalogBrandId { get; set; }
        [Required]
        public int AvailableStock { get; set; }
        [Required]
        public int RestockThreshold { get; set; }
        [Required]
        public int MaxStockThreshold { get; set; }
        [Required]
        public bool OnReorder { get; set; }
    }
}
