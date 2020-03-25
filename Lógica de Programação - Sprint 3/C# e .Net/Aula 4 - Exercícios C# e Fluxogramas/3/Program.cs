/* Uma empresa decide dar aumento de 30% aos funcionários cujo salário é inferior a 500 reais. Escreva um programa que receba o salário de um funcionário e imprima o valor do salário reajustado ou uma mensagem caso o funcionário não tenha direito a aumento. */

using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu salário: ");
            double salario = Double.Parse(Console.ReadLine());
            Math.Round(novosalario, 2);
            double novosalario = (double) 30/100*salario + salario; /* Se você não colocar (double) antes, ele vai reconhecer que 30/100 é um número inteiro, a menos que você coloque 30.0/100.0, o que não é prático. Ao colocar o (double) você não vai pegar apenas a parte inteira, mas a parte decimal também. Você pode colocar (float) ou (decimal) também, depende de sua necessidade. */
            if (salario < 500) {
                Console.WriteLine("Por ter um salário menor que R$500,00 você receberá um aumento salarial de 30%, passando a receber a partir de hoje um novo salário de " + novosalario + "R$.");
            }else{
                Console.WriteLine("Por ter um salário maior ou igual a R$500,00 você não tem direito a receber um aumento salarial.");
            }
        }
    }
}