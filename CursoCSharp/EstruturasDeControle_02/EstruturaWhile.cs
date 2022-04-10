using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativasAtuais = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("insira seu palpite de 1 a 15 numeros: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasAtuais++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    Console.WriteLine("Parabens você acertou");
                    var corAnterior = Console.BackgroundColor;
                    // muda a cor do console
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativasAtuais);
                    Console.BackgroundColor = corAnterior;
                }else if (numeroSecreto > palpite)
                {
                    Console.WriteLine("maior ... tente novamente");
                    Console.Write("numero de tentativas restantes:{0} ", tentativasRestantes);
                }else if (numeroSecreto < palpite)
                {
                    Console.WriteLine("menor ... tente novamente");
                    Console.Write("numero de tentativas restantes:{0} ", tentativasRestantes);
                }
            }
            Console.WriteLine("meu exemplo");

        }
    }
}
