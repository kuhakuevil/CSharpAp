using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Codigo da aula:");
            Console.WriteLine("Avalie meu atendimento com uma nota " +
                "1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo, obrigado por avaliar");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim, obrigado por avaliar");
                    break;
                case 3:
                    Console.WriteLine("Regular, obrigado por avaliar");
                    break;
                case 4:
                    Console.WriteLine("Bom, Obrigado por avaliar");
                    break;
                case 5:
                    Console.WriteLine("Ótimo, obrigado por avaliar");
                    break;
                default:
                    Console.WriteLine("Nota invalida");
                    break;
            }
            Console.WriteLine("Fim do atendimento!!!");

            Console.WriteLine("meu exemplo de switch");
            Console.WriteLine("Selecione uma forma de pagamento 1 = boleto / " +
                "2 = chave pix / 3 = codigo de barras");
            int.TryParse(Console.ReadLine(), out int numero);
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Imprimir boleto");
                    break;
                case 2:
                    Console.WriteLine("Gerar chave pix");
                    break;
                case 3:
                    Console.WriteLine("Paga com codigo de barras");
                    break;
                default:
                    Console.WriteLine("Operação invalida tentar novamente!");
                    break;
            }
        }
    }
}
