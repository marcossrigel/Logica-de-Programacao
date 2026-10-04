using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double numero_par = 0;
            double inicial = 2.0;

            for (int i=0; i<n; i++)
            {
                numero_par = inicial * inicial;
                Console.WriteLine(inicial + "^2 = " + numero_par);
                inicial = inicial + 2.0;
                if (inicial == n)
                {
                    numero_par = inicial * inicial;
                    Console.WriteLine(inicial + "^2 = " + numero_par);
                    break;
                }
            }
        }
    }
}
