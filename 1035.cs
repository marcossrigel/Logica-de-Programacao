using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');
            
            double a = double.Parse(vetor[0]);
            double b = double.Parse(vetor[1]);
            double c = double.Parse(vetor[2]);
            double d = double.Parse(vetor[3]);

            double soma_CD = c + d;
            double soma_AB = a + b;

            if (b > c && d > a && soma_CD > soma_AB && c > 0 && d > 0 && a % 2 == 0)
                Console.WriteLine("Valores aceitos");
            else
                Console.WriteLine("Valores nao aceitos");

        }
    }
}
