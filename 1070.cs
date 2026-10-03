using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
                x++;

            for (int i = 0; i < 6; i++) {
                Console.WriteLine(x);
                x = x + 2;
            }
        }
    }
}
