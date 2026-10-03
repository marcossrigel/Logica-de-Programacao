using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = x;
            double soma = 0;
            double cont = 0;

            while (x > 0)
            {
                soma = soma + x;
                cont++;
                x = double.Parse(Console.ReadLine());
            }

            double media = soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
