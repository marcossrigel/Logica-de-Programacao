using System;
using System.Globalization;

namespace PrimeiroProjeto 
{
    class curso 
    {
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] sexo = new char[n];

            double menor_altura = 100.0;
            double maior_altura = 0.0;
            double media_feminina = 0.0;
            double cont_homens = 0.0;
            double cont_mulheres = 0.0;
            double soma_mulheres = 0.0;

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);

                if (alturas[i] < menor_altura)
                    menor_altura = alturas[i];
                if (alturas[i] > maior_altura)
                    maior_altura = alturas[i];
                if (sexo[i] == 'F')
                {
                    cont_mulheres++;
                    soma_mulheres += alturas[i];
                }
                if (sexo[i] == 'M')
                    cont_homens++;
            }

            media_feminina = soma_mulheres / cont_mulheres;

            Console.WriteLine("Menor altura = " + menor_altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maior_altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + media_feminina.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + cont_homens);

        }
    }
}
