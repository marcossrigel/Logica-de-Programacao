using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');
            
            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);
            int c = int.Parse(vetor[2]);

            int maior_AB = (a + b + Math.Abs(a - b)) / 2;
            int maior = (c + maior_AB + Math.Abs(c - maior_AB)) / 2;

            Console.WriteLine(maior + " eh o maior");

        }
    }
}
