using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC_12_BackEnd.Interfaces;

namespace UC_12_BackEnd.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get; set;}

        public DateTime dataNasc {get; set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}