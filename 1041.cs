using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');

            double x = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (y == 0)
                Console.WriteLine("Eixo X");
            else if (x == 0)
                Console.WriteLine("Eixo Y");
            else if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if(x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if(x < 0 && y < 0)
                Console.WriteLine("Q3");
            else
                Console.WriteLine("Q4");
        }
    }
}
