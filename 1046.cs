using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.Serialization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            string[] horas = Console.ReadLine().Split(' ');

            int hora_inicio = int.Parse(horas[0]);
            int hora_fim = int.Parse(horas[1]);
            int resultado;

            if (hora_inicio < hora_fim)
                resultado = hora_fim - hora_inicio;
            else
                resultado = 24 - hora_inicio + hora_fim;

            Console.WriteLine("O JOGO DUROU " + resultado + " HORA(S)");

        }
    }
}
