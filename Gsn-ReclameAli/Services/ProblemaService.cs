using Gsn_ReclameAli.Interfaces;
using Gsn_ReclameAli.Models;

namespace Gsn_ReclameAli.Services
{
    public class ProblemaService: IProblemaService
    {
        private readonly IProblemaRepository _problemaRepository;

        public ProblemaService(IProblemaRepository problemaRepository)
        {
            _problemaRepository = problemaRepository;

        }

        public async Task<ProblemaModel> SalvarProblemaAsync(ProblemaModel problema)
        {
            try
            {

                await _problemaRepository.SalvarProblemaAsync(problema);
                await _problemaRepository.SalvarEnderecoAsync(problema.Endereco);
                return default;

            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public async Task<List<ProblemaModel>>ListarProblemaAsync()
        {
            try
            {              
                return default;

            }
            catch (Exception ex)
            {
                return default;
            }
        }
    }
}
