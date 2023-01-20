
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UC_12_BackEnd.Interfaces;

namespace UC_12_BackEnd.classes
{
    public abstract class Pessoa : IPessoa
    {
      public string? nome {get; set;}

      public float rendimento {get; set;}

      public string? endereco {get; set;}

      public abstract float CalcularImposto (float rendimento);
    }
}