/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1050
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1050
{
    class CodigoDeArea
    {
        static void Main(string[] args)
        {
            int X;
            string codigo = null;

            X = int.Parse(Console.ReadLine());

            switch (X)
            {
                case 61:
                    codigo = "Brasilia";
                    break;
                case 71:
                    codigo = "Salvador";
                    break;
                case 11:
                    codigo = "Sao Paulo";
                    break;
                case 21:
                    codigo = "Rio de Janeiro";
                    break;
                case 32:
                    codigo = "Juiz de Fora";
                    break;
                case 19:
                    codigo = "Campinas";
                    break;
                case 27:
                    codigo = "Vitoria";
                    break;
                case 31:
                    codigo = "Belo Horizonte";
                    break;
                default:
                    codigo = "DDD nao cadastrado";
                    break;
            }
            Console.WriteLine(codigo);
            Console.ReadKey();
        }
    }
}
