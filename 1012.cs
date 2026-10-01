using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');

            double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double area_triangulo_retangulo = a * c / 2;
            double area_circunferencia_raio = 3.14159 * Math.Pow(c, 2.0);
            double area_trapezio = (a + b) * c / 2.0;
            double area_quadrado = Math.Pow(b, 2.0);
            double area_retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + area_triangulo_retangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + area_circunferencia_raio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + area_trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + area_quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + area_retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
