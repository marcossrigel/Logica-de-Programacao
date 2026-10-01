using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo_viagem, velocidade_media, litros, distancia;

            tempo_viagem = int.Parse(Console.ReadLine());
            velocidade_media = int.Parse(Console.ReadLine());

            distancia = tempo_viagem * velocidade_media;

            litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3"));
        }
    }
}
