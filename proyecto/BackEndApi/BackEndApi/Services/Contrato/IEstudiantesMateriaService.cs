using BackEndApi.Models;

namespace BackEndApi.Services.Contrato
{
    public interface IEstudiantesMateriaService
    {
        Task<List<EstudiantesMateria>> GetList();
    }
}
