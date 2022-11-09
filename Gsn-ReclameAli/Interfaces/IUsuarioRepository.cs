using Gsn_ReclameAli.Models;

namespace Gsn_ReclameAli.Interfaces
{
    public interface IUsuarioRepository
    {
        Task SalvarUsuarioAsync(Usuario usuario);

        Task<Usuario> ObterUsuarioAsync(string email);
           
    }
}
