/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1019
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1019
{
    class Tempo
    {
        static void Main(string[] args)
        {
            int N;
            double conversaoHoras;
            int conversaoMinutos;
            int conversaoSegundos;
            int restoDeN;

            N = int.Parse(Console.ReadLine());

            conversaoHoras = N / 3600;
            restoDeN = N % 3600;
            conversaoMinutos = restoDeN / 60;
            conversaoSegundos = restoDeN % 60;

            Console.WriteLine(conversaoHoras + ":" + conversaoMinutos + ":" + conversaoSegundos);
            Console.ReadKey();
        }
    }
}
