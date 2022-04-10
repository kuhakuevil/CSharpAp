using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;
            Console.WriteLine("Nota invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota invalida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Pode melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);

            //teste
            Console.WriteLine("Digite nota do aluno");
            double.TryParse(Console.ReadLine(), out double nota2);
            double notaDeCorte2 = 7.0;
            Console.WriteLine("Nota invalida? {0}", nota2 > 10.0);
            Console.WriteLine("Nota invalida? {0}", nota2 < 0.0);
            Console.WriteLine("Perfeito? {0}", nota2 == 10.0);
            Console.WriteLine("Pode melhorar? {0}", nota2 != 10.0);
            Console.WriteLine("Passou por média? {0}", nota2 >= notaDeCorte2);
            Console.WriteLine("Recuperação? {0}", nota2 < notaDeCorte2);
            Console.WriteLine("Reprovado? {0}", nota2 <= 3.0);
        }
    }
}
