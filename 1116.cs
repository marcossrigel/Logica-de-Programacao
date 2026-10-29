using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double x, y, divisao;

            for (int i=0; i<n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');

                x = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                y = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
