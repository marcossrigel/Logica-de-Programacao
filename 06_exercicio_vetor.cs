using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int contador_idades = 0;
            string nome_pessoa_mais_velha = "";

            string[] nomes = new string[n];
            int[] idades = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                nomes[i] = vetor[0];
                idades[i] = int.Parse(vetor[1]);
                if (idades[i] > contador_idades)
                {
                    contador_idades = idades[i];
                    nome_pessoa_mais_velha = nomes[i];
                }
            }

            Console.WriteLine("Pessoa mais velha: "  + nome_pessoa_mais_velha);

        }
    }
}
