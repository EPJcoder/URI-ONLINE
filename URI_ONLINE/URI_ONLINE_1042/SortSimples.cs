/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1042
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1042
{
    class SortSimples
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');

            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);
            z = int.Parse(vetor[2]);

            if (x < y && x < z && y < z)
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
            }
            else
            {
                if (y < x && y < z && x < z)
                {
                    Console.WriteLine(y);
                    Console.WriteLine(x);
                    Console.WriteLine(z);
                }
                else
                {
                    if (z < x && z < y && y < x)
                    {
                        Console.WriteLine(z);
                        Console.WriteLine(y);
                        Console.WriteLine(x);
                    }
                    else
                    {
                        if (z < x && z < y && x < y)
                        {
                            Console.WriteLine(z);
                            Console.WriteLine(x);
                            Console.WriteLine(y);
                        }
                        else
                        {
                            if (y < x && y < z && z < x)
                            {
                                Console.WriteLine(y);
                                Console.WriteLine(z);
                                Console.WriteLine(x);
                            }
                            else
                            {
                                if (x < y && x < z && z < y)
                                {
                                    Console.WriteLine(x);
                                    Console.WriteLine(z);
                                    Console.WriteLine(y);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
