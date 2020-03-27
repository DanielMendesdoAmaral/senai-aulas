/* Faça um programa que imprima na tela a soma dos valores de um intervalo definido pelo usuário. */

using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            Console.Write("Digite um número mínimo: ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Digite um número máximo: ");
            int n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("A soma de todos os valores entre " + n1 + " e " + n2 + " é: ");
            for (int contador=n1;contador<=n2;contador++){
                soma = soma + contador;
            }
            Console.Write(soma);
        }
    }
}
