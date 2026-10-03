using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, y, z;

            string[] vetor = Console.ReadLine().Split(' ');

            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if (c > a && c > b)
            {
                x = a;
                y = b;
                z = c;
                a = z;
                b = x;
                c = y;
            }
            else if (b > a && b > c)
            {
                x = a;
                y = b;
                z = c;
                a = y;
                b = x;
                c = z;
            }

            double quadrado_a = Math.Pow(a, 2.0);
            double quadrado_b = Math.Pow(b, 2.0);
            double quadrado_c = Math.Pow(c, 2.0);
            double soma_BC = b + c;
            double soma_quadradoBC = quadrado_b + quadrado_c;

            if (a >= soma_BC)
                Console.WriteLine("NAO FORMA TRIANGULO");
            else {
                if (quadrado_a == soma_quadradoBC)
                    Console.WriteLine("TRIANGULO RETANGULO");
                if (quadrado_a > soma_quadradoBC)
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (quadrado_a < soma_quadradoBC)
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                if (a == b && a == c && b == c)
                    Console.WriteLine("TRIANGULO EQUILATERO");
                if ((a == b && c != a) || (c == a && c != b) || (c == b && c != a))
                    Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
