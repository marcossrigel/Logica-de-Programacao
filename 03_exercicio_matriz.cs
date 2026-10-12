
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n,n];
            int[] ehMaior = new int[n];

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                    if (a[i, j] > ehMaior[i])
                        ehMaior[i] = a[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ehMaior[i]);
            }

        }
    }
}
