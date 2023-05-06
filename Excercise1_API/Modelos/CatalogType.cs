using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Excercise1_API.Modelos
{
    public class CatalogType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatalogtypeId { get; set; }

        public string Type { get; set; }
    }
}