
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = double.Parse(vetor[j], CultureInfo.InvariantCulture);
                }
            }

            // Soma dos Positivos...
            double soma = 0;
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if (matriz[i,j] > 0)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            //  Linha escolhida 
            int linha = int.Parse(Console.ReadLine());
            double[] opcoes_linha = new double[n];

            for (int i = 0; i < n; i++)
            {
                for(int j = 0;j < n;j++)
                {
                    if (i == linha)
                    {
                        opcoes_linha[j] = matriz[linha, j];
                    }
                }
            }

            // Coluna escolhida

            int coluna = int.Parse(Console.ReadLine());
            double[] opcoes_coluna = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == coluna)
                    {
                        opcoes_coluna[i] = matriz[i, coluna];
                    }
                }
            }

            // Diagonal Principal
            double[] diagonal_principal = new double[n];

            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if (i == j)
                    {
                        diagonal_principal[i] = matriz[i, j];
                    }
                }
            }

            // Matriz alterada
            double[,] matriz_alterada = new double[n,n];
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if (matriz[i, j] < 0)
                        matriz_alterada[i, j] = Math.Pow(matriz[i, j], 2.0);
                    else
                        matriz_alterada[i, j] = matriz[i, j];
                }
            }

            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i=0;i<n;i++)
                Console.Write(opcoes_linha[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            Console.WriteLine();
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i=0;i<n;i++)
                Console.Write(opcoes_coluna[i].ToString("F1", CultureInfo.InvariantCulture)+ " ");
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
                Console.Write(diagonal_principal[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA: ");
            for(int i=0;i<n;i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matriz_alterada[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
