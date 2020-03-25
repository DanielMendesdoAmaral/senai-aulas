/* Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, sabendo que a decisão é sempre pelo mais barato.      */

using System;
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o preço do primeiro produto: ");
            double p1 = Double.Parse(Console.ReadLine());
            Console.Write("Informe o preço do segundo produto: ");
            double p2 = Double.Parse(Console.ReadLine());
            Console.Write("Informe o preço do terceiro produto: ");
            double p3 = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            if ((p1==p2) && (p1<p3)){
                Console.WriteLine("Compre o primeiro ou o segundo produto.");
            }
            else if ((p1==p3) && (p1<p2)){
                Console.WriteLine("Compre o primeiro ou o terceiro produto.");
            }
            else if ((p3==p2) && (p3<p1)) {
                Console.WriteLine("Compre o segundo ou o terceiro produto.");
            }
            else if ((p1==p2) && (p2==p3)){
                Console.WriteLine("Compre o primeiro, o segundo ou o terceiro produto.");
            }
            else if ((p1<p2) && (p1<p3)){
                Console.WriteLine("Compre o primeiro produto.");
            }
            else if ((p2<p1) && (p2<p3)){
                Console.WriteLine("Compre o segundo produto.");
            }
            else{
                Console.WriteLine("Compre o terceiro produto.");
            }
        }
    }
}
