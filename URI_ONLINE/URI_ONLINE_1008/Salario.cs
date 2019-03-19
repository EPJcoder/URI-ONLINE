/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1008
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1008
{
    class Salario
    {
        static void Main(string[] args)
        {
            int NUMBER;
            int horasTrabalhadas;
            double valorHoras;
            double SALARY;

            NUMBER = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARY = (double)horasTrabalhadas * valorHoras;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
