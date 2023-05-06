using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Excercise1_API.Modelos.Dto
{
    public class CatalogBrandDto
    {
        [Required]
        public int CatalogBrandId { get; set; }

        public string Brand { get; set; }
    }
}
