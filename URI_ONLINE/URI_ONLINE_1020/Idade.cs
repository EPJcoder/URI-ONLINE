/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1020
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1020
{
    class Idade
    {
        static void Main(string[] args)
        {
            int numero;
            int idadeAno;
            int idadeMes;
            int idadeDias;
            int restoNumero;

            numero = int.Parse(Console.ReadLine());

            idadeAno = numero / 365;
            restoNumero = numero % 365;
            idadeMes = restoNumero / 30;
            idadeDias = restoNumero % 30;

            Console.WriteLine(idadeAno + " ano(s)");
            Console.WriteLine(idadeMes + " mes(es)");
            Console.WriteLine(idadeDias + " dia(s)");
            Console.ReadKey();
        }
    }
}
