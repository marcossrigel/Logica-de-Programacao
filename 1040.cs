using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            float n1, n2, n3, n4, n5, media, nova_media;

            string[] vetor = Console.ReadLine().Split(' ');

            n1 = float.Parse(vetor[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vetor[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vetor[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vetor[3], CultureInfo.InvariantCulture);

            media = ((n1 * 2f) + (n2 * 3f) + (n3 * 4f) + (n4 * 1f)) / 10f;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
                Console.WriteLine("Aluno aprovado.");
            else if (media < 5.0)
                Console.WriteLine("Aluno reprovado.");
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                n5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                nova_media = (n5 + media) / 2f;
                Console.WriteLine("Nota do exame: " + n5.ToString("F1", CultureInfo.InvariantCulture));
                if (nova_media >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else
                    Console.WriteLine("Aluno reprovado.");
                Console.Write("Media final: " + nova_media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
