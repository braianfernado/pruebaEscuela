using BackEndApi.Models;

namespace BackEndApi.Services.Contrato
{
    public interface IMateriaService
    {
        Task<List<Materia>> GetList();
        Task<Materia> Get(int MateriaID);
        Task<Materia> add(Materia modelo);
        Task<bool> Update(Materia modelo);
        Task<bool> Delete(Materia modelo);
    }
}
