/* Faça um programa onde o usuário digita um valor, e imprima na tela todos os valores entre 0 e o valor digitado. */

using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Int32.Parse(Console.ReadLine());
            for (int contador = 0; contador<=numero; contador++){
                Console.Write(contador + ".. ");
            }
        }
    }
}
