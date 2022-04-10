using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos_03
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "gabriel";
            sicrano.Sobrenome = "Azevedo";
            sicrano.Idade = 23;
            // jeito nao recomendado de apresentar no console
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = Console.ReadLine();
            fulano.Sobrenome = Console.ReadLine();
            //fulano.Idade = Console.ReadLine();
            //fulano.Nome = "Yse";
            //fulano.Sobrenome = "gabriely";
            fulano.Idade = 16;
            //jeito recomendado de apresentar
            var apresentaçãoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentaçãoDoFulano);
        }
    }
}
