using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, "People").Replace("People", " Pessoas ");
            Console.WriteLine(saudacao);
            var mensagemDeBoasVindas = "Tudo bem".ToUpper().Insert(8, " Espero que sim!");
            Console.WriteLine(mensagemDeBoasVindas);
            Console.WriteLine("TESTE.TESTE!".Length);

            string valorImportante = null;
            //Console.WriteLine(valorImportante.Length);
            //
        }
    }
}
