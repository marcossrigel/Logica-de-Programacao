using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int carro_x;

            carro_x = int.Parse(Console.ReadLine());

            int tempo = carro_x * 2;

            Console.WriteLine(tempo + " minutos");

        }
    }
}
