using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, y, z;
            
            x = 1;
            y = 1;
            z = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(x + " ");
                Console.Write(y + " ");
                Console.WriteLine(z);
                x = x + 1;
                y = x * x;
                z = y * x;
            }
        }
    }
}
