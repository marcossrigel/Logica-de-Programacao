using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int raio = int.Parse(Console.ReadLine());

            double volume = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));

        }
    }
}
