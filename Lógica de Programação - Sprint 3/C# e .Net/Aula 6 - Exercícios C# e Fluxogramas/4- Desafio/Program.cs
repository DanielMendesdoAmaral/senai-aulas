/* A série de Fibonacci é formada pela seqüência 0,1,1,2,3,5,8,13,21,34,55,... 
Pesquise como funciona o algoritmo Fibonacci.
Faça um programa que gere a série até que o valor seja maior que 500.   */

using System;

namespace _4__Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, antecessor, sucessor;
            contador = 0;
            antecessor = 0;
            sucessor = 1;
            while (contador<8){
                Console.Write(" " + antecessor + " " + sucessor);
                antecessor = antecessor + sucessor;
                sucessor = sucessor + antecessor;
                contador++;
            }
        }
    }
}
