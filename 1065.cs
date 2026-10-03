using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, par, impar;
            par = 0;
            impar = 0;

            for (int i = 0; i < 5; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (Math.Abs(numero) % 2 == 0)
                    par++;
                if (Math.Abs(numero) % 2 == 1)
                    impar++;
            }

            Console.WriteLine(par + " valores pares");
        }
    }
}
