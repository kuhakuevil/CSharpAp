using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle_02
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            //Foreach percorre do primeiro ao ultimo elemento sem excessão
            var palavra = "maggot";
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "ana", "bia", "carlos" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
