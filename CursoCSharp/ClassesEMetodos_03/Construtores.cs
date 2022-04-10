using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos_03
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
        public string Cor;
        public string Combustivel;

        public Carro(string modelo, string fabricante, int ano, string cor, string combustivel)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
            Cor = cor;
            Combustivel = combustivel;
        }

        public Carro()
        {

        }
    }
    class Construtores
    {
        public static void Executar()
        {
            //maneira bacana de ser utilizada
            var carro1 = new Carro("renegade", "Jeep", 2021, "Verde musco", "Diesel");
            Console.WriteLine($"modelo do veiculo: " +
                $"{carro1.Modelo}  ");
            Console.WriteLine($"o fabricante do veiculo: " +
                $"{carro1.Fabricante}");
            Console.WriteLine($"o ano que foi produzido:" +
                $" {carro1.Ano}");
            Console.WriteLine($"a cor do veiculo original de fabrica:" +
                $" {carro1.Cor}");
            Console.WriteLine($"o Tipo de combustível utilizado:" +
                $" {carro1.Combustivel}");

            //outra maneira de se fazer
            var carro2 = new Carro();
            carro2.Modelo = "Gol";
            carro2.Fabricante = "Volkswagen";
            carro2.Ano = 2009;
            carro2.Cor = "Preto";
            carro2.Combustivel = "Flex Power";

            Console.WriteLine($"{carro2.Modelo}");
            Console.WriteLine($"{carro2.Fabricante}");
            Console.WriteLine($"{carro2.Ano}");
            Console.WriteLine($"{carro2.Cor}");
            Console.WriteLine($"{carro2.Combustivel}");

            // maneira mais facil de se fazer
            var carro3 = new Carro()
            {
                Modelo = "Civic",
                Fabricante = "Honda",
                Ano = 2004,
                Cor = "Prata",
                Combustivel = "Gasolina"
            };
            Console.WriteLine($"{carro3.Modelo}{carro3.Fabricante}{carro3.Ano}{carro3.Cor}{carro3.Combustivel}");
        }
    }
}
