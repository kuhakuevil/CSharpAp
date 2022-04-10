using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class OperadorTernario
    {
        public static void Executar()
        {
            // operador ternario é formado por 3 partes
            // primeira parte é a expressão logo depois temos a ( ? )
            // a parte 2 é a parte que sera atribuida se for verdadeira
            // a parte 3 é a parte que sera atribuida se for falso
            var nota = 7.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

            Console.WriteLine("Teste");//eu que fiz kkk funciona kkkk
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine(nota1);
            var notaDeCorte = nota1 <= 4.0 && bomComportamento ? "Recuperação" : "Não ficou de recuperação";
            Console.WriteLine(notaDeCorte);
        }
    }
}
