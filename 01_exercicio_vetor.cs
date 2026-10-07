using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double[] vetor = new double[n];
            double anterior = 0;
            double posicao = 0;

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                if (vetor[i] > anterior)
                {
                    anterior = vetor[i];
                    posicao = i;
                }
            }

            Console.WriteLine(anterior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);

            Console.WriteLine();
        }

    }
}
