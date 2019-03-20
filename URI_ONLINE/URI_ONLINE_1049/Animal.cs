/*
 *      Exercícios do site https://www.urionlinejudge.com.br
 *      Programador: Euclydes Penteado Junior
 *      Meu GitHub: EPJcoder
 *      Linguagem utilizada: C#
 *      Exercício de número: 1049
 *      OBS: Para subir o exercício no URI apague o método: Console.ReadKey();
 */

using System;

namespace URI_ONLINE_1049
{
    class Animal
    {
        static void Main(string[] args)
        {
            string A;
            string B;
            string C;

            A = Console.ReadLine();
            B = Console.ReadLine();
            C = Console.ReadLine();

            if ((A == "vertebrado") && (B == "mamifero") && (C == "onivoro"))
            {
                Console.WriteLine("homem");
            }
            if ((A == "vertebrado") && (B == "ave") && (C == "carnivoro"))
            {
                Console.WriteLine("aguia");
            }
            if ((A == "invertebrado") && (B == "anelideo") && (C == "onivoro"))
            {
                Console.WriteLine("minhoca");
            }
            if ((A == "vertebrado") && (B == "ave") && (C == "onivoro"))
            {
                Console.WriteLine("pomba");
            }
            if ((A == "vertebrado") && (B == "mamifero") && (C == "herbivoro"))
            {
                Console.WriteLine("vaca");
            }
            if ((A == "invertebrado") && (B == "inseto") && (C == "hematofago"))
            {
                Console.WriteLine("pulga");
            }
            if ((A == "invertebrado") && (B == "inseto") && (C == "herbivoro"))
            {
                Console.WriteLine("lagarta");
            }
            if ((A == "invertebrado") && (B == "anelideo") && (C == "hematofago"))
            {
                Console.WriteLine("sanguessuga");
            }
            Console.ReadKey();
        }
    }
}
