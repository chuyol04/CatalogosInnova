using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Excercise1_API.Modelos
{
    public class CatalogBrand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatalogBrandId { get; set; }

        public string Brand { get; set; }
    }
}