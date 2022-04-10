using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class InterpolacaoDeString
    {
        public static void Executar()
        {
            string nome = "gabriel";
            string produto = "Celular";
            string marca = "Samsung";
            double parcela = 266.47;
            double valorfinal = parcela * 9;

            Console.WriteLine($"{nome} comprou um {produto} da marca " +
                $"{marca} que custava R$ 1400 a vista mas ele parcelou " +
                $"em 9 vezes de:{parcela} o valor " +
                $"final do celular sera de:" +
                $"{valorfinal}");

            string nomeDoProduto = "Notebook GaMer";
            string marcaDoNotebook = "AlienWare";
            double preco = 15699.00;
            Console.WriteLine("O {0} da marca {1} custa no seu valor de mercado " +
                "R$:{2}",nomeDoProduto,marcaDoNotebook,preco);
            Console.WriteLine($"O {nomeDoProduto} da marca {marcaDoNotebook}" +
                $" custa R$:{preco}");
        }
    }
}
