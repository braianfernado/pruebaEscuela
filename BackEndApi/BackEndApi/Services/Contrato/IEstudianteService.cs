using BackEndApi.Models;

namespace BackEndApi.Services.Contrato
{
    public interface IEstudianteService
    {
        Task<List<Estudiante>> GetList();
        Task<Estudiante> Get(int EstudianteID);
        Task<Estudiante> add(Estudiante modelo);
        Task<bool> Update(Estudiante modelo);
        Task<bool> Delete(Estudiante modelo);
    }
}
