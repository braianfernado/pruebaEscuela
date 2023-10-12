using BackEndApi.Models;

namespace BackEndApi.Services.Contrato
{
    public interface IProfesoreService
    {
        Task<List<Profesore>> GetList();
    }
}
