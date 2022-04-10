using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos_01
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Escolha um numero de 0 a 9.");
            int numeroEscolhido = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha outro numero de 0 a 9.");
            int numeroEscolhido2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vamos multiplicar esses dois numeros");
            int resultado = numeroEscolhido * numeroEscolhido2;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Agora vamos pega seus dados Tudo bem?");
            Console.WriteLine("Qual seu salário?");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Seu salário é de R$:{salario}");
            Console.WriteLine($"{nome} {salario} {resultado}");

            // lembrando que esse sinal (?) representa navegação segura e o
            // Parse é utilizado para tentar fazer um passe de conversão
        }
    }
}
