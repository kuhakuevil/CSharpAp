using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class UsandoContinue
    {
        public static void Executar()
        {
            // o continue não causa a saida do bloco simplesmente
            //causa a saida prematura daquela repetição
            int intervalo = 50;
            Console.WriteLine("Os numeros pares de 1 a 50 são: {0}",intervalo);

            for(int numero = 1; numero <= intervalo; numero++)
            {
                if (numero % 2 == 1)
                {
                    continue;
                }
            Console.Write(numero + " ");
            }
        }
    }
}
