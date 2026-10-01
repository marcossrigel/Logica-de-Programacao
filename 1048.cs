using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.Serialization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double reajuste = 0.0;

            if (salario <= 400.00)
            {
                reajuste = salario * 0.15;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.00)
            {
                reajuste = salario * 0.04;
                salario += reajuste;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }

        }
    }
}
