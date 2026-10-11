
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] nome_produto = new string[n];
            double[] preco_compra = new double[n];
            double[] preco_venda = new double[n];

            int abaixo10 = 0;
            int entre10e20 = 0;
            int acima20 = 0;

            double total_compra = 0.0;
            double total_venda = 0.0;
            double lucro_total = 0.0;

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');

                nome_produto[i] = vetor[0];
                preco_compra[i] = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                preco_venda[i] = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                double lucro = preco_venda[i] - preco_compra[i];
                double percentual = (lucro / preco_compra[i]) * 100.0;

                if (percentual < 10.0)
                    abaixo10++;                
                else if (percentual <= 20.0)
                    entre10e20++;
                else
                    acima20++;

                total_compra += preco_compra[i];
                total_venda += preco_venda[i];
            }

            lucro_total = total_venda - total_compra;

            Console.WriteLine("Lucro abaixo de 10%: " + abaixo10);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre10e20);
            Console.WriteLine("Lucro acima de 20%: " + acima20);
            Console.WriteLine("Valor total de compra: " + total_compra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + total_venda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro_total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
