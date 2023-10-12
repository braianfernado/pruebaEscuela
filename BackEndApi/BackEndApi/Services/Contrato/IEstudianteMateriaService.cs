using BackEndApi.Models;

namespace BackEndApi.Services.Contrato
{
    public interface IEstudianteMateriaService
    {
        Task<List<EstudiantesMateria>> GetList();
    }
}
