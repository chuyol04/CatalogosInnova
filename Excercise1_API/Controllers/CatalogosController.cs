using AutoMapper;
using Azure;
using Excercise1_API.Modelos;
using Excercise1_API.Modelos.Dto;
using Excercise1_API.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Excercise1_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly ILogger<CatalogosController> _logger;
        private readonly ICatalogRepositorio _CatalogRepo;
        private readonly IMapper _mapper;


        public CatalogosController(ILogger<CatalogosController> logger, ICatalogRepositorio catalogRepo,  IMapper mapper)
        {

            _logger = logger;
            _CatalogRepo = catalogRepo;
            _mapper = mapper;

        }

        //METODO GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]//codigos de estado
        public async Task<ActionResult<IEnumerable<CatalogItemDto>>>GetCatalogs()
        {
            _logger.LogInformation("Obtener los catalogos");
            IEnumerable<CatalogItem> CatalogList = await _CatalogRepo.ObtenerTodos();


            return Ok(_mapper.Map<IEnumerable<CatalogItemDto>>(CatalogList));
        }



        //METODO GET SOLO UN REGISTRO EN PARTICULAR
        [HttpGet("id:int", Name = "GetCatalog")]
        [ProducesResponseType(StatusCodes.Status200OK)]//codigos de estado
        [ProducesResponseType(StatusCodes.Status400BadRequest)]//codigos de estado
        [ProducesResponseType(StatusCodes.Status404NotFound)]//codigos de estado
        public  async Task<ActionResult<CatalogItemDto>> GetCatalog(int id)
        {

            if (id == 0)
            {
                _logger.LogError("Error al traer villa con Id" + id);
                return BadRequest();
            }

            var Catalog = await _CatalogRepo.Obtener(v => v.Id == id);

            if (Catalog == null)
            {
                return NotFound();
            }


            //aqui seria solo para obtener un solo dato
            return Ok(_mapper.Map<CatalogItemDto>(Catalog));
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)] //Tamaño maximo del parametro
        public async Task<ActionResult<CatalogItemDto>> CreateCatalog([FromBody] CatalogItemCreateDto createDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (createDto == null)
            {
                return BadRequest(createDto);
            }

            CatalogItem modelo = _mapper.Map<CatalogItem>(createDto);


            await _CatalogRepo.Crear(modelo);

            return CreatedAtRoute("GetCatalog", new { id = modelo.Id }, modelo);



        }


        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCatalog(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }

            var Catalog = await _CatalogRepo.Obtener(v => v.Id == id);

            if (Catalog == null)
            {
                return NotFound();
            }

            _CatalogRepo.Remover(Catalog);
            return NoContent();

        }





        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCatalog(int id, [FromBody] CatalogItemUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.Id)
            {
                return BadRequest();
            }

            CatalogItem modelo = _mapper.Map<CatalogItem>(updateDto);

            _CatalogRepo.Actualizar(modelo);
            return NoContent();
        }

    }
}
