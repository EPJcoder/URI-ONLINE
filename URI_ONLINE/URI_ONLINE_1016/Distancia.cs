/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1016
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1016
{
    class Distancia
    {
        static void Main(string[] args)
        {
            int distanciaVeiculo;
            int tempoVeiculo;

            distanciaVeiculo = int.Parse(Console.ReadLine());

            tempoVeiculo = distanciaVeiculo * 2;

            Console.WriteLine(tempoVeiculo + " minutos");
            Console.ReadKey();
        }
    }
}
