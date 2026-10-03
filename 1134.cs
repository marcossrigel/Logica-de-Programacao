using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            int opcao = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (opcao != 4)
            {
                if (opcao == 1)
                    alcool++;
                if (opcao == 2)
                    gasolina++;
                if (opcao == 3)
                    diesel++;

                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
