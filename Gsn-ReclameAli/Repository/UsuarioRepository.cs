using Gsn_ReclameAli.DataContext;
using Gsn_ReclameAli.Interfaces;
using Gsn_ReclameAli.Models;
using Microsoft.EntityFrameworkCore;

namespace Gsn_ReclameAli.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected readonly GsnReclameAliContext _context;


        public UsuarioRepository(GsnReclameAliContext context)
        {
            _context = context;
        }

        public async Task SalvarUsuarioAsync(Usuario usuario)
        {
            await _context.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }


        public async Task<Usuario> ObterUsuarioAsync(string email) =>
          await _context.Usuario.FirstOrDefaultAsync(p => p.Email.Equals(email));
    }
}
