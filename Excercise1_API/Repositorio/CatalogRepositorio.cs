using Excercise1_API.Datos;
using Excercise1_API.Modelos;
using Excercise1_API.Repositorio.IRepositorio;

namespace Excercise1_API.Repositorio
{
    public class CatalogRepositorio : Repositorio<CatalogItem>, ICatalogRepositorio
    {
        private readonly ApplicationDbContext _db;

        public CatalogRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<CatalogItem> Actualizar(CatalogItem entidad)
        {
            entidad.Description = "Finalizado";
            _db.Items.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
