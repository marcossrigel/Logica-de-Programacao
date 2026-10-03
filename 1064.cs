using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, positivo, soma, media;
            positivo = 0;
            soma = 0;

            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i <= 5; i++)
            {
                if (numero > 0)
                {
                    positivo++;
                    soma = soma + numero;
                    if (i == 5)
                    {
                        break;
                    }
                    numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else
                {
                    numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            media = soma / positivo;

            Console.WriteLine(positivo + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
