using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos_01;
using CursoCSharp.EstruturasDeControle_02;
using CursoCSharp.ClassesEMetodos_03;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // * Fundamentos *
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de Tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação de String - Fundamentos", InterpolacaoDeString.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados Do Console - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuição - Fundamentos", OperadoresDAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // * Estrutura De Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar},
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE/IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura Repetição While  - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Repetição DoWhile  - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura Repetição For  - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Repetição Foreach  - Estruturas de Controle", EstruturaForeach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                
                // * Classes E Metodos
                {"Membros - Classes & Metodos", Membros.Executar},
                {"Construtores - Classes & Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes & Metodos", MetodosComRetorno.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}