using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];
            int pares = 0;

            string[] s = Console.ReadLine().Split(' ');

            for (int i=0;i<n;i++)
                vetor[i] = int.Parse(s[i]);
            
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + " ");
                    pares++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(pares);
        }
    }
}
