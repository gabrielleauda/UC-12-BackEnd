using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC_12_BackEnd.classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(texto);
            for (var i = 0; i < 6; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
                
            }
            Console.ResetColor();
            Console.Clear();
        }
    }
}