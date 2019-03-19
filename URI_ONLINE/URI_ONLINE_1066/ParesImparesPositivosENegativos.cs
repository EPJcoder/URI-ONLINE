/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1066
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1066
{
    class ParesImparesPositivosENegativos
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;
            int E;
            int somaPares = 0;
            int somaImpares = 0;
            int somaPositivos = 0;
            int somaNegativos = 0;

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
            if (A % 2 != 0)
            {
                somaImpares = somaImpares + 1;
            }
            if (B % 2 != 0)
            {
                somaImpares = somaImpares + 1;
            }
            if (C % 2 != 0)
            {
                somaImpares = somaImpares + 1;
            }
            if (D % 2 != 0)
            {
                somaImpares = somaImpares + 1;
            }
            if (E % 2 != 0)
            {
                somaImpares = somaImpares + 1;
            }
            if (A > 0)
            {
                somaPositivos = somaPositivos + 1;
            }
            if (B > 0)
            {
                somaPositivos = somaPositivos + 1;
            }
            if (C > 0)
            {
                somaPositivos = somaPositivos + 1;
            }
            if (D > 0)
            {
                somaPositivos = somaPositivos + 1;
            }
            if (E > 0)
            {
                somaPositivos = somaPositivos + 1;
            }
            if (A < 0)
            {
                somaNegativos = somaNegativos + 1;
            }
            if (B < 0)
            {
                somaNegativos = somaNegativos + 1;
            }
            if (C < 0)
            {
                somaNegativos = somaNegativos + 1;
            }
            if (D < 0)
            {
                somaNegativos = somaNegativos + 1;
            }
            if (E < 0)
            {
                somaNegativos = somaNegativos + 1;
            }
            Console.WriteLine(somaPares + " valor(es) par(es)");
            Console.WriteLine(somaImpares + " valor(es) impar(es)");
            Console.WriteLine(somaPositivos + " valor(es) positivo(s)");
            Console.WriteLine(somaNegativos + " valor(es) negativo(s)");
            Console.ReadKey();
        }
    }
}
