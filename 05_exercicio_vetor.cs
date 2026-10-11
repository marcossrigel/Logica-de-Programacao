using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma = 0.0;
            double cont = 0.0;
            double media = 0.0;

            int[] A = new int[n];
            string[] vetor = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) { 
                A[i] = int.Parse(vetor[i]);
                if (A[i] % 2 == 0)
                {
                    soma += A[i];
                    cont++;
                }
            }

            media = soma / cont;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
