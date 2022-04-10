using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos_01
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            Console.WriteLine("Calculando a Circunferência");
            double raio = 4.5;
            const double Pi = 3.14;

            raio = 5.5;
            // Pi = 0;
            double area = Pi * raio * raio;
            Console.WriteLine($"A área da cincurferência é: {area}");

            Console.WriteLine("calculando imc do gabriel");
            Console.WriteLine("Entre 18,5 e 24,9: Normal");
            Console.WriteLine("Menor que 18,5: Magreza");
            Console.WriteLine("Maior que 40,0: Obesidade Grave");
            double peso = 53;
            double altura = 1.68;
            double imc = peso / (altura * altura);
            Console.WriteLine($"Resultado do imc do gabriel: {imc}");

            // tipos internos 
            bool estaChovendo = false;
            Console.WriteLine($"Esta chovendo hoje {estaChovendo}");
            
            // * 
            byte idade = 23;
            Console.WriteLine("idade " + idade);
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine($"o saldo de gols é {saldoDeGols}");
            short salario = short.MaxValue;
            Console.WriteLine("Salario anual é: "+salario);
            int menorInteiro = int.MinValue;// mais usados dos inteiros
            Console.WriteLine("menor valor inteiro: " + menorInteiro);
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine($"A população brasileira é de {populacaoBrasileira}");
            long menorValorLong = long.MinValue;
            Console.WriteLine($"menor valor long é de {menorValorLong}");
            ulong populacaoMundial = 8_000_000_000;
            Console.WriteLine($" população mundial é de {populacaoMundial}");

            Console.WriteLine("Observação float tem que colocar F no final do numero. exemplo a baixo");
            float precoComputador = 1599.99f;
            Console.WriteLine($"o valor do computador da positivo é de: {precoComputador}");

            double valorDoBitCoin = 231904.29;
            Console.WriteLine($"hoje dia 09/02/2022 um bitcoin vale : {valorDoBitCoin}");
            decimal distanciaDela = decimal.MaxValue;
            Console.WriteLine($"foda... {distanciaDela}");
            char pLetra = 'Y';
            Console.WriteLine(pLetra);
            string frase = "Muito prazer meu nome é ótario.";
            Console.WriteLine(frase);

            // # Adicionais 
            Console.WriteLine("valor do celular parcelado");
            double celular = 266.47;
            int parcelas = 9;
            double valortotal = celular * parcelas;
            Console.WriteLine($"valor total {valortotal}");
        }
    }
}
