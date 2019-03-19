/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1017
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1017
{
    class GastoCombustivel
    {
        static void Main(string[] args)
        {
            int tempo;
            int velocidade;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            litros = (double)tempo * velocidade / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
