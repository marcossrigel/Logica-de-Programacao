using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = x;
            int soma_pares = 0;

            while (x != 0)
            {
                if (x % 2 != 0)
                {
                    x++;
                    y = x;
                }
                for (int i=1; i<5; i++)
                {
                    y = y + 2;
                    soma_pares = x + y;
                    x = soma_pares;
                }
                Console.WriteLine(soma_pares);
                x = int.Parse(Console.ReadLine());
                y = x;
                soma_pares = 0;
            }

        }
    }
}
