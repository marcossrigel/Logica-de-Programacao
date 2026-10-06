using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int cont = 0;

            for (int i=0; i<n; i++)
            {
                cont++;
                Console.Write(cont + " ");
                cont++;
                Console.Write(cont + " ");
                cont++;
                Console.Write(cont + " ");
                cont++;
                Console.WriteLine("PUM");
            }
        }
    }
}
