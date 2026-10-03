using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor > 0.0 && valor <= 2000.00)
                Console.WriteLine("Isento");
            else
            {
                double imposto;

                if (valor <= 3000.00)
                    imposto = (valor - 2000.00) * 0.08;
                else if (valor <= 4500.00)
                {
                    imposto = 1000.00 * 0.08;
                    imposto += (valor - 3000.00) * 0.18;
                }
                else
                {
                    imposto = 1000.00 * 0.08;
                    imposto += 1500.00 * 0.18;
                    imposto += (valor - 4500.00) * 0.28;
                }
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
