using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');

            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("quarto");

                vetor = Console.ReadLine().Split(' ');

                x = int.Parse(vetor[0]);
                y = int.Parse(vetor[1]);
            }
        }
    }
}
