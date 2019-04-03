/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1071
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1071
{
    class SomaImpares
    {
        static void Main(string[] args)
        {
            int X;
            int Y;
            int minimo;
            int maximo;
            int soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                minimo = X;
                maximo = Y;
            }
            else
            {
                minimo = Y;
                maximo = X;
            }
            soma = 0;
            for (int i = minimo + 1; i < maximo; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
