using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.Serialization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');

            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            double calculo = 0;

            if (x == 1)
                calculo = 4.0 * y;
            else if (x == 2)
                calculo = 4.50 * y;
            else if (x == 3)
                calculo = 5.0 * y;
            else if (x == 4)
                calculo = 2.0 * y;
            else if (x == 5)
                calculo = 1.50 * y;

            Console.WriteLine("Total: R$ " + calculo.ToString("F2"));

        }
    }
}
