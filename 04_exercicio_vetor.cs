using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] A = new double[n];
            string[] s = Console.ReadLine().Split(' ');

            double media = 0.0;
            double soma = 0.0;

            for (int i = 0; i < n; i++) { 
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                soma += A[i];
            }

            for (int i = 0; i < n; i++) 
                media = soma / n;
            
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++)
            {
                if (A[i] < media)
                {
                    Console.WriteLine(A[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
