
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for(int i = 0; i<n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }

            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}
