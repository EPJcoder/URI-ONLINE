/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1059
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1059
{
    class NumerosPares
    {
        static void Main(string[] args)
        {
            int x;

            for (int i = 1; i <= 50; i++)
            {
                x = i * 2;
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
