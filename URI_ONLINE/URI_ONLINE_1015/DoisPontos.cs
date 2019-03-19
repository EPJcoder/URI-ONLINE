/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1015
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1015
{
    class DoisPontos
    {
        static void Main(string[] args)
        {
            double x1;
            double y1;

            double x2;
            double y2;

            double distancia;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');
            x1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            vetor = Console.ReadLine().Split(' ');
            x2 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);


            distancia = Math.Sqrt(((Math.Pow(x2, 2.0) - 2.0 * x2 * x1 + x1 * x1) + (Math.Pow(y2, 2.0) - 2.0 * y2 * y1 + y1 * y1)));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
