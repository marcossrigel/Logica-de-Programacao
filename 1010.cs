using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int produto1 = int.Parse(vetor[0]);
            int quantidade1 = int.Parse(vetor[1]);
            double preco1 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            string[] vetor2 = Console.ReadLine().Split(' ');
            int produto2 = int.Parse(vetor2[0]);
            int quantidade2 = int.Parse(vetor2[1]);
            double preco2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);

            double resultado = (quantidade1 * preco1) + (quantidade2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + resultado.ToString("F2"));
            
        }
    }
}
