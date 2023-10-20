using Microsoft.EntityFrameworkCore;
using BackEndApi.Models;
using BackEndApi.Services.Contrato;

namespace BackEndApi.Services.Implementacion
{
    public class ProfesorService: IProfesoreService
    {
        private DbescuelaContext _dbContext;


        public ProfesorService(DbescuelaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Profesore>> GetList()
        {
            try
            {

                List<Profesore> lista = new List<Profesore>();
                lista = await _dbContext.Profesores.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }




}
