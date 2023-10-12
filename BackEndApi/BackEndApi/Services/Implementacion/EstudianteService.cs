using Microsoft.EntityFrameworkCore;
using BackEndApi.Models;
using BackEndApi.Services.Contrato;

namespace BackEndApi.Services.Implementacion
{
    public class EstudianteService : IEstudianteService
    {
        private DbescuelaContext _dbContext;

        public EstudianteService(DbescuelaContext dbContext)
        {
            _dbContext = dbContext; 
    }


    public async Task<Estudiante> add(Estudiante modelo)
        {
            try
            {
                 _dbContext.Estudiantes.Add(modelo);
                await _dbContext.SaveChangesAsync();

                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(Estudiante modelo)
        {
            try
            {
                _dbContext.Estudiantes.Remove(modelo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Estudiante> Get(int EstudianteID)
        {
            try
            {
                Estudiante? encontrado = new Estudiante();
                encontrado = await _dbContext.Estudiantes.
                    Where(e => e.EstudianteId == EstudianteID).FirstOrDefaultAsync();

                return encontrado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Estudiante>> GetList()
        {
            try
            {
                List<Estudiante> lista = new List<Estudiante>();
                lista=await _dbContext.Estudiantes.ToListAsync();
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Update(Estudiante modelo)
        {
            try
            {
                _dbContext.Estudiantes.Update(modelo);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}