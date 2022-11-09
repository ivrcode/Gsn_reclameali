using Gsn_ReclameAli.Interfaces;
using Gsn_ReclameAli.Models;
using Gsn_ReclameAli.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;

namespace Gsn_ReclameAli.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SalvarUsuarioAsync(Usuario usuario)
        {
            try
            {
                var result = await _usuarioService.SalvarUsuarioAsync(usuario);
                //if(result.StatusCode )
                //{

                //}
                return RedirectToAction("Index", "Usuario");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logar(string email, string senha)
        {
            var usuario = await _usuarioService.AutenticarUsuarioAsync(email, senha);
            if (usuario.StatusCode == HttpStatusCode.OK)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, usuario.Model.UsuarioId.ToString()),
                    new Claim(ClaimTypes.Name, usuario.Model.Nome),
                    new Claim(ClaimTypes.UserData, JsonConvert.SerializeObject(usuario.Model))
                };
                var identity = new ClaimsIdentity(claims, "BRBViagensAuth");
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("ReclameAliAuth", principal);
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
