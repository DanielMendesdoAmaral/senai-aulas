/* Faça um programa que pergunte ao usuário quantos produtos ele deseja cadastrar. A partir disso faça o cadastro de cada produto solicitando nome do produto e preço, e mostrando uma mensagem de sucesso com as informações cadastradas. */

using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            string nome;
            double preco;
            Console.Write("Quantos produtos voce quer cadastrar? ");
            int qtd = Int32.Parse(Console.ReadLine());
            Console.Clear();
            for (contador = 1; contador<=qtd; contador++){
                Console.WriteLine("---------------------------");
                Console.WriteLine("|        PRODUTO " + contador + "        |");
                Console.WriteLine("---------------------------");
                Console.Write("NOME: ");
                nome = Console.ReadLine();
                Console.Write("PREÇO: R$");
                preco = Double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("PRODUTO " +contador + " cadastrado com sucesso!");
                Console.WriteLine("Nome do produto " + contador + ": " + nome);
                Console.WriteLine("Preço do produto " + contador + ": " + preco);
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}
