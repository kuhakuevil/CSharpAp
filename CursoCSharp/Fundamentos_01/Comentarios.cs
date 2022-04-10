using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class Comentarios
    {
        public static void Executar()
        {
            // cuidado com comentários desnecessários 
            Console.WriteLine("Código limpo é sempre melhor. !");
            Console.WriteLine("O Csharp tem XML Comments (///)");
            ///<summary>
            /// Exemplo de XML Comments
            /// </summary>
            Console.WriteLine("O Csharp tem comentários de " +
                "multiplas linhas (/* */)");
            /*
             Exemplo de comentários de multiplas linhas
             */
            Console.WriteLine("Sempre procure deixa seu código " +
                "o mais claro possível para evita comentários" +
                " obvios");

            Console.WriteLine("Tecla de atalho para comentários é " +
                "CTRL + K + C / CTRL + K + U");
        }
    }
}
