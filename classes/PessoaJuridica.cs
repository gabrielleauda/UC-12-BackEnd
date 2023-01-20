using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC_12_BackEnd.Interfaces;

namespace UC_12_BackEnd.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}