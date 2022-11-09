using System.ComponentModel.DataAnnotations;

namespace Gsn_ReclameAli.Models
{
    public class EnderecoModel
    {
         public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public int ProblemaId { get; set; }
        public virtual List<ProblemaModel> Problema { get; set; }

    }
}
