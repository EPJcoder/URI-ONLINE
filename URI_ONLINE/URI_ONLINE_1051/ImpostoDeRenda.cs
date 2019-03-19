/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1051
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1051
{
    class ImpostoDeRenda
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double imposto = 0;
            double pagar = 0;
            double faixaMinima = 0;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0.00 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario >= 2000.01 && salario <= 3000.00)
            {
                imposto = 0.08;
                faixaMinima = 2000.01;
                pagar = (imposto * (salario - faixaMinima));
                Console.WriteLine("R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 3000.01 && salario <= 4500.00)
            {
                imposto = 0.08;
                faixaMinima = 3000.01;
                pagar = (imposto * 1000.00) + (0.18 * (salario - faixaMinima));
                Console.WriteLine("R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 4500.00)
            {
                imposto = 0.08;
                faixaMinima = 4500.00;
                pagar = (imposto * 1000.00) + (0.18 * 1500.00) + (0.28 * (salario - faixaMinima));
                Console.WriteLine("R$ " + pagar.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
