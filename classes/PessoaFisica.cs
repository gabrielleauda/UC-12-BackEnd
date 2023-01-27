using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC_12_BackEnd.Interfaces;


// - Pessoa física
// Para rendimentos até 1500, isento
// Para rendimentos entre 1500 e 3500, 2%
// Para rendimentos entre 3500 e 6000, 3,5%
// para rendimentos acima de 6000, 5%


namespace UC_12_BackEnd.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get; set;}

        public DateTime dataNasc {get; set;}

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;
                return resultado;
            }

            else if (rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento / 100) * 3.5f;
                return resultado;
            }
            else 
            {
               float resultado = (rendimento / 100) * 5;
               return resultado;
            }
            
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}