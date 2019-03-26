using System;

namespace URI_ONLINE_1114
{
    class SenhaFixa
    {
        static void Main(string[] args)
        {
            int X;
            int senha = 2002;

            X = int.Parse(Console.ReadLine());

            while (senha != X)
            {
                Console.WriteLine("Senha Invalida");
                X = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            Console.ReadKey();
        }
    }
}
