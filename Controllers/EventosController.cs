using ApiSegundaPracticaAWS.Models;
using ApiSegundaPracticaAWS.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiSegundaPracticaAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryEventos repo;

        public EventosController(RepositoryEventos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Evento>>> GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CategoriaEvento>>> GetCategorias()
        {
            return await this.repo.GetCategoriasAsync();
        }

        [HttpGet]
        [Route("[action]/{idcategoria}")]
        public async Task<ActionResult<List<Evento>>> GetEventosCategoria(int idcategoria)
        {
            return await this.repo.GetEventosCategoriaAsync(idcategoria);
        }


    }
}