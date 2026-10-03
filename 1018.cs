using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            int nota_100 = n / 100;
            n = n % 100;
            Console.WriteLine(nota_100 + " nota(s) de R$ 100,00");

            int nota_50 = n / 50;
            n = n % 50;
            Console.WriteLine(nota_50 + " nota(s) de R$ 50,00");

            int nota_20 = n / 20;
            n = n % 20;
            Console.WriteLine(nota_20 + " nota(s) de R$ 20,00");

            int nota_10 = n / 10;
            n = n % 10;
            Console.WriteLine(nota_10 + " nota(s) de R$ 10,00");

            int nota_5 = n / 5;
            n = n % 5;
            Console.WriteLine(nota_5 + " nota(s) de R$ 5,00");

            int nota_2 = n / 2;
            n = n % 2;
            Console.WriteLine(nota_2 + " nota(s) de R$ 2,00");

            int nota_1 = n / 1;
            n = n % 1;
            Console.WriteLine(nota_1 + " nota(s) de R$ 1,00");
        }
    }
}
