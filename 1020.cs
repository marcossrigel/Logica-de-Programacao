
using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int idade_dias = int.Parse(Console.ReadLine());

            int ano = idade_dias / 365;
            int resto_ano = idade_dias % 365;
            int mes = resto_ano / 30;
            int reto_mes = mes % 30;
            int dias = resto_ano % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            
        }
    }
}
