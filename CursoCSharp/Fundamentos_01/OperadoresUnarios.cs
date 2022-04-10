using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            Console.WriteLine("Codigo limpo é sempre melhor.");
            Console.WriteLine("Esse abaixo ta uma merda nunca faça assim");

            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;
            Console.WriteLine(-valorNegativo);
            numero1++;// Pos ficsado
            Console.WriteLine(numero1);
            --numero1;// Pre ficsado 
            Console.WriteLine(numero1);
            Console.WriteLine(!booleano);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
