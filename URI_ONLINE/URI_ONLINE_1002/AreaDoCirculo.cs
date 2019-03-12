/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1002
 *      OBS: para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1002
{
    class AreaDoCirculo
    {
        static void Main(string[] args)
        {
            double n;
            n = 3.14159;

            double raio;
            double area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
