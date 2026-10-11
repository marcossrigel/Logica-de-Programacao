
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');   
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matriz[i,j] < 0)
                        Console.WriteLine(matriz[i,j]);
                }
            }
        }
    }
}
