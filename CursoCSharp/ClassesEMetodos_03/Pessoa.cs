using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos_03
{
    class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá me chamo {Nome} " +
                $"{Sobrenome} e tenho {Idade} anos de " +
                $"idade.");
        }
        
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
