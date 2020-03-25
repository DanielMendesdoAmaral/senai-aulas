/* 1- Faça um programa que receba a idade de uma pessoa em anos e imprima essa idade em: Meses, Dias, Horas, Minutos. */

using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos anos de idade você tem? ");

            int idadeanos = Int32.Parse(Console.ReadLine());
            int idademeses = idadeanos*12;
            int idadedias = idadeanos*(365);
            int idadehoras = idadedias*24;
            int idademinutos = idadehoras*60;

            Console.WriteLine("Você tem " + idademeses + " meses de idade.");
            Console.WriteLine("Você tem " + idadedias + " dias de idade.");
            Console.WriteLine("Você tem " + idadehoras + " horas de idade.");
            Console.WriteLine("Você tem " + idademinutos + " minutos de idade.");
        }
    }
}
