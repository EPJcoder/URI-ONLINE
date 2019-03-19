/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1021
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1021
{
    class NotasEMoedas
    {
        static void Main(string[] args)
        {
            int resto;
            int nota;
            int moeda;
            int quociente;
            double N;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto %= (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto %= moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto %= moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto %= moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto %= moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto %= moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
            Console.ReadKey();
        }
    }
}
