using ProcessoseletivoUppetTools.Libraries.Validacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessoseletivoUppetTools.Models
{
    public class Empresa
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpresaId { get; set; }

       
        public string Nome { get; set; }

       
        public string Fantasia { get; set; }

       
        public string IE { get; set; }

        [Required(ErrorMessage = "Informe o CNPJ")]
        
        [CPFCNPJ]
        public string Cnpj { get; set; }
       
        public string Logradouro { get; set; }

       
       
        public string Numero { get; set; }

       
       
        public string Complemento { get; set; }

       
        public string Bairro { get; set; }


       
        public string Cep { get; set; }

        
       public string Localidade { get; set; }

       
        public string UF { get; set; }

        public string Situacao { get; set; }

        public string AtvPrincCod { get; set; }

        public string AtvPrincDesc { get; set; }


        public string Porte { get; set; }




    }
}
