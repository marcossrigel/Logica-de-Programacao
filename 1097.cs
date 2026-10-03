using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i += 2)
            {
                int j = i + 6;

                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine($"I={i} J={j}");
                    j--;
                }
            }
        }
    }
}
