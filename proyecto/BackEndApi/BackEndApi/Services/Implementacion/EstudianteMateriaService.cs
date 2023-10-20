using BackEndApi.Models;

using Microsoft.EntityFrameworkCore;
using BackEndApi.Models;
using BackEndApi.Services.Contrato;

namespace BackEndApi.Services.Implementacion
{
    public class EstudianteMateriaService:IEstudiantesMateriaService
    {

        private DbescuelaContext _dbContext;


        public EstudianteMateriaService(DbescuelaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<EstudiantesMateria>> GetList()
        {
            try
            {
                List<EstudiantesMateria> lista = new List<EstudiantesMateria>();
                lista = await _dbContext.EstudiantesMaterias.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
