using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UC_12_BackEnd.Interfaces;


// - Pessoa jurídica
// Para Rendimentos até 3000, 3%
// Para rendimentos entre 3000 e 6000, 5%
// Para rendimentos entre 6000 e 10000, 7%
// Para rendimentos acima de 10000, 9%



namespace UC_12_BackEnd.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimento)
        {
             if (rendimento <= 3000)
            {
                return rendimento * 0.03f; //3%
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
               return rendimento * 0.05f; //5%
            }

            else if (rendimento > 6000 && rendimento <= 10000)
            {
               return rendimento * 0.07f; //7%
            }
            else 
            {
               return rendimento * 0.09f; //9%
            }
            
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)

        {
          bool retornoCnpjValido =  Regex.IsMatch(cnpj,@"^(\d{14})|(\d{2}.\d{3}.\d{3}/d{4}-\{2})$");

          if (retornoCnpjValido)
          {
            string substringCnpj14 = cnpj.Substring(8, 4);

            if (substringCnpj14 == "0001")
            {
                return true;
            }
           
          }

          string substringCnpj18 = cnpj.Substring(11, 4);
           if (substringCnpj18 == "0001")
            {
                return true;
            }

          return false;
        }
    }
}