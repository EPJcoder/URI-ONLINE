/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1013
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1013
{
    class MaiorNumero
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;

            int MaiorAB;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');

            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            C = int.Parse(vetor[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;

            if (MaiorAB > C)
            {
                Console.WriteLine(MaiorAB + " eh o maior");
            }
            else
            {
                Console.WriteLine(C + " eh o maior");
            }
            Console.ReadKey();
        }
    }
}
