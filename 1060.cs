using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            int cont = 0;

            for (int i = 0; i < 6; i++)
            {
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (numero > 0)
                    cont++;
            }

            Console.WriteLine(cont + " valores positivos");

        }
    }
}
