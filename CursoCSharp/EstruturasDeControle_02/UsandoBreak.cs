using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class UsandoBreak
    {
        public static void Executar()
        {
            // break esta associado switch e a um laço de repetição e não ao um bloco if
            Random random = new Random();
            int numero = random.Next(1, 51);
            Console.WriteLine("é o numero que queremos? {0}", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o numero que queremos ?", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não!");
                }
                Console.WriteLine("Fim...");
            }
        }
    }
}
