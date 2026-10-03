using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class curso
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3;

            nome1 = Console.ReadLine();

            if (nome1 == "vertebrado")
            {
                nome2 = Console.ReadLine();
                if (nome2 == "ave")
                {
                    nome3 = Console.ReadLine();
                    if (nome3 == "carnivoro")
                        Console.WriteLine("aguia");
                    if (nome3 == "onivoro")
                        Console.WriteLine("pomba");

                }
                else if (nome2 == "mamifero")
                {
                    nome3 = Console.ReadLine();
                    if (nome3 == "onivoro")
                        Console.WriteLine("homem");
                    if (nome3 == "herbivoro")
                        Console.WriteLine("vaca");
                }
            }
            
            if (nome1 == "invertebrado")
            {
                nome2 = Console.ReadLine();
                if (nome2 == "inseto")
                {
                    nome3 = Console.ReadLine();
                    if (nome3 == "hematofago")
                        Console.WriteLine("pulga");
                    if (nome3 == "herbivoro")
                        Console.WriteLine("lagarta");
                }
                else if (nome2 == "anelideo")
                {
                    nome3 = Console.ReadLine();
                    if (nome3 == "hematofago")
                        Console.WriteLine("sanguessuga");
                    if (nome3 == "onivoro")
                        Console.WriteLine("minhoca");
                }
            }
        }
    }
}
