using Gsn_ReclameAli.Models;

namespace Gsn_ReclameAli.Interfaces
{
    public interface IProblemaRepository
    {

        Task SalvarProblemaAsync(ProblemaModel problema);

        Task SalvarEnderecoAsync(EnderecoModel endereco);

        //Task<List<ProblemaModel>> ListarProblemaAsync();
    }
}
