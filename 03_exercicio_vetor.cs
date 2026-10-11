using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int[] B = new int[n];

            string[] vetorA = Console.ReadLine().Split(' ');
            string[] vetorB = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) 
                A[i] = int.Parse(vetorA[i]);

            for (int i = 0; i < n; i++)
                B[i] = int.Parse(vetorB[i]);

            int[] C = new int[n];

            for (int i = 0; i < n; i++)
                C[i] = A[i] + B[i];
            
            for(int i = 0; i < n; i++)
                Console.Write(C[i] + " ");

        }
    }
}
