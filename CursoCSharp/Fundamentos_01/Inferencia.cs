using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "gabriel";
            //nome = 123; nao pode ser feito assim.
            Console.WriteLine(nome);

            //int idade; pode ser feito assim.
            var idade = 23;
            Console.WriteLine(idade);

            Console.WriteLine("Obsevação variaveis feitas por inferencia deve ser inicializadas para nao da erro.");

            int continha;
            continha = 15;
            var b = 5;
            Console.WriteLine(continha - b);
        }
    }
}
