using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = 0;

            if (x > y)
            {
                int auxiliar = x;
                x = y;
                y = auxiliar;
            }


            while(x <= y)
            {
                if (x % 13 != 0)
                    soma += x;
                x++;
            }

            Console.WriteLine(soma);
        }
    }
}
