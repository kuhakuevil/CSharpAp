using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço com desconto é de: {0}",totalComDesconto);

            // Calculando IMC
            double peso = 53;
            double altura = 1.68;
            double imc = peso / (altura * altura);
            double imc2 = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é de: {imc}");
            Console.WriteLine($"IMC2 é de: {imc2}");

            // Impar/Par
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem o resto {1}", impar, impar % 2);
        }
    }
}
