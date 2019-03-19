/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1037
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1037
{
    class Intervalo
    {
        static void Main(string[] args)
        {
            double numero;

            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero > 25 && numero <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero >= 0 && numero <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero > 75 && numero <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else if (numero > 50 && numero <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            Console.ReadKey();
        }
    }
}
