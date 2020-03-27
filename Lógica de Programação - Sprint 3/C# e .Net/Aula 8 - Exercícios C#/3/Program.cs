/* Faça um programa para atribuir nota de 10 alunos, mostrando a nota de cada aluno e a média da sala no final do programa. */

using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double somaNotas = 0;
            double media = 0;
            for (int contador=1;contador<=10;contador++){
                Console.Write("NOTA DO ALUNO " + contador + ": ");
                double nota = Double.Parse(Console.ReadLine());
                somaNotas = somaNotas + nota;
            }
            media = somaNotas/10;
            Console.Write("A média final da sala é: " + media);
        }
    }
}
