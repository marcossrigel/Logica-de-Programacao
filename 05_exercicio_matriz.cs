
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

            int[,] matrizA = new int[n, m];
            int[,] matrizB = new int[n, m];

            for (int i=0;i<n;i++)
            {
                string[] vetorA = Console.ReadLine().Split(' ');
                for (int j=0;j<m;j++)
                {
                    matrizA[i,j] = int.Parse(vetorA[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                string[] vetorB = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrizB[i, j] = int.Parse(vetorB[j]);
                }
            }

            int[,] matrizC = new int[n, m];

            for (int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    matrizC[i,j] = matrizA[i,j] + matrizB[i,j];
                    Console.Write(matrizC[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
