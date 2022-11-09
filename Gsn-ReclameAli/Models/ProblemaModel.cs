namespace Gsn_ReclameAli.Models
{
    public class ProblemaModel
    {
        
        public int ProblemaId { get; set; } 

        public string Titulo { get; set; }

        public string Descricao { get; set; }   

        public virtual EnderecoModel Endereco { get; set; }    
         
     
    }
}
