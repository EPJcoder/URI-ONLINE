/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1011
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1011
{
    class Esfera
    {
        static void Main(string[] args)
        {
            double R;
            double pi;
            pi = 3.14159;
            double VOLUME;

            R = double.Parse(Console.ReadLine());

            VOLUME = (4 / 3.0) * pi * R * R * R;

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}