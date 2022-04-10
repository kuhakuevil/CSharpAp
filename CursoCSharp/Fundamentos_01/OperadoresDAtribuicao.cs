using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class OperadoresDAtribuicao
    {
        public static void Executar()
        {
            var numero1 = 3;
            numero1 = 7;
            numero1 += 10;// numero1 = numero1 + 10;
            numero1 -= 3;// numero1 = numero1 - 3;
            numero1 *= 5;// numero1 = numero1 * 5;
            numero1 /= 2;// numero1 = numero1 / 2;
            Console.WriteLine(numero1);

            int a = 1;
            int b = a;
            a++;// a = a + 1;
            b--;// b = b - 1;
            Console.WriteLine($"o valor de A é: {a} o valor de B é: {b}");
        }
    }
}
