/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1035
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
namespace URI_ONLINE_1035
{
    class TesteDeSelecao
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');

            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            C = int.Parse(vetor[2]);
            D = int.Parse(vetor[3]);

            if (B > C && (D > A) && (C + D) > (A + B) && (C) > 0 && (D) > 0 && (A % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
            Console.ReadKey();
        }
    }
}
