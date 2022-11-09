using Gsn_ReclameAli.Common;
using Gsn_ReclameAli.Interfaces;
using Gsn_ReclameAli.Models;

namespace Gsn_ReclameAli.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuariosRepository;
        
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuariosRepository = usuarioRepository;

        }

        public async Task<Resultado<Usuario>> SalvarUsuarioAsync(Usuario usuario)
        {
            try
            {
                var user = await _usuariosRepository.ObterUsuarioAsync(usuario.Email);
                if (usuario != null)
                    return Resultado<Usuario>.InformacaoMensagem("E-mail do usuário já cadastrado!");

                usuario.Senha = usuario.Senha.ToUpper();
                await _usuariosRepository.SalvarUsuarioAsync(usuario);
                return Resultado<Usuario>.SucessoMensagem("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return Resultado<Usuario>.ErroMensagem($"Erro ao cadastrar o usuário {ex.Message}!");
            }
        }


        public async Task<Resultado<Usuario>> AutenticarUsuarioAsync(string email, string senha)
        {
            try
            {               
                var usuario = await _usuariosRepository.ObterUsuarioAsync(email);
                if (usuario == null) return Resultado<Usuario>.InformacaoMensagem("Usuário não cadastrado!");

                if(usuario.Senha != senha.ToUpper()) return Resultado<Usuario>.InformacaoMensagem("Usuário ou senha incorretos!");
                var resultado = new Resultado<Usuario>()
                {
                    Mensagem = "Usuário logado com sucesso!",
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Model = usuario
                };
                return resultado;   
            }
            catch (Exception ex)
            {
                return Resultado<Usuario>.ErroMensagem($"Erro ao obter o usuário {ex.Message}!");
            }
        }

        


    }
}
