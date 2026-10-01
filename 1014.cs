using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia_total_percorrida_X;
            double total_combustivel_gasto_Y;
            double consumo_medio;

            distancia_total_percorrida_X = int.Parse(Console.ReadLine());
            total_combustivel_gasto_Y = double.Parse(Console.ReadLine());

            consumo_medio = distancia_total_percorrida_X / total_combustivel_gasto_Y;

            Console.WriteLine(consumo_medio.ToString("F3") + " km/l");

        }
    }
}
