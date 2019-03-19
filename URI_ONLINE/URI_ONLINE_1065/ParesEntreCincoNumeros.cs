/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1065
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1065
{
    class ParesEntreCincoNumeros
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;
            int E;
            int somaPares = 0;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            E = int.Parse(Console.ReadLine());

            if (A % 2 == 0)
            {
                somaPares = somaPares + 1;
            }
            if (B % 2 == 0)
            {
                somaPares = somaPares + 1;
            }
            if (C % 2 == 0)
            {
                somaPares = somaPares + 1;
            }
            if (D % 2 == 0)
            {
                somaPares = somaPares + 1;
            }
            if (E % 2 == 0)
            {
                somaPares = somaPares + 1;
            }
            Console.WriteLine(somaPares + " valores pares");
            Console.ReadKey();
        }
    }
}
