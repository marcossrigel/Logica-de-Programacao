using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, par, impar, negativo, positivo;
            par = 0;
            impar = 0;
            negativo = 0;
            positivo = 0;

            for (int i = 0; i < 5; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                    par++;
                if (Math.Abs(numero) % 2 == 1)
                    impar++;
                if (numero < 0)
                    negativo++;
                if (numero > 0)
                    positivo++;
            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
        }
    }
}
