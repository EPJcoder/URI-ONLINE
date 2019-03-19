/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1064
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1064
{
    class PositivosEMedia
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double D;
            double E;
            double F;
            double media;
            double positivo = 0;
            double totalPositivos = 0;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (A > 0)
            {
                totalPositivos = A;
                positivo = positivo + 1;
            }
            if (B > 0)
            {
                totalPositivos = totalPositivos + B;
                positivo = positivo + 1;
            }
            if (C > 0)
            {
                totalPositivos = totalPositivos + C;
                positivo = positivo + 1;
            }
            if (D > 0)
            {
                totalPositivos = totalPositivos + D;
                positivo = positivo + 1;
            }
            if (E > 0)
            {
                totalPositivos = totalPositivos + E;
                positivo = positivo + 1;
            }
            if (F > 0)
            {
                totalPositivos = totalPositivos + F;
                positivo = positivo + 1;
            }
            media = (double)totalPositivos / positivo;
            Console.WriteLine(positivo + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
