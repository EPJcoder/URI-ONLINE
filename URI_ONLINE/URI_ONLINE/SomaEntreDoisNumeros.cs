/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1001
 *      OBS: para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE
{
    class SomaEntreDoisNumeros
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = " + X);
            Console.ReadKey();
        }
    }
}
