/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1048
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1048
{
    class AumentoDeSalario
    {
        static void Main(string[] args)
        {
            double salario;
            double reajusteGanho;
            double percentual;
            percentual = 0;
            reajusteGanho = 0;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 400.00)
            {
                percentual = 0.15;
                reajusteGanho = (percentual * salario);
                salario = ((percentual * salario) + salario);
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 0.12;
                reajusteGanho = (percentual * salario);
                salario = ((percentual * salario) + salario);
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 0.10;
                reajusteGanho = (percentual * salario);
                salario = ((percentual * salario) + salario);
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 0.07;
                reajusteGanho = (percentual * salario);
                salario = ((percentual * salario) + salario);
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.00)
            {
                percentual = 0.04;
                reajusteGanho = (percentual * salario);
                salario = ((percentual * salario) + salario);
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
            Console.ReadKey();
        }
    }
}
