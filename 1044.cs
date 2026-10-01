using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.Serialization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');

            int a = int.Parse(vetor[0]);
            int b = int.Parse(vetor[1]);

            if (b % a == 0 || a % b == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
        }
    }
}
