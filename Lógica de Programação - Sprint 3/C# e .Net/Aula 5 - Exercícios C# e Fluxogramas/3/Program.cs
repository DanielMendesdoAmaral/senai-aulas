/* Faça um Programa que pergunte em que turno você estuda. Peça para digitar M-matutino ou V-Vespertino ou N- Noturno. Imprima a mensagem "Bom Dia!", "Boa Tarde!" ou "Boa Noite!" ou "Valor Inválido!", conforme o caso.
 */

using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que turno você estuda [M-Matutino] [V-Vespertino] [N-Noturno]? ");
            string turno = Console.ReadLine();
            if (turno == "M"){
                Console.Write("Bom dia!");
            }
            else if (turno == "V"){
                Console.Write("Boa tarde!");
            }
            else if (turno == "N"){
                Console.Write("Boa noite!");
            }
            else{
                Console.Write("Valor inválido!");
            }
        }
    }
}
