using Gsn_ReclameAli.Interfaces;
using Gsn_ReclameAli.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gsn_ReclameAli.Controllers
{
    public class ProblemaController : Controller
    {
        private readonly IProblemaService _problemaService;
        public ProblemaController(IProblemaService problemaService)
        {
            _problemaService = problemaService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(ProblemaModel problema)
        {
            _problemaService.SalvarProblemaAsync(problema);
            return default;
        }


        [HttpGet]
        public IActionResult ListarProblemas(ProblemaModel problema)
        {
            _problemaService.SalvarProblemaAsync(problema);
            return default;
        }
    }
}
