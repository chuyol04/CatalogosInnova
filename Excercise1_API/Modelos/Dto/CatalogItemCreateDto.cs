﻿using System.ComponentModel.DataAnnotations;

namespace Excercise1_API.Modelos.Dto
{
    public class CatalogItemCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureFileName { get; set; }
        public string PictureUri { get; set; }
        [Required]
        public int CatalogTypeId { get; set; }
        [Required]
        public int CatalogBrandId { get; set; }
        public int AvailableStock { get; set; }
        public int RestockThreshold { get; set; }
        public int MaxStockThreshold { get; set; }
        public bool OnReorder { get; set; }
    }
}
