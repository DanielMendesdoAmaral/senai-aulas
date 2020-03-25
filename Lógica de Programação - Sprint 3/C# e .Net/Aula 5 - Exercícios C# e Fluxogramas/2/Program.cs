/* Faça um programa que leia três números e mostre o maior deles. */

using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double n1 = Double.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            double n2 = Double.Parse(Console.ReadLine());
            Console.Write("Digite mais um número: ");
            double n3 = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dentre os três, o maior número digitado é: ");

            if ((n2<n1) && (n3<n1)) {
                Console.Write(n1);
            } 
            else if ((n1<n2) && (n3<n2)) {
                Console.Write(n2);
            }
            else {
                Console.Write(n3);
            }
        }
    }
}
