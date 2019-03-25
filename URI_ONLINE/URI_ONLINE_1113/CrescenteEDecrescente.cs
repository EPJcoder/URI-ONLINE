/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1113
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1113
{
    class CrescenteEDecrescente
    {
        static void Main(string[] args)
        {
            int X;
            int Y;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');

            X = int.Parse(vetor[0]);
            Y = int.Parse(vetor[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                string[] vetor2;
                vetor2 = Console.ReadLine().Split(' ');

                X = int.Parse(vetor2[0]);
                Y = int.Parse(vetor2[1]);
            }
            Console.ReadKey();
        }
    }
}
