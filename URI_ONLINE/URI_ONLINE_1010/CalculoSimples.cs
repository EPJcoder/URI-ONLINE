/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1010
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1010
{
    class CalculoSimples
    {
        static void Main(string[] args)
        {
            int codigoPeca1;
            int numeroPeca1;
            double valorUnitario1;
            double pagar;

            int codigoPeca2;
            int numeroPeca2;
            double valorUnitario2;

            string[] vet = Console.ReadLine().Split(' ');

            codigoPeca1 = int.Parse(vet[0]);
            numeroPeca1 = int.Parse(vet[1]);
            valorUnitario1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.ReadKey();

            string[] vetor = Console.ReadLine().Split(' ');

            codigoPeca2 = int.Parse(vetor[0]);
            numeroPeca2 = int.Parse(vetor[1]);
            valorUnitario2 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            pagar = valorUnitario1 * numeroPeca1 + valorUnitario2 * numeroPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
