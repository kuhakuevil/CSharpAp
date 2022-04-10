using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class EstruturaFor
    {
        public static void Executar()
        {
            Console.WriteLine("Exemplos de pq usar o for");
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"o valor de i é : {i}");
                i++;
            }
            // estrutura for é composta por 3 partes 
            // a declaração da variavel nesse exemplo seria o int db = 0;
            // a expressão que ira dizer se é verdadeiro ou falso db <= 3500;
            // e o incremento seria o db += 350;
            for (int db = 0; db < 3500; db += 350){
                Console.WriteLine($"Deposito bancario mensal é de: {db}");
            }


            Console.WriteLine("Execicio da aula abaixo");

            double somatorio = 0;
            string entrada;
            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);

            for(int notaDoAluno = 1; notaDoAluno <= tamanhoDaTurma; notaDoAluno++)
            {
                Console.Write("informe a nota do aluno {0}:",notaDoAluno);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine($"A media da turma é: {media}");

            for (int ponto = 10;ponto < 0; ponto--)
            {
                Console.WriteLine($"o valor de ponto é {ponto}");
            }
        }
    }
}
