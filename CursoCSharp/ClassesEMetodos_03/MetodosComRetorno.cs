using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos_03
{
    class CalculadoraComum
    {
        //assinatura de um metodo dentro de uma classe
        //tem que ter seu nome alem disso tem que ter um conjuto de parâmetros
        public int Somar(int a, int b)
        {
            return a + b;
        }
        //Assinatura de um metodo deve ser unica dentro da mesma classe
        public int Somar(int c, int d, int e)
        {
            return c + d + e;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraSimples = new CalculadoraComum();
            var resultado = calculadoraSimples.Somar(5, 5);
            var resultado1 = calculadoraSimples.Somar(5, 5, 5);
            var resultado2 = calculadoraSimples.Subtrair(5, 5);
            var resultado3 = calculadoraSimples.Multiplicar(5, 5);
            var resultado4 = calculadoraSimples.Dividir(5, 5);
            Console.WriteLine($"Somar: {resultado} / Somar: {resultado1} Subtrair: {resultado2} / Multiplicar: {resultado3} / Dividir: {resultado4}");
        }
    }
    
}
