using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace CursoCSharp.Fundamentos_01
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            // F1 coloca apanas uma casa decimal
            Console.WriteLine(valor.ToString("C"));
            // C moeda ou simbolo de dinheiro
            Console.WriteLine(valor.ToString("P"));
            // P percentual %
            Console.WriteLine(valor.ToString("#.##"));
            // mesma coisa que o F1 so que com duas casas
            // decimais 

            CultureInfo cultura = new CultureInfo("pt-Br");
            // ao criar uma variavel não esqueça de dar nome a ela
            Console.WriteLine(valor.ToString("C2",cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
