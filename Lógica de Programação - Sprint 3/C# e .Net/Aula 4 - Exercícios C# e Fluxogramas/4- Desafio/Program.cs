/* Faça um programa que receba a idade de um nadador e imprima a sua categoria seguindo as regras: 
    a) Infantil A: 5 – 7 anos
    b) Infantil B: 8 – 10 anos
    c) Juvenil A: 11 – 13 anos
    d) Juvenil B: 14 – 17 anos
    e) Sênior: Maiores de 18 anos
*/

using System;

namespace _4__Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira sua idade para descobrir a qual categoria você pertence: ");
            int idade = Int32.Parse(Console.ReadLine());
            if ((5<=idade) && (idade<=7)){
                Console.WriteLine("Você pertence à categoria INFANTIL A.");
            }
            else if ((8<=idade) && (idade<=10)){
                Console.WriteLine("Você pertence à categoria INFANTIL B.");
            }
            else if ((11<=idade) && (idade<=13)){
                Console.WriteLine("Você pertence à categoria JUVENIL A.");
            }
            else if ((14<=idade) && (idade<=17)){
                Console.WriteLine("Você pertence à categoria JUVENIL B.");
            }
            else{
                Console.WriteLine("Você pertence à categoria SÊNIOR.");
            }
        }
    }
}
