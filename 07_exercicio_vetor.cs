using System;
using System.Globalization;

namespace PrimeiroProjeto 
{
    class curso 
    {
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] nota_01 = new double[n];
            double[] nota_02 = new double[n];

            double[] soma = new double[n];
            double media = 0.0;
            
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                nota_01[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota_02[i] = double.Parse(s[2], CultureInfo.InvariantCulture); 
                soma[i] = nota_01[i] + nota_02[i];
            }

            for (int i = 0; i < n; i++)
            {
                media = soma[i] / 2.0;
                if (media >= 6)
                    Console.WriteLine(nomes[i]);
            }

        }
    }
}
