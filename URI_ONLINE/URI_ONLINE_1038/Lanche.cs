/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1038
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1038
{
    class Lanche
    {
        static void Main(string[] args)
        {
            int codigo;
            int quantidade;
            double pagar;
            pagar = 0;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');
            codigo = int.Parse(vetor[0], CultureInfo.InvariantCulture);
            quantidade = int.Parse(vetor[1], CultureInfo.InvariantCulture);

            if (codigo == 1)
            {
                pagar = quantidade * 4.00;
            }
            if (codigo == 2)
            {
                pagar = quantidade * 4.50;
            }
            if (codigo == 3)
            {
                pagar = quantidade * 5.00;
            }
            if (codigo == 4)
            {
                pagar = quantidade * 2.00;
            }
            if (codigo == 5)
            {
                pagar = quantidade * 1.50;
            }
            Console.WriteLine("Total: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
