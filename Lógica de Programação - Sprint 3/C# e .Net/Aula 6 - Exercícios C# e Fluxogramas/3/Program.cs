/* Faça um programa que leia e valide as seguintes informações:
    Nome: diferente de vazio;
    Idade: entre 0 e 150;
    Salário: maior que zero;
    Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));  */

using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, estadoCivil;
            int idade;
            double salario;

            do {
                Console.Write("NOME: ");
                nome = Console.ReadLine();
                Console.Write("IDADE: ");
                idade = Int32.Parse(Console.ReadLine());
                Console.Write("SALÁRIO: R$");
                salario = Double.Parse(Console.ReadLine());
                Console.Write("ESTADO CIVIL [s] solteiro(a) - [c] casado(a) - [v] viuvo(a) - [d] divorciado(a): ");
                estadoCivil = Console.ReadLine();
                Console.WriteLine();
                if (nome==""){
                    Console.WriteLine("Erro! O nome não pode ser vazio.");
                }
                if ((idade<=0) || (idade>=150)){
                    Console.WriteLine("Erro! A idade deve estar entre 0 e 150.");
                }
                if (salario<=0){
                    Console.WriteLine("Erro! O salario deve ser maior que 0.");
                }
                if ((estadoCivil!="s") && (estadoCivil!="c") && (estadoCivil!="v") && (estadoCivil!="d")){
                    Console.WriteLine("Erro! Apenas 's', 'c', 'v' e 'd' são valores aceitos.");
                }
                Console.WriteLine("");
            } while ((nome=="") || ((idade<=0) || (idade>=150)) || (salario<=0) || ((estadoCivil!="s") && (estadoCivil!="c") && (estadoCivil!="v") && (estadoCivil!="d")));
        }
    }
}
