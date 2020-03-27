/* Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido. */

using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            do {
                Console.Write("Digite uma nota entre 0 e 10: ");
                nota = Double.Parse(Console.ReadLine());
                if ((nota<0)||(nota>10)){
                    Console.WriteLine("Valor inválido! Digite uma nota entre 0 e 10!");
                }
            } while ((nota<0)||(nota>10));
        }
    }
}
