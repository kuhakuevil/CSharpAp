using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;
            // estrutura do While sera sempre executada a menos
            // uma vez e ela sempre termina com ponto em virgula
            // e o bloco vem antes da senteça de codigo

            do
            {
                Console.WriteLine("Qual seu nome ? ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja Continua (S/N) ?");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
