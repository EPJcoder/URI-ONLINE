/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1078
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1078
{
    class Tabuada
    {
        static void Main(string[] args)
        {
            int N;
            int tabuada;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                tabuada = i * N;
                Console.WriteLine(i + " x " + N + " = " + tabuada);
            }
            Console.ReadKey();
        }
    }
}
