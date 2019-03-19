/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1060
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1060
{
    class NumerosPositivos
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double D;
            double E;
            double F;
            double positivo;
            positivo = 0;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (A > 0)
            {
                positivo = positivo + 1;
            }
            if (B > 0)
            {
                positivo = positivo + 1;
            }
            if (C > 0)
            {
                positivo = positivo + 1;
            }
            if (D > 0)
            {
                positivo = positivo + 1;
            }
            if (E > 0)
            {
                positivo = positivo + 1;
            }
            if (F > 0)
            {
                positivo = positivo + 1;
            }
            Console.WriteLine(positivo + " valores positivos");
            Console.ReadKey();
        }
    }
}
