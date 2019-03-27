/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1115
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1115
{
    class Quadrante
    {
        static void Main(string[] args)
        {
            int X;
            int Y;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');

            X = int.Parse(vetor[0]);
            Y = int.Parse(vetor[1]);

            while (!(X == 0 || Y == 0))
            {
                if (X > 0.0 && Y > 0.0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (X < 0.0 && Y > 0.0)
                {
                    Console.WriteLine("segundo");
                }
                else if (X < 0.0 && Y < 0.0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (X > 0.0 && Y < 0.0)
                {
                    Console.WriteLine("quarto");
                }
                vetor = Console.ReadLine().Split(' ');

                X = int.Parse(vetor[0]);
                Y = int.Parse(vetor[1]);
            }
            Console.ReadKey();
        }
    }
}
