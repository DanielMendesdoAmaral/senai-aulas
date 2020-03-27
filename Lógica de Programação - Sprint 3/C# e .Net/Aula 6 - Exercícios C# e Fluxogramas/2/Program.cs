/* Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações. */

using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, senha;
            do {
                Console.Write("NOME DE USUÁRIO: ");
                nome = Console.ReadLine();
                Console.Write("SENHA: ");
                senha = Console.ReadLine();
                if (nome==senha){
                    Console.WriteLine("ERRO! NOME DE USUÁRIO E SENHA NÃO PODEM SER IGUAIS!");
                    Console.WriteLine("");
                }
            } while (nome==senha);
        }
    }
}
