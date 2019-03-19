/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1046
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1046
{
    class TempoDeJogo
    {
        static void Main(string[] args)
        {
            int horaInicio;
            int horaFinal;
            int horaDeJogo = 0;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');

            horaInicio = int.Parse(vetor[0]);
            horaFinal = int.Parse(vetor[1]);

            if (horaInicio < 12 && horaFinal > 12)
            {
                horaDeJogo = (24 - horaInicio) + (horaFinal - 24);
            }
            else
            {
                if (horaInicio > 12 && horaFinal < 12)
                {
                    horaDeJogo = (24 - horaInicio) + horaFinal;
                }
                else
                {
                    if (horaInicio == horaFinal)
                    {
                        horaDeJogo = (24 + horaInicio) - horaFinal;
                    }
                }
            }
            Console.WriteLine("O JOGO DUROU " + horaDeJogo + " HORA(S)");
            Console.ReadKey();
        }
    }
}
