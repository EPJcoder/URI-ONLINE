/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1041
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1041
{
    class CoordenadasDoPonto
    {
        static void Main(string[] args)
        {
            double X;
            double Y;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');

            X = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            Y = double.Parse(vetor[1], CultureInfo.InvariantCulture);


            if (X == 0.0 && Y != 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (X != 0.0 && Y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X == 0.0 && Y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            Console.ReadKey();
        }
    }
}
