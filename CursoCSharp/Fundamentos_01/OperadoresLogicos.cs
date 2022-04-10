using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var trabalho1 = true;
            var trabalho2 = false;
            bool comprouTV50 = trabalho1 && trabalho2;
            Console.WriteLine("Comprou TV de 50? {0}", comprouTV50);

            var comprouSorvete = trabalho1 || trabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            var comprouTV32 = trabalho1 ^ trabalho2;
            Console.WriteLine("Comprou TV de 32? {0}", comprouTV32);

            Console.WriteLine("Mais saudadel ? {0}", !comprouSorvete);
        }
    }
}
