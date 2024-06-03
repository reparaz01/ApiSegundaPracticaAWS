using ApiSegundaPracticaAWS.Data;
using ApiSegundaPracticaAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSegundaPracticaAWS.Repositories
{
    public class RepositoryEventos
    {
        private EventosContext context;

        public RepositoryEventos(EventosContext context)
        {
            this.context = context;
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<CategoriaEvento>> GetCategoriasAsync()
        {
            return await this.context.Categorias.ToListAsync();
        }

        public async Task<List<Evento>> GetEventosCategoriaAsync(int idCategoria)
        {
            var consulta = from evento in this.context.Eventos
                           where evento.IdCategoria == idCategoria
                           select evento;

            return await consulta.ToListAsync();
        }


    }
}
