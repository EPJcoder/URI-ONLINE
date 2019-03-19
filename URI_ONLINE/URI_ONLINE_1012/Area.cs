/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1012
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;
using System.Globalization;

namespace URI_ONLINE_1012
{
    class Area
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            double areaTrianguloRetangulo;
            double areaCircunferencia;
            double areaTrapezio;
            double areaQuadrado;
            double areaRetangulo;
            double pi;
            pi = 3.14159;

            string[] vetor;
            vetor = Console.ReadLine().Split(' ');
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            areaTrianguloRetangulo = (A * C) / 2.0;
            areaCircunferencia = pi * C * C;
            areaTrapezio = ((A + B) * C / 2.0);
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCircunferencia.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
