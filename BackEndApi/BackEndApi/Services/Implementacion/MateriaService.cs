using Microsoft.EntityFrameworkCore;
using BackEndApi.Models;
using BackEndApi.Services.Contrato;

namespace BackEndApi.Services.Implementacion
{
    public class MateriaService : IMateriaService
    {

            private DbescuelaContext _dbContext;

            public MateriaService(DbescuelaContext dbContext)
            {
                _dbContext = dbContext;
            }

        public async Task<Materia> add(Materia modelo)
        {
            try
            {
                _dbContext.Materias.Add(modelo);
                await _dbContext.SaveChangesAsync();

                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





        public async Task<bool> Delete(Materia modelo)
        {
            try
            {
                _dbContext.Materias.Remove(modelo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<Materia> Get(int MateriaID)
        {
            try
            {
                Materia? encontrado = new Materia();
                encontrado = await _dbContext.Materias.
                    Where(e => e.MateriaId == MateriaID).FirstOrDefaultAsync();

           

                return encontrado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<List<Materia>> GetList()
        {
            try
            {

                List<Materia> lista = new List<Materia>();
                lista = await _dbContext.Materias.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      



        public async Task<bool> Update(Materia modelo)
        {
            try
            {
                _dbContext.Materias.Update(modelo);
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



