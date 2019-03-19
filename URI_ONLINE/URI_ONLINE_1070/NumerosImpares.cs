/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1070
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1070
{
    class NumerosImpares
    {
        static void Main(string[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
            {
                X = X + 1;
                Console.WriteLine(X);
                Console.WriteLine(X + 2);
                Console.WriteLine(X + 4);
                Console.WriteLine(X + 6);
                Console.WriteLine(X + 8);
                Console.WriteLine(X + 10);
            }
            else
            {
                if (X % 2 != 0)
                {
                    Console.WriteLine(X);
                    Console.WriteLine(X + 2);
                    Console.WriteLine(X + 4);
                    Console.WriteLine(X + 6);
                    Console.WriteLine(X + 8);
                    Console.WriteLine(X + 10);
                }
            }
            Console.ReadKey();
        }
    }
}
