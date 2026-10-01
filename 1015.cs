using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');
            
            double x1 = double.Parse(vetor[0]);
            double y1 = double.Parse(vetor[1]);

            vetor = Console.ReadLine().Split(' ');

            double x2 = double.Parse(vetor[0]);
            double y2 = double.Parse(vetor[1]);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distancia.ToString("F4"));

        }
    }
}
