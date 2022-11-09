using Gsn_ReclameAli.DataContext;
using Gsn_ReclameAli.Interfaces;
using Gsn_ReclameAli.Models;
using Microsoft.EntityFrameworkCore;

namespace Gsn_ReclameAli.Repository
{
    public class ProblemaRepository : IProblemaRepository
    {
        protected readonly GsnReclameAliContext _context;


        public ProblemaRepository(GsnReclameAliContext context)
        {
            _context = context;
        }


        public async Task SalvarEnderecoAsync(EnderecoModel endereco)
        {
            var result = await _context.AddAsync(endereco);
            await _context.SaveChangesAsync();

        }

        public async Task SalvarProblemaAsync(ProblemaModel problema)
        {
            
           
            var teste = await _context.AddAsync(problema);
            teste = teste; 
            await _context.SaveChangesAsync();

        }

        //public async Task<List<ProblemaModel>> ListarProblemaAsync() => await _context.Problema.ToListAsync();


    }
}
