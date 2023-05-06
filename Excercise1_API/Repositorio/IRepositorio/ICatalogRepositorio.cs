using Excercise1_API.Modelos;

namespace Excercise1_API.Repositorio.IRepositorio
{
    public interface ICatalogRepositorio :IRepositorio<CatalogItem>
    {
        Task<CatalogItem> Actualizar(CatalogItem entidad);
    }
}
