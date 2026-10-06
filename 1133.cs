using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int inicio = Math.Min(x, y);
            int fim = Math.Max(x, y);

            for (int i = inicio + 1; i < fim; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
