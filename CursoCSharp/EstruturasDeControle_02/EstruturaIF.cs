using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class EstruturaIF
    {
        public static void Executar()
        {
            Console.WriteLine("Exemplo da Aula ");

            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("O Aluno possui bom comportamento ? (S/N)");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s";

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }

            Console.WriteLine("Meu Exemplo:");
            if(nota <= 4.0 && !bomComportamento)
            {
                Console.WriteLine("Aluno que Não esta no quadro de honra");
                Console.WriteLine("Parabens Você reprovou direto");
            }

        }
    }
}
