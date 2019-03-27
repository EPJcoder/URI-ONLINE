/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1047
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1047
{
    class TempoDeJogoComMinutos
    {
        static void Main(string[] args)
        {
            int horarioInicial;
            int horarioFinal;
            int minutoInicial;
            int minutoFinal;
            int comecoDeJogo;
            int finalDeJogo;
            int tempoDeJogo = 0;
            int minutos = 0;
            int horas = 0;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');

            horarioInicial = int.Parse(vetor[0]);
            minutoInicial = int.Parse(vetor[1]);
            horarioFinal = int.Parse(vetor[2]);
            minutoFinal = int.Parse(vetor[3]);

            comecoDeJogo = (horarioInicial * 60) + minutoInicial;
            finalDeJogo = (horarioFinal * 60) + minutoFinal;

            if (!(comecoDeJogo != finalDeJogo))
            {
                tempoDeJogo = 24 * 60;
            }
            else if (comecoDeJogo > finalDeJogo)
            {
                tempoDeJogo = ((24 * 60) - comecoDeJogo) + finalDeJogo;
            }
            else
            {
                tempoDeJogo = finalDeJogo - comecoDeJogo;
            }
            horas = tempoDeJogo / 60;
            minutos = tempoDeJogo % 60;

            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S) E " + minutos + " MINUTO(S)");
            Console.ReadKey();
        }
    }
}
