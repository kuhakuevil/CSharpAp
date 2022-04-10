using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            // quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;// conhecido como cash ()
            // maneira correta de se fazer uma conversão (tipo)
            // de dado que vc quer converter
            Console.WriteLine("Nota truncada: {0}",notaTruncada);

            Console.Write("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            //feito uma conversão
            Console.WriteLine("idade inserida: {0}",idadeInteiro);
            // outra maneira de fazer uma conversão
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}",idadeInteiro);

            Console.WriteLine("Digite um numero de 0 a 9");
            string palpite = Console.ReadLine();
            int numero1;
            int.TryParse(palpite, out numero1);
            Console.WriteLine("Resultado: {0}",numero1);
            // outra maneira de fazer
            Console.WriteLine("Digite um segundo numero de 0 a 9");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado: {0}", numero2);
            // TryParse tenta fazer a conversão se não conseguir coloca
            // o valor Zero
            int soma = numero1 + numero2;
            int multiplicar = soma * 2;
            int divisao = multiplicar / numero2;
            Console.WriteLine("somando esses dois numeros {0}",soma);
            Console.WriteLine("Multiplicando por 2: {0}",multiplicar);
            Console.WriteLine("Dividindo pelo o numero2 escolhido: {0}",divisao);
        }
    }
}
