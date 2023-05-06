using System.ComponentModel.DataAnnotations;

namespace Excercise1_API.Modelos.Dto
{
    public class CatalogTypeDto
    {
        [Required]
        public int CatalogtypeId { get; set; }

        public string Type { get; set; }
    }
}
