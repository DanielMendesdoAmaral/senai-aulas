/* Faça um programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:

    a) salário bruto;
    b) quanto pagou ao INSS;
    c) quanto pagou ao sindicato;
    d) o salário líquido.

    Calcule os descontos e o salário líquido, conforme a tabela abaixo:
    + Salário Bruto : R$
    - IR (11%) : R$
    - INSS (8%) : R$
    - Sindicato ( 5%) : R$
    = Salário Liquido : R$

    Obs.: Salário Bruto - Descontos = Salário Líquido.           */

using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanto você ganha por hora? ");
            double salarioHora = Double.Parse(Console.ReadLine());
            Console.Write("Quantas horas você trabalha por mês? ");
            double horasMes = Double.Parse(Console.ReadLine());

            double salarioBruto = (double) salarioHora*horasMes;
            double impostoRenda = (double) 11/100*salarioBruto;
            double inss = (double) 8/100*salarioBruto;
            double sindicato = (double) 5/100*salarioBruto;
            double salarioLiquido = (double) salarioBruto - (impostoRenda + inss + sindicato);
            
            Console.WriteLine();
            Console.WriteLine("+ Salário bruto: " + salarioBruto.ToString("C") + ".");
            Console.WriteLine("- IR (11%): " + impostoRenda.ToString("C") + "."); 
            Console.WriteLine("- INSS (8%): " + inss.ToString("C") + "."); 
            Console.WriteLine("- Sindicato (5%): " + sindicato.ToString("C") + ".");
            Console.WriteLine("= Salário líquido: " + salarioLiquido.ToString("C") + ".");
        } 
    }
}
