/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1009
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1009
{
    class SalarioComBonus
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo;
            double totalVendas;
            double TOTAL;

            nome = (Console.ReadLine());
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine());

            TOTAL = (0.15 * totalVendas) + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
