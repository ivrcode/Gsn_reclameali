using Gsn_ReclameAli.Models;

namespace Gsn_ReclameAli.Interfaces
{
    public interface IProblemaService
    {
        Task<ProblemaModel> SalvarProblemaAsync(ProblemaModel problema);

        Task<List<ProblemaModel>> ListarProblemaAsync();
    }
}
