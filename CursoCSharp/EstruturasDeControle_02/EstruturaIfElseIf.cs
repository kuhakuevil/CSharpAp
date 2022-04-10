using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Estrutura if/else/if");
            Console.WriteLine("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra!");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Te vejo ano que vem");
            }
            Console.WriteLine("Fim!!!");

            Console.WriteLine("Meu Execicio sobre a aula");
            Console.WriteLine("Avalie nosso atendimento com a nota de" +
                " 0 a 5");
            string avaliacao = Console.ReadLine();
            int.TryParse(avaliacao, out int numero);
            if(numero == 5)
            {
                Console.WriteLine("Otimo muito obrigado!");
            }else if (numero == 4)
            {
                Console.WriteLine("Bom muito obrigado!");
            }else if(numero == 3)
            {
                Console.WriteLine("Regular muito obrigado!");
            }else if(numero == 2)
            {
                Console.WriteLine("Ruim muito obrigado!");
            }else if(numero <= 1){
                Console.WriteLine("péssimo Muito obrigado!");
            }
        }
    }
}
