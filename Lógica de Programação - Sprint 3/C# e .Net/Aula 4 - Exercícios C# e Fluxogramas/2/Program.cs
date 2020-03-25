/*  2- Faça um programa que receba o ano de nascimento de uma pessoa e o ano atual. Calcule e imprima: 
        a) A idade dessa pessoa;
        b) Essa idade convertida em semana. */

using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu? ");

            double anonascimento = Double.Parse(Console.ReadLine());
            double anoatual = DateTime.Now.Year;
            double idadeano = anoatual-anonascimento;
            double idadesemanas = (double) idadeano*(365.0/7.0);

            Console.WriteLine("Você tem " + Math.Round(idadeano,3) + " anos de idade.");
            Console.WriteLine("Você tem " + Math.Round(idadesemanas,3) + " semanas de idade."); 
        }
    }
}
