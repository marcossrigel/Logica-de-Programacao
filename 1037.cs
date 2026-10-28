
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0.00 && numero <= 25.00)
                Console.WriteLine("Intervalo [0,25]");
            else if (numero >= 25.00 && numero <= 50.00)
                Console.WriteLine("Intervalo (25,50]");
            else if (numero >= 50.00 && numero <= 75.00)
                Console.WriteLine("Intervalo (50,75)");
            else if (numero >= 75.00 && numero <= 100.00)
                Console.WriteLine("Intervalo (75,100]");
            else
                Console.WriteLine("Fora de intervalo");
        }
    }
}
